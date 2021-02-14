# Bike manager - BOVELO

![set text](https://i.imgur.com/Vq0UU1Q.png)

![set text](https://www.travis-ci.com/Seb1903/bovelo_manager.svg?branch=repo_organization)

## Presentation :information_source:

We created this application to provide some organization to startups (more precisely a bicycle startup).  

It contains a GUI that displays their products and eventually records orders. The backend of the application can also organize a schedule to manage the different orders.  

The whole data management uses MySql's database and its setup is already done. Here's the [Database Diagram](https://app.lucidchart.com/documents/image/a85c1e3f-c0a3-42cb-80f3-677829ead223/0/1000/1).  

To have more clarity in the operation of the application, we made other diagrams :

- [The Use Case Diagram](https://app.lucidchart.com/documents/image/a46ee63b-3627-4046-a257-9277f3b090aa/0/1000/1)  
- [The Sequence Diagram](https://app.lucidchart.com/documents/image/570fe02b-57dd-400f-bd7d-0c7af648c352/0/1000/1)  
- [The Class Diagram](https://lucid.app/documents/view/c6953fb9-22ae-4676-a6b1-a276b2a08189)  

## How the app works

Now it's time to try this app. You have to clone the repository in a local folder on your computer. Then create a new file named `Database.cs` and copy the bellow lines of code to paste it.

```C#
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bovelo
{
public class Database
{
public string MyConnection = "\
                            server=<IP_address>;\
                            port=<Port>;\
                            user=<Username>;\
                            password=<Password>\
                            database=<DATABASE_NAME>;";
}
}
```

Once you've done that, change the following values (don't share your information, it must be kept **confidential**) :

- IP_address
- Port
- Username
- Password
- Database_name

And now enjoy the app !

## Group

```text
18003 Noël Logan
18090 Demarcin Louis  
18332 Denis Maximilien  
18360 Martinez Balbuena Sébastien  
18365 Mitrovic Nikola  
20264 Penning Chloé
```
