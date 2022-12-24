using Domain.Models;

var it = new Department();
it.Id = 1;
it.Name = "IT";
var hr = new Department();
hr.Id = 2;
hr.Name = "HR";
var accounting = new Department();
accounting.Id = 3;
accounting.Name = "Accounting";

var roles1 = new Role();
roles1.Id = 1;
roles1.Name = "IT";
var roles2 = new Role();
roles2.Id = 1;
roles2.Name = "User";
var roles3 = new Role();
roles2.Id = 1;
roles2.Name = "HR";
var roles4 = new Role();
roles2.Id = 1;
roles2.Name = "Accounting";

var employye1 = new Employee();
employye1.Id = 1;
employye1.FirstName = "Anushervon";
employye1.LastName = "Bekov";
employye1.Roles= new List<Role>() {roles1,roles2};

var employye2 = new Employee();
employye2.Id = 1;
employye2.FirstName = "Muhaammad";
employye2.LastName = "Yaqubzoda";
employye2.Roles = new List<Role>() { roles2, roles3 };

var employye3 = new Employee();
employye3.Id = 1;
employye3.FirstName = "Ardasher";
employye3.LastName = "Saattorov";
employye3.Roles = new List<Role>() { roles1, roles3 };

var employye4 = new Employee();
employye4.Id = 1;
employye4.FirstName = "Abdulloh";
employye4.LastName = "Sheralizoda";
employye4.Roles = new List<Role>() { roles3, roles2 };

var employye5 = new Employee();
employye5.Id = 1;
employye5.FirstName = "Sherzod";
employye5.LastName = "Isamqulov";
employye5.Roles = new List<Role>() { roles2, roles3,roles1 };

