using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveSplit.Model;
using LiveSplit.UI.Components;

namespace LiveSplit.SupAutoSplit {
  public class Factory : IComponentFactory {
	public string ComponentName => "supAutoSplit";

	public string Description => "An auto splitter using template matching";

	public ComponentCategory Category => ComponentCategory.Control;

	public string UpdateName => ComponentName;

	public string XMLURL => "https://link.sup39.dev/LiveSplit/supAutoSplit.xml"; // TODO

	public string UpdateURL => "https://link.sup39.dev/LiveSplit/supAutoSplit/update"; // TODO

	public Version Version => Version.Parse("0.1.1");

	public IComponent Create(LiveSplitState state) => new Component(state);
  }
}
