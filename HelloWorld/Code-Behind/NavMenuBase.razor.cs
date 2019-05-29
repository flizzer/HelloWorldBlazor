using Microsoft.AspNetCore.Components;

namespace HelloWorldBlazor
{
    public class NavMenuBase : ComponentBase
    {
        public bool collapseNavMenu = true;

        public string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

        public void ToggleNavMenu()
        {
            collapseNavMenu = !collapseNavMenu;
        }
    }
}
