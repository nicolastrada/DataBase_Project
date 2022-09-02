# DataBase_Project

Progetto Basi di Dati : DigitalPhoto


Per poter utilizzare il nostro applicativo prima di tutto bisogna avere i seguenti software installi sul proprio computer :
  - MySql Server
  - MySql Connector Net
  - MySql for Visual Studio
  - Visual Studio 2019
------------------------------------------


Una volta caricata la soluzione all'interno del vostro Visual Studio sarà necessario installare una serie di pacchetti attraverso la voce
"tool"->"NuGet"
I pacchetti da installare saranno :  
  - EntityFramework
  - MySql.Data
  - MySql.Data.EntityFramework

------------------------------------------

Una volta installati tutti questi pacchetti, sarà necessario collegare il vostro DB a Visual Studio. E successivamente cambiare la stringa di connessione all'interno del file Web.Config, tale stringa andrà modificata con le vostre credenziali ed i vostri dati.


```
<add name="HospitalEntities" connectionString="metadata=res://*/Models.DBModel.csdl|res://*/Models.DBModel.ssdl|res://*/Models.DBModel.msl;provider=MySql.Data.MySqlClient;provider connection string=&quot;server=127.0.0.1;user id=NAMEID;password=PASSWORD;database=hospital&quot;" providerName="System.Data.EntityClient" />
```

Una volta collegato correttamente il vostro Data Base, si proceda cliccando sul menu a sinitra, navigando nella cartella Views -> Home -> Index.cshtml,
basterà lanciare il nostro applicativo semplicemente premendo CTRL + F5 e verrete catapultati sul nostro gestionale.
