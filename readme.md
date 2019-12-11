# Example of a Generic Repository Pattern in ASP.NET WebAPI

To create a new controller for a new model, you will need a Repository that will
inherit from the GenericRepository class.  You will need to pass it the entity type
that it will use.  If you want to use the Update() method, you will need to override
that method at this point.  

Simply create a new controller at this point, inherit the GenericController class,
and tell it what Repository and Model you are working with.  The following
endpoints will be set up for you:

1. **GET** /{controller}/ - Get All
1. **GET** /{controller}/{id} - Get Single
1. **PUT** /{controller}/{id} - Update Record
1. **DELETE** /{controller}/{id} - Delete Record
1. **POST** /{controller}/ - Create New Record