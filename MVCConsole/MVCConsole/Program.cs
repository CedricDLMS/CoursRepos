using Business;
using Business.Contracts;
using Controllers;
using Entities;
using Repository;
using Repository.Contracts;
using Unity;
using View;

IUnityContainer unityContainer = new UnityContainer();
unityContainer.RegisterFactory<LocalStorage>(c => LocalStorage.Instance);
unityContainer.RegisterType<IEmployeRepository, EmployeRepository>();
unityContainer.RegisterType<IEmployeBusiness, EmployeBusiness>();
unityContainer.RegisterType<EmployeController>();
unityContainer.RegisterType<MenuIU>();

var menuIU = unityContainer.Resolve<MenuIU>();

while (true){
    await menuIU.Menu();
}