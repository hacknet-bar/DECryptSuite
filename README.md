<h1>Hacknet DEC文件加密和解密工具</h1>
<p size="16">
  
Coel注：分割线下的内容是作者添加在README.MD中的内容，由我和百度翻译（滑稽）翻译。其中【】中的内容是本人增加的，并非MD文件自带。
  
————————————————华丽的分割线—————————————————

免责声明！ <br><br>

这种“加密”和“解密”工具是基于游戏中的解密工具的，它不是存储重要文件的安全方法。<br>
它是为好玩而制作的，只能用于娱乐，而不是合法的加密。<br>
它将被保存在一个类似于BASH的状态，意思是没有GUI或任何东西。【D3f4ult：GUI在另一个Branch，只是Coel懒得翻译而已，反正正文内容差不多。】<br>

免责声明结束。<br><br>

制作者：<br>
Kleberstoff<br>
一个漫不经心的家伙<br>
Matt（Hacknet的主要制作者）；这种“加密”和“解密”的方法来自他。<br><br>

<h2>一些可能会遇到的问题</h2><br><br>

<strong>我可以修改源代码吗？</strong><br>
Yes.<br><br>

<strong>我可以用在XYZ上面吗？</strong><br>
Yes.<br><br>

<strong>我应该使用它来存储重要文件吗【比如A片的链接，滑稽】？</strong><br>
Ye……等等，千万不要。（因为这玩意完全不安全）<br><br>

<strong>我该怎么用呢？</strong><br>
它是CLI（命令行接口【即为Command Line Interface】）——它通过Windows CMD工作，在与程序集相同的文件夹中打开CMD，<br>
（Shift+右键，可以做一个很好的快捷方式），然后用它的名称和参数调用它。<br><br>

输入DECryptSuite.exe –h可以查看帮助。<br>
<strong>或者</strong><br>
使用GUI，请参阅GUI分支。<br>

<h3>向作者反馈？</h3><br>
与我联系：<br><br>

Keybase: https://keybase.io/kleberstoff<br>
Discord: Kleberstoff#5914<br>
Email: admin@kleberstoff.xyz<br>
</p>

————————————————华丽的分割线—————————————————

以下是我个人使用的方法，各位在使用时可以参考，如果在照着我的方法的情况下出现任何问题，本人懒得负责233333

一开始需要进行初始化。

首先找到工具根目录\ConsoleApp1\bin\Debug\files文件夹，将你想要加密的文件打包成input.zip（千万不要动里面的ConsoleApp1.zip文件！！！）如下图：

![pic1](https://raw.githubusercontent.com/hacknet-bar/DECryptSuite/master/1.png)

用命令提示符打开工具目录，建议大家右键将地址复制成文本，然后输入cd 后Ctrl+V粘贴地址，可以省下很多精力。

输入DECryptSuite.exe（和Hacknet一样可以用Tab补全），开始初始化。

![pic2](https://raw.githubusercontent.com/hacknet-bar/DECryptSuite/master/2.png)

翻译：

首次运行检测…

欢迎使用DECrypt Suite v0.0加密解密工具。

我们现在问你一些问题，准备好后按Enter。

（Enter后）

你的签名应该是什么？将使用该文件作为每个文件的签名。

注：尽量避免特殊字符，并尝试使用一个关于你的缩略语，这是众所周知的。

然后输入一个签名，对于Hacknet吧务组来说，签名将统一为Hacknet Bar Admin Team，除了吧务组以外的人，请勿使用该签名！

![pic3](https://raw.githubusercontent.com/hacknet-bar/DECryptSuite/master/3.png)

签名为Hacknet Bar Admin Team，是否确认？（y/n）

再次确定签名无误后输入y，按下Enter继续，3秒后弹出窗口，进行加密

![pic4](https://raw.githubusercontent.com/hacknet-bar/DECryptSuite/master/4.png)

记住这不是真正的安全加密！

使用会有风险！这是对你的警告

（绿字是各种关于dec文件内容。【D3f4ult：github里有绿字吗】）

按Enter退出。

按下Enter后会自动退出，这个时候就可以在files里面看到文件了。

![pic5](https://raw.githubusercontent.com/hacknet-bar/DECryptSuite/master/5.png)

之后就不需要这么麻烦了，直接双击工具即可加密。别忘了把input.zip放在files里面。<br><br>
-h可以查看帮助，在这里就不翻译了。
