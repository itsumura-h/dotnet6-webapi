using Microsoft.AspNetCore.Mvc;

namespace src.api.Controllers;

[Route("api/test-users/")]
public class TestUsers: ControllerBase{
  [HttpGet()]
  public string Index(){
    Console.WriteLine("Index");
    return "index";
  }

  [HttpGet("{id}/")]
  public object Show(int id){
    Console.WriteLine("show");
    return new {message = $"show {id}"};
  }

  public class CreateRequest{
    public string email {get; set;}
  }

  [HttpPost()]
  public IActionResult Create([FromBody] CreateRequest request){
    Console.WriteLine(request.email);
    return new StatusCodeResult(200);
  }

  public class UpdateRequest{
    public string email {get; set;}
  }

  [HttpPut("{id}/")]
  public IActionResult Update(int id, [FromBody] UpdateRequest request){
    Console.WriteLine(id);
    Console.WriteLine(request.email);
    return new StatusCodeResult(200);
  }
}
