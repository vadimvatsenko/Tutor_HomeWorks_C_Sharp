using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_10_3_Classes
{
    public class Device
    {
        string _deviceModel;
        string _deviceName;
        int _countOfDevices;
        int _countOfDefectiveDevices;



        public Device(string deviceModel, string deviceName, int countOfDevices, int countOfDefectiveDevices)
        {
            _deviceModel = deviceModel;
            _deviceName = deviceName;
            _countOfDevices = countOfDevices;
            _countOfDefectiveDevices = countOfDefectiveDevices;
        }

        public int CountOfDevices
        {
            get { return _countOfDevices; }
        }

        public void Print() =>
            Console.WriteLine(
                $"DeviceModel: {_deviceModel}, " +
                $"device name: {_deviceName}, " +
                $"count of devices: {_countOfDevices}, " +
                $"count of defective devices: {_countOfDefectiveDevices}");

        public int CountNoDefective() => _countOfDevices - _countOfDefectiveDevices;
    }
}
