﻿using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface;
using Robust.Client.UserInterface.XAML;

namespace Content.Client.UserInterface.Systems.Actions.Controls;

[GenerateTypedNameReferences]
public sealed partial class ActionPageButtons : Control
{
    public ActionPageButtons()
    {
        RobustXamlLoader.Load(this);
    }
}