using ComicsShopBLL.Services.Interfaces;
using System;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Text;
using ComicsShopDAL.UnitOfWork;

namespace ComicsShopBLL
{
    public class ServiceFactory:IServiceFactory
    {
        //private IAuthenticationService _authenticationService;
        //private IUserService _userService;
        //private ITeacherService _teacherService;
        //private ILessonService _lessonService;
        //private ITeacherFeedbackService _teacherFeedbackService;
        //private ILessonFeedbackService _lessonFeedbackService;
        private IProductService productService;
        private readonly IServiceProvider _serviceProvider;

        public ServiceFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IProductService ProductService => productService ?? (productService = _serviceProvider.GetService<IProductService>());

        IProductService IServiceFactory.ProductService { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //public IAuthenticationService AuthenticationService => _authenticationService ?? (_authenticationService = _serviceProvider.GetService<IAuthenticationService>());

        //public IUserService UserService => _userService ?? (_userService = _serviceProvider.GetService<IUserService>());

        //public ITeacherService TeacherService => _teacherService ?? (_teacherService = _serviceProvider.GetService<ITeacherService>());

        //public ILessonService LessonService => _lessonService ?? (_lessonService = _serviceProvider.GetService<ILessonService>());

        //public ILessonFeedbackService LessonFeedbackService => _lessonFeedbackService ?? (_lessonFeedbackService = _serviceProvider.GetService<ILessonFeedbackService>());

        //public ITeacherFeedbackService TeacherFeedbackService => _teacherFeedbackService ?? (_teacherFeedbackService = _serviceProvider.GetService<ITeacherFeedbackService>());

    }
}
