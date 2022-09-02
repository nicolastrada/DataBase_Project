# DataBase_Project

Progetto Basi di Dati : DigitalPhoto

Ferri Samuele, Strada Nicola

Per poter utilizzare il nostro applicativo prima di tutto bisogna avere i seguenti software installi sul proprio computer :
  - MySql Server
  - MySql Connector .Net
  - MySql for Visual Studio
  - Visual Studio 2019

------------------------------------------

Una volta caricata la soluzione all'interno del vostro Visual Studio sarà necessario installare una serie di pacchetti attraverso la voce
"tool" -> "Gestisci pacchetti NuGet"
I pacchetti da installare saranno:  
  - EntityFramework
  - MySql.Data
  - MySql.Data.EntityFramework

------------------------------------------

Una volta installati tutti questi pacchetti, sarà necessario collegare il DB a Visual Studio. E successivamente cambiare la stringa di connessione all'interno del file App.Config, tale stringa dovrà essere modificata con le vostre credenziali e i vostri dati.


```
<connectionStrings>
    <add name="digitalphotoEntities" connectionString="metadata=res://*/Model_DigitalPhoto.csdl|res://*/Model_DigitalPhoto.ssdl|res://*/Model_DigitalPhoto.msl;provider=MySql.Data.MySqlClient;provider connection string=&quot;server=localhost;user id=IDUSER;password=PASSWORD;persistsecurityinfo=True;database=digitalphoto;allowuservariables=True&quot;" providerName="System.Data.EntityClient" />
</connectionStrings>
```

Una volta collegato correttamente il vostro DataBase, si proceda cliccando sul menu a sinitra, selezionando e aprendo il file Program.cs, dopodichè sarà sufficiente lanciare il nostro applicativo utilizzando semplicemente il tasto esegui sul menù in alto. Così facendo verrà aperto il nostro gestionale DigitalPhoto pronto all'utilizzo.
