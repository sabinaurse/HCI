using Microsoft.AspNetCore.Mvc;

using HCI.Assistant.Api.Models.DTOs.AIAssistantController;

namespace HCI.Assistant.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AIAssistantController : ControllerBase
{
        [HttpPost("/message")]
        public async Task<ActionResult<AIAssistantControllerPostMessageResponseDTO>> PostMessage([FromBody] AIAssistantControllerPostMessageRequestDTO request)
        {
            AIAssistantControllerPostMessageResponseDTO response = new()
            {
                TextMessage = "HI!" + request.TextMessage
            };

            return Ok(response);
        }
}