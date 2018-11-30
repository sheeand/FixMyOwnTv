using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FixMyOwnTv.Models;
using System.Globalization;

namespace FixMyOwnTv.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Default(string article, string title)
        {
            ViewBag.Host = Request.Headers["Host"];
            FixMyOwnTv.Models.PageInfo page = new FixMyOwnTv.Models.PageInfo();

            if (String.IsNullOrEmpty(article))
            {
                page = GetPageObject("default", "");
                ViewBag.Page = "default";
                return View(page);
            }
            else
            {
                if (article.ToLower().Contains("fixmyowntv") && !String.IsNullOrEmpty(title))
                {
                    string y = HttpContext.Request.Url.Authority.ToString();
                    return Redirect(String.Concat("http://", y, "/", title));
                }
                else
                {
                    page = GetPageObject(article, title);
                    ViewBag.Page = String.Concat(article, " ", title);
                    return View(page);
                }
            }
        }

        private PageInfo GetPageObject(string article, string title)
        {
            PageInfo page = new PageInfo();
            page.Article = article;
            article = article.ToLower();
            if (!String.IsNullOrEmpty(title))
            {
                title = title.ToLower();
            }
            ViewBag.defaultMenuPick = "Home page - Fix Your Own TV!";
            ViewBag.antennasMenuPick = "Get the Best Indoor Antenna Reception";
            ViewBag.boardsMenuPick = "Replacing Printed Circuit Boards";
            ViewBag.booksMenuPick = "Books";
            ViewBag.burninMenuPick = "Image Retention - Burn-In";
            ViewBag.buzzingMenuPick = "Buzzing Plasma TVs";
            ViewBag.colorsMenuPick = "How to Fix the Color";
            ViewBag.couldMenuPick = "Could I Really Fix My Own TV?";
            ViewBag.cyclingMenuPick = "Clicking / No Power";
            ViewBag.dangerMenuPick = "Danger - High Voltage!";
            ViewBag.davesMenuPick = "For Technicians Only";
            ViewBag.deadMenuPick = "Dead TV Set";
            ViewBag.dlpMenuPick = "DLP - LCD Projection TVs";
            ViewBag.enginesMenuPick = "Replacing Light Engines (Optical Blocks)";
            ViewBag.equipmentMenuPick = "Do I Need Test Equipment?";
            ViewBag.flatsMenuPick = "Flat-Screen TVs";
            ViewBag.faqsMenuPick = "";
            ViewBag.gettoMenuPick = "How Do I Get to the Printed Circuit Boards?";
            ViewBag.hookedupMenuPick = "How Is My TV Hooked Up?";
            ViewBag.iaudMenuPick = "Intermittent Audio";
            ViewBag.intsignalMenuPick = "Intermittent Signals";
            ViewBag.channelsMenuPick = "Channels Changing";
            ViewBag.inputsMenuPick = "Inputs Changing";
            ViewBag.volumecontrolMenuPick = "Uncontrollable Volume";
            ViewBag.lampfailureMenuPick = "Lamp Failure";
            ViewBag.lampsMenuPick = "Replacing Lamps";
            ViewBag.lcdplasmaMenuPick = "Is my TV an LCD, LED or Plasma?";
            ViewBag.lcdMenuPick = "LCD / LED Screen Replacement";
            ViewBag.manualsMenuPick = "TV Service Manuals";
            ViewBag.mythrealityMenuPick = "Plasma TVs - Myths vs. Realities?";
            ViewBag.networkMenuPick = "WiFi Connectivity";
            ViewBag.orderpartsMenuPick = "How to Order TV Parts";
            ViewBag.partsMenuPick = "TV Replacement Parts";
            ViewBag.plasmaMenuPick = "Plasma Screen Replacement";
            ViewBag.rattlesMenuPick = "Speaker Rattle, Buzz";
            ViewBag.shatteredMenuPick = "Cracked TV Screen";
            ViewBag.solderMenuPick = "Replacing Soldered Parts";
            ViewBag.stripesandbarsMenuPick = "Stripes, Lines or Bars";
            ViewBag.updateMenuPick = "Software Updates";
            ViewBag.wheelsMenuPick = "Replacing DLP Color Wheels";
            ViewBag.volumeMenuPick = "No Sound";
            ViewBag.worthfixingMenuPick = "Is My TV Worth Fixing?";
            ViewBag.zoomMenuPick = "Picture Doesn't Fit Screen";

            string s = Session.SessionID;
            string sPostback = String.Format("{0}PostbackCount", s);
            if (Object.Equals(Session[sPostback], null))
            {
                Session[sPostback] = false;
                ViewBag.ExposeCustomSearch = "none;";
            }
            else
            {
                Session[sPostback] = true;
                ViewBag.ExposeCustomSearch = "inline;";
            }

            if ((String.IsNullOrEmpty(article)) || (article == "default"))
            {
                ViewBag.CanonicalLink = "http://www.fixmyowntv.com";
            }
            else
            {
                ViewBag.CanonicalLink = String.Format("http://www.fixmyowntv.com/{0}", article);
            }

            switch (article)
            {
                default:
                    page.Title = "Fix My Own TV - Learn how - get what you need";
                    page.Description = "Repair your own TV - Learn, get what you need, do it yourself - Make informed decisions about repairing your television yourself";
                    page.Keywords = "samsung led tv problems,vizio tv problems,flat screen tv problems,sony tv problems,tv repair problems,panasonic tv problems,vizio tv repair,samsung tv repair,flat screen tv repair,sony tv repair,tv repair parts,panasonic tv repair,led tv problems,lcd tv problems,plasma tv problems,how to troubleshoot tv problem,how to diagnose tv problem,find what's wrong with tv,fix problem with tv,how to fix a tv problem,tv repair self help,fix a flat screen tv,fix a plasma tv,fix an lcd tv,fix my own tv,fix my tv,fix plasma tv,fix tv,how do i fix my tv,how to fix a plasma tv,how to fix a tv,how to fix an lcd tv,how to fix lcd tv,how to fix my tv,how to fix tv,how to repair a flat screen tv,how to repair a tv,how to repair lcd tv,how to repair tv,LCD TV repair,lcd tv repair cost,LCD TV troubleshooting,LED TV repair,LED TV troubleshooting,need help fixing my tv,need help fixing tv,plasma TV troubleshooting,tv repair myself";
                    page.og_description = "Find out if you could fix your own TV. You might discover that it's an easy fix! And by doing it yourself you would save yourself some money.";
                    break;
                case "aboutus":
                    page.Title = "About the author";
                    page.Description = "How a laid-off Consumer Electronics engineer found a successful career as a TV service technician and then became a successful we site developer.";
                    page.Keywords = "";
                    page.og_description = "How a laid-off Consumer Electronics engineer found a successful career as a TV service technician and then became a successful we site developer.";
                    break;
                case "antennas":
                    page.Title = "Get the Best Indoor Antenna Reception";
                    page.Description = "Learn how to make an indoor TV antenna work the best. Find out what aspects could be causing poor performance and what you can do about it.";
                    page.Keywords = "make tv antenna work,make tv aerial work,how to get more channels with an indoor antenna,how to make a tv antenna work,how to improve tv antenna performance,how to improve tv antenna reception,improve tv reception,poor tv reception,weak tv signals,how to improve tv signal strength,how to install a tv antenna,tv antenna installation,where to put a tv antenna,best place for an indoor antenna,best place for an indoor aerial,best place for an indoor tv antenna,best place for an indoor tv aerial,best location for an indoor tv antenna,best location for an indoor tv aerial,best location for an indoor antenna,best location for an indoor aerial,improve tv signal strength,install a tv antenna,where to place a tv aerial,where to place a tv antenna,where to place an aerial,where to put a tv aerial,where to put a tv antenna,tv antenna position,tv antenna placement,tv aerial position,tv aerial placement,where to put an aerial,antenna position,antenna placement,aerial position,no tv reception,antenna direction,antenna signal,antenna channels,hdtv reception,hdtv antenna direction,tv antenna setup,tv antenna aiming,poor tv reception,hdtv antenna signal,tv signal,antenna signal strength,antenna reception,antenna tv signal,tv aerial direction,tv tower locations,tv antenna pointing,make tv antenna,tv reception problems,ota tv,digital tv signal strength,my antenna,tv aerial signal,digital tv signal,tv antenna direction,hd over the air,indoor tv,antenna,tv antenna signal strength,digital antenna signal,digital tv reception,hd tv reception,digital antenna range,aerial tv,hdtv antenna reception,tv reception in my area,improve tv signal,tv antenna range,tv reception,improve tv reception,antena tv digital indoor,signal antenna,antena tv indoor,ota tv antenna,digital tv antenna reception,best antenna reception,hd antenna range,tv antenna coverage,antenna local tv channels,antenna installation,antena digital indoor,over the air tv reception,antenna dtv,boost antenna signal,antenna tv reception,digital antenna reception";
                    page.og_description = "First, it's good to have an idea of what the distance and direction is to the TV transmitters. Knowing how far the transmitters are, you can make a few basic decisions...";
                    break;
                case "boards":
                    page.Title = "Replacing Printed Circuit Boards";
                    page.Description = "How to solder - Shows basic soldering technique as it applies to replacing electrolytic capacitors on a printed circuit board in a television";
                    page.Keywords = "how do I replace a plasma panel,how to replace a main board in a lg tv,how to replace a main board in a samsung tv,how to replace a main board in a sharp tv,how to replace a main board in a sony tv,how to replace a main board in a tv,how to replace a mother board in a lg tv,how to replace a mother board in a samsung tv,how to replace a mother board in a sharp tv,how to replace a mother board in a sony tv,how to replace a mother board in a tv,how to replace board in a lg tv,how to replace board in a samsung tv,how to replace board in a sharp tv,how to replace board in a sony tv,how to replace board in a tv,how to replace board in a tv,how to replace board main board in a tv,how to replace board main board in a tv,how to replace board mother board in a tv,how to replace board mother board in a tv,how to replace circuit board in a samsung tv,how to replace circuit board in a sharp tv,how to replace circuit board in a sony tv,how to replace circuit board in a tv,how to replace circuit board in an lg tv,how to replace circuit board in lg tv,how to replace lg tv board,how to replace lg tv circuit board,how to replace lg tv printed circuit board,how to replace main board in a lg tv,how to replace main board in a samsung tv,how to replace main board in a sharp tv,how to replace main board in a sony tv,how to replace main board in a tv,how to replace mother board in a lg tv,how to replace mother board in a samsung tv,how to replace mother board in a sharp tv,how to replace mother board in a sony tv,how to replace mother board in a tv,how to replace mother board in tvs,how to replace plasma panels,how to replace power board in a tv,how to replace power board in tvs,how to replace power supply board in a tv,how to replace power supply board in tvs,how to replace printed circuit board in a samsung tv,how to replace printed circuit board in a sharp tv,how to replace printed circuit board in a sony tv,how to replace printed circuit board in a tv,how to replace printed circuit board in an lg tv,how to replace printed circuit board in lg tv,how to replace samsung tv board,how to replace samsung tv board,how to replace samsung tv circuit board,how to replace samsung tv printed circuit board,how to replace sharp tv board,how to replace sharp tv circuit board,how to replace sharp tv printed circuit board,how to replace sony tv board,how to replace tv board,how to replace tv circuit board,how to replace tv main board,how to replace tv mother board,how to replace tv power board,how to replace tv power supplies,how to replace tv printed circuit board,replace plasma panel,replace a main board,replace a main board in a samsung tv,replace a main board in a sharp tv,replace a main board in a sony tv,replace a main board in a tv,replace a mother board in a lg tv,replace a mother board in a sharp tv,replace a mother board in a sony tv,replace board in a lg tv,replace board in a samsung tv,replace board in a sharp tv,replace board in a sony tv,replace board in a tv,replace board main board in a tv,replace board main board in a tv,replace board mother board in a tv,replace board mother board in a tv,replace circuit board in a samsung tv,replace circuit board in a sharp tv,replace circuit board in a sony tv,replace circuit board in a tv,replace circuit board in an lg tv,replace circuit board in lg tv,replace lg tv board,replace lg tv circuit board,replace lg tv printed circuit board,replace main board in a lg tv,replace main board in a samsung tv,replace main board in a sharp tv,replace main board in a sony tv,replace main board in a tv,replace mother board in a lg tv,replace mother board in a samsung tv,replace mother board in a sharp tv,replace mother board in a sony tv,replace mother board in a tv,replace mother board in lg tvs,replace plasma panels,replace power board in a tv,replace power board in tvs,replace power supply board in a tv,replace power supply board in tvs,replace printed circuit board in a samsung tv,replace printed circuit board in a sharp tv,replace printed circuit board in a sony tv,replace printed circuit board in a tv,replace printed circuit board in an lg tv,replace printed circuit board in lg tv,replace samsung tv board,replace samsung tv circuit board,replace samsung tv printed circuit board,replace sharp tv board,replace sharp tv circuit board,replace sharp tv printed circuit board,replace sony tv board,replace tv board,replace tv circuit board,replace tv main board,replace tv mother board,replace tv power board,replace tv power supplies,replace tv printed circuit board,tv printed circuit board";
                    page.og_description = "Printed circuit boards in TVs are not that difficult to replace.  It’s just a matter of disconnecting the cable connectors from the board, unscrewing it, replacing it with the new one, and then putting everything back together in the reverse order. There may be additional things to do before and/or after you replace it...";
                    break;
                case "books":
                    page.Title = "Books About TV";
                    page.Description = "Books for the handyman, including television primers and textbooks about how to start a business in TV repair";
                    page.Keywords = "TV repair books,TV repair business,TV theory,basic TV,TV engineering,television repair books,television repair business,television theory,basic television,television engineering";
                    page.og_description = "";
                    break;
                case "burnin":
                    page.Title = "Image Retention and Burn-In";
                    page.Description = "What's the difference between picture burn-in and image retention? Why do they occur? Do they mean there is something wrong with my television?";
                    page.Keywords = "burn in,plasma screen burn in,plasma burn,burn in plasma,burn in on plasma,burn plasma,hdtv burn in,lcd burn in,lcd burn,burn in lcd,plasma burns,plasma burning,burning plasma,lcd screen burn,lcd screen burn in,plasma burn in fix,fix plasma burn in,how to fix plasma burn in,fix burn in plasma,how to fix burn in on plasma,plasma burn fix,burn in plasma fix,plasma burn in repair,fix screen burn,screen burn fix,lcd burn in fix,fix lcd burn,plasma image burn,image burn in plasma,image burn plasma,plasma tv burning,plasma burn out,lg plasma burn in,remove plasma burn in,fixing plasma burn in,how to prevent plasma burn in,plasma burn in time,burned image on plasma,do plasmas still burn in";
                    page.og_description = "Image retention and burn-in are two different things.  This article explains the difference.";
                    break;
                case "buzzing":
                    page.Title = "Buzzing Plasma TVs";
                    page.Description = "Do plasma TVs buzz? How loud is too loud? Is there a solution? This article describes what to expect from a plasma TV in terms of noise";
                    page.Keywords = "my tv is buzzing,why is my tv buzzing,vizio tv buzzing,plasma tv buzzing,buzzing tv,tv is buzzing,tv speakers buzzing,buzzing noise from tv,tv buzzing noise,samsung tv buzzing,buzzing sound from tv,tv buzzing sound";
                    page.og_description = "All plasma TVs produce a very faint buzzing noise. But maybe it is so abnormally loud, you can hear it across the room.  If the picture looks fine otherwise, then you are dealing with a noisy circuit board inside the TV...";
                    break;
                case "colors":
                    page.Title = "How to Fix the Color in your TV Picture";
                    page.Description = "If the colors in your TV picture don't look right and you're not sure what to do, find out how to fix the problem here";
                    page.Keywords = "tv colors wrong,tv picture has wrong colors,how to set tv color,tv picture help,tv color help,tv color adjustment help,tv picture adjustment,proper tv picture settings,proper tv color setting,proper tv color adjustment,how to set the color temperature on a tv,setting the colors on tv,how to adjust the color temperature on a tv,adjust tv colors,setting tv colors,fix the tv picture,tv picture too green,tv picture too blue,tv picture too orange,tv picture has no color,tv picture too purple,tv picture too yellow,fix tv color,color temperature setting,color temperature adjustment,color temp setting,color temp adjustment,tv picture brightness,tv picture contrast,tv picture tint,tv picture saturation,tv picture controls,tv color controls";
                    page.og_description = "If your TV color problem is always there no matter what channel you are watching, then it could either be 1.) a faulty printed circuit board in your television, 2.) a faulty or improper cable connection, or 3.) an improper picture menu setting on your TV...";
                    break;
                case "could":
                    page.Title = "Could I Really Fix My Own TV?";
                    page.Description = "How can you tell if it would be too hard for you to fix your own TV. Gauge the severity of the problem before attempting to repair your own TV";
                    page.Keywords = "broken tv,tv service,fix plasma,flat screen tv repair,how to fix plasma tv,how to repair a plasma tv,how to repair plasma tv,lcd tv repair,mitsubishi tv repair,plasma repair,plasma television repair,plasma tv repair,plasma tv repairs,repair plasma tv,samsung tv repair,service manuals,television repair,tv repair,problems with plasma,plasma problems";
                    page.og_description = "If a person are willing to try, the question is do they have the ability? This will depend on: 1) the difficulty of the repair, 2) the competence of the person doing the repair, 3) whether the person has the proper tools and the time to do it, and 4) whether the person is instructed on how to do it...";
                    break;
                case "cycling":
                    page.Title = "Problem: TV Keeps Clicking / Won't Power-Up";
                    page.Description = "Does the TV seem like it's trying to start, but won't? Troubleshoot and repair a common TV power supply problem involving faulty electrolytic capacitors";
                    page.Keywords = "samsung tv turns off by itself,samsung tv turning off by itself,samsung tv turns on and off by itself,samsung tv turning on and off by itself,samsung tv shuts off by itself,samsung tv turns off and on by itself,my samsung tv turns off by itself,samsung tv turning itself off,my tv turns on and off by itself,samsung tv turns itself off,samsung lcd tv turns on and off by itself,samsung tv switches itself off,samsung tv turning on and off,samsung tv turning off and on,samsung tv turning off,samsung tv turn on and off,samsung tv turns off,samsung tv turns off and on,samsung tv problems turning on and off,samsung tv keeps turning off and on,tv turns off,samsung tv turns off on its own";
                    page.og_description = "If the TV acts as if it’s coming on, but instead keeps clicking over and over again until finally it stops cycling and the TV comes on with picture and sound, then the problem has to be one or more defective capacitors...";
                    break;
                case "danger":
                    page.Title = "Danger - High Voltage!";
                    page.Description = "How dangerous is it to fix your own TV? Heighten your awareness of the hazards and safety concerns of TV repair";
                    page.Keywords = "plasma TV,LCD TV,repair yourself,repair myself,confidence,safety,high voltage";
                    page.og_description = "All domestically purchased TVs are guaranteed to be safe because they have been tested and approved by Underwriters Laboratories (UL). But as soon as you remove the back cover to fix your, all bets are off. It's important for you to be aware of this risk when servicing your television...";
                    break;
                case "daves":
                    page.Title = "For Technicians Only";
                    page.Description = "";
                    page.Keywords = "";
                    page.og_description = "";
                    break;
                case "dead":
                    page.Title = "Problem: Dead TV Set";
                    page.Description = "Your TV acts dead, like there is no power going to it. Learn how to troubleshoot and repair a TV set that won't turn on";
                    page.Keywords = "plasma TV,LCD TV,repair yourself,repair myself,no power,TV wont turn on";
                    page.og_description = "One possible cause might be that the power cord is unplugged, especially if it can be unplugged from the back of the television. Or, there could be a problem with a circuit board...";
                    break;
                case "dlp":
                    page.Title = "Cleaning a DLP or LCD Projection TV";
                    page.Description = "Want to enhance the picture quality of your DLP or LCD projection TV? Cleaning the optics of an aging TV can significabntly help!";
                    page.Keywords = "samsung dlp cleaning,dlp cleaning,clean dlp,dlp mirror cleaning,how to clean a dlp,cleaning dlp mirror";
                    page.og_description = "Want to enhance the picture quality of your DLP or LCD projection TV? Cleaning the optics of an aging TV can significabntly help!";
                    break;
                case "engines":
                    page.Title = "Replacing Light Engines (Optical Blocks)";
                    page.Description = "How difficult is it to replace a light engine or optical block in a TV? Learn what to expect when repairing a DLP or an LCD projection TV";
                    page.Keywords = "tv light engine,light engine replacement,dlp light engine,dlp light engine replacement,mitsubishi light engine replacement,rca light engine,samsung light engine,mitsubishi light engine,mitsubishi tv light engine,optical block replacement,kds-r60xbr1 optical block replacement,kds-r50xbr1 optical block replacement";
                    page.og_description = "Some are easy, some are not. The service manual should be your guide. This article will give you the basics.";
                    break;
                case "equipment":
                    page.Title = "Do I Need Test Equipment?";
                    page.Description = "Most of the time, test equipment is not necessary to troubleshoot certain TV problems.  But there are benifits of having a digital multimeter for TV repair";
                    page.Keywords = "TV parts,meter,voltmeter,TV repair,continuity,voltage";
                    page.og_description = "Most of the time, test equipment is not necessary to troubleshoot certain TV problems.  But there are benifits of having a digital multimeter for TV repair";
                    break;
                case "error":
                    page.Title = "Error - FixMyOwnTV";
                    page.Description = "";
                    page.Keywords = "";
                    page.og_description = "";
                    break;
                case "flats":
                    page.Title = "Cleaning Flat-Screen TVs";
                    page.Description = "What is the best way to clean TV screens? Learn how to clean a plasma, LCD or LED television screens safely";
                    page.Keywords = "how to clean lcd screen,cleaning lcd screen,samsung lcd cleaning,lcd screen cleaning,clean lcd screen,how to clean a lcd screen,tv cleaning,how to clean plasma screen,cleaning plasma screen,plasma screen cleaning,clean plasma screen,how to clean a plasma screen";
                    page.og_description = "A feather duster is fine for routine cleaning. Use damp cleaning cloth to wipe off smudges and finger prints. Cleaning products that contain no alcohol and no ammonia good. But you can also use a solution of mild dish detergent and water...";
                    break;
                case "faqs":
                    page.Title = "Frequently Asked Questions";
                    page.Description = "Here is a list of random questions and answers having to do with TV repair.";
                    page.Keywords = "LCD,LED,plasma,CRT,DLP,projection,TV,liquid crystal display,light emitting diode,cathode-ray tube,picture tube,digital light processor,television,panel,screen,display,transport";
                    page.og_description = "";
                    break;
                case "getto":
                    page.Title = "How Do I Get to the Printed Circuit Boards?";
                    page.Description = "How does a TV come apart so you can fix it? Learn how to open the back of the television so you can repair your TV";
                    page.Keywords = "plasma TV,LCD TV,repair yourself,repair myself,confidence,TV printed circuit boards,back cover";
                    page.og_description = "How does a TV come apart so you can fix it? Learn how to open the back of the television so you can repair your TV";
                    break;
                case "hookedup":
                    page.Title = "How Is My TV Hooked Up?";
                    page.Description = "What's the difference between coaxial, HDMI, composite, component, audio and video cables? Learn how to recognize the cables involved with how a TV is connected to other devices";
                    page.Keywords = "difference between composite and component video,what's the difference between component and composite video,how do I hook up composite video cables,how do I hook up component video cables,hooking up composite video cables,hooking up component video cables,what is a composite video cable,what is a component video cable,what is a USB cable,what is an HDMI cable,what is an RCA connector,what is a phono connector,video connectors,audio connectors,hooking up video cables,hooking up audio cables,hooking up coaxial cables,hooking up RF cables,hooking up Y Pr Pb cables,what is component video,what is composite video,what is HDMI";
                    page.og_description = "These are not a silly questions, especially if someone else hooked it up for you.  Knowing how your TV is connected to other devices might help you troubleshoot certain problems.";
                    break;
                case "iaud":
                    page.Title = "Problem: Intermittent TV Audio";
                    page.Description = "Does the sound cut in and out on your TV? Learn the probable causes of typical TV audio problems, and how to resolve them";
                    page.Keywords = "studdering TV sound,intermittent TV sound,TV sound comes and goes";
                    page.og_description = "Does the sound cut in and out on your TV? Learn the probable causes of typical TV audio problems, and how to resolve them";
                    break;
                case "intsignal":
                    page.Title = "Intermittent TV Picture / Sound / Signals";
                    page.Description = "Does your TV signal come and go? Are you dealing with blocky pictures and studdering sound? Six different senarios involving intermittent signals are discussed, along with step-by-step troubleshooting.";
                    page.Keywords = "what causes tv pixelation,tv picture breaking up into squares,macroblocking,troubleshooting weak tv signals,intermittent TV signal,irratic TV signal,TV picture freezes,pixelly TV picture,weak TV signal,poor TV cable,connections,intermittent satellite reception,poor cable connection,blocky TV pictures,studdering TV sound,blocks of pixels in TV picture,HDMI incompatibility issue,poor antenna connection,poor aerial connection";
                    page.og_description = "Does your TV signal come and go? Are you dealing with blocky pictures and studdering sound? Six different senarios involving intermittent signals are discussed, along with step-by-step troubleshooting.";
                    break;
                case "keypad":
                    switch (title)
                    {
                        case "channels":
                            page.Keywords = "tv keeps changing channels, tv changing channels by itself, samsung tv changing channels by itself, tv keeps changing channels by itself, samsung tv channels, samsung tv channel list, samsung tv channel, make tv channel";
                            page.Description = "Do the channels on your TV change all by themselves? Learn what could cause the channels to go up or down on their own";
                            page.Title = "Channels Keep Changing";
                            page.og_description = "Do the channels on your TV change all by themselves? Learn what could cause the channels to go up or down on their own";
                            break;
                        case "inputs":
                            page.Keywords = "tv inputs keep changing, tv sources keep changing, tv changes inputs by itself, tv changes sources by itself";
                            page.Description = "Do the inputs change all by themselves on your TV? Learn what could cause the input selection to keep changing";
                            page.Title = "Inputs Keep Changing";
                            page.og_description = "Do the inputs change all by themselves on your TV? Learn what could cause the input selection to keep changing";
                            break;
                        case "volume":
                            page.Keywords = "samsung tv volume problems, samsung tv volume not working, tv volume, tv volume control, samsung volume problems, samsung tv volume stuck, samsung tv no volume, no volume on samsung tv, television volume, tv volume problem";
                            page.Description = "Does the volume get louder or softer all by itself on your TV? Learn what could cause the volume to go all the way up or all the way down";
                            page.Title = "Uncontrollable Volume";
                            page.og_description = "Does the volume get louder or softer all by itself on your TV? Learn what could cause the volume to go all the way up or all the way down";
                            break;
                        default:
                            page.Title = "Fix My Own TV - Your one-stop resource to learn how and get what you need";
                            page.Description = "Make informed decisions about repairing your television yourself. Find insight on common TV problems and rudimentary instruction on TV repair";
                            page.Keywords = "";
                            page.og_description = "Make informed decisions about repairing your television yourself. Find insight on common TV problems and rudimentary instruction on TV repair";
                            break;
                    }
                    break;
                case "lampfailure":
                    page.Title = "Problem: TV Lamp Failure";
                    page.Description = "Does my TV have a lamp in it? How can I tell if it needs to be replaced? Learn what happens when a lamp go out in a DLP or an LCD projection TV";
                    page.Keywords = "TV bulb,TV lamp,DPL lamp";
                    page.og_description = "Does my TV have a lamp in it? How can I tell if it needs to be replaced? Learn what happens when a lamp go out in a DLP or an LCD projection TV";
                    break;
                case "lamps":
                    page.Title = "Replacing TV Lamps";
                    page.Description = "How to replace a lamp in a TV can be very easy. Learn how to easily replace the lamp (bulb) inside a DLP or LCD projection TV";
                    page.Keywords = "how to replace a TV lamp,TV lamp replacement,TV bulb replacement,replace TV lamp,replace TV bulb,replace DLP lamp";
                    page.og_description = "How to replace a lamp in a TV can be very easy. Learn how to easily replace the lamp (bulb) inside a DLP or LCD projection TV";
                    break;
                case "lcd-plasma":
                    page.Title = "Is my TV an LCD, LED or Plasma?";
                    page.Description = "You have a flat screen TV. But is it a plasma, LED or LCD? Learn how to tell the difference";
                    page.Keywords = "plasma vs lcd,lcd vs plasma,lcd vs led,led vs lcd, difference between lcd and led, difference between led and plasma, difference between lcd and plasma";
                    page.og_description = "One sure way to know whether you have an LCD/LED TV or a plasma TV is to poke the screen with your finger while watching TV. If it is of the LCD/LED variety the picture will go slightly dark where you poked the screen reacting with a ripple-like effect, and then quickly return to normal...";
                    break;
                case "lcd":
                    page.Title = "LCD / LED Screen Replacement";
                    page.Description = "Learn how to replace a broken LCD and LED screen yourself. Learn how to remove and install an LCD or an LED flat-screen panel";
                    page.Keywords = "led tv screen repair,samsung tv screen repair,lcd tv screen repair,lcd tv screen repair,visio tv screen replacement,samsung tv screen replacement, sony tv screen replacement,lg tv screen replacement,flat screen repair,lcd screen replacement,lcd tv screen replacement,led screen replacement,led tv screen replacement,replace lcd panel,replace lcd screen,replace led panel,replace led screen,replace tv panel,replace tv screen,replacing LCD panel,replacing LCD screen,replacing LED panel,replacing LED screen,tv screen replacement,flat screen replacement";
                    page.og_description = "This article describes what to expect when replacing an LCD panel. It is like replacing a part under the hood of your car. You may have to remove some parts to get to what needs to be replaced, and then put it all back together again in the reverse order...";
                    break;
                case "manuals":
                    page.Title = "TV Service Manuals";
                    page.Description = "Looking for TV service manuals? Find the TV repair manual you need here. They are listed by television manufacturer";
                    page.Keywords = "TV repair manuals,TV service manuals,TV schematics,TV parts lists";
                    page.og_description = "Looking for TV service manuals? Find the TV repair manual you need here. They are listed by television manufacturer";
                    break;
                case "myth-reality":
                    page.Title = "Plasma TVs - Myths vs. Realities";
                    page.Description = "A seasoned TV repair guy discusses what a plasma TV is, how it works, common misconceptions, and proper care of a modern consumer television receiver";
                    page.Keywords = "what are plasma tvs,problems with plasma tvs,transporting plasma tv,can a plasma tv leak,can a plasma tv lay down";
                    page.og_description = "A seasoned TV repair buy discusses what a plasma TV is, how it works, common misconceptions, and proper care of a modern consumer television receiver";
                    break;
                case "network":
                    page.Title = "WiFi Connectivity";
                    page.Description = "Having connection problems with Netfix, Amazon Video, Hulu, or Sling? Here's how to troubleshoot the internet connection problem with your TV";
                    page.Keywords = "plasma TV,TV internet connection,TV connectivity,dongle,TV Ethernet connection,TV LAN connection,TV wireless network,TV USB,TV wireless problem,TV router connection,TV modem connection,TV won't connect to the internet,TV has no WiFi connection, TV Wifi connection";
                    page.og_description = "Having connection problems with Netfix, Amazon Video, Hulu, or Sling? Here's how to troubleshoot the internet connection problem with your TV";
                    break;
                case "orderparts":
                    page.Title = "How to Order TV Parts";
                    page.Description = "Most TV parts are replaceable. This article describes how to place an order for parts for a TV";
                    page.Keywords = "plasma screen,plasma tv screen,plasma tv screens,plasma television screen,plasma television screens,cheap plasma screens,screen for tv,plasma display panels,LCD panels,TV parts,lcd tv parts,panasonic plasma tv parts,plasma screen replacement parts,plasma tv parts,samsung tv parts,shop jimmy,shopjimmy,shopjimmy.com,television parts,toshiba tv parts,tv repair parts";
                    page.og_description = "Most TV parts are replaceable. This article describes how to place an order for parts for a TV";
                    break;
                case "parts":
                    page.Title = "TV Replacement Parts";
                    page.Description = "Most TV parts are replaceable. Find the TV part you need from these television parts dealers";
                    page.Keywords = "tv replacement parts,replacement parts for TVs,TV parts,parts for TVs";
                    page.og_description = "Most TV parts are replaceable. Find the TV part you need from these television parts dealers";
                    break;
                case "plasma":
                    page.Title = "Plasma Screen Replacement";
                    page.Description = "Broken TV screens cannot be repaired - they can only be replaced. Learn how to remove and install a plasma display panel in a TV";
                    page.Keywords = "plasma screen replacement,plasma tv screen replacement,replace plasma panel,replace plasma screen,replace tv panel,replace tv screen,replacing plasma panel,replacing plasma screen,tv screen replacement";
                    page.og_description = "This article describes what to expect when replacing a plasma display panel. It is like replacing a part under the hood of your car. You may have to remove some parts to get to what needs to be replaced, and then put it all back together again in the reverse order...";
                    break;
                case "rattles":
                    page.Title = "Problem: Speaker Rattle or Buzz";
                    page.Description = "Certain sounds coming out of your TV speaker may cause a disturbing noise. Is it a blown speaker, defective printed circuit board, or a loose object?";
                    page.Keywords = "blown speaker test,speaker test,testing speakers,blown subwoofer test,subwoofer test,testing subwoofers,speaker rattle,rattling speakers,subwoofer rattle,rattling subwoofer,audio test,testing audio,audio rattle,rattling audio,acoustic test,acoustic rattle,acoustic vibration,acoustic noise";
                    page.og_description = "A rattle or buzz coming from the TV that coincides with the audio can either be an acoustic problem or an electronics problem. This web site will show you how to diagnose and fix the problem...";
                    break;
                case "shattered":
                    page.Title = "How to Fix a Cracked TV Screen";
                    page.Description = "What can be done to fix a cracked or broken TV screen? There are many ways TV screens can crack. Learn how they are repairable.";
                    page.Keywords = "broken lcd panel,broken lcd screen,broken led panel,broken led screen,broken plasma panel,broken plasma screen,broken tv panel,broken tv screen,can a broken lcd screen be fixed,can a broken led screen be fixed,can a broken plasma screen be fixed,can a broken tv screen be fixed,can a cracked lcd screen be fixed,can a cracked led screen be fixed,can a cracked plasma screen be fixed,can a cracked tv screen be fixed,can a plasma panel be fixed,can a plasma screen be fixed,can a shattered lcd screen be fixed,can a shattered led screen be fixed,can a shattered plasma screen be fixed,can a shattered tv screen be fixed,can a tv panel be fixed,can a tv screen be fixed,can an lcd panel be fixed,can an lcd screen be fixed,can an led panel be fixed,can an led screen be fixed,cracked lcd screen,cracked led screen,cracked plasma screen,cracked tv screen,how to fix a broken lcd screen,how to fix a broken led screen,how to fix a broken plasma screen,how to fix a broken tv screen,how to fix a cracked lcd screen,how to fix a cracked led screen,how to fix a cracked plasma screen,how to fix a cracked tv screen,how to fix a lcd panel,how to fix a lcd screen,how to fix a plasma panel,how to fix a plasma screen,how to fix a shattered lcd screen,how to fix a shattered led screen,how to fix a shattered plasma screen,how to fix a shattered tv screen,how to fix a tv panel,how to fix a tv screen,how to fix an led panel,how to fix an led screen,lcd screen repair,lcd tv panel repair,led screen repair,led tv panel repair,plasma panel repair,plasma screen repair,plasma screen warentee,shattered lcd screen,shattered led screen,shattered plasma screen,shattered tv screen,spider cracks,stress fractures,tv  makes a buzzing noise,tv  makes a loud buzzing noise,tv makes a loud buzzing noise,tv screen is bad,tv screen is cracked,tv screen is damaged,tv screen repair,TV screen warranty,tv screen won't light up,tv won't turn on";
                    page.og_description = "In most cases, depending on the availability of replacement parts, your TV can be fixed. The hard truth is, whether you have an LCD, LED or plasma TV, a cracked or shattered screen cannot actually be repaired - it can only be replaced...";
                    break;
                case "solder":
                    page.Title = "Replacing Soldered Parts";
                    page.Description = "Learn basic soldering technique as it applies to replacing electrolytic capacitors in a TV";
                    page.Keywords = "2200uf 10v capacitor,samsung tv capacitor,samsung tv capacitor replacement,samsung tv capacitors,capacitors for samsung tv,tv capacitors,samsung capacitor replacement,samsung capacitor,capacitor for samsung tv,capacitor in tv,replacing capacitors on samsung tv,samsung tv capacitor problems,tv capacitor,samsung capacitors,tv capacitor replacement,replace capacitors samsung tv,samsung capacitor repair,samsung tv capacitor repair,capacitor samsung tv,capacitors for tv,capacitor for tv,samsung tv capacitor problem,samsung capacitor fix,replacement capacitors for samsung tv,where to buy tv capacitors,capacitor tv,where to buy capacitors for tv,capacitor repair,capacitor samsung,replacing samsung capacitors,replacement capacitor,lcd tv capacitor,capacitors samsung";
                    page.og_description = "Learn basic soldering technique as it applies to replacing electrolytic capacitors in a TV";
                    break;
                case "stripesandbars":
                    page.Title = "Problem: Pin Stripes, Lines or Bars";
                    page.Description = "Learn how to diagnose what's wrong with your TV if you see colorful pin-stripe lines or bars in the picture";
                    page.Keywords = "plasma tv lines on screen,plasma tv problems,lines in the TV picture";
                    page.og_description = "Learn how to diagnose what's wrong with your TV if you see colorful pin-stripe lines or bars in the picture";
                    break;
                case "update":
                    page.Title = "Software Updates for TVs";
                    page.Description = "The software in many TVs can be updated. Learn how to perform a software update on your televlsion";
                    page.Keywords = "TV software update,TV firmware update,TV software upgrade,TV firmware upgrade,TV software download,TV firmware download";
                    page.og_description = "The software in many TVs can be updated. Learn how to perform a software update on your televlsion";
                    break;
                case "wheels":
                    page.Title = "Replacing DLP Color Wheels";
                    page.Description = "DLP (Digital Light Processing) projection TVs have mechanical parts in them that can be replaced. Learn how to get to the color wheel in a DLP TV and replace it";
                    page.Keywords = "";
                    page.og_description = "DLP (Digital Light Processing) projection TVs have mechanical parts in them that can be replaced. Learn how to get to the color wheel in a DLP TV and replace it";
                    break;
                case "volume":
                    page.Title = "No Sound";
                    page.Description = "This article describes how to troublshooting a TV that has a picture but no sound";
                    page.Keywords = "TV no sound, TV no audio";
                    page.og_description = "This article describes how to troublshooting a TV that has a picture but no sound";
                    break;
                case "worth-fixing":
                    page.Title = "Is My TV Worth Fixing?";
                    page.Description = "There are many things to consider when trying to decide whether to fix your own TV. Here is some common sense from an expert.";
                    page.Keywords = "CRT,picture tube,console TV,should I fix my TV,should TVs be fixed,TV parts,TV replacement parts";
                    page.og_description = "There are many things to consider when trying to decide whether to fix your own TV. Here is some common sense from an expert.";
                    break;
                case "zoom":
                    page.Title = "Problem: TV Picture Doesn't Fit The Screen";
                    page.Description = "Follow this step-by-step process on how to get your TV picture to fit the screen properly";
                    page.Keywords = "proper tv picture size adjustment,anamorphic tv picture,anamorphic video,history of high definition,history of wide screen TV,can't change tv picture size,how to change tv picture shape,how to change tv picture size,how to fix size of tv picture,how to fix tv picture size,justified tv picture,justified video,leterbox tv picture,letterbox video,picture doesn't fill the screen,picture not fitting tv screen,pillarbox tv picture,pillarbox video,size of the tv picture cannot be changed,there are black pillars on either side the picture,tv picture always looks stretched,tv picture doesn't fit the screen,tv picture has wrong shape,tv picture is worng size,tv picture size wrong,tv picture too big,tv picture too large,tv picture too narrow,tv picture too small,tv picture too wide";
                    page.og_description = "Whether a wrong button got pushed on the TV remote by mistake, or some other mishap took place, this article will help you get the picture to fit the screen properly. There is also a section on why TVs are even capable of displaying pictures incorrectly anyway...";
                    break;
            }
            return page;
        }
    }
}
