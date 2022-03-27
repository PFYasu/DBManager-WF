# DBManager - Graphical database management system

The application allows to perform administrative tasks such as copying data between databases, viewing the contents of tables, executing SQL statements, tracking changes in selected dataset. The application has implementation of two database engines: **PostgreSQL** and **MySQL**.

![image](https://user-images.githubusercontent.com/59066762/160277441-939cc086-aef8-4a42-a26c-19da2efdd1ce.png)

## How it works?
Each supported database engine is embedded in a separate project called **DBManager.EngineModule.X**, where **X** is the name of the engine being implemented. The project must have certain classes:
* **XModel** - contains the implementation of the **IEngineModule** interface,
* **XPresenter** - contains the implementation of the **IEnginePresenter** interface,
* **XConnectorView** - contains the graphical user interface necessary for entering connection data specific to a given platform. 

The created classes must be bound by the **EngineModuleAttribute** attribute, which specifies the necessary information needed by the main program to search for supported database engines automatically.

## Installation
Place the compiled database engine libraries right next to the main program executable called **DBManager.exe**. If the library described uses other libraries, these should also be placed next to the executable file.
