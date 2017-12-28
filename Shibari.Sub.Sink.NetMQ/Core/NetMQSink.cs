using Shibari.Sub.Core.Shared.Types.Common;
using Shibari.Sub.Core.Shared.Types.Common.Sinks;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shibari.Sub.Sink.NetMQ.Core
{
    [ExportMetadata("Name", "NetMQ Sink")]
    [Export(typeof(ISinkPlugin))]
    public class NetMQSink : ISinkPlugin
    {
        public event RumbleRequestReceivedEventHandler RumbleRequestReceived;

        public void DeviceArrived(IDualShockDevice device)
        {
            throw new NotImplementedException();
        }

        public void DeviceRemoved(IDualShockDevice device)
        {
            throw new NotImplementedException();
        }

        public void InputReportReceived(IDualShockDevice device, IInputReport report)
        {
            throw new NotImplementedException();
        }
    }
}
