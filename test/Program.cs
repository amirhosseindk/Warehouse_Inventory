// Get local DNS
using System.Net;

string localDns = Dns.GetHostName();
Console.WriteLine("Local DNS: " + localDns);

// Get local IP address
string localIpAddress = GetLocalIPAddress();
Console.WriteLine("Local IP Address: " + localIpAddress);

// Get public IP address
string publicIpAddress = GetPublicIPAddress();
Console.WriteLine("Public IP Address: " + publicIpAddress);

// Get public DNS
string publicDns = Dns.GetHostEntry(publicIpAddress).HostName;
Console.WriteLine("Public DNS: " + publicDns);

static string GetLocalIPAddress()
{
    var host = Dns.GetHostEntry(Dns.GetHostName());
    foreach (var ip in host.AddressList)
    {
        if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
        {
            return ip.ToString();
        }
    }
    throw new Exception("Local IP Address not found.");
}

static string GetPublicIPAddress()
{
    using (var webClient = new WebClient())
    {
        string publicIpAddress = webClient.DownloadString("https://api.ipify.org");
        return publicIpAddress;
    }
}

Console.ReadKey();