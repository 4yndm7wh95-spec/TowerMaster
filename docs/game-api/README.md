# 游戏接口资料索引

供看不到本机游戏、`decompiled/` 和 PCK 的开发者使用。本次对应 **《杀戮尖塔2》v0.111.0**，只读分析，未修改游戏或 mod 代码。程序集身份 `sts2, Version=0.1.0.0`；游戏目标框架 `.NETCoreApp,Version=v9.0`（不要把程序集版本 0.1.0.0 当游戏版本）。DLL SHA256：`0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

| 资料 | 内容 |
| --- | --- |
| [flows.md](flows.md) | 进房/未知房解析、回合与暂停、战斗命令、动作同步排序、死亡拥有者、独立随机流及等待屏障建议 |
| [ui.md](ui.md) | 界面容器/输入、控件/字体/本地化、模型显示、全员牌堆和数据读取、调试界面参考 |
| [scene-trees.md](scene-trees.md) | 从本机 PCK 只读提取的六个主场景及递归实例子场景，共29份节点元数据；无资源正文 |
| [signatures/](signatures/) | 4353类型、109命名空间的元数据反射表；字段/属性/方法/构造/事件、基类/接口、async标记、枚举具名值 |

## 签名覆盖与表示方式

覆盖请求中的 Combat、Commands、GameActions、GameActions.Multiplayer、Multiplayer.Game、Runs、Rooms、Map、Entities 全部子命名空间、Nodes 全部子命名空间、Localization（附带 Fonts 子命名空间）和 Helpers。Models 只列 AbstractModel、MonsterModel、EncounterModel、ActModel、PowerModel、CardModel、RelicModel、PotionModel、ModelDb；Powers 只列 StrengthPower、WeakPower、VulnerablePower、FrailPower、ArtifactPower 及游戏内基类；Cards 列构造器声明 CardType.Status 的17种状态牌及基类，含 DeprecatedCard（存在于程序集不等于实际会生成）。

为使流程/UI引用可查，另附 **ValueProps、Random、HoverTips、Assets** 签名。Godot/System等外部依赖只显示基类与引用类型名，没有导出整个引擎库。每表按类型完整名称排列，只列本类型声明成员；继承的游戏成员沿基类表查询，不重复粘贴。包括非公开/静态、访问器、编译器生成状态机和 Godot 生成成员，使用时先找正常公开方法，不能因私有成员列出就把它视为稳定扩展 API。

`[async]` 来源 AsyncStateMachineAttribute；Task返回不一定有标记。可空引用注解未从特性重建，表中没有 `?` **不能证明不接受null**，相关命令的null规则在 flows 中结合正文核对。枚举默认参数可显示底层数字，枚举字段有所有具名值。构造器名采用 CLR `.ctor/.cctor`，嵌套类型采用 `+`，泛型约束带原始约束标志；是元数据签名表示，不能直接把整行当C#源码编译。

游戏有 `MegaCrit.Sts2` 与 `MegaCrit.sts2` 的命名空间大小写变体。Windows 文件系统不区分大小写，后者文件加 `.case-variant.md` 防覆盖；**类型全名保留真实大小写**，按名字反射必须用表内名称。文件行号全部指本机对应版本 `decompiled/sts2/<命名空间>/<类型>.cs`，不在仓库中；游戏更新后行号会变化。

## 重新生成

需要游戏完整DLL依赖目录、.NET 9 SDK（更新后按游戏要求调整工具目标框架）、Python 3、与DLL同版本的本地反编译。不要提交游戏DLL、PCK、资源或反编译源码。

在仓库根目录执行（可替换路径）：

```powershell
./scripts/dump_api.ps1 -AssemblyPath 'C:\Users\kkk\Desktop\slaythespire\Slay the Spire 2\data_sts2_windows_x86_64\sts2.dll' -DecompiledRoot './decompiled/sts2' -GameVersion 'v0.111.0'
py -3 scripts/dump_ui_scenes.py 'C:\Users\kkk\Desktop\slaythespire\Slay the Spire 2\SlayTheSpire2.pck' --game-version v0.111.0
```

`dump_api.ps1` 支持 `-Dotnet` 指定SDK入口、`-OutputDir` 指定输出；工具在可提交的 `scripts/api-dump/`，使用 SDK 自带 MetadataLoadContext，只读元数据，不运行游戏初始化器，无第三方NuGet包。缺依赖/未识别Dazed时直接失败，不静默提交部分结果。状态牌名字由本地 Cards 文件的 base(...CardType.Status...) 筛出，成员仍由反射读取；更新后若构造写法变了，必须重新核对筛选规则。不要只复制一个孤立sts2.dll而丢掉Godot等依赖。

`dump_ui_scenes.py` 支持 `--output`；读取独立GDPC目录、逐项定位目标tscn，在内存解析并只输出允许的节点/布局元数据。当前验证格式：Godot4.5.1、PCK格式3；遇加密目录或加密目标直接失败。未支持嵌入可执行文件尾部的PCK；未知未来格式须先检查格式规范。本工具没有把整个场景或二进制资源写到仓库。

更新后最好生成到新的临时输出目录，对比并替换旧签名目录，避免已经删除的命名空间旧文件残留；工具只覆写当前文件，不自动递归删除旧文件。同时人工更新 README 的版本/hash/计数、flows/ui 的方法和行号；**重新生成签名不会自动验证流程文字**。场景树没有显式属性的栏位不要补猜默认值。

## 本轮验证及边界

两个生成入口成功重跑；签名类型标题数4353、命名空间文件109，状态牌含Dazed；六个主场景全部在PCK找到，递归树29份；检查大小写变体无覆盖。只提交签名、节点元数据、自己的流程描述与生成脚本，没有提交原始日志/资源/方法体。

本轮没有实测几十秒等待、自定义同步动作、已死塔主战斗动作、SubViewport怪物头像、加载时的新增UI。建议和已确认源码行为在正文区分。未找到/不确定及检索位置已分别注明，不能把候选挂点当作已测试实现。

## 命名空间文件清单

下列链接以实际导出文件为准（大小写变体有后缀）：

- [MegaCrit.Sts2.Core.Assets](signatures/MegaCrit.Sts2.Core.Assets.md)
- [MegaCrit.Sts2.Core.Combat](signatures/MegaCrit.Sts2.Core.Combat.md)
- [MegaCrit.Sts2.Core.Commands](signatures/MegaCrit.Sts2.Core.Commands.md)
- [MegaCrit.Sts2.Core.Entities.Actions](signatures/MegaCrit.Sts2.Core.Entities.Actions.md)
- [MegaCrit.Sts2.Core.Entities.Ancients](signatures/MegaCrit.Sts2.Core.Entities.Ancients.md)
- [MegaCrit.Sts2.Core.Entities.Ascension](signatures/MegaCrit.Sts2.Core.Entities.Ascension.md)
- [MegaCrit.Sts2.Core.Entities.CardRewardAlternatives](signatures/MegaCrit.Sts2.Core.Entities.CardRewardAlternatives.md)
- [MegaCrit.Sts2.Core.Entities.Cards](signatures/MegaCrit.Sts2.Core.Entities.Cards.md)
- [MegaCrit.Sts2.Core.Entities.Characters](signatures/MegaCrit.Sts2.Core.Entities.Characters.md)
- [MegaCrit.Sts2.Core.Entities.Creatures](signatures/MegaCrit.Sts2.Core.Entities.Creatures.md)
- [MegaCrit.Sts2.Core.Entities.Enchantments](signatures/MegaCrit.Sts2.Core.Entities.Enchantments.md)
- [MegaCrit.Sts2.Core.Entities.Encounters](signatures/MegaCrit.Sts2.Core.Entities.Encounters.md)
- [MegaCrit.Sts2.Core.Entities.Gold](signatures/MegaCrit.Sts2.Core.Entities.Gold.md)
- [MegaCrit.Sts2.Core.Entities.Intents](signatures/MegaCrit.Sts2.Core.Entities.Intents.md)
- [MegaCrit.Sts2.Core.Entities.Merchant](signatures/MegaCrit.Sts2.Core.Entities.Merchant.md)
- [MegaCrit.Sts2.Core.Entities.Models](signatures/MegaCrit.Sts2.Core.Entities.Models.md)
- [MegaCrit.Sts2.Core.Entities.Multiplayer](signatures/MegaCrit.Sts2.Core.Entities.Multiplayer.md)
- [MegaCrit.Sts2.Core.Entities.Orbs](signatures/MegaCrit.Sts2.Core.Entities.Orbs.md)
- [MegaCrit.Sts2.Core.Entities.Players](signatures/MegaCrit.Sts2.Core.Entities.Players.md)
- [MegaCrit.Sts2.Core.Entities.Potions](signatures/MegaCrit.Sts2.Core.Entities.Potions.md)
- [MegaCrit.Sts2.Core.Entities.Powers](signatures/MegaCrit.Sts2.Core.Entities.Powers.md)
- [MegaCrit.Sts2.Core.Entities.Relics](signatures/MegaCrit.Sts2.Core.Entities.Relics.md)
- [MegaCrit.Sts2.Core.Entities.RestSite](signatures/MegaCrit.Sts2.Core.Entities.RestSite.md)
- [MegaCrit.Sts2.Core.Entities.Rewards](signatures/MegaCrit.Sts2.Core.Entities.Rewards.md)
- [MegaCrit.Sts2.Core.Entities.Rngs](signatures/MegaCrit.Sts2.Core.Entities.Rngs.md)
- [MegaCrit.Sts2.Core.Entities.Text](signatures/MegaCrit.Sts2.Core.Entities.Text.md)
- [MegaCrit.Sts2.Core.Entities.TreasureRelicPicking](signatures/MegaCrit.Sts2.Core.Entities.TreasureRelicPicking.md)
- [MegaCrit.Sts2.Core.Entities.UI](signatures/MegaCrit.Sts2.Core.Entities.UI.md)
- [MegaCrit.Sts2.Core.GameActions](signatures/MegaCrit.Sts2.Core.GameActions.md)
- [MegaCrit.Sts2.Core.GameActions.Multiplayer](signatures/MegaCrit.Sts2.Core.GameActions.Multiplayer.md)
- [MegaCrit.Sts2.Core.Helpers](signatures/MegaCrit.Sts2.Core.Helpers.md)
- [MegaCrit.Sts2.Core.HoverTips](signatures/MegaCrit.Sts2.Core.HoverTips.md)
- [MegaCrit.Sts2.Core.Localization.DynamicVars](signatures/MegaCrit.Sts2.Core.Localization.DynamicVars.md)
- [MegaCrit.Sts2.Core.Localization.Fonts.FontPathSets](signatures/MegaCrit.Sts2.Core.Localization.Fonts.FontPathSets.md)
- [MegaCrit.Sts2.Core.Localization.Fonts](signatures/MegaCrit.Sts2.Core.Localization.Fonts.md)
- [MegaCrit.Sts2.Core.Localization.Formatters](signatures/MegaCrit.Sts2.Core.Localization.Formatters.md)
- [MegaCrit.Sts2.Core.Localization](signatures/MegaCrit.Sts2.Core.Localization.md)
- [MegaCrit.Sts2.Core.Map](signatures/MegaCrit.Sts2.Core.Map.md)
- [MegaCrit.Sts2.Core.Models.Cards](signatures/MegaCrit.Sts2.Core.Models.Cards.md)
- [MegaCrit.Sts2.Core.Models](signatures/MegaCrit.Sts2.Core.Models.md)
- [MegaCrit.Sts2.Core.Models.Powers](signatures/MegaCrit.Sts2.Core.Models.Powers.md)
- [MegaCrit.Sts2.Core.Multiplayer.Game](signatures/MegaCrit.Sts2.Core.Multiplayer.Game.md)
- [MegaCrit.Sts2.Core.Nodes.Animation](signatures/MegaCrit.Sts2.Core.Nodes.Animation.md)
- [MegaCrit.Sts2.Core.Nodes.Audio](signatures/MegaCrit.Sts2.Core.Nodes.Audio.md)
- [MegaCrit.Sts2.Core.Nodes.Cards.Holders](signatures/MegaCrit.Sts2.Core.Nodes.Cards.Holders.md)
- [MegaCrit.Sts2.Core.Nodes.Cards](signatures/MegaCrit.Sts2.Core.Nodes.Cards.md)
- [MegaCrit.Sts2.Core.Nodes.Combat](signatures/MegaCrit.Sts2.Core.Nodes.Combat.md)
- [MegaCrit.Sts2.Core.Nodes.CommonUi](signatures/MegaCrit.Sts2.Core.Nodes.CommonUi.md)
- [MegaCrit.Sts2.Core.Nodes.Debug](signatures/MegaCrit.Sts2.Core.Nodes.Debug.md)
- [MegaCrit.Sts2.Core.Nodes.Debug.Multiplayer](signatures/MegaCrit.Sts2.Core.Nodes.Debug.Multiplayer.md)
- [MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere](signatures/MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.md)
- [MegaCrit.Sts2.Core.Nodes.Events.Custom](signatures/MegaCrit.Sts2.Core.Nodes.Events.Custom.md)
- [MegaCrit.Sts2.Core.Nodes.Events](signatures/MegaCrit.Sts2.Core.Nodes.Events.md)
- [MegaCrit.Sts2.Core.Nodes.Ftue](signatures/MegaCrit.Sts2.Core.Nodes.Ftue.md)
- [MegaCrit.Sts2.Core.Nodes.GodotExtensions](signatures/MegaCrit.Sts2.Core.Nodes.GodotExtensions.md)
- [MegaCrit.Sts2.Core.Nodes.HoverTips](signatures/MegaCrit.Sts2.Core.Nodes.HoverTips.md)
- [MegaCrit.Sts2.Core.Nodes](signatures/MegaCrit.Sts2.Core.Nodes.md)
- [MegaCrit.Sts2.Core.Nodes.Multiplayer](signatures/MegaCrit.Sts2.Core.Nodes.Multiplayer.md)
- [MegaCrit.Sts2.Core.Nodes.Orbs](signatures/MegaCrit.Sts2.Core.Nodes.Orbs.md)
- [MegaCrit.Sts2.Core.Nodes.Pooling](signatures/MegaCrit.Sts2.Core.Nodes.Pooling.md)
- [MegaCrit.Sts2.Core.Nodes.Potions](signatures/MegaCrit.Sts2.Core.Nodes.Potions.md)
- [MegaCrit.Sts2.Core.Nodes.Reaction](signatures/MegaCrit.Sts2.Core.Nodes.Reaction.md)
- [MegaCrit.Sts2.Core.Nodes.Relics](signatures/MegaCrit.Sts2.Core.Nodes.Relics.md)
- [MegaCrit.Sts2.Core.Nodes.RestSite](signatures/MegaCrit.Sts2.Core.Nodes.RestSite.md)
- [MegaCrit.Sts2.Core.Nodes.Rewards](signatures/MegaCrit.Sts2.Core.Nodes.Rewards.md)
- [MegaCrit.Sts2.Core.Nodes.Rooms](signatures/MegaCrit.Sts2.Core.Nodes.Rooms.md)
- [MegaCrit.Sts2.Core.Nodes.Screens.Bestiary](signatures/MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.md)
- [MegaCrit.Sts2.Core.Nodes.Screens.Capstones](signatures/MegaCrit.Sts2.Core.Nodes.Screens.Capstones.md)
- [MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary](signatures/MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.md)
- [MegaCrit.Sts2.Core.Nodes.Screens.CardSelection](signatures/MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.md)
- [MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect](signatures/MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.md)
- [MegaCrit.Sts2.Core.Nodes.Screens.Credits](signatures/MegaCrit.Sts2.Core.Nodes.Screens.Credits.md)
- [MegaCrit.Sts2.Core.Nodes.Screens.CustomRun](signatures/MegaCrit.Sts2.Core.Nodes.Screens.CustomRun.md)
- [MegaCrit.Sts2.Core.Nodes.Screens.DailyRun](signatures/MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.md)
- [MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen](signatures/MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.md)
- [MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen](signatures/MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.md)
- [MegaCrit.Sts2.Core.Nodes.Screens.InspectScreens](signatures/MegaCrit.Sts2.Core.Nodes.Screens.InspectScreens.md)
- [MegaCrit.Sts2.Core.Nodes.Screens.MainMenu](signatures/MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.md)
- [MegaCrit.Sts2.Core.Nodes.Screens.Map](signatures/MegaCrit.Sts2.Core.Nodes.Screens.Map.md)
- [MegaCrit.Sts2.Core.Nodes.Screens](signatures/MegaCrit.Sts2.Core.Nodes.Screens.md)
- [MegaCrit.Sts2.Core.Nodes.Screens.ModdingScreen](signatures/MegaCrit.Sts2.Core.Nodes.Screens.ModdingScreen.md)
- [MegaCrit.Sts2.Core.Nodes.Screens.Overlays](signatures/MegaCrit.Sts2.Core.Nodes.Screens.Overlays.md)
- [MegaCrit.Sts2.Core.Nodes.Screens.PauseMenu](signatures/MegaCrit.Sts2.Core.Nodes.Screens.PauseMenu.md)
- [MegaCrit.Sts2.Core.Nodes.Screens.PotionLab](signatures/MegaCrit.Sts2.Core.Nodes.Screens.PotionLab.md)
- [MegaCrit.Sts2.Core.Nodes.Screens.ProfileScreen](signatures/MegaCrit.Sts2.Core.Nodes.Screens.ProfileScreen.md)
- [MegaCrit.Sts2.Core.Nodes.Screens.RelicCollection](signatures/MegaCrit.Sts2.Core.Nodes.Screens.RelicCollection.md)
- [MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen](signatures/MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.md)
- [MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext](signatures/MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.md)
- [MegaCrit.Sts2.Core.Nodes.Screens.Settings](signatures/MegaCrit.Sts2.Core.Nodes.Screens.Settings.md)
- [MegaCrit.Sts2.Core.Nodes.Screens.Shops](signatures/MegaCrit.Sts2.Core.Nodes.Screens.Shops.md)
- [MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen](signatures/MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.md)
- [MegaCrit.Sts2.Core.Nodes.Screens.Timeline](signatures/MegaCrit.Sts2.Core.Nodes.Screens.Timeline.md)
- [MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens](signatures/MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.md)
- [MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic](signatures/MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.md)
- [MegaCrit.sts2.Core.Nodes.TopBar.case-variant](signatures/MegaCrit.sts2.Core.Nodes.TopBar.case-variant.md)
- [MegaCrit.Sts2.Core.Nodes.TopBar](signatures/MegaCrit.Sts2.Core.Nodes.TopBar.md)
- [MegaCrit.Sts2.Core.Nodes.TreasureRooms](signatures/MegaCrit.Sts2.Core.Nodes.TreasureRooms.md)
- [MegaCrit.Sts2.Core.Nodes.Vfx.Backgrounds](signatures/MegaCrit.Sts2.Core.Nodes.Vfx.Backgrounds.md)
- [MegaCrit.Sts2.Core.Nodes.Vfx.Cards](signatures/MegaCrit.Sts2.Core.Nodes.Vfx.Cards.md)
- [MegaCrit.Sts2.Core.Nodes.Vfx.Events](signatures/MegaCrit.Sts2.Core.Nodes.Vfx.Events.md)
- [MegaCrit.Sts2.Core.Nodes.Vfx.Examples](signatures/MegaCrit.Sts2.Core.Nodes.Vfx.Examples.md)
- [MegaCrit.Sts2.Core.Nodes.Vfx.Forms](signatures/MegaCrit.Sts2.Core.Nodes.Vfx.Forms.md)
- [MegaCrit.Sts2.Core.Nodes.Vfx](signatures/MegaCrit.Sts2.Core.Nodes.Vfx.md)
- [MegaCrit.Sts2.Core.Nodes.Vfx.Ui](signatures/MegaCrit.Sts2.Core.Nodes.Vfx.Ui.md)
- [MegaCrit.Sts2.Core.Nodes.Vfx.Utilities](signatures/MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.md)
- [MegaCrit.Sts2.Core.Random](signatures/MegaCrit.Sts2.Core.Random.md)
- [MegaCrit.Sts2.Core.Rooms](signatures/MegaCrit.Sts2.Core.Rooms.md)
- [MegaCrit.Sts2.Core.Runs](signatures/MegaCrit.Sts2.Core.Runs.md)
- [MegaCrit.Sts2.Core.ValueProps](signatures/MegaCrit.Sts2.Core.ValueProps.md)
