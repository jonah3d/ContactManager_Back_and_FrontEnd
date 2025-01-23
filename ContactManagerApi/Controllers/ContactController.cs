using AutoMapper;
using ContactManagerApi.DTO;
using ContactManagerApi.Models;
using ContactManagerApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContactManagerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IContactRepository contactRepository;

        public ContactController(IMapper mapper,IContactRepository contactRepository)
        {
            this.mapper = mapper;
            this.contactRepository = contactRepository;
        }

        [HttpPost]
        public async Task<IActionResult> AddContact([FromBody] AddContactDTO addContactDTO)
        {
           var contactDM =  mapper.Map<Contact>(addContactDTO);

          await  contactRepository.AddContactAsync(contactDM);

            return Ok(mapper.Map<ContactDTO>(contactDM));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllContacts()
        {
            var contacts = await contactRepository.GetAllContactsAsync();
            return Ok(mapper.Map<List<ContactDTO>>(contacts));
        }

        [HttpGet("{telephone}")]
        public async Task<IActionResult> GetContact(string telephone)
        {
            var contact = await contactRepository.GetContactAsync(telephone);

            if (contact == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<ContactDTO>(contact));
        }


        [HttpDelete("{telephone}")]
        public async Task<IActionResult> DeleteContact(string telephone)
        {
         var deleteWM =   await  contactRepository.DeleteContactAsync(telephone);

            if (deleteWM == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<ContactDTO>(deleteWM));
        }

        [HttpPut("{telephone}")]
        public async Task<IActionResult> UpdateContact(string telephone, [FromBody] UpdateContactDTO updateContactDTO)
        {
            var contactDM = mapper.Map<Contact>(updateContactDTO);

            if(contactDM == null)
            {
                return NotFound();
            }

            var updateWM = await contactRepository.UpdateContactAsync(telephone, contactDM);
            return Ok(mapper.Map<ContactDTO>(updateWM));
        }
    }
}
