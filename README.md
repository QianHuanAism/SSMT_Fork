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

# 代码提交问题

部分用户需求会导致架构大幅度变更，此情况请单独开一个Fork分支去维护

例如部分用户在旧的集合分支架构中维护了1200个Mod导致无法迁移到新的蓝图架构的情况，

例如部分用户需要把启动器功能继续完善，导致添加大量与3Dmigoto不相关的获取游戏咨询的情况

主仓库用于更新最新特性和保证核心功能稳定，需要加奇怪的东西请考虑清楚，

如果涉及巨大的架构变更请先在自己的Fork分支中进行发布和维护测试

