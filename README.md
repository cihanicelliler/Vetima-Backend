# Vetima - Vetima prototype
<br><br>
 A prototype created for the Vetima website.
 <br><br>
The project was developed in C # language, implemented by the server in the back-end interface, with layered software corporate architecture, SOLID software principles, Web API, EntityFrameWork structure. JWT integration; Implementations of Transaction, Cache, Validation and Performance aspects have been implemented, and support for FluentValidation for Validation and Autofac support for IoC has been added.
 <br><br>
## :card_index_dividers: Layers
### :file_folder: Entities Layer
It is the layer created to hold database objects to be used in the project.<br>
It consists of three sub-folders. <br>
&nbsp;&nbsp;1.The `Abstract` folder has been moved to the `Core` layer to keep the abstract objects (`Abstract` folder has been moved to the `Core` layer since it contains common codes in the projects that will be developed later.),<br>
&nbsp;&nbsp;2.`Concrete` folder for holding concrete objects <br>
&nbsp;&nbsp;3.The folder `DTOs` is used to give different properties to objects and to combine tables in the database.
<br><br>
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`Abstract`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: ~~IEntity~~<br>
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder: `Concrete`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [Category](https://github.com/cihanicelliler/Vetima-Backend/blob/master/Entities/Concrete/Category.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [Product](https://github.com/cihanicelliler/Vetima-Backend/blob/master/Entities/Concrete/Product.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [ProductImages](https://github.com/cihanicelliler/Vetima-Backend/blob/master/Entities/Concrete/ProductImages.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder: `DTOs`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [ProductDeailDto](https://github.com/cihanicelliler/Vetima-Backend/blob/master/Entities/DTOs/ProductDetailDto.cs)<br>
### :file_folder: DataAccess Layer
Database is the data access layer established to perform CRUD operations.<br>
It consists of two subfolders.<br>
&nbsp;&nbsp;1.`Abstract` folder to hold abstract objects,<br>
&nbsp;&nbsp;2.`Concrete` folder to hold concrete objects. <br>
<br><br>
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`Abstract`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [ICategoryDal](https://github.com/cihanicelliler/Vetima-Backend/blob/master/DataAccess/Abstract/ICategoryDal.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [IProductDal](https://github.com/cihanicelliler/Vetima-Backend/blob/master/DataAccess/Abstract/IProductDal.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [IProductImagesDal](https://github.com/cihanicelliler/Vetima-Backend/blob/master/DataAccess/Abstract/IProductImagesDal.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder: `Concrete`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder: `EntityFrameWork`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [EfCategoryDal](https://github.com/cihanicelliler/Vetima-Backend/blob/master/DataAccess/Concrete/EntityFramework/EfCategoryDal.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [EfProductDal](https://github.com/cihanicelliler/Vetima-Backend/blob/master/DataAccess/Concrete/EntityFramework/EfProductDal.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [EfProductImagesDal](https://github.com/cihanicelliler/Vetima-Backend/blob/master/DataAccess/Concrete/EntityFramework/EfProductImages.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [ProductDbContext](https://github.com/cihanicelliler/Vetima-Backend/blob/master/DataAccess/Concrete/EntityFramework/ProductDbContext.cs)<br>

### :file_folder: Business Layer
It is the layer that processes the data captured by DataAccess from the database to the project. In other words, it is the layer on which workloads are written.
It consists of four subfolders.<br>
&nbsp;&nbsp;1.`Abstract` folder to hold abstract objects,<br>
&nbsp;&nbsp;2.`Concrete` folder to hold concrete objects.<br>
&nbsp;&nbsp;4.`Constants` folder for the management of information messages as a result of the operation performed with user data, <br>
&nbsp;&nbsp;5.To create the `DependecyResolvers` folder instance,<br>
<br><br>
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`Abstract`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [ICategoryService](https://github.com/cihanicelliler/Vetima-Backend/blob/master/Business/Abstract/ICategoryService.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [IProductImagesService](https://github.com/cihanicelliler/Vetima-Backend/blob/master/Business/Abstract/IProductImagesService.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [IProductService](https://github.com/cihanicelliler/Vetima-Backend/blob/master/Business/Abstract/IProductService.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`Concrete`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [CategoryManager](https://github.com/cihanicelliler/Vetima-Backend/blob/master/Business/Concrete/CategoryManager.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [ProductImagesManager](https://github.com/cihanicelliler/Vetima-Backend/blob/master/Business/Concrete/ProductImagesManager.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [ProductManager](https://github.com/cihanicelliler/Vetima-Backend/blob/master/Business/Concrete/ProductManager.cs)<br>
nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`Constants`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [Messages](https://github.com/cihanicelliler/Vetima-Backend/blob/master/Business/Constants/Messages.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`DependecyResolvers`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder: `Autofac`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [AutofacBusinessModule](https://github.com/cihanicelliler/Vetima-Backend/blob/master/Business/DependecyResolvers/Autofac/AutofacBusinessModule.cs)<br>

### :file_folder: Core Layer
It is a universal layer with common codes to be used in all projects.<br>
It consists of seven sub-folders.<br>
&nbsp;&nbsp;1.`Aspects` folder,<br>
&nbsp;&nbsp;2.`CrossCuttingConcerns` folder,<br>
&nbsp;&nbsp;3.`DataAccess` folder,<br>
&nbsp;&nbsp;4.`Entities` folder, <br>
&nbsp;&nbsp;5.`DependecyResolvers` folder,<br>
&nbsp;&nbsp;6.`Extensions` folder,<br>
&nbsp;&nbsp;7.`Utilities` folder,<br>
<br><br>
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`Aspect`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder: `Autofac`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder: `Caching`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [CacheAspect](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Aspects/Autofac/Caching/CacheAspect.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [CacheRemoveAspect](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Aspects/Autofac/Caching/CacheRemoveAspect.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder: `Performance`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [PerformanceAspect](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Aspects/Autofac/Performance/PerformanceAspect.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder: `Transactional`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [TransactionScopeAspect](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Aspects/Autofac/Transaction/TransactionScopeAspect.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder: `Validation`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [ValidationAspect](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Aspects/Autofac/Validation/ValidationAspect.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`CrossCuttingConcerns`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder: `Caching`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder: `Microsoft`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [MemoryCacheManager](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/CrossCuttingConcerns/Caching/Microsoft/MemoryCacheManager.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder: `Validation`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [ValidationTool](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/CrossCuttingConcerns/Validation/ValidationTool.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`DataAccess`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder: `EntityFramework`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [EfEntityRepositoryBase](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/DataAccess/EntityFramework/EfEntityRepositoryBase.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`DependecyResolvers`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [CoreModule](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/DependencyResolvers/CoreModule.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`Entities`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [IDto](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Entities/IDto.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`Concrete`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [OperationClaim](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Entities/Concrete/OperationClaim.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [User](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Entities/Concrete/User.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [UserOperationClaim](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Entities/Concrete/UserOperationClaim.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`Extensions`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [ClaimExtensions](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Extensions/ClaimExtensions.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [ClaimsPrincipalExtensions](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Extensions/ClaimsPrincipalExtensions.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [ServiceCollectionExtensions](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Extensions/ServiceCollectionExtensions.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`Utilities`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`Business`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [BusinessRules](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Utilities/Business/BusinessRules.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`Interceptors`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [AspectInterceptorSelector](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Utilities/Interceptors/AspectInterceptorSelector.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [MethodInterception](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Utilities/Interceptors/MethodInterception.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [MethodInterceptionBaseAttribute](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Utilities/Interceptors/MethodInterceptionBaseAttribute.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`IoC`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [ICoreModule](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Utilities/IoC/ICoreModule.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [ServiceTool](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Utilities/IoC/ServiceTool.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`Results`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [DataResult](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Utilities/Results/DataResult.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [ErrorDataResult](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Utilities/Results/ErrorDataResult.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [ErrorResult](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Utilities/Results/ErrorResult.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [IDataResult](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Utilities/Results/IDataResult.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [IResult](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Utilities/Results/IResult.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [Result](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Utilities/Results/Result.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [SuccessDataResult](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Utilities/Results/SuccessDataResult.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [SuccessResult](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Utilities/Results/SuccessResult.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`Security`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`Encryption`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [SecurityKeyHelper](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Utilities/Security/Encryption/SecurityKeyHelper.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [SigningCredentialsHelper](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Utilities/Security/Encryption/SigningCredentialsHelper.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`Hashing`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [HashingHelper](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Utilities/Security/Hashing/HashingHelper.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`JWT`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [AccessToken](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Utilities/Security/JWT/AccessToken.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [ITokenHelper](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Utilities/Security/JWT/ITokenHelper.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [JwtHelper](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Utilities/Security/JWT/JwtHelper.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [TokenOptions](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Utilities/Security/JWT/TokenOptions.cs)<br>

### :file_folder: WebAPI Layer
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`Controllers`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [CategoriesController](https://github.com/cihanicelliler/Vetima-Backend/blob/master/WebAPI/Controllers/CategoriesController.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [ProductImagesController](https://github.com/cihanicelliler/Vetima-Backend/blob/master/WebAPI/Controllers/ProductImagesController.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [ProductsController](https://github.com/cihanicelliler/Vetima-Backend/blob/master/WebAPI/Controllers/ProductsController.cs)<br>

Thank you for taking your time to read. You can contact me from my accounts below.<br>
<br>

<a href="https://github.com/cihanicelliler" target="_blank">

![alt text](https://img.shields.io/badge/GitHub-100000?style=for-the-badge&logo=github&logoColor=white)

</a>
<a href="https://www.linkedin.com/in/cihan-icelliler/" target="_blank">

![alt text](https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white)

</a>
