# BOVELO Project

![set text](https://i.imgur.com/Vq0UU1Q.png)

## Presentation

We have created this application to provide help the startup bovelo to manage its bike production and order.

It provides a GUI that displays their products line and records orders from clients. The application features a planning and organisation chart for the production process.  

The database structure is based on MySql and we include the [Database Diagram](https://github.com/smarbal/bovelo_manager/issues/8#issuecomment-817109381).  

Further diagrams are listed below:

- [The Use Case Diagram](https://app.lucidchart.com/documents/image/a46ee63b-3627-4046-a257-9277f3b090aa/0/1000/1)  
- [The Sequence Diagram](https://app.lucidchart.com/documents/image/570fe02b-57dd-400f-bd7d-0c7af648c352/0/1000/1)  
- [The Class Diagram](https://lucid.app/documents/view/c6953fb9-22ae-4676-a6b1-a276b2a08189)  
- [The Supplier Order Sequence Diagram](https://lucid.app/documents/embeddedchart/cec42233-dc50-458f-ae1c-218914939d81)

## Prerequisites
### .NET Framework
Install .NET Framework version [4.7.2](https://dotnet.microsoft.com/download/dotnet-framework/net472) **Developer Pack** for building and running C# applications.
### MySQL Connector/NET
Download the version [8.0.23](https://downloads.mysql.com/archives/c-net/) of MySQL Connector that provides usefull tools for accessing the database and add MySql.Data reference to BoveloLibrary if you have building issues.

## Setup
Clone the repository in a local folder on your computer. Then create a new file named `Database.cs` in `BoveloLibrary` folder and copy the following lines. 

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
public string MyConnection = "server=XXX.XXX.XXX.XX;user=3BE-GRP5;database=bovelo;port=XXXXX;password=************";
}
}
```
You need to change the following values (don't share your information, it must be kept **confidential**) :

- IP_address
- Port
- Username
- Password
- Database_name

Build the solution and select either the `BoveloInternal` or `BoveloClient` as the main the project to run the specific application.

## Group Members

```text
Demarcin Louis [18090]
Denis Maximilien [18332]
Martinez Balbuena Sébastien [18360]
Mitrovic Nikola [18365]
Noël Logan [18003]
Penning Chloé [20264]
```
