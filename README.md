# BEE-CHAT-BACKEND-DOT-NET-CORE


This is the backend of BeeChat app using <b>ASP.NET CORE web api</b><br>
This backend developed in code first approach manner.
<h2>Frontend </h2>
Frontend was build using VUE JS 3. <br> Link: https://github.com/NoorMohammadTalukder/BeeChat-UI-Updated
<h3>Follwed architecturde and principle: </h3>
<ul>
  <li>1 Tier Architecture</li>
  <li>SOLID</li>
</ul>
<h2>Backend </h2>
<h3>Key Technologies: </h3>
<ul>
  <li>Visual Studio 2022 </li>
  <li>Postman</li>
  <li>Nuget Package Manager</li>
  <li>MS SQL Server (version:15.0.2095)</li>
</ul>

<h3>Features: </h3>
<ul>
  <li>api of user registration and login</li>
  <li>api of message creation,delete and get</li>
</ul>

<h3>Project Setup: </h3>
<ul>
  <li>Download Visual Studio 2022 (Community edition) from <a href="https://visualstudio.microsoft.com/vs/community/">here</a> </li>
  <li>Download MS SQL Server version:15.0.2095 from <a href="https://sqlserverbuilds.blogspot.com/2019/01/sql-server-2019-versions.html">here</a></li>

  <li>Download the zip code from <a href="https://github.com/NoorMohammadTalukder/BEE-CHAT-BACKEND-DOT-NET-CORE/archive/refs/heads/master.zip">here</a> and unzip it          and open it using Visual Studio 2022  </li>
  <li>  in appsetting.json <br>
       "ConnectionStrings": {
        "DefaultConnection": "Server=ROKAN-PC\\SQLEXPRESS;Database=Chat_DB;Trusted_Connection=True"
      }
      <br>
      replace <b>ROKAN-PC\\SQLEXPRESS</b> with your own MS SQL connection string
  </li>
  
  <li>Then go to Tools->NuGet Package Manager ->Package Manager Console and after the console opens, run the command update-database. This will create the database in      your MS SQL server.
  </li>
  
  <li>Run the code using ctrl+F5 </li>
  
</ul>
