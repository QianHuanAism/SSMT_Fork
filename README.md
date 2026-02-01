# SSMT

基于3Dmigoto的模型提取与Mod制作工具箱

# 使用文档

https://starbobis.github.io/SSMT-Documents/

# Build

打包使用Velopack，打包代码参考如下：

```
vpk pack --packId SSMT3  --packDir .\net8.0-windows10.0.19041.0\ --mainExe SSMT3.exe --packVersion 3.5.8
```

一般打包发布只需要修改后面的版本号为对应版本即可

# 社区共建

SSMT本体、TheHerta3插件、SSMT-Documents文档均已基于GPL3.0 LICENSE 开源，欢迎大家参与共建

# 提交反馈注意事项

请详细描述你的问题，并尽可能附带FrameAnalysis文件以及提取用的DrawIB，以便于开发者能够复现并帮助你高效解决问题。

# 代码提交注意事项

部分用户需求会导致架构大幅度变更，此情况请单独开一个Fork分支去维护

例如部分用户在旧的集合分支架构中维护了1200个Mod导致无法迁移到新的蓝图架构的情况，

例如部分用户需要把启动器功能继续完善，导致添加大量与3Dmigoto不相关的获取游戏咨询的情况

主仓库用于更新最新特性和保证核心功能稳定，需要加奇怪的东西请考虑清楚，

如果涉及巨大的架构变更请先在自己的Fork分支中进行发布和维护测试

# 第三方工具使用清单

部分代码，例如注入器、DLL劫持等功能可能会被部分杀软误报为病毒木马，如果不信任已经发布的Release中的东西，请自行编译源码使用

- 3Dmigoto的d3d11.dll来源于SpectrumQT的 https://github.com/SpectrumQT/XXMI-Libs-Package 仓库，并在最近为了支持终末地基于彭嘉旭的 https://github.com/pengjiaxusz/3Dmigoto 仓库进行了修改
- Resource中的d3dcompiler_46.dll来源于原始3Dmigto仓库编译产生
- Resource中的d3dcompiler_47.dll来源于https://github.com/SpectrumQT/XXMI-Libs-Package 中的复制Windows SDK逻辑
- ffmpeg.exe来源于ffmpeg的GitHub 的Release
- texconv.exe来源于微软发布的仓库Release
- Run.exe来源于3Dmigoto-Injector-V2项目编译结果，且由于注入代码，编译后必定导致误报
- WinDivert.dll和WinDivert64.sys来源于WinDivert的GitHub Release
- upx.exe来源于upx的GitHub release
- 此外3Dmigoto的d3d11.dll需要执行函数hook和记录按键，部分杀软会误报为木马。
- 修改游戏本身也带有一定的侵权风险。

# 基础信任问题

若你对本工具无法建立基本的信任，请自行编译或下载所有内容来使用。

由于代码已开源，若信任本工具，请认准Release中发布的版本，防止下载到其他人二次编译的包含恶意代码的版本。

本工具不接受也不会回应任何没有完整可复现证据链的恶意抹黑，例如造谣此工具为包含木马病毒的恶意软件却无法提供完整可复现证据链的行为将被忽略。

本工具与AGMG社区的XXMI系列工具功能高度重合，存在直接性竞争和可能的利益冲突，Mod逆向功能也与AGMG社区规则相悖，因此任何来自AGMG成员的恶意抹黑行为都会被忽略。

本工具诞生之初仅用于自己学习测试使用，并未想过分享给其他人使用，但是有相同需求的人很多，因此出于基本的善意进行分享。

本工具除SSMT的附带插件外，全套内容基于GPL3.0协议开源，仅用于学习交流代码使用，请勿用于任何商业用途。

# 注意

本工具仅用于学习交流代码使用，使用此工具需自行承担所有可能的责任与风险，包括但不限于游戏账号被封禁、侵权法律责任等。
