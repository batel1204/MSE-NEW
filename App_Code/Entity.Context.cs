﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.Linq;

public partial class MSEsystemEntities1 : DbContext
{
    public MSEsystemEntities1()
        : base("name=MSEsystemEntities1")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }

    public virtual DbSet<Category> Category { get; set; }
    public virtual DbSet<ChiefManager> ChiefManager { get; set; }
    public virtual DbSet<Department> Department { get; set; }
    public virtual DbSet<Employee> Employee { get; set; }
    public virtual DbSet<Expertise> Expertise { get; set; }
    public virtual DbSet<Image> Image { get; set; }
    public virtual DbSet<Location> Location { get; set; }
    public virtual DbSet<Manager> Manager { get; set; }
    public virtual DbSet<Personnel> Personnel { get; set; }
    public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    public virtual DbSet<Ticket> Ticket { get; set; }
    public virtual DbSet<TicketsForEmployee> TicketsForEmployee { get; set; }
    public virtual DbSet<MyTickets> MyTickets { get; set; }
    public virtual DbSet<Task> Task { get; set; }
    public virtual DbSet<User> User { get; set; }
    public virtual DbSet<TicketsToDo> TicketsToDo { get; set; }

    public virtual ObjectResult<spGetData_Result> spGetData()
    {
        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetData_Result>("spGetData");
    }
}
