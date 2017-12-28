using NetMQ;
using NetMQ.Sockets;
using Shibari.Sub.Core.Shared.Types.Common;
using Shibari.Sub.Core.Shared.Types.Common.Sinks;
using System;
using System.ComponentModel.Composition;
using System.Linq;

namespace Shibari.Sub.Sink.NetMQ.Core
{
    [ExportMetadata("Name", "NetMQ Sink")]
    [Export(typeof(ISinkPlugin))]
    public class NetMQSink : ISinkPlugin
    {
        private readonly PublisherSocket _server = new PublisherSocket();

        public NetMQSink()
        {
            _server.Bind("tcp://localhost:43317");
        }

        public event RumbleRequestReceivedEventHandler RumbleRequestReceived;

        public void DeviceArrived(IDualShockDevice device)
        {
            // TODO: implement
        }

        public void DeviceRemoved(IDualShockDevice device)
        {
            // TODO: implement
        }

        public void InputReportReceived(IDualShockDevice device, IInputReport report)
        {
            var type = BitConverter.GetBytes((Int32)device.DeviceType).Take(4).ToArray();

            _server.SendMoreFrame(type).SendFrame(report.Buffer);
        }
    }
}
