# Vortex Simple | A C# simple cheat loader
This loader is for beginners that do not have the enough knowledge to code.

# Discord
[Vortex's Discord server](https://discord.gg/9ntPfFC)

# Note
- This loader is not safe to use for any P2C your stuff will get leaked if you do.
- This loader is in beta state report all bugs to me.

## Screenshots

<p align="center">
 <img src="https://i.gyazo.com/8e74ddbf4ae4bde1c9fae5052baaa263.png">
</p>

<p align="center">
 <img src="https://i.gyazo.com/8c2cda7b2a1a28a89718d83dc32e6f9d.png">
</p>

<p align="center">
 <img src="https://i.gyazo.com/7e678d045ea146f1bc27f52275ba93b4.png">
</p>

## SQL Setup For HWID

1. Enter your PHPMyAdmin (Or whatever tool you use for SQL management) and navigate to your mybb_users.

2. Click on the "Structure" tab at the top of PHPMyAdmin.

3. Now add a new column named `hwid` that is a `varchar` with a max limit of `255`.

## Web Files Setup

1. Upload the check.php.

2. Change the login information to yours in lines 2-3 and that's all!

## Loader Form Files

Change all of the links in settings.cs to match your website.

## FAQ

**Q: I can't open the loader.**

A: Make sure all metro dll files are in the same location as the exe! or install Costura Fody
___
**Q: CSGO crashes after injection or wont inject?**

A: Make sure dll's are not protected by vmprotect! VMPROTECT IS USELESS! Vmprotect does change the signature when putting it in sigbench but it is just getting sig of dll but when you inject vmprotect doesnt protect anything but instead gets removed so your original dll sig (before you vmprotected it) is what is being scanned! (Note: This is only confirmed for old version of vmprotect v2.x.x)
___
**Q: Getting a error such as this? https://i.imgur.com/YOVCxdr.png**

A: This is most commonly due to error connecting to server and has NOTHING to do with your incorrect login. This issue is most commonly found when using blazing fast or some kind of anti ddos solution (Tested that it does work with cloudflare).

___
**Q: Login incorrect!**

A: Read Sql login is incorrect below to fix.
___
**Q: Sql login is incorrect?**

A: This is one of those common issues mainly for people using cpanel which auto generates your password.
In order to fix it, simply make sure that your password does NOT contrain any symbols!
___
**Q: Is this a cheat for Counter Strike?**

A: No, this is a tool for being able to sell cheats without giving your .dll file to your users
___
**Q: Is this only for Counter Strike?**

A: No! Although it is targeted towards CS:GO it can literally be used for any game that takes dll based cheats
___
**Q: Is this detected by VAC?**

A: At the time of writing no. But make sure you change the signature of the loader to some extent.
___
**Q: If I am using this, do I have to give you credit?**

A: [The license for the project](https://github.com/Kanepu/Vortex-loader/blob/master/LICENSE)
___
**Q: Can I use this for a massive P2C?**

A: Yes, but your stuff WILL get leaked eventually. I'd recommend using this for a private cheat for your friends with a max of like 30 members.
___
**Q: Do I need a website?**

A: Yes and no. You can make it local only by using a tool such as XAMPP but if you want it to be available for others to use you should get a website. Port forwarding would work too but I advise against it.
___
**Q: How do I make paid usergroups on MyBB?**

A: https://community.mybb.com/thread-123597.html ALSO if you wanna be a real meme and need invite codes: https://community.mybb.com/thread-113141.html

## Credits

[HazzardEdit](https://www.youtube.com/channel/UCG0LukbgMa6vJkA_JJ4Jepg) for the [HWID creation and encryption code.](https://www.youtube.com/watch?v=M1-pAqPqJcw)

[weakspider](https://www.unknowncheats.me/forum/members/172964.html) for the [Injection method](https://www.unknowncheats.me/forum/c-/213037-x86-manual-map-injection.html)

[Roshly](https://github.com/Roshly): Used his php script and copied some stuff from his readme.mb.
