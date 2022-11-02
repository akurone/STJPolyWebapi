using Microsoft.AspNetCore.Mvc;

namespace STJPolyWebapi.Controllers
{
	[ApiController]
	[Route("[controller]/[action]")]
	public class TestController : ControllerBase
	{
		//no discriminator:
		[HttpGet] public SomeBaseType A() => new DerivedA();

		//same DerivedA has discriminator here:
		[HttpGet] public Wrapper B() => new() { Wrapped = new DerivedA() };
	}
}