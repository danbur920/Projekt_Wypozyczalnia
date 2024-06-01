using Rentals.Models;

namespace Rentals.Areas.Admin.Models
{
    public class UserViewModel
    {
        public string Id { get; set; }

        public bool Active { get; set; }

        public string Email { get; set; }

        public string UserName { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool EmailConfirmed { get; set; }

        public bool PhoneNumberConfirmed { get; set; }
        public UserClass UserClass { get; set; }
        public List<string> Roles { get; set; } = new List<string>();
    }
}


//form asp-action="Edit" asp-controller="Home" method="post">
//    <div asp-validation-summary="ModelOnly" class= "text-danger" ></ div >
//    < input type = "hidden" asp -for= "Id" />
//    < div class= "form-group" >
//        < label asp -for= "Active" class= "control-label" ></ label >
//        < input asp -for= "Active" class= "form-control" />
//        < span asp - validation -for= "Active" class= "text-danger" ></ span >
//    </ div >
//    < div class= "form-group" >
//        < label asp -for= "Email" class= "control-label" ></ label >
//        < input asp -for= "Email" class= "form-control" />
//        < span asp - validation -for= "Email" class= "text-danger" ></ span >
//    </ div >
//    < div class= "form-group" >
//        < label asp -for= "UserName" class= "control-label" ></ label >
//        < input asp -for= "UserName" class= "form-control" />
//        < span asp - validation -for= "UserName" class= "text-danger" ></ span >
//    </ div >
//    < div class= "form-group" >
//        < label asp -for= "PhoneNumber" class= "control-label" ></ label >
//        < input asp -for= "PhoneNumber" class= "form-control" />
//        < span asp - validation -for= "PhoneNumber" class= "text-danger" ></ span >
//    </ div >
//    < div class= "form-group" >
//        < label asp -for= "Address" class= "control-label" ></ label >
//        < input asp -for= "Address" class= "form-control" />
//        < span asp - validation -for= "Address" class= "text-danger" ></ span >
//    </ div >
//    < div class= "form-group" >
//        < label asp -for= "City" class= "control-label" ></ label >
//        < input asp -for= "City" class= "form-control" />
//        < span asp - validation -for= "City" class= "text-danger" ></ span >
//    </ div >
//    < div class= "form-group" >
//        < label asp -for= "PostalCode" class= "control-label" ></ label >
//        < input asp -for= "PostalCode" class= "form-control" />
//        < span asp - validation -for= "PostalCode" class= "text-danger" ></ span >
//    </ div >
//    < div class= "form-group" >
//        < label asp -for= "FirstName" class= "control-label" ></ label >
//        < input asp -for= "FirstName" class= "form-control" />
//        < span asp - validation -for= "FirstName" class= "text-danger" ></ span >
//    </ div >
//    < div class= "form-group" >
//        < label asp -for= "LastName" class= "control-label" ></ label >
//        < input asp -for= "LastName" class= "form-control" />
//        < span asp - validation -for= "LastName" class= "text-danger" ></ span >
//    </ div >
//    < div class= "form-group" >
//        < label asp -for= "EmailConfirmed" class= "control-label" ></ label >
//        < input asp -for= "EmailConfirmed" class= "form-control" />
//        < span asp - validation -for= "EmailConfirmed" class= "text-danger" ></ span >
//    </ div >
//    < div class= "form-group" >
//        < label asp -for= "PhoneNumberConfirmed" class= "control-label" ></ label >
//        < input asp -for= "PhoneNumberConfirmed" class= "form-control" />
//        < span asp - validation -for= "PhoneNumberConfirmed" class= "text-danger" ></ span >
//    </ div >
//     < div class= "form-group" >
//        < input type = "submit" value = "Save" class= "btn btn-primary" />
//    </ div >
//</ form >