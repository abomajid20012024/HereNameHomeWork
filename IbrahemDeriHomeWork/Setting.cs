using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IbrahemDeriHomeWork
{
    internal class Setting
    {
        String URL;
        String Protocol;
        String SubDomin;
        String DominName;
        String path;
        public Setting(String url)
        {
            
    
            SubDomin = url.Split(":")[1].Split("//")[1].Split(".")[0];
            Protocol = url.Split(":")[0].Split("//")[0];
            DominName = url.Split(":")[1].Split("//")[1].Split("/")[0].Split("www.")[1];
            path = url.Split(":")[1].Split("//")[1].Split(".com")[1];
        }
        public string getUrl()
        {
            return  Protocol+"://"+SubDomin+DominName+path;
        }
        public String getProtocol()
        {
            return Protocol;
        }
        public String getSubDomin()
        {
            return SubDomin;
        }
        public String getDominName()
        {
            return DominName;
        }
        public String getPath()
        {
            return path;
        }
    }
}
