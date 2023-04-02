# HyperWebUI 官方文档

该 HyperWebUI 目前处于为开发完成的状态，在功能上会有欠缺，请见谅。

## 工作区配置
在一切开始之前，你需要配置 HyperWebUI 的工作区，请在我们的 GitHub 储存库中下载 **Style.css** 并放置到你的工作区，请在你的网站 html 文件的 `<head> ... </head>` 之间使用 `<link>` 元素区链接它，以下是代码示例：

````
<!--该代码默认 UI 文件位于 html 文件的同级目录并且保持原来的文件名文件名 "Style.css"-->
<html>
    <head>
        <title> <!--请在此处填写网页标题--> </title>
        <link rel="stylesheet" href="./Style.css">
    </head>
    <body>

    </body>
</html>
````

##  主题与主题预设

### 主题
在 HyperWebUI 中，主题是最重要的一项设置。如果不设置它， HyperWebUI 将不会产生任何效果。
<br>
所谓的 "主题" 实际上是一堆 css 属性与全局变量。这些属性和全局变量定义了你网站的样式。目前已有的属性和全局变量如下：

- 属性
    - `background`  网站背景样式
    - `color`  普通文字的颜色
- 全局变量
    - `--Radius`  块元素的圆角大小
    - `--Border`  块元素的边框样式
    - `--ModuleFontColor`  块元素内联的字体颜色
    - `--ModuleBackground`  块元素的背景样式
    - `--ModuleBackground-hover`  鼠标悬停在可交互元素上时，可交互元素的背景样式
    - `--ModuleBackground-active`  鼠标点击可交互元素时，可交互元素的背景样式

如果你懂 css ，可以通过编辑 `<body>` 的 style 属性值来定义以上的属性值从而达到自定义样式的效果。如果你不懂 css ，或者不愿意自定义样式，可以使用 **主题预设** 来 "解放双手" 。

### 主题预设
在目前的 HyperWebUI 版本中， 提供了两种主题预设。分别为：

- style_light
- style_technology

请在 `<body>` 的 class 属性的值设置为你所需的主题预设的名称。
