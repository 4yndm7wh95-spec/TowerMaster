# 场景节点结构（游戏 v0.111.0）

PCK 只读解析。仅记录节点元数据及布局数值，不包含资源或场景全文。实例节点类型来自外部场景引用；其内部树需递归查看被引用场景，此表不伪造展开。运行时添加的节点不在静态树中。

## scenes/rooms/combat_room.tscn

资源 SHA256 `bf8895c89d8940217621434e168b6d9c9b4511e0eec16b6f13495bdc255e71af`。

| 节点名 | 节点路径（根相对） | 类型/实例引用 | 布局与输入属性 |
| --- | --- | --- | --- |
| `CombatRoom` | `/` | `Control / 脚本 res://src/Core/Nodes/Rooms/NCombatRoom.cs` | layout_mode = 3; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2 |
| `CombatSceneContainer` | `CombatSceneContainer` | `Control / 脚本 res://src/Core/Nodes/Combat/NCombatSceneContainer.cs` | unique_name_in_owner = true; layout_mode = 2; anchors_preset = 0; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `BgContainer` | `CombatSceneContainer/BgContainer` | `Control` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = 23.0; offset_right = 23.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `BackCombatVfxContainer` | `CombatSceneContainer/BackCombatVfxContainer` | `Control` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2 |
| `AllyContainer` | `CombatSceneContainer/AllyContainer` | `Control` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `EnemyContainer` | `CombatSceneContainer/EnemyContainer` | `Control` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `CombatVfxContainer` | `CombatVfxContainer` | `Control` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `RadialBlur` | `RadialBlur` | `BackBufferCopy / 脚本 res://src/Core/Nodes/Vfx/NRadialBlurVfx.cs` | visible = false |
| `Rect` | `RadialBlur/Rect` | `ColorRect` | custom_minimum_size = Vector2(1920, 1080); anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; offset_right = 1920.0; offset_bottom = 1080.0; grow_horizontal = 2; grow_vertical = 2 |
| `CombatUi` | `CombatUi` | `实例 → res://scenes/combat/combat_ui.tscn` | unique_name_in_owner = true; layout_mode = 2; anchors_preset = 0 |
| `ProceedButton` | `ProceedButton` | `实例 → res://scenes/ui/proceed_button.tscn` | unique_name_in_owner = true; visible = false; layout_mode = 1 |
| `WaitingForOtherPlayers` | `WaitingForOtherPlayers` | `Panel` | unique_name_in_owner = true; visible = false; layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2 |
| `Label` | `WaitingForOtherPlayers/Label` | `Label / 脚本 res://addons/mega_text/MegaLabel.cs` | layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; offset_left = 141.0; offset_top = -9.0; offset_right = -141.0; offset_bottom = -32.0; grow_horizontal = 2; grow_vertical = 2 |

## scenes/screens/map/map_screen.tscn

资源 SHA256 `ec8b827e10f69fc270480fe248c4d531b7f31cebecb3df8da20aa52fb2a30667`。

| 节点名 | 节点路径（根相对） | 类型/实例引用 | 布局与输入属性 |
| --- | --- | --- | --- |
| `MapScreen` | `/` | `Control / 脚本 res://src/Core/Nodes/Screens/Map/NMapScreen.cs` | layout_mode = 3; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2 |
| `Backstop` | `Backstop` | `ColorRect` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `TheMap` | `TheMap` | `Control` | layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `MapBg` | `TheMap/MapBg` | `VBoxContainer / 脚本 res://src/Core/Nodes/Screens/Map/NMapBg.cs` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 10; anchor_right = 1.0; offset_top = -1600.0; offset_bottom = 1640.0; grow_horizontal = 2; mouse_filter = 2 |
| `MapTop` | `TheMap/MapBg/MapTop` | `TextureRect` | custom_minimum_size = Vector2(0, 1080); layout_mode = 2; mouse_filter = 2 |
| `MapMid` | `TheMap/MapBg/MapMid` | `TextureRect` | custom_minimum_size = Vector2(0, 1080); layout_mode = 2; mouse_filter = 2 |
| `MapBot` | `TheMap/MapBg/MapBot` | `TextureRect` | custom_minimum_size = Vector2(0, 1080); layout_mode = 2; mouse_filter = 2 |
| `Paths` | `TheMap/Paths` | `Control` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `Points` | `TheMap/Points` | `Control` | layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `Drawings` | `TheMap/Drawings` | `Control / 脚本 res://src/Core/Nodes/Screens/Map/NMapDrawings.cs` | unique_name_in_owner = true; anchors_preset = 0; offset_top = -1600.0; offset_right = 1920.0; offset_bottom = 1640.0; mouse_filter = 2 |
| `MapMarker` | `TheMap/MapMarker` | `TextureRect / 脚本 res://src/Core/Nodes/Screens/Map/NMapMarker.cs` | visible = false; layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -960.0; offset_top = -540.0; offset_right = -920.0; offset_bottom = -500.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `MapLegend` | `MapLegend` | `TextureRect` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = 558.0; offset_top = -251.0; offset_right = 898.0; offset_bottom = 203.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `LegendHotkeyIcon` | `MapLegend/LegendHotkeyIcon` | `实例 → res://scenes/ui/hotkey_icon.tscn` | unique_name_in_owner = true; custom_minimum_size = Vector2(48, 48); layout_mode = 1; offset_left = 49.0; offset_top = 39.000004; offset_right = 97.0; offset_bottom = 87.0; size_flags_stretch_ratio = 0.0 |
| `Header` | `MapLegend/Header` | `Label / 脚本 res://addons/mega_text/MegaLabel.cs` | layout_mode = 1; anchors_preset = 5; anchor_left = 0.5; anchor_right = 0.5; offset_left = -123.0; offset_top = 3.0; offset_right = 123.0; offset_bottom = 123.0; grow_horizontal = 2 |
| `LegendItems` | `MapLegend/LegendItems` | `VBoxContainer` | layout_mode = 1; anchors_preset = 5; anchor_left = 0.5; anchor_right = 0.5; offset_left = -124.0; offset_top = 101.0; offset_right = 156.0; offset_bottom = 457.0; grow_horizontal = 2; mouse_filter = 2 |
| `UnknownLegendItem` | `MapLegend/LegendItems/UnknownLegendItem` | `Control / 脚本 res://src/Core/Nodes/Screens/Map/NMapLegendItem.cs` | custom_minimum_size = Vector2(280, 48); layout_mode = 2 |
| `Icon` | `MapLegend/LegendItems/UnknownLegendItem/Icon` | `TextureRect` | layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -120.0; offset_top = -31.0; offset_right = -56.0; offset_bottom = 33.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `MegaLabel` | `MapLegend/LegendItems/UnknownLegendItem/MegaLabel` | `Label / 脚本 res://addons/mega_text/MegaLabel.cs` | layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -56.0; offset_top = -65.0; offset_right = 129.0; offset_bottom = 72.0; grow_horizontal = 2; grow_vertical = 2 |
| `MerchantLegendItem` | `MapLegend/LegendItems/MerchantLegendItem` | `Control / 脚本 res://src/Core/Nodes/Screens/Map/NMapLegendItem.cs` | custom_minimum_size = Vector2(280, 48); layout_mode = 2 |
| `Icon` | `MapLegend/LegendItems/MerchantLegendItem/Icon` | `TextureRect` | layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -120.0; offset_top = -31.0; offset_right = -56.0; offset_bottom = 33.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `MegaLabel` | `MapLegend/LegendItems/MerchantLegendItem/MegaLabel` | `Label / 脚本 res://addons/mega_text/MegaLabel.cs` | layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -56.0; offset_top = -65.0; offset_right = 129.0; offset_bottom = 72.0; grow_horizontal = 2; grow_vertical = 2 |
| `TreasureLegendItem` | `MapLegend/LegendItems/TreasureLegendItem` | `Control / 脚本 res://src/Core/Nodes/Screens/Map/NMapLegendItem.cs` | custom_minimum_size = Vector2(280, 48); layout_mode = 2 |
| `Icon` | `MapLegend/LegendItems/TreasureLegendItem/Icon` | `TextureRect` | layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -120.0; offset_top = -31.0; offset_right = -56.0; offset_bottom = 33.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `MegaLabel` | `MapLegend/LegendItems/TreasureLegendItem/MegaLabel` | `Label / 脚本 res://addons/mega_text/MegaLabel.cs` | layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -56.0; offset_top = -65.0; offset_right = 129.0; offset_bottom = 72.0; grow_horizontal = 2; grow_vertical = 2 |
| `RestSiteLegendItem` | `MapLegend/LegendItems/RestSiteLegendItem` | `Control / 脚本 res://src/Core/Nodes/Screens/Map/NMapLegendItem.cs` | custom_minimum_size = Vector2(280, 48); layout_mode = 2 |
| `Icon` | `MapLegend/LegendItems/RestSiteLegendItem/Icon` | `TextureRect` | layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -120.0; offset_top = -31.0; offset_right = -56.0; offset_bottom = 33.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `MegaLabel` | `MapLegend/LegendItems/RestSiteLegendItem/MegaLabel` | `Label / 脚本 res://addons/mega_text/MegaLabel.cs` | layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -56.0; offset_top = -65.0; offset_right = 129.0; offset_bottom = 72.0; grow_horizontal = 2; grow_vertical = 2 |
| `EnemyLegendItem` | `MapLegend/LegendItems/EnemyLegendItem` | `Control / 脚本 res://src/Core/Nodes/Screens/Map/NMapLegendItem.cs` | custom_minimum_size = Vector2(280, 48); layout_mode = 2 |
| `Icon` | `MapLegend/LegendItems/EnemyLegendItem/Icon` | `TextureRect` | layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -120.0; offset_top = -31.0; offset_right = -56.0; offset_bottom = 33.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `MegaLabel` | `MapLegend/LegendItems/EnemyLegendItem/MegaLabel` | `Label / 脚本 res://addons/mega_text/MegaLabel.cs` | layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -56.0; offset_top = -65.0; offset_right = 129.0; offset_bottom = 72.0; grow_horizontal = 2; grow_vertical = 2 |
| `EliteLegendItem` | `MapLegend/LegendItems/EliteLegendItem` | `Control / 脚本 res://src/Core/Nodes/Screens/Map/NMapLegendItem.cs` | custom_minimum_size = Vector2(280, 48); layout_mode = 2 |
| `Icon` | `MapLegend/LegendItems/EliteLegendItem/Icon` | `TextureRect` | layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -120.0; offset_top = -31.0; offset_right = -56.0; offset_bottom = 33.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `MegaLabel` | `MapLegend/LegendItems/EliteLegendItem/MegaLabel` | `Label / 脚本 res://addons/mega_text/MegaLabel.cs` | layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -56.0; offset_top = -65.0; offset_right = 129.0; offset_bottom = 72.0; grow_horizontal = 2; grow_vertical = 2 |
| `Back` | `Back` | `实例 → res://scenes/ui/back_button.tscn` | layout_mode = 1 |
| `DrawingTools` | `DrawingTools` | `NinePatchRect` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 2; anchor_top = 1.0; anchor_bottom = 1.0; offset_left = 56.0; offset_top = -108.0; offset_right = 264.0; offset_bottom = -40.0; grow_vertical = 0 |
| `DrawingToolsHotkey` | `DrawingTools/DrawingToolsHotkey` | `实例 → res://scenes/ui/hotkey_icon.tscn` | unique_name_in_owner = true; custom_minimum_size = Vector2(48, 48); layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -139.00002; offset_top = -11.0; offset_right = -91.000015; offset_bottom = 49.0; grow_horizontal = 2; grow_vertical = 2; size_flags_stretch_ratio = 0.0 |
| `HBoxContainer` | `DrawingTools/HBoxContainer` | `HBoxContainer` | custom_minimum_size = Vector2(60, 60); layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -94.0; offset_top = -30.0; offset_right = 94.0; offset_bottom = 30.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `DrawButton` | `DrawingTools/HBoxContainer/DrawButton` | `Control / 脚本 res://src/Core/Nodes/Screens/Map/NMapDrawButton.cs` | unique_name_in_owner = true; custom_minimum_size = Vector2(60, 60); layout_mode = 2 |
| `Icon` | `DrawingTools/HBoxContainer/DrawButton/Icon` | `TextureRect` | layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2; scale = Vector2(1.1, 1.1); mouse_filter = 2 |
| `EraseButton` | `DrawingTools/HBoxContainer/EraseButton` | `Control / 脚本 res://src/Core/Nodes/Screens/Map/NMapEraseButton.cs` | unique_name_in_owner = true; custom_minimum_size = Vector2(60, 60); layout_mode = 2 |
| `Icon` | `DrawingTools/HBoxContainer/EraseButton/Icon` | `TextureRect` | layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2; scale = Vector2(1.1, 1.1); mouse_filter = 2 |
| `ClearButton` | `DrawingTools/HBoxContainer/ClearButton` | `Control / 脚本 res://src/Core/Nodes/Screens/Map/NMapClearButton.cs` | unique_name_in_owner = true; custom_minimum_size = Vector2(68, 60); layout_mode = 2 |
| `Icon` | `DrawingTools/HBoxContainer/ClearButton/Icon` | `TextureRect` | layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2; scale = Vector2(1.1, 1.1); mouse_filter = 2 |
| `ShareButton` | `ShareButton` | `实例 → res://scenes/ui/share_button.tscn / 脚本 res://src/Core/Nodes/Screens/Map/NMapShareButton.cs` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 3; anchor_left = 1.0; anchor_top = 1.0; anchor_right = 1.0; anchor_bottom = 1.0; offset_left = -220.0; offset_top = -112.0; offset_right = -48.0; offset_bottom = -48.0; grow_horizontal = 0; grow_vertical = 0; size_flags_horizontal = 8; size_flags_vertical = 8 |
| `ShareToast` | `ShareToast` | `Label / 脚本 res://addons/mega_text/MegaLabel.cs` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 3; anchor_left = 1.0; anchor_top = 1.0; anchor_right = 1.0; anchor_bottom = 1.0; offset_left = -359.0; offset_top = -177.0; offset_right = -49.0; offset_bottom = -121.0; grow_horizontal = 0; grow_vertical = 0 |

## scenes/screens/rewards_screen.tscn

资源 SHA256 `68140982f9a6eaa778f7e8e404c8ea5370a3342b9f5337b6cb550c8788f6dfe2`。

| 节点名 | 节点路径（根相对） | 类型/实例引用 | 布局与输入属性 |
| --- | --- | --- | --- |
| `RewardsScreen` | `/` | `Control / 脚本 res://src/Core/Nodes/Screens/NRewardsScreen.cs` | layout_mode = 3; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2 |
| `Rewards` | `Rewards` | `Control` | layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -264.0; offset_top = -304.0; offset_right = 262.0; offset_bottom = 336.0; grow_horizontal = 2; grow_vertical = 2 |
| `Background` | `Rewards/Background` | `TextureRect` | layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2 |
| `Banner` | `Rewards/Background/Banner` | `TextureRect` | layout_mode = 1; anchors_preset = 5; anchor_left = 0.5; anchor_right = 0.5; offset_left = -324.0; offset_top = -28.0; offset_right = 328.0; offset_bottom = 134.0; grow_horizontal = 2 |
| `HeaderLabel` | `Rewards/Background/Banner/HeaderLabel` | `Label / 脚本 res://addons/mega_text/MegaLabel.cs` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; offset_left = 141.0; offset_top = -9.0; offset_right = -141.0; offset_bottom = -32.0; grow_horizontal = 2; grow_vertical = 2 |
| `RewardContainerMask` | `Rewards/RewardContainerMask` | `TextureRect` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -237.0; offset_top = -217.0; offset_right = 237.0; offset_bottom = 267.0; grow_horizontal = 2; grow_vertical = 2 |
| `RewardsContainer` | `Rewards/RewardContainerMask/RewardsContainer` | `VBoxContainer` | unique_name_in_owner = true; layout_mode = 0; offset_left = 36.0; offset_top = 35.0; offset_right = 438.0; offset_bottom = 435.0 |
| `Scrollbar` | `Rewards/Scrollbar` | `实例 → res://scenes/ui/scrollbar.tscn` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = -1; anchor_left = 1.0; anchor_right = 1.0; anchor_bottom = 1.0; offset_left = -14.0; offset_top = 140.0; offset_right = 31.0; offset_bottom = -55.0; grow_horizontal = 0 |
| `ProceedButton` | `ProceedButton` | `实例 → res://scenes/ui/proceed_button.tscn` | layout_mode = 1 |
| `WaitingForOtherPlayers` | `WaitingForOtherPlayers` | `Panel` | unique_name_in_owner = true; visible = false; layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2 |
| `Label` | `WaitingForOtherPlayers/Label` | `Label / 脚本 res://addons/mega_text/MegaLabel.cs` | layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; offset_left = 141.0; offset_top = -9.0; offset_right = -141.0; offset_bottom = -32.0; grow_horizontal = 2; grow_vertical = 2 |

## scenes/ui/top_bar.tscn

资源 SHA256 `793bfa91a1868ca67b7466cb621c5a36408efb8e5d029ff000ba5fb25f4a9125`。

| 节点名 | 节点路径（根相对） | 类型/实例引用 | 布局与输入属性 |
| --- | --- | --- | --- |
| `TopBar` | `/` | `Control / 脚本 res://src/Core/Nodes/CommonUi/NTopBar.cs` | layout_mode = 3; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2 |
| `BgImage` | `BgImage` | `TextureRect` | layout_mode = 1; anchors_preset = -1; anchor_left = 0.495833; anchor_top = -0.000925926; anchor_right = 0.495833; anchor_bottom = -0.000925926; offset_left = -1280.0; offset_right = 1280.0; offset_bottom = 100.0; grow_horizontal = 2; scale = Vector2(1.01, 1.01) |
| `TrailContainer` | `TrailContainer` | `Control` | unique_name_in_owner = true; anchors_preset = 0 |
| `LeftAlignedStuff` | `LeftAlignedStuff` | `HBoxContainer` | layout_mode = 0; offset_left = 8.0; offset_right = 1288.0; offset_bottom = 80.0 |
| `PortraitContainer` | `LeftAlignedStuff/PortraitContainer` | `MarginContainer` | custom_minimum_size = Vector2(0, 80); layout_mode = 2 |
| `TopBarPortraitTip` | `LeftAlignedStuff/PortraitContainer/TopBarPortraitTip` | `Control / 脚本 res://src/Core/Nodes/TopBar/NTopBarPortraitTip.cs` | unique_name_in_owner = true; custom_minimum_size = Vector2(72, 0); layout_mode = 2; size_flags_horizontal = 0 |
| `Bg` | `LeftAlignedStuff/PortraitContainer/TopBarPortraitTip/Bg` | `TextureRect` | layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `TopBarPortrait` | `LeftAlignedStuff/PortraitContainer/TopBarPortraitTip/TopBarPortrait` | `Control / 脚本 res://src/Core/Nodes/TopBar/NTopBarPortrait.cs` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -27.0; offset_top = -27.0; offset_right = 27.0; offset_bottom = 27.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `AscensionIcon` | `LeftAlignedStuff/PortraitContainer/TopBarPortraitTip/AscensionIcon` | `TextureRect` | unique_name_in_owner = true; visible = false; layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; offset_left = 43.0; offset_top = 28.0; offset_right = 13.0; offset_bottom = 2.0; grow_horizontal = 2; grow_vertical = 2 |
| `AscensionLabel` | `LeftAlignedStuff/PortraitContainer/TopBarPortraitTip/AscensionIcon/AscensionLabel` | `Label / 脚本 res://addons/mega_text/MegaLabel.cs` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; offset_left = 9.0; offset_top = -3.0; offset_right = -11.0; offset_bottom = 15.0; grow_horizontal = 2; grow_vertical = 2 |
| `AchievementLock` | `LeftAlignedStuff/PortraitContainer/TopBarPortraitTip/AchievementLock` | `TextureRect` | unique_name_in_owner = true; custom_minimum_size = Vector2(30, 30); layout_mode = 1; offset_left = -6.0; offset_right = 24.0; offset_bottom = 30.0; mouse_filter = 2 |
| `TopBarHp` | `LeftAlignedStuff/TopBarHp` | `HBoxContainer / 脚本 res://src/Core/Nodes/TopBar/NTopBarHp.cs` | unique_name_in_owner = true; layout_mode = 2 |
| `HpIcon` | `LeftAlignedStuff/TopBarHp/HpIcon` | `TextureRect` | custom_minimum_size = Vector2(53, 80); layout_mode = 2; size_flags_vertical = 4; mouse_filter = 2 |
| `HpLabel` | `LeftAlignedStuff/TopBarHp/HpLabel` | `Label / 脚本 res://addons/mega_text/MegaLabel.cs` | unique_name_in_owner = true; custom_minimum_size = Vector2(120, 80); layout_mode = 2 |
| `TopBarGold` | `LeftAlignedStuff/TopBarGold` | `HBoxContainer / 脚本 res://src/Core/Nodes/TopBar/NTopBarGold.cs` | unique_name_in_owner = true; custom_minimum_size = Vector2(0, 80); layout_mode = 2 |
| `GoldIcon` | `LeftAlignedStuff/TopBarGold/GoldIcon` | `TextureRect` | custom_minimum_size = Vector2(54, 80); layout_mode = 2; mouse_filter = 2 |
| `GoldLabel` | `LeftAlignedStuff/TopBarGold/GoldLabel` | `Label / 脚本 res://addons/mega_text/MegaLabel.cs` | unique_name_in_owner = true; custom_minimum_size = Vector2(80, 80); layout_mode = 2 |
| `PotionMarginifier` | `LeftAlignedStuff/PotionMarginifier` | `MarginContainer` | layout_mode = 2 |
| `PotionContainer` | `LeftAlignedStuff/PotionMarginifier/PotionContainer` | `MarginContainer / 脚本 res://src/Core/Nodes/Potions/NPotionContainer.cs` | unique_name_in_owner = true; custom_minimum_size = Vector2(140, 80); layout_mode = 2 |
| `PotionBg` | `LeftAlignedStuff/PotionMarginifier/PotionContainer/PotionBg` | `NinePatchRect` | layout_mode = 2 |
| `PotionErrorBg` | `LeftAlignedStuff/PotionMarginifier/PotionContainer/PotionErrorBg` | `NinePatchRect` | layout_mode = 2 |
| `MarginContainer` | `LeftAlignedStuff/PotionMarginifier/PotionContainer/MarginContainer` | `MarginContainer` | layout_mode = 2 |
| `PotionHolders` | `LeftAlignedStuff/PotionMarginifier/PotionContainer/MarginContainer/PotionHolders` | `HBoxContainer` | layout_mode = 2; mouse_filter = 2 |
| `PotionShortcutButton` | `LeftAlignedStuff/PotionMarginifier/PotionContainer/PotionShortcutButton` | `实例 → res://scenes/potions/potion_shortcut_button.tscn` | layout_mode = 2; size_flags_horizontal = 0 |
| `RoomIcons` | `LeftAlignedStuff/RoomIcons` | `HBoxContainer` | custom_minimum_size = Vector2(0, 80); layout_mode = 2; mouse_filter = 2 |
| `RoomIconResizer` | `LeftAlignedStuff/RoomIcons/RoomIconResizer` | `MarginContainer` | layout_mode = 2; mouse_filter = 2 |
| `RoomIcon` | `LeftAlignedStuff/RoomIcons/RoomIconResizer/RoomIcon` | `Control / 脚本 res://src/Core/Nodes/TopBar/NTopBarRoomIcon.cs` | unique_name_in_owner = true; custom_minimum_size = Vector2(44, 44); layout_mode = 2; size_flags_horizontal = 4 |
| `Icon` | `LeftAlignedStuff/RoomIcons/RoomIconResizer/RoomIcon/Icon` | `TextureRect` | custom_minimum_size = Vector2(44, 44); layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -22.0; offset_top = -44.0; offset_right = 22.0; offset_bottom = 44.0; grow_horizontal = 2; grow_vertical = 2; size_flags_horizontal = 4; mouse_filter = 2 |
| `Outline` | `LeftAlignedStuff/RoomIcons/RoomIconResizer/RoomIcon/Icon/Outline` | `TextureRect` | layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2; size_flags_horizontal = 4; mouse_filter = 2 |
| `FloorIcon` | `LeftAlignedStuff/RoomIcons/FloorIcon` | `HBoxContainer / 脚本 res://src/Core/Nodes/TopBar/NTopBarFloorIcon.cs` | unique_name_in_owner = true; layout_mode = 2 |
| `FloorIconPositioner` | `LeftAlignedStuff/RoomIcons/FloorIcon/FloorIconPositioner` | `MarginContainer` | layout_mode = 2 |
| `FloorInfoIcon` | `LeftAlignedStuff/RoomIcons/FloorIcon/FloorIconPositioner/FloorInfoIcon` | `TextureRect` | custom_minimum_size = Vector2(60, 64); layout_mode = 2; mouse_filter = 2 |
| `FloorNumLabel` | `LeftAlignedStuff/RoomIcons/FloorIcon/FloorNumLabel` | `Label / 脚本 res://addons/mega_text/MegaLabel.cs` | unique_name_in_owner = true; custom_minimum_size = Vector2(0, 80); layout_mode = 2 |
| `BossIcon` | `LeftAlignedStuff/RoomIcons/BossIcon` | `MarginContainer / 脚本 res://src/Core/Nodes/TopBar/NTopBarBossIcon.cs` | unique_name_in_owner = true; layout_mode = 2; mouse_filter = 0 |
| `Icon` | `LeftAlignedStuff/RoomIcons/BossIcon/Icon` | `TextureRect` | custom_minimum_size = Vector2(44, 44); layout_mode = 2; size_flags_horizontal = 4; mouse_filter = 2 |
| `Outline` | `LeftAlignedStuff/RoomIcons/BossIcon/Icon/Outline` | `TextureRect` | layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2; size_flags_horizontal = 4; mouse_filter = 2 |
| `Modifiers` | `LeftAlignedStuff/Modifiers` | `HBoxContainer` | unique_name_in_owner = true; custom_minimum_size = Vector2(0, 80); layout_mode = 2; mouse_filter = 2 |
| `RightAlignedStuff` | `RightAlignedStuff` | `HBoxContainer` | layout_mode = 1; anchors_preset = 1; anchor_left = 1.0; anchor_right = 1.0; offset_left = -492.0; offset_right = -16.0; offset_bottom = 80.0; grow_horizontal = 0; mouse_filter = 2 |
| `SaveIndicator` | `RightAlignedStuff/SaveIndicator` | `实例 → res://scenes/ui/save_indicator.tscn` | layout_mode = 2 |
| `Padding` | `RightAlignedStuff/Padding` | `Control` | custom_minimum_size = Vector2(36, 0); layout_mode = 2; mouse_filter = 2 |
| `TimerContainer` | `RightAlignedStuff/TimerContainer` | `HBoxContainer / 脚本 res://src/Core/Nodes/TopBar/NRunTimer.cs` | unique_name_in_owner = true; layout_mode = 2; mouse_filter = 0 |
| `TimerIcon` | `RightAlignedStuff/TimerContainer/TimerIcon` | `TextureRect` | custom_minimum_size = Vector2(40, 80); layout_mode = 2; mouse_filter = 2 |
| `TimerLabel` | `RightAlignedStuff/TimerContainer/TimerLabel` | `Label / 脚本 res://addons/mega_text/MegaLabel.cs` | unique_name_in_owner = true; custom_minimum_size = Vector2(120, 80); layout_mode = 2 |
| `Map` | `RightAlignedStuff/Map` | `实例 → res://scenes/ui/top_bar/top_bar_map_button.tscn` | unique_name_in_owner = true; layout_mode = 2 |
| `Deck` | `RightAlignedStuff/Deck` | `实例 → res://scenes/ui/top_bar/top_bar_deck_button.tscn` | unique_name_in_owner = true; layout_mode = 2 |
| `PauseButton` | `RightAlignedStuff/PauseButton` | `实例 → res://scenes/ui/top_bar/top_bar_settings_button.tscn` | unique_name_in_owner = true; layout_mode = 2 |
| `GoldPopup` | `GoldPopup` | `Label / 脚本 res://addons/mega_text/MegaLabel.cs` | unique_name_in_owner = true; visible = false; custom_minimum_size = Vector2(200, 59.7); layout_mode = 0; offset_left = 212.0; offset_top = 26.0; offset_right = 412.0; offset_bottom = 86.0 |
| `ActiveScreenProxy` | `ActiveScreenProxy` | `Control` | unique_name_in_owner = true; anchors_preset = 0; offset_left = 870.0; offset_top = -430.0; offset_right = 910.0; offset_bottom = -390.0; mouse_filter = 2 |

## scenes/cards/card.tscn

资源 SHA256 `ca8f1cf93536b0d0d03daa7e9bd00073013316abcd158a82f6bfe4dc832b9cba`。

| 节点名 | 节点路径（根相对） | 类型/实例引用 | 布局与输入属性 |
| --- | --- | --- | --- |
| `Card` | `/` | `Control / 脚本 res://src/Core/Nodes/Cards/NCard.cs` | layout_mode = 3; anchors_preset = 0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `CardContainer` | `CardContainer` | `Control` | unique_name_in_owner = true; anchors_preset = 0; mouse_filter = 2 |
| `Shadow` | `CardContainer/Shadow` | `TextureRect` | layout_mode = 0; offset_left = -138.0; offset_top = -199.0; offset_right = 162.0; offset_bottom = 223.0; mouse_filter = 2 |
| `Highlight` | `CardContainer/Highlight` | `TextureRect / 脚本 res://src/Core/Nodes/Cards/NCardHighlight.cs` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -381.0; offset_top = -475.0; offset_right = 378.0; offset_bottom = 476.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `PortraitCanvasGroup` | `CardContainer/PortraitCanvasGroup` | `CanvasGroup` | unique_name_in_owner = true |
| `Portrait` | `CardContainer/PortraitCanvasGroup/Portrait` | `TextureRect` | unique_name_in_owner = true; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -125.0; offset_top = -168.0; offset_right = 125.0; offset_bottom = 22.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `AncientPortrait` | `CardContainer/PortraitCanvasGroup/AncientPortrait` | `TextureRect` | unique_name_in_owner = true; visible = false; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; offset_left = -153.0; offset_top = -215.0; offset_right = 445.0; offset_bottom = 627.0; grow_horizontal = 2; grow_vertical = 2; scale = Vector2(0.5, 0.5); mouse_filter = 2 |
| `AncientBorderGlassOverlay` | `CardContainer/AncientBorderGlassOverlay` | `TextureRect` | unique_name_in_owner = true; visible = false; layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; offset_left = -148.46497; offset_top = -210.71002; offset_right = 442.08002; offset_bottom = 621.3; grow_horizontal = 2; grow_vertical = 2; scale = Vector2(0.5, 0.5); mouse_filter = 2 |
| `AncientBorder` | `CardContainer/AncientBorder` | `TextureRect` | unique_name_in_owner = true; visible = false; layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -154.0; offset_top = -223.0; offset_right = 152.0; offset_bottom = 217.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `AncientTextBg` | `CardContainer/AncientTextBg` | `TextureRect` | unique_name_in_owner = true; visible = false; layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -133.0; offset_top = -22.0; offset_right = 131.0; offset_bottom = 181.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `Lock` | `CardContainer/Lock` | `TextureRect` | unique_name_in_owner = true; visible = false; layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -125.0; offset_top = -175.0; offset_right = 125.0; offset_bottom = 15.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `Frame` | `CardContainer/Frame` | `TextureRect` | unique_name_in_owner = true; visible = false; layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -150.0; offset_top = -211.0; offset_right = 150.0; offset_bottom = 211.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `DescriptionLabel` | `CardContainer/DescriptionLabel` | `RichTextLabel / 脚本 res://addons/mega_text/MegaRichTextLabel.cs` | unique_name_in_owner = true; layout_mode = 0; offset_left = -122.0; offset_top = 37.0; offset_right = 121.0; offset_bottom = 173.0; mouse_filter = 2 |
| `PortraitBorder` | `CardContainer/PortraitBorder` | `TextureRect` | unique_name_in_owner = true; visible = false; layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -137.5; offset_top = -164.0; offset_right = 137.5; offset_bottom = 46.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `OverlayContainer` | `CardContainer/OverlayContainer` | `Control` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `TitleBanner` | `CardContainer/TitleBanner` | `TextureRect` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -163.0; offset_top = -207.0; offset_right = 164.0; offset_bottom = -124.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `AncientBanner` | `CardContainer/AncientBanner` | `TextureRect` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -163.0; offset_top = -207.0; offset_right = 164.0; offset_bottom = -124.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `Fire` | `CardContainer/AncientBanner/Fire` | `AnimatedSprite2D` | position = Vector2(164, -10); scale = Vector2(0.6, 0.6) |
| `TitleLabel` | `CardContainer/TitleLabel` | `Label / 脚本 res://addons/mega_text/MegaLabel.cs` | unique_name_in_owner = true; layout_mode = 0; offset_left = -105.0; offset_top = -204.0; offset_right = 105.0; offset_bottom = -150.0 |
| `TypePlaque` | `CardContainer/TypePlaque` | `NinePatchRect` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -30.5; offset_top = 1.0; offset_right = 30.5; offset_bottom = 38.0; grow_horizontal = 2; grow_vertical = 2 |
| `TypeLabel` | `CardContainer/TypePlaque/TypeLabel` | `Label / 脚本 res://addons/mega_text/MegaLabel.cs` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -22.0; offset_top = -14.0; offset_right = 22.0; offset_bottom = 14.0; grow_horizontal = 2; grow_vertical = 2 |
| `CardVfxContainer` | `CardContainer/CardVfxContainer` | `Control` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `EnergyIcon` | `CardContainer/EnergyIcon` | `TextureRect` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -166.0; offset_top = -227.0; offset_right = -102.0; offset_bottom = -163.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `EnergyLabel` | `CardContainer/EnergyIcon/EnergyLabel` | `Label / 脚本 res://addons/mega_text/MegaLabel.cs` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -23.0; offset_top = -26.0; offset_right = 23.0; offset_bottom = 30.0; grow_horizontal = 2; grow_vertical = 2 |
| `UnplayableEnergyIcon` | `CardContainer/EnergyIcon/UnplayableEnergyIcon` | `TextureRect` | unique_name_in_owner = true; visible = false; layout_mode = 0; offset_left = 8.0; offset_top = 8.0; offset_right = 56.0; offset_bottom = 56.0 |
| `StarIcon` | `CardContainer/StarIcon` | `TextureRect` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -186.0; offset_top = -189.0; offset_right = -128.0; offset_bottom = -131.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `StarLabel` | `CardContainer/StarIcon/StarLabel` | `Label / 脚本 res://addons/mega_text/MegaLabel.cs` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -14.0; offset_top = -20.0; offset_right = 14.0; offset_bottom = 20.0; grow_horizontal = 2; grow_vertical = 2 |
| `UnplayableStarIcon` | `CardContainer/StarIcon/UnplayableStarIcon` | `TextureRect` | unique_name_in_owner = true; visible = false; layout_mode = 0; offset_left = 5.0; offset_top = 5.0; offset_right = 53.0; offset_bottom = 53.0 |
| `Enchantment` | `CardContainer/Enchantment` | `TextureRect` | unique_name_in_owner = true; layout_mode = 0; offset_left = -166.0; offset_top = -116.0; offset_right = -94.0; offset_bottom = -62.0; mouse_filter = 2 |
| `Icon` | `CardContainer/Enchantment/Icon` | `TextureRect` | layout_mode = 0; offset_left = 14.0; offset_top = 9.0; offset_right = 49.0; offset_bottom = 44.0 |
| `Label` | `CardContainer/Enchantment/Label` | `Label / 脚本 res://addons/mega_text/MegaLabel.cs` | layout_mode = 0; offset_left = 26.0; offset_top = 27.0; offset_right = 66.0; offset_bottom = 53.0 |
| `EnchantmentVfxOverride` | `CardContainer/EnchantmentVfxOverride` | `TextureRect` | unique_name_in_owner = true; visible = false; layout_mode = 0; offset_left = -202.0; offset_top = -142.0; offset_right = -58.0; offset_bottom = -34.0 |
| `CardSparkles` | `CardContainer/CardSparkles` | `实例 → res://scenes/vfx/card_sparkles_vfx.tscn` | visible = false |

## scenes/combat/player_hand.tscn

资源 SHA256 `a656fc74e795597c697b6152e2154efba8285541c6af012cf1ebecb9bb8aef1a`。

| 节点名 | 节点路径（根相对） | 类型/实例引用 | 布局与输入属性 |
| --- | --- | --- | --- |
| `PlayerHand` | `/` | `Control / 脚本 res://src/Core/Nodes/Combat/NPlayerHand.cs` | layout_mode = 3; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2 |
| `SelectModeBackstop` | `SelectModeBackstop` | `ColorRect` | unique_name_in_owner = true; visible = false; layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `CardHolderContainer` | `CardHolderContainer` | `Control` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 7; anchor_left = 0.5; anchor_top = 1.0; anchor_right = 0.5; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 0; mouse_filter = 2 |
| `SelectedHandCardContainer` | `SelectedHandCardContainer` | `Control / 脚本 res://src/Core/Nodes/Combat/NSelectedHandCardContainer.cs` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_top = -52.0; offset_bottom = -52.0; grow_horizontal = 2; grow_vertical = 2 |
| `UpgradePreviewContainer` | `UpgradePreviewContainer` | `Control` | unique_name_in_owner = true; visible = false; layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `UpgradePreview` | `UpgradePreviewContainer/UpgradePreview` | `实例 → res://scenes/cards/upgrade_preview.tscn` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_top = -50.0; offset_bottom = -50.0; grow_horizontal = 2; grow_vertical = 2; scale = Vector2(0.9, 0.9) |
| `SelectModeConfirmButton` | `SelectModeConfirmButton` | `实例 → res://scenes/ui/confirm_button.tscn` | unique_name_in_owner = true; layout_mode = 1 |
| `SelectionHeader` | `SelectionHeader` | `RichTextLabel / 脚本 res://addons/mega_text/MegaRichTextLabel.cs` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 14; anchor_top = 0.5; anchor_right = 1.0; anchor_bottom = 0.5; offset_left = 7.0; offset_top = -342.0; offset_right = 7.0; offset_bottom = -292.0; grow_horizontal = 2; grow_vertical = 2 |
| `PeekButton` | `PeekButton` | `实例 → res://scenes/combat/peek_button.tscn` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 4; anchor_left = 0.0; anchor_right = 0.0; offset_left = 100.0; offset_top = -64.0; offset_right = 228.0; offset_bottom = 64.0; grow_horizontal = 1 |

## scenes/combat/combat_ui.tscn

资源 SHA256 `a5c0e40a5c290c8d057e435e8408cc5f91a44066091ce219aa23ff1e8984d417`。

| 节点名 | 节点路径（根相对） | 类型/实例引用 | 布局与输入属性 |
| --- | --- | --- | --- |
| `CombatUi` | `/` | `Control / 脚本 res://src/Core/Nodes/Combat/NCombatUi.cs` | layout_mode = 3; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `EnergyCounterContainer` | `EnergyCounterContainer` | `Control` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 2; anchor_top = 1.0; anchor_bottom = 1.0; offset_left = 100.0; offset_top = -252.0; offset_right = 100.0; offset_bottom = -252.0; grow_vertical = 0 |
| `StarCounter` | `StarCounter` | `实例 → res://scenes/combat/energy_counters/star_counter.tscn` | unique_name_in_owner = true; layout_mode = 1 |
| `PingButton` | `PingButton` | `实例 → res://scenes/combat/ping_button.tscn` | unique_name_in_owner = true; layout_mode = 1; offset_left = -382.0; offset_top = 100.0; offset_right = -232.0; offset_bottom = 170.0 |
| `EndTurnButton` | `EndTurnButton` | `实例 → res://scenes/combat/end_turn_button.tscn` | unique_name_in_owner = true; layout_mode = 1; offset_top = 16.0; offset_bottom = 106.0 |
| `CombatPileContainer` | `CombatPileContainer` | `实例 → res://scenes/combat/combat_piles_container.tscn` | unique_name_in_owner = true; layout_mode = 1 |
| `CardPreviewContainer` | `CardPreviewContainer` | `Control / 脚本 res://src/Core/Nodes/CommonUi/NCardPreviewContainer.cs` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `MessyCardPreviewContainer` | `MessyCardPreviewContainer` | `Control / 脚本 res://src/Core/Nodes/CommonUi/NMessyCardPreviewContainer.cs` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; offset_left = 263.0; offset_top = 196.0; offset_right = -302.0; offset_bottom = -122.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `Hand` | `Hand` | `实例 → res://scenes/combat/player_hand.tscn` | unique_name_in_owner = true; layout_mode = 1; mouse_filter = 2 |
| `PlayQueue` | `PlayQueue` | `Control / 脚本 res://src/Core/Nodes/Combat/NCardPlayQueue.cs` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `PlayContainer` | `PlayContainer` | `Control` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |

## scenes/ui/proceed_button.tscn

资源 SHA256 `f7bd79a21abaf894a0152a54a1024104a8a1ef57f1bbe0887589ed27d8f6f407`。

| 节点名 | 节点路径（根相对） | 类型/实例引用 | 布局与输入属性 |
| --- | --- | --- | --- |
| `ProceedButton` | `/` | `Control / 脚本 res://src/Core/Nodes/CommonUi/NProceedButton.cs` | custom_minimum_size = Vector2(269, 108); layout_mode = 3; anchors_preset = 3; anchor_left = 1.0; anchor_top = 1.0; anchor_right = 1.0; anchor_bottom = 1.0; offset_left = -337.0; offset_top = -316.0; offset_right = -68.0; offset_bottom = -208.0; grow_horizontal = 0; grow_vertical = 0 |
| `Image` | `Image` | `TextureRect` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; offset_left = -11.0; offset_top = -22.0; offset_right = 16.0; offset_bottom = 25.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `Shadow` | `Image/Shadow` | `TextureRect` | layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; offset_left = 12.0; offset_top = 12.0; offset_right = 12.0; offset_bottom = 12.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `Outline` | `Image/Outline` | `TextureRect` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `Label` | `Image/Label` | `Label / 脚本 res://addons/mega_text/MegaLabel.cs` | unique_name_in_owner = true; layout_mode = 0; offset_left = 57.0; offset_top = 14.0; offset_right = 236.0; offset_bottom = 151.0 |
| `HotkeyIcon` | `HotkeyIcon` | `实例 → res://scenes/ui/hotkey_icon.tscn` | unique_name_in_owner = true; layout_mode = 0; offset_left = -16.0; offset_top = 60.0; offset_right = 32.0; offset_bottom = 108.0; scale = Vector2(0.85, 0.85) |

## scenes/ui/hotkey_icon.tscn

资源 SHA256 `5d6ba70f520cf783127ecb94379145fe828789303f129fd934b62a31896e9349`。

| 节点名 | 节点路径（根相对） | 类型/实例引用 | 布局与输入属性 |
| --- | --- | --- | --- |
| `HotkeyIcon` | `/` | `Control / 脚本 res://src/Core/Nodes/CommonUi/NHotkeyIcon.cs` | layout_mode = 3; anchors_preset = 0; offset_left = -24.0; offset_top = -24.0; offset_right = 24.0; offset_bottom = 24.0; scale = Vector2(0.85, 0.85); mouse_filter = 2 |
| `ControllerIcon` | `ControllerIcon` | `TextureRect` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -64.0; offset_top = -32.0; offset_right = 64.0; offset_bottom = 32.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `KeyboardIcon` | `KeyboardIcon` | `MarginContainer` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -32.0; offset_top = -32.0; offset_right = 32.0; offset_bottom = 32.0; grow_horizontal = 2; grow_vertical = 2; scale = Vector2(0.7, 0.7); mouse_filter = 2 |
| `TextureRect` | `KeyboardIcon/TextureRect` | `NinePatchRect` | layout_mode = 2 |
| `LabelPositioner` | `KeyboardIcon/LabelPositioner` | `MarginContainer` | layout_mode = 2; mouse_filter = 2 |
| `KeyboardLabel` | `KeyboardIcon/LabelPositioner/KeyboardLabel` | `Label / 脚本 res://addons/mega_text/MegaLabel.cs` | unique_name_in_owner = true; layout_mode = 2; size_flags_horizontal = 4 |

## scenes/ui/back_button.tscn

资源 SHA256 `9e63312e967c34bfa8a1ae60319e046f2073de95b3b60e3a13b0f71cc51d77c6`。

| 节点名 | 节点路径（根相对） | 类型/实例引用 | 布局与输入属性 |
| --- | --- | --- | --- |
| `BackButton` | `/` | `Control / 脚本 res://src/Core/Nodes/CommonUi/NBackButton.cs` | layout_mode = 3; anchors_preset = 2; anchor_top = 1.0; anchor_bottom = 1.0; offset_left = -40.0; offset_top = -354.0; offset_right = 160.0; offset_bottom = -244.0; grow_vertical = 0 |
| `Shadow` | `Shadow` | `TextureRect` | layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; offset_left = -9.0; offset_top = -1.0; offset_right = 58.0; offset_bottom = 39.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `Outline` | `Outline` | `TextureRect` | layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; offset_left = -24.0; offset_top = -16.0; offset_right = 49.0; offset_bottom = 30.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `Image` | `Image` | `TextureRect` | layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; offset_left = -21.0; offset_top = -13.0; offset_right = 46.0; offset_bottom = 27.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `Icon` | `Image/Icon` | `TextureRect` | layout_mode = 0; offset_left = 88.0; offset_top = 28.0; offset_right = 168.0; offset_bottom = 108.0; mouse_filter = 2 |
| `HotkeyIcon` | `Image/HotkeyIcon` | `实例 → res://scenes/ui/hotkey_icon.tscn` | unique_name_in_owner = true; layout_mode = 1; offset_left = 70.0; offset_top = 92.0; offset_right = 118.0; offset_bottom = 140.0; scale = Vector2(0.85, 0.85) |

## scenes/ui/share_button.tscn

资源 SHA256 `b31c3c608b4ae5ff5a19407d9b31a4cd3d2d5011fa74d745587a3d73b3e9d5bd`。

| 节点名 | 节点路径（根相对） | 类型/实例引用 | 布局与输入属性 |
| --- | --- | --- | --- |
| `ShareButton` | `/` | `MarginContainer / 脚本 res://src/Core/Nodes/Screens/NShareButton.cs` | custom_minimum_size = Vector2(180, 64); offset_right = 172.0; offset_bottom = 64.0 |
| `ButtonImage` | `ButtonImage` | `TextureRect` | unique_name_in_owner = true; layout_mode = 2; mouse_filter = 2 |
| `Shadow` | `ButtonImage/Shadow` | `TextureRect` | layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; offset_left = 6.0; offset_top = 4.0; offset_right = 6.0; offset_bottom = 4.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `LabelContainer` | `LabelContainer` | `MarginContainer` | unique_name_in_owner = true; layout_mode = 2; mouse_filter = 2 |
| `HBoxContainer` | `LabelContainer/HBoxContainer` | `HBoxContainer` | layout_mode = 2; mouse_filter = 2 |
| `Icon` | `LabelContainer/HBoxContainer/Icon` | `TextureRect` | custom_minimum_size = Vector2(48, 48); layout_mode = 2; size_flags_horizontal = 0; mouse_filter = 2 |
| `Label` | `LabelContainer/HBoxContainer/Label` | `Label / 脚本 res://addons/mega_text/MegaLabel.cs` | unique_name_in_owner = true; custom_minimum_size = Vector2(64, 64); layout_mode = 2; size_flags_horizontal = 3 |
| `IconHolder` | `IconHolder` | `Control` | visible = false; layout_mode = 2 |
| `HotkeyIcon` | `IconHolder/HotkeyIcon` | `实例 → res://scenes/ui/hotkey_icon.tscn` | unique_name_in_owner = true; custom_minimum_size = Vector2(48, 48); layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = 66.0; offset_top = 0.9999962; offset_right = 114.0; offset_bottom = 49.0; grow_horizontal = 2; grow_vertical = 2 |

## scenes/ui/scrollbar.tscn

资源 SHA256 `97142976f38b19e1b84683cef5b859f1fdb6d49055c5b8488983a02014f9106b`。

| 节点名 | 节点路径（根相对） | 类型/实例引用 | 布局与输入属性 |
| --- | --- | --- | --- |
| `Scrollbar` | `/` | `Range / 脚本 res://src/Core/Nodes/GodotExtensions/NScrollbar.cs` | unique_name_in_owner = false; visible = true; custom_minimum_size = Vector2(0, 0); layout_mode = 3; anchors_preset = 0; anchor_left = 0.0; anchor_top = 0.0; anchor_right = 0.0; anchor_bottom = 0.0; offset_left = 0.0; offset_top = 0.0; offset_right = 48.0; offset_bottom = 820.0; grow_horizontal = 1; grow_vertical = 1; scale = Vector2(1, 1); size_flags_horizontal = 1; size_flags_vertical = 1; size_flags_stretch_ratio = 1.0; mouse_filter = 0 |
| `TrackBody` | `TrackBody` | `TextureRect` | layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2; size_flags_vertical = 3; mouse_filter = 2 |
| `TrackTop` | `TrackTop` | `TextureRect` | layout_mode = 1; anchors_preset = 10; anchor_right = 1.0; offset_top = -48.0; grow_horizontal = 2; mouse_filter = 2 |
| `TrackBot` | `TrackBot` | `TextureRect` | layout_mode = 1; anchors_preset = 12; anchor_top = 1.0; anchor_right = 1.0; anchor_bottom = 1.0; offset_bottom = 48.0; grow_horizontal = 2; grow_vertical = 0; mouse_filter = 2 |
| `Handle` | `Handle` | `TextureRect / 脚本 res://src/Core/Nodes/CommonUi/NScrollbarTrain.cs` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 7; anchor_left = 0.5; anchor_top = 1.0; anchor_right = 0.5; anchor_bottom = 1.0; offset_left = -36.0; offset_top = -847.0; offset_right = 36.0; offset_bottom = -775.0; grow_horizontal = 2; grow_vertical = 0 |

## scenes/potions/potion_shortcut_button.tscn

资源 SHA256 `dd54bd045308e6a163d3307d685c2b0c238a460a969cb65c62b1422da6cb8a3e`。

| 节点名 | 节点路径（根相对） | 类型/实例引用 | 布局与输入属性 |
| --- | --- | --- | --- |
| `PotionShortcutButton` | `/` | `Control / 脚本 res://src/Core/Nodes/Potions/NPotionShortcutButton.cs` | layout_mode = 3; anchors_preset = 0; size_flags_horizontal = 8; mouse_filter = 2 |
| `HotkeyIcon` | `HotkeyIcon` | `实例 → res://scenes/ui/hotkey_icon.tscn` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -26.0; offset_right = 22.0; grow_horizontal = 2; grow_vertical = 2; scale = Vector2(0.75, 0.75) |

## scenes/ui/save_indicator.tscn

资源 SHA256 `a3a50a20f90340787e47021bf9657c2f5b7321a3d8ec48be1b32c5f65f969d6b`。

| 节点名 | 节点路径（根相对） | 类型/实例引用 | 布局与输入属性 |
| --- | --- | --- | --- |
| `SaveIndicator` | `/` | `Control / 脚本 res://src/Core/Nodes/CommonUi/NSaveIndicator.cs` | custom_minimum_size = Vector2(200, 80); layout_mode = 3; anchors_preset = 0; mouse_filter = 2 |
| `Label` | `Label` | `RichTextLabel / 脚本 res://addons/mega_text/MegaRichTextLabel.cs` | custom_minimum_size = Vector2(200, 80); layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -100.0; offset_top = -21.0; offset_right = 100.0; offset_bottom = 59.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |

## scenes/ui/top_bar/top_bar_map_button.tscn

资源 SHA256 `364d0fb75cdc24dffec3649ed9c25adbf66d6bf894d6a52aa7341b952386edb7`。

| 节点名 | 节点路径（根相对） | 类型/实例引用 | 布局与输入属性 |
| --- | --- | --- | --- |
| `Map` | `/` | `MarginContainer / 脚本 res://src/Core/Nodes/TopBar/NTopBarMapButton.cs` | custom_minimum_size = Vector2(80, 80); mouse_filter = 0 |
| `Control` | `Control` | `Control` | layout_mode = 2; mouse_filter = 2 |
| `Icon` | `Control/Icon` | `TextureRect` | layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `HotkeyIcon` | `Control/HotkeyIcon` | `实例 → res://scenes/ui/hotkey_icon.tscn` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -47.999996; offset_top = -1.0; offset_right = 3.8146973e-06; offset_bottom = 47.0; grow_horizontal = 2; grow_vertical = 2; scale = Vector2(0.62, 0.62) |

## scenes/ui/top_bar/top_bar_deck_button.tscn

资源 SHA256 `7fb359324ceae51688fc33c54cac77958ce6c24f85175149e568b0d258fa18ae`。

| 节点名 | 节点路径（根相对） | 类型/实例引用 | 布局与输入属性 |
| --- | --- | --- | --- |
| `TopBarDeckButton` | `/` | `Control / 脚本 res://src/Core/Nodes/TopBar/NTopBarDeckButton.cs` | custom_minimum_size = Vector2(80, 80); layout_mode = 3; anchors_preset = 0 |
| `Control` | `Control` | `Control` | layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `Icon` | `Control/Icon` | `TextureRect` | custom_minimum_size = Vector2(72, 72); layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -36.0; offset_top = -36.0; offset_right = 36.0; offset_bottom = 36.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `HotkeyIcon` | `HotkeyIcon` | `实例 → res://scenes/ui/hotkey_icon.tscn` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -47.999996; offset_top = -1.0; offset_right = 3.8146973e-06; offset_bottom = 47.0; grow_horizontal = 2; grow_vertical = 2; scale = Vector2(0.62, 0.62) |
| `DeckCardCount` | `DeckCardCount` | `Label / 脚本 res://addons/mega_text/MegaLabel.cs` | layout_mode = 1; anchors_preset = 3; anchor_left = 1.0; anchor_top = 1.0; anchor_right = 1.0; anchor_bottom = 1.0; offset_left = -37.0; offset_top = -36.0; offset_right = -4.0; grow_horizontal = 0; grow_vertical = 0 |

## scenes/ui/top_bar/top_bar_settings_button.tscn

资源 SHA256 `04464f127b41ea6eb5d49c2c52c3efe9ab760c2f0fe7a0ee0b053da59e331d91`。

| 节点名 | 节点路径（根相对） | 类型/实例引用 | 布局与输入属性 |
| --- | --- | --- | --- |
| `Options` | `/` | `MarginContainer / 脚本 res://src/Core/Nodes/TopBar/NTopBarPauseButton.cs` | custom_minimum_size = Vector2(80, 80); mouse_filter = 0 |
| `Control` | `Control` | `Control` | layout_mode = 2; mouse_filter = 2 |
| `Icon` | `Control/Icon` | `TextureRect` | custom_minimum_size = Vector2(64, 64); layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `HotkeyIcon` | `Control/HotkeyIcon` | `实例 → res://scenes/ui/hotkey_icon.tscn` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -47.999996; offset_top = -1.0; offset_right = 3.8146973e-06; offset_bottom = 47.0; grow_horizontal = 2; grow_vertical = 2; scale = Vector2(0.62, 0.62) |

## scenes/vfx/card_sparkles_vfx.tscn

资源 SHA256 `953c646eef31cacd4162d07a7353e101a1979b255fd73d2e7c622acd3c8fc4de`。

| 节点名 | 节点路径（根相对） | 类型/实例引用 | 布局与输入属性 |
| --- | --- | --- | --- |
| `CardSparkles` | `/` | `GPUParticles2D` |  |

## scenes/cards/upgrade_preview.tscn

资源 SHA256 `4563cb37deeaa83cb68b49cc23f0a570a1a34b0c8948559ff70460ac03b9e0d7`。

| 节点名 | 节点路径（根相对） | 类型/实例引用 | 布局与输入属性 |
| --- | --- | --- | --- |
| `UpgradePreview` | `/` | `Control / 脚本 res://src/Core/Nodes/Cards/NUpgradePreview.cs` | layout_mode = 3; anchors_preset = 0; mouse_filter = 2 |
| `Before` | `Before` | `Control` | unique_name_in_owner = true; anchors_preset = 0; offset_left = -280.0; offset_right = -280.0 |
| `After` | `After` | `Control` | unique_name_in_owner = true; layout_mode = 3; anchors_preset = 0; offset_left = 280.0; offset_right = 280.0 |
| `Arrows` | `Arrows` | `Control` | anchors_preset = 0; mouse_filter = 2 |
| `Shadow` | `Arrows/Shadow` | `HBoxContainer` | layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -93.5; offset_top = -24.5; offset_right = 109.5; offset_bottom = 40.5; grow_horizontal = 2; grow_vertical = 2 |
| `Arrow1` | `Arrows/Shadow/Arrow1` | `TextureRect` | layout_mode = 2; mouse_filter = 2 |
| `Arrow2` | `Arrows/Shadow/Arrow2` | `TextureRect` | layout_mode = 2; mouse_filter = 2 |
| `Arrow3` | `Arrows/Shadow/Arrow3` | `TextureRect` | layout_mode = 2; mouse_filter = 2 |
| `HBoxContainer` | `Arrows/HBoxContainer` | `HBoxContainer` | layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -101.5; offset_top = -32.5; offset_right = 101.5; offset_bottom = 32.5; grow_horizontal = 2; grow_vertical = 2 |
| `Arrow1` | `Arrows/HBoxContainer/Arrow1` | `TextureRect` | layout_mode = 2; mouse_filter = 2 |
| `Arrow2` | `Arrows/HBoxContainer/Arrow2` | `TextureRect` | layout_mode = 2; mouse_filter = 2 |
| `Arrow3` | `Arrows/HBoxContainer/Arrow3` | `TextureRect` | layout_mode = 2; mouse_filter = 2 |

## scenes/ui/confirm_button.tscn

资源 SHA256 `41c620a847d069d4fd6d23d50bc20616f2ddc0b4689c6d066dbc44fcb06c7999`。

| 节点名 | 节点路径（根相对） | 类型/实例引用 | 布局与输入属性 |
| --- | --- | --- | --- |
| `ConfirmButton` | `/` | `Control / 脚本 res://src/Core/Nodes/CommonUi/NConfirmButton.cs` | layout_mode = 3; anchors_preset = 3; anchor_left = 1.0; anchor_top = 1.0; anchor_right = 1.0; anchor_bottom = 1.0; offset_left = -160.0; offset_top = -354.0; offset_right = 40.0; offset_bottom = -244.0; grow_horizontal = 0; grow_vertical = 0 |
| `Shadow` | `Shadow` | `TextureRect` | layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; offset_left = -41.0; offset_top = -1.0; offset_right = 26.0; offset_bottom = 39.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `Outline` | `Outline` | `TextureRect` | layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; offset_left = -56.0; offset_top = -16.0; offset_right = 17.0; offset_bottom = 30.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `Image` | `Image` | `TextureRect` | layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; offset_left = -53.0; offset_top = -13.0; offset_right = 14.0; offset_bottom = 27.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `Icon` | `Image/Icon` | `TextureRect` | layout_mode = 0; offset_left = 88.0; offset_top = 28.0; offset_right = 168.0; offset_bottom = 108.0; mouse_filter = 2 |
| `HotkeyIcon` | `Image/HotkeyIcon` | `实例 → res://scenes/ui/hotkey_icon.tscn` | unique_name_in_owner = true; layout_mode = 0; offset_left = 156.0; offset_top = 92.0; offset_right = 204.0; offset_bottom = 140.0; scale = Vector2(0.85, 0.85) |

## scenes/combat/peek_button.tscn

资源 SHA256 `84e307232102640429545e55493bfb177e894c9c33388390a6341304f14691ea`。

| 节点名 | 节点路径（根相对） | 类型/实例引用 | 布局与输入属性 |
| --- | --- | --- | --- |
| `PeekButton` | `/` | `Control / 脚本 res://src/Core/Nodes/Combat/NPeekButton.cs` | layout_mode = 3; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -1024.0; offset_top = -604.0; offset_right = -896.0; offset_bottom = -476.0; grow_horizontal = 2; grow_vertical = 2 |
| `Visuals` | `Visuals` | `TextureRect` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `Flash` | `Visuals/Flash` | `TextureRect` | unique_name_in_owner = true; visible = false; layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; offset_left = -17.0; offset_top = -17.0; offset_right = 17.0; offset_bottom = 17.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `OutsideClickHitbox` | `OutsideClickHitbox` | `Control / 脚本 res://src/Core/Nodes/GodotExtensions/NClickableControl.cs` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 0; mouse_filter = 1 |
| `HotkeyIcon` | `HotkeyIcon` | `实例 → res://scenes/ui/hotkey_icon.tscn` | unique_name_in_owner = true; layout_mode = 0; offset_left = -16.0; offset_top = 71.0; offset_right = 32.0; offset_bottom = 119.0; scale = Vector2(0.85, 0.85) |
| `CurrentCardMarker` | `CurrentCardMarker` | `Marker2D` | unique_name_in_owner = true; position = Vector2(64, -105) |

## scenes/combat/energy_counters/star_counter.tscn

资源 SHA256 `63ac8630f5d7b747a434cbd10768c8018460598df10b90a70a8c8a8db92c73b3`。

| 节点名 | 节点路径（根相对） | 类型/实例引用 | 布局与输入属性 |
| --- | --- | --- | --- |
| `StarCounter` | `/` | `Control / 脚本 res://src/Core/Nodes/Combat/NStarCounter.cs` | layout_mode = 3; anchors_preset = 2; anchor_top = 1.0; anchor_bottom = 1.0; offset_left = 64.0; offset_top = -212.0; offset_right = 192.0; offset_bottom = -83.9999; grow_vertical = 0; scale = Vector2(0.8, 0.8) |
| `Icon` | `Icon` | `TextureRect` | layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `RotationLayers` | `Icon/RotationLayers` | `Control` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `Layer1` | `Icon/RotationLayers/Layer1` | `TextureRect` | layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `Layer2` | `Icon/RotationLayers/Layer2` | `TextureRect` | layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `MarginContainer` | `MarginContainer` | `MarginContainer` | layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `CountLabel` | `MarginContainer/CountLabel` | `RichTextLabel / 脚本 res://addons/mega_text/MegaRichTextLabel.cs` | unique_name_in_owner = true; layout_mode = 2; mouse_filter = 2 |

## scenes/combat/ping_button.tscn

资源 SHA256 `113a32b2feca6c24cac8b4214ace95084ac3acafa1996728285b252637ea8e93`。

| 节点名 | 节点路径（根相对） | 类型/实例引用 | 布局与输入属性 |
| --- | --- | --- | --- |
| `PingButton` | `/` | `Control / 脚本 res://src/Core/Nodes/Combat/NPingButton.cs` | layout_mode = 3; anchors_preset = 3; anchor_left = 1.0; anchor_top = 1.0; anchor_right = 1.0; anchor_bottom = 1.0; offset_left = -328.0; offset_top = -210.0; offset_right = -178.0; offset_bottom = -140.0; grow_horizontal = 0; grow_vertical = 0 |
| `Visuals` | `Visuals` | `Control` | layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `Image` | `Visuals/Image` | `TextureRect` | layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `Label` | `Visuals/Label` | `Label / 脚本 res://addons/mega_text/MegaLabel.cs` | layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -57.0; offset_top = -19.5; offset_right = 57.0; offset_bottom = 19.5; grow_horizontal = 2; grow_vertical = 2 |
| `HotkeyIcon` | `Visuals/HotkeyIcon` | `实例 → res://scenes/ui/hotkey_icon.tscn` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = 48.0; offset_top = -5.0; offset_right = 96.0; offset_bottom = 43.0; grow_horizontal = 2; grow_vertical = 2; scale = Vector2(0.7, 0.7) |

## scenes/combat/end_turn_button.tscn

资源 SHA256 `06366310faf0409175f4eb919fd9270c8184cff987ad2f2e40f09c3329f8c301`。

| 节点名 | 节点路径（根相对） | 类型/实例引用 | 布局与输入属性 |
| --- | --- | --- | --- |
| `EndTurnButton` | `/` | `Control / 脚本 res://src/Core/Nodes/Combat/NEndTurnButton.cs` | layout_mode = 3; anchors_preset = 3; anchor_left = 1.0; anchor_top = 1.0; anchor_right = 1.0; anchor_bottom = 1.0; offset_left = -316.0; offset_top = -234.0; offset_right = -96.0; offset_bottom = -144.0; grow_horizontal = 0; grow_vertical = 0 |
| `Visuals` | `Visuals` | `Control` | layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `GlowVfx` | `Visuals/GlowVfx` | `TextureRect` | layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -256.0; offset_top = -128.0; offset_right = 256.0; offset_bottom = 128.0; grow_horizontal = 2; grow_vertical = 2; scale = Vector2(0.5, 0.5); mouse_filter = 2 |
| `Image` | `Visuals/Image` | `TextureRect` | layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -256.0; offset_top = -128.0; offset_right = 256.0; offset_bottom = 128.0; grow_horizontal = 2; grow_vertical = 2; scale = Vector2(0.5, 0.5); mouse_filter = 2 |
| `Glow` | `Visuals/Glow` | `TextureRect` | layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -256.0; offset_top = -128.0; offset_right = 256.0; offset_bottom = 128.0; grow_horizontal = 2; grow_vertical = 2; scale = Vector2(0.5, 0.5); mouse_filter = 2 |
| `Label` | `Visuals/Label` | `Label / 脚本 res://addons/mega_text/MegaLabel.cs` | layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; offset_left = 29.0; offset_top = 11.0; offset_right = -29.0; offset_bottom = -7.0; grow_horizontal = 2; grow_vertical = 2 |
| `HotkeyIcon` | `Visuals/HotkeyIcon` | `实例 → res://scenes/ui/hotkey_icon.tscn` | unique_name_in_owner = true; layout_mode = 0; offset_left = 185.00002; offset_top = 54.000004; offset_right = 233.00002; offset_bottom = 102.0; scale = Vector2(0.85, 0.85) |
| `PlayerIconContainer` | `PlayerIconContainer` | `实例 → res://scenes/ui/multiplayer_vote_container.tscn` | unique_name_in_owner = true; layout_mode = 0; offset_left = -16.0; offset_top = -15.0; offset_right = 233.0; offset_bottom = 15.0 |
| `Bar` | `Bar` | `ColorRect / 脚本 res://src/Core/Nodes/Combat/NEndTurnLongPressBar.cs` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 14; anchor_top = 0.5; anchor_right = 1.0; anchor_bottom = 0.5; offset_left = 8.0; offset_top = -56.0; offset_right = -8.0; offset_bottom = -50.0; grow_horizontal = 2; grow_vertical = 2 |
| `BarOutline` | `Bar/BarOutline` | `ColorRect` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; offset_left = -5.0; offset_top = -4.0; offset_right = 5.0; offset_bottom = 4.0; grow_horizontal = 2; grow_vertical = 2 |

## scenes/combat/combat_piles_container.tscn

资源 SHA256 `9bd982a6820e3b8faa4a2d2472697c774d95d8182737a79739263cbfc3aa666e`。

| 节点名 | 节点路径（根相对） | 类型/实例引用 | 布局与输入属性 |
| --- | --- | --- | --- |
| `CombatPilesContainer` | `/` | `Control / 脚本 res://src/Core/Nodes/Combat/NCombatPilesContainer.cs` | layout_mode = 3; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `DrawPile` | `DrawPile` | `实例 → res://scenes/combat/draw_pile.tscn` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 2; anchor_top = 1.0; anchor_bottom = 1.0; offset_left = 15.0; offset_top = -95.0; offset_right = 95.0; offset_bottom = -15.0; grow_vertical = 0 |
| `DiscardPile` | `DiscardPile` | `实例 → res://scenes/combat/discard_pile.tscn` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 3; anchor_left = 1.0; anchor_top = 1.0; anchor_right = 1.0; anchor_bottom = 1.0; offset_left = -94.0; offset_top = -95.0; offset_right = -14.0; offset_bottom = -15.0; grow_horizontal = 0; grow_vertical = 0 |
| `ExhaustPile` | `ExhaustPile` | `实例 → res://scenes/combat/exhaust_pile.tscn` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 3; anchor_left = 1.0; anchor_top = 1.0; anchor_right = 1.0; anchor_bottom = 1.0; offset_left = -90.0; offset_top = -280.0; offset_right = -10.0; offset_bottom = -200.0; grow_horizontal = 0; grow_vertical = 0 |

## scenes/ui/multiplayer_vote_container.tscn

资源 SHA256 `95795bff4460476d38eb2b5c9a39545a3ea4614a3ed058ca72ad1e1ca0008c39`。

| 节点名 | 节点路径（根相对） | 类型/实例引用 | 布局与输入属性 |
| --- | --- | --- | --- |
| `MultiplayerVoteContainer` | `/` | `HBoxContainer / 脚本 res://src/Core/Nodes/CommonUi/NMultiplayerVoteContainer.cs` | offset_left = 70.0; offset_top = 310.0; offset_right = 319.0; offset_bottom = 340.0; mouse_filter = 2 |

## scenes/combat/draw_pile.tscn

资源 SHA256 `e578cf41b681ed81e5ba79353ea850ca80825f0cc54c0784bda9e67a36f23bbe`。

| 节点名 | 节点路径（根相对） | 类型/实例引用 | 布局与输入属性 |
| --- | --- | --- | --- |
| `DrawPile` | `/` | `Control / 脚本 res://src/Core/Nodes/Combat/NDrawPileButton.cs` | layout_mode = 3; anchors_preset = 0; offset_right = 80.0; offset_bottom = 80.0 |
| `Icon` | `Icon` | `TextureRect` | layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `CountContainer` | `CountContainer` | `Control` | layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = 8.0; offset_top = -4.0; offset_right = 56.0; offset_bottom = 44.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `Background` | `CountContainer/Background` | `TextureRect` | layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `Count` | `CountContainer/Count` | `Label / 脚本 res://addons/mega_text/MegaLabel.cs` | layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; offset_left = 12.0; offset_top = -26.0; offset_right = -12.0; offset_bottom = 26.0; grow_horizontal = 2; grow_vertical = 2 |
| `HotkeyIcon` | `HotkeyIcon` | `实例 → res://scenes/ui/hotkey_icon.tscn` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -50.0; offset_top = -1.0; offset_right = -2.0; offset_bottom = 47.0; grow_horizontal = 2; grow_vertical = 2; scale = Vector2(0.7, 0.7) |

## scenes/combat/discard_pile.tscn

资源 SHA256 `25c70cd445d37218c4b1c315e852642de5004aa53814317960174085aa0550a3`。

| 节点名 | 节点路径（根相对） | 类型/实例引用 | 布局与输入属性 |
| --- | --- | --- | --- |
| `DiscardPile` | `/` | `Control / 脚本 res://src/Core/Nodes/Combat/NDiscardPileButton.cs` | layout_mode = 3; anchors_preset = 0; offset_right = 80.0; offset_bottom = 80.0 |
| `Icon` | `Icon` | `TextureRect` | layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `CountContainer` | `CountContainer` | `Control` | layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -57.5; offset_top = -3.5; offset_right = -9.5; offset_bottom = 44.5; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `Background` | `CountContainer/Background` | `TextureRect` | layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `Count` | `CountContainer/Count` | `Label / 脚本 res://addons/mega_text/MegaLabel.cs` | layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; offset_left = 12.0; offset_top = -26.0; offset_right = -12.0; offset_bottom = 26.0; grow_horizontal = 2; grow_vertical = 2 |
| `HotkeyIcon` | `HotkeyIcon` | `实例 → res://scenes/ui/hotkey_icon.tscn` | unique_name_in_owner = true; custom_minimum_size = Vector2(48, 48); layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = 2.0000038; offset_top = -1.0; offset_right = 50.0; offset_bottom = 47.0; grow_horizontal = 2; grow_vertical = 2; scale = Vector2(0.7, 0.7) |

## scenes/combat/exhaust_pile.tscn

资源 SHA256 `5e5f81f449c3542ae4b3572d415a454811d16e85e61d096df3c7136cc40c5708`。

| 节点名 | 节点路径（根相对） | 类型/实例引用 | 布局与输入属性 |
| --- | --- | --- | --- |
| `ExhaustPile` | `/` | `Control / 脚本 res://src/Core/Nodes/Combat/NExhaustPileButton.cs` | layout_mode = 3; anchors_preset = 0; offset_right = 80.0; offset_bottom = 80.0 |
| `Icon` | `Icon` | `TextureRect` | layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `CountContainer` | `CountContainer` | `Control` | layout_mode = 1; anchors_preset = 15; anchor_right = 1.0; anchor_bottom = 1.0; grow_horizontal = 2; grow_vertical = 2; mouse_filter = 2 |
| `Count` | `CountContainer/Count` | `Label / 脚本 res://addons/mega_text/MegaLabel.cs` | layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -19.0; offset_top = -48.0; offset_right = 19.0; offset_bottom = 52.0; grow_horizontal = 2; grow_vertical = 2 |
| `HotkeyIcon` | `HotkeyIcon` | `实例 → res://scenes/ui/hotkey_icon.tscn` | unique_name_in_owner = true; layout_mode = 1; anchors_preset = 8; anchor_left = 0.5; anchor_top = 0.5; anchor_right = 0.5; anchor_bottom = 0.5; offset_left = -4.999996; offset_top = 0.9999924; offset_right = 43.0; offset_bottom = 49.0; grow_horizontal = 2; grow_vertical = 2; scale = Vector2(0.7, 0.7) |
