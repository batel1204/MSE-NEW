﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class Category
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Category()
    {
        this.Ticket = new HashSet<Ticket>();
    }

    public int idCategory { get; set; }
    public string CategoryName { get; set; }
    public string Domain { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Ticket> Ticket { get; set; }
}

public partial class ChiefManager
{
    public string idChiefManager { get; set; }

    public virtual Manager Manager { get; set; }
}

public partial class Department
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Department()
    {
        this.User = new HashSet<User>();
    }

    public string Department1 { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<User> User { get; set; }
}

public partial class Employee
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Employee()
    {
        this.TicketsForEmployee = new HashSet<TicketsForEmployee>();
    }

    public string idEmployee { get; set; }
    public string Expertise { get; set; }
    public string Domain { get; set; }

    public virtual Manager Manager { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<TicketsForEmployee> TicketsForEmployee { get; set; }
    public virtual User User { get; set; }
}

public partial class Expertise
{
    public int idExpertise { get; set; }
    public string ExpertiseName { get; set; }
}

public partial class Image
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Image()
    {
        this.Ticket = new HashSet<Ticket>();
    }

    public int idImage { get; set; }
    public string Size { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Ticket> Ticket { get; set; }
}

public partial class Location
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Location()
    {
        this.Personnel = new HashSet<Personnel>();
        this.Ticket = new HashSet<Ticket>();
    }

    public int idLocation { get; set; }
    public string Building { get; set; }
    public string Room { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Personnel> Personnel { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Ticket> Ticket { get; set; }
}

public partial class Manager
{
    public string idManager { get; set; }
    public Nullable<int> idLocation { get; set; }

    public virtual ChiefManager ChiefManager { get; set; }
    public virtual Employee Employee { get; set; }
}

public partial class MyTickets
{
    public string idUser { get; set; }
    public int idTicket { get; set; }
    public string idEmployee { get; set; }
    public string CategoryName { get; set; }
    public string Building { get; set; }
    public string Room { get; set; }
    public Nullable<System.DateTime> TimeOpen { get; set; }
    public string Status { get; set; }
}

public partial class Personnel
{
    public string idPersonnel { get; set; }
    public Nullable<int> idLocation { get; set; }

    public virtual Location Location { get; set; }
    public virtual User User { get; set; }
}

public partial class sysdiagrams
{
    public string name { get; set; }
    public int principal_id { get; set; }
    public int diagram_id { get; set; }
    public Nullable<int> version { get; set; }
    public byte[] definition { get; set; }
}

public partial class Task
{
    public int idTask { get; set; }
    public int idTicket { get; set; }
    public string TaskDescription { get; set; }
    public Nullable<bool> Done { get; set; }
    public Nullable<bool> isArchive { get; set; }
}

public partial class Ticket
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Ticket()
    {
        this.TicketsForEmployee = new HashSet<TicketsForEmployee>();
    }

    public int idTicket { get; set; }
    public int idCategory { get; set; }
    public Nullable<int> idLocation { get; set; }
    public bool Priority { get; set; }
    public string Description { get; set; }
    public string Status { get; set; }
    public Nullable<int> Image { get; set; }

    public virtual Category Category { get; set; }
    public virtual Image Image1 { get; set; }
    public virtual Location Location { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<TicketsForEmployee> TicketsForEmployee { get; set; }
}

public partial class TicketsForEmployee
{
    public string idEmployee { get; set; }
    public string idUser { get; set; }
    public int idTicket { get; set; }
    public Nullable<System.DateTime> TimeOpen { get; set; }
    public Nullable<System.DateTime> TimeClose { get; set; }
    public string AnotherAsignee { get; set; }
    public string Domain { get; set; }

    public virtual Employee Employee { get; set; }
    public virtual Ticket Ticket { get; set; }
    public virtual User User { get; set; }
}

public partial class TicketsToDo
{
    public int idTicket { get; set; }
    public string CategoryName { get; set; }
    public string Building { get; set; }
    public string Room { get; set; }
    public Nullable<System.DateTime> TimeOpen { get; set; }
    public string Status { get; set; }
    public string DisplayName { get; set; }
    public string Domain { get; set; }
    public string Description { get; set; }
    public Nullable<System.DateTime> TimeClose { get; set; }
}

public partial class User
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public User()
    {
        this.TicketsForEmployee = new HashSet<TicketsForEmployee>();
    }

    public string uid { get; set; }
    public string DisplayName { get; set; }
    public string EmailAddress { get; set; }
    public string TelephoneNumber { get; set; }
    public string Department { get; set; }
    public string UserPassword { get; set; }
    public bool LoginStatus { get; set; }
    public int Role { get; set; }
    public Nullable<bool> isArchive { get; set; }

    public virtual Department Department1 { get; set; }
    public virtual Employee Employee { get; set; }
    public virtual Personnel Personnel { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<TicketsForEmployee> TicketsForEmployee { get; set; }
}

public partial class spGetData_Result
{
    public string uid { get; set; }
    public string DisplayName { get; set; }
    public string EmailAddress { get; set; }
    public string TelephoneNumber { get; set; }
    public string Department { get; set; }
    public string UserPassword { get; set; }
    public bool LoginStatus { get; set; }
    public int Role { get; set; }
}
