﻿using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using FitnessTracker.Contracts.Request.Auth;
using FitnessTracker.Contracts.Request.Exercise;
using FitnessTracker.Contracts.Request.Coach;
using FitnessTracker.Contracts.Request.Queries;
using FitnessTracker.Contracts.Request.Training;
using FitnessTracker.Contracts.Request.User;
using FitnessTracker.Models;
using FitnessTracker.Models.Filters;

namespace FitnessTracker.MappingProfiles
{
    public class RequestToModelProfile : Profile
    {
        public RequestToModelProfile()
        {
            CreateMap<PaginationQuery, PaginationFilter>();
            CreateMap<ExerciseQuery, ExerciseFilter>();

            CreateMap<AuthRegisterRequest, User>();
            CreateMap<AuthChangePasswordRequest, User>();

            CreateMap<UpdateUserRequest, User>();
            CreateMap<UpdateUserRoleRequest, User>();

            CreateMap<CreateExerciseRequest, Exercise>();
            CreateMap<UpdateExerciseRequest, Exercise>();

            // Coach
            CreateMap<CreateCoach, Coach>();
            // /Coach

            CreateMap<CreateTrainingRequest, Training>();
            CreateMap<UpdateTrainingRequest, Training>();
            CreateMap<ExerciseHistoryStatsRequest, ExerciseHistoryStats>();

        }
    }
}