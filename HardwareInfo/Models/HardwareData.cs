using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareInfo.Models;
public class HardwareData:INotifyPropertyChanged
{
    private String _name;
    public String Name
    {
        set
        {
            _name = value;
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("Name"));
            }
        }
        get
        {
            return _name;
        }
    }
    private String _content;
    public String Content
    {
        set
        {
            _content = value;
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("Content"));
            }
        }
        get
        {
            return _content;
        }
    }
    private int _cpuload;
    public int CpuLoad
    {
        set
        {
            _cpuload = value;
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("CpuLoad"));
            }
        }
        get
        {
            return _cpuload;
        }
    }
    private int _memload;
    public int memLoad
    {
        set
        {
            _memload = value;
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("memLoad"));
            }
        }
        get
        {
            return _memload;
        }
    }
    public event PropertyChangedEventHandler? PropertyChanged;
}
