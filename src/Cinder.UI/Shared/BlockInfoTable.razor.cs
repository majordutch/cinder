using Cinder.UI.Infrastructure.Components;
using Cinder.UI.Infrastructure.Dtos;
using Microsoft.AspNetCore.Components;

namespace Cinder.UI.Shared
{
    public class BlockInfoTableModel : CinderComponentBase
    {
        [Parameter]
        public BlockDto Block { get; set; }
    }
}
