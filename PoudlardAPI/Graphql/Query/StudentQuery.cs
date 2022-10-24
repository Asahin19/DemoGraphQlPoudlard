﻿using GraphQL;
using GraphQL.Types;
using PoudlardAPI.Graphql.Types;
using System;
using System.Linq;

namespace PoudlardAPI.Graphql.Query
{
    public class StudentQuery : ObjectGraphType
    {
        private readonly ApplicationDbContext _appContext;
        public StudentQuery(ApplicationDbContext appContext)
        {
            this._appContext = appContext;
            Name = "Query";
            Field<ListGraphType<StudentGraphType>>("students", "Return list of students", resolve: context => _appContext.Students.ToList());

            Field<StudentGraphType>("student", "Returns a Single Student",
                new QueryArguments(new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id", Description = "Customer Id" }),
                    context => _appContext.Students.Single(x => x.Id == context.Arguments["id"].GetPropertyValue<int>()));
        }
    }
}
