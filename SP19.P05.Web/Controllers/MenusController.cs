using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SP19.P05.Web.Data;
using SP19.P05.Web.Features.Menus;

//namespace SP19.P05.Web.Controllers
//{
//    public class MenusController : ApiBase
//    {
//        private readonly DataContext dataContext;
//        private readonly IMapper mapper;

//        public MenusController(DataContext dataContext, IMapper mapper)
//        {
//            this.dataContext = dataContext;
//            this.mapper = mapper;
//        }

//        [HttpGet]
//        public async Task<ActionResult<IEnumerable<MenuDto>>> Get()
//        {
//            var entityQueryable = dataContext.Set<Menu>();
//            var dtoQueryable = mapper.ProjectTo<MenuDto>(entityQueryable);
//            var itemDtos = await dtoQueryable.ToArrayAsync();
//            return itemDtos;
//        }

//        [HttpPut]
//        public async Task<ActionResult<MenuDto>> Put(MenuDto dto)
//        {
//            var entity = await dataContext.Set<Menu>().FirstOrDefaultAsync(x => x.Id == dto.Id);
//            if (entity == null)
//            {
//                return NotFound();
//            }
//            mapper.Map(dto, entity);
//            await dataContext.SaveChangesAsync();
//            return dto;
//        }

//        [HttpPost]
//        public async Task<ActionResult<MenuDto>> Post(MenuDto dto)
//        {
//            var entity = new Menu();
//            mapper.Map(dto, entity);
//            dataContext.Add(entity);
//            await dataContext.SaveChangesAsync();
//            dto.Id = entity.Id;
//            return dto;
//        }

//        [HttpDelete("{id}")]
//        public async Task<ActionResult> Delete(int id)
//        {
//            var entity = await dataContext.Set<Menu>().FirstOrDefaultAsync(x => x.Id == id);
//            if (entity == null)
//            {
//                return NotFound();
//            }

//            dataContext.Remove(entity);
//            await dataContext.SaveChangesAsync();
//            return Ok();
//        }
//    }
//}


    namespace SP19.P05.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenusController : ControllerBase
    {
        //creating an instance of datacontext
        private readonly DataContext context;

        //creating an instance of Imapper
        private readonly IMapper mapper;


        //creating a constructor for MenusControllerclass
        public MenusController(DataContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;

        }

        [HttpGet]
        public ActionResult<IEnumerable<MenuDto>> GetAllMenuDto()
        {
            var menu = context.Menu;

            return Ok(mapper.Map<IEnumerable<MenuDto>>(menu));

        }

        //[HttpPost]



        [HttpPost]
        public async Task<ActionResult<MenuDto>> CreateMenu(MenuDto menuDto)
        {
            var menu = new Menu();

            mapper.Map(menuDto, menu);
            context.Add(menu);
            await context.SaveChangesAsync();
            //t    menuDto.Id = menu.Id;

            return menuDto;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<MenuDto>>> GetMenuDtoAsync(int id)
        {
            //   return Ok(mapper.Map<IEnumerable<MenuDto>>(cont ext.Menu.FindAsync(id)));
            var dto = await context.Menu.FindAsync(id);
           
            return Ok(mapper.Map<MenuDto>(dto));
            

        }


    }
}