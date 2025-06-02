using UiPath.CodedWorkflows.DescriptorIntegration;

namespace TestAutomationProject.ObjectRepository
{
    public static class Descriptors
    {
        public static class __Browser
        {
            static string _reference = "1Jb6ZRNzckWYcwizoRILhg/4m0LEqlvZkO_Z_456Hk82w";
            public static _Implementation.___Browser.__Browser Browser { get; private set; } = new _Implementation.___Browser.__Browser();
        }
    }
}

namespace TestAutomationProject._Implementation
{
    internal class ScreenDescriptorDefinition : IScreenDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }
        public string Reference { get; set; }
        public string DisplayName { get; set; }
    }

    internal class ElementDescriptorDefinition : IElementDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }
        public string Reference { get; set; }
        public string DisplayName { get; set; }
        public IElementDescriptor ParentElement { get; set; }
        public IElementDescriptor Element { get; set; }
    }

    namespace ___Browser
    {
        public class __Browser : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;

            public __Browser()
            {
                _screenDescriptor = new ScreenDescriptorDefinition
                {
                    Reference = "1Jb6ZRNzckWYcwizoRILhg/rNzSVJMk_kixzrhT1-Y1NQ",
                    DisplayName = "Browser",
                    Screen = this
                };
            }
        }
    }
}