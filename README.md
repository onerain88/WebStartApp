# WebStartApp

## WinLib

Windows 平台的库解决方案，目前只包括一个 RegistryLib

RegistryLib 提供了写入*当前用户*注册表的功能（不需要权限），并且可以通过当前进程获取应用的 exe 路径。

## UnityDemo

Unity 工程，这里需要注意的是只支持*单实例*的应用，即不允许启动相同应用的多个进程。
需要勾选 Project Settings -> Resolution and Presentation -> Force Single Instance。 

## web

React 项目，点击 Start App 后会以 wsapp: 唤醒（打开）应用。