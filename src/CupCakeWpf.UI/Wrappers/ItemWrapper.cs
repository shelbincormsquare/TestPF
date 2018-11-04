using CupCakeWpf.UI.Models;

namespace CupCakeWpf.UI.Wrappers
{
    public class ItemWrapper: ModelWrapper<Item>
    {
        public ItemWrapper(Item model) : base(model)
        {
        }

        public int Id { get { return Model.Id; } }

        public string Name
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
    }
}
