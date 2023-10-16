using Microsoft.AspNetCore.Mvc;

namespace PortafolioC.controller;


public class PrincipalController: Controller
{
    
//rutas

[HttpGet]
[Route("")]
public string Index()
{
    return "This is my index";
}



[HttpGet]
[Route("projects")]

public string Project(){
    return "This is my projects";
}
[HttpGet]
[Route("contact")]

public string Contact(){
    return "This is my contact";
}


}