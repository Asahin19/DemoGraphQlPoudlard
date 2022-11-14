using GraphQL;
using GraphQL.Types;
using Microsoft.EntityFrameworkCore;
using PoudlardAPI.Entities;
using PoudlardAPI.Graphql.Types;
using PoudlardAPI.Graphql.Types.Enum;
using System;
using System.Linq;

namespace PoudlardAPI.Graphql.Query
{

    public class RootMutation : ObjectGraphType
    {
        private readonly ApplicationDbContext _appContext;
        public RootMutation(ApplicationDbContext appContext)
        {
            this._appContext = appContext;
            Name = "Mutation";

            Field<StudentGraphType>("createStudent", "Create Student",
                new QueryArguments(
                    new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "firstName", Description = "student first name" },
                    new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "lastName", Description = "student last name" },
                    new QueryArgument<NonNullGraphType<HouseEnum>> { Name = "house", Description = "Student house" },
                    new QueryArgument<NonNullGraphType<DateTimeGraphType>> { Name = "birthDate", Description = "Student birthDate" }
                    ),
                    context =>
                    {

                        string firstName = context.Arguments["firstName"].GetPropertyValue<string>();
                        string lastName = context.Arguments["lastName"].GetPropertyValue<string>();
                        DataModel.Enum.House house = context.Arguments["house"].GetPropertyValue<DataModel.Enum.House>();
                        DateTime birthDate = context.Arguments["birthDate"].GetPropertyValue<DateTime>();

                        var student = new Student()
                        {
                            BirthDate = birthDate,
                            FirstName = firstName,
                            LastName = lastName,
                            HouseId = (int?)house
                        };
                        var entityStudent = this._appContext.Add(student);
                        this._appContext.SaveChanges();

                        return student;
                    });
        }
    }
}

