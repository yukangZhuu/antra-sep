namespace Assignment_02;

public class URLParser
{
    public static void ParseUrl(string url)
    {
        string protocol = "";
        string server = "";
        string resource = "";

        // Check if the URL contains a protocol
        int protocolSeparator = url.IndexOf("://");
        if (protocolSeparator != -1)
        {
            protocol = url.Substring(0, protocolSeparator);
            url = url.Substring(protocolSeparator + 3);
        }

        int serverSeparator = url.IndexOf('/');
        if (serverSeparator != -1)
        {
            server = url.Substring(0, serverSeparator);
            resource = url.Substring(serverSeparator + 1);
        }
        else
        {
            server = url;
        }

        Console.WriteLine($"URL: {url}");
        Console.WriteLine($"[protocol] = \"{protocol}\"");
        Console.WriteLine($"[server] = \"{server}\"");
        Console.WriteLine($"[resource] = \"{resource}\"");
    }
}