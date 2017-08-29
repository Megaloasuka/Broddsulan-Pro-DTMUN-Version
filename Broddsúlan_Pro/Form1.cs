namespace BroddsúlanPro
{
    using BroddsúlanPro.My;
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Media;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class Form1 : Form
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        [AccessedThroughProperty("btn_backbrowse")]
        private Button _btn_backbrowse;
        [AccessedThroughProperty("btn_bannerbrowse")]
        private Button _btn_bannerbrowse;
        [AccessedThroughProperty("btn_create_back")]
        private Button _btn_create_back;
        [AccessedThroughProperty("btn_create_next")]
        private Button _btn_create_next;
        [AccessedThroughProperty("btn_dabianquan")]
        private Button _btn_dabianquan;
        [AccessedThroughProperty("btn_dbqcancel")]
        private Button _btn_dbqcancel;
        [AccessedThroughProperty("btn_dbqok")]
        private Button _btn_dbqok;
        [AccessedThroughProperty("btn_dbqstop")]
        private Button _btn_dbqstop;
        [AccessedThroughProperty("btn_enl_cancel")]
        private Button _btn_enl_cancel;
        [AccessedThroughProperty("btn_enl_save")]
        private Button _btn_enl_save;
        [AccessedThroughProperty("btn_entermanage")]
        private Button _btn_entermanage;
        [AccessedThroughProperty("btn_file")]
        private Button _btn_file;
        [AccessedThroughProperty("btn_file_1")]
        private Button _btn_file_1;
        [AccessedThroughProperty("btn_file_2")]
        private Button _btn_file_2;
        [AccessedThroughProperty("btn_file_browse")]
        private Button _btn_file_browse;
        [AccessedThroughProperty("btn_file_cancel")]
        private Button _btn_file_cancel;
        [AccessedThroughProperty("btn_file_modify")]
        private Button _btn_file_modify;
        [AccessedThroughProperty("btn_file_ok")]
        private Button _btn_file_ok;
        [AccessedThroughProperty("btn_fileplayback")]
        private Button _btn_fileplayback;
        [AccessedThroughProperty("btn_files_3")]
        private Button _btn_files_3;
        [AccessedThroughProperty("btn_files_4")]
        private Button _btn_files_4;
        [AccessedThroughProperty("btn_files_5")]
        private Button _btn_files_5;
        [AccessedThroughProperty("btn_fontchange")]
        private Button _btn_fontchange;
        [AccessedThroughProperty("btn_ispresent")]
        private Button _btn_ispresent;
        [AccessedThroughProperty("btn_manage_exit")]
        private Button _btn_manage_exit;
        [AccessedThroughProperty("btn_manage_save")]
        private Button _btn_manage_save;
        [AccessedThroughProperty("btn_mc_add")]
        private Button _btn_mc_add;
        [AccessedThroughProperty("btn_mc_end")]
        private Button _btn_mc_end;
        [AccessedThroughProperty("btn_mc_next")]
        private Button _btn_mc_next;
        [AccessedThroughProperty("btn_mc_start")]
        private Button _btn_mc_start;
        [AccessedThroughProperty("btn_mcedit_cancle")]
        private Button _btn_mcedit_cancle;
        [AccessedThroughProperty("btn_mcedit_save")]
        private Button _btn_mcedit_save;
        [AccessedThroughProperty("btn_misc")]
        private Button _btn_misc;
        [AccessedThroughProperty("btn_misc_1")]
        private Button _btn_misc_1;
        [AccessedThroughProperty("btn_misc_2")]
        private Button _btn_misc_2;
        [AccessedThroughProperty("btn_misc_3")]
        private Button _btn_misc_3;
        [AccessedThroughProperty("btn_misc_4")]
        private Button _btn_misc_4;
        [AccessedThroughProperty("btn_misc_5")]
        private Button _btn_misc_5;
        [AccessedThroughProperty("btn_misc_cancel")]
        private Button _btn_misc_cancel;
        [AccessedThroughProperty("btn_misc_ok")]
        private Button _btn_misc_ok;
        [AccessedThroughProperty("btn_modecancel")]
        private Button _btn_modecancel;
        [AccessedThroughProperty("btn_modify_presents")]
        private Button _btn_modify_presents;
        [AccessedThroughProperty("btn_motion_1")]
        private Button _btn_motion_1;
        [AccessedThroughProperty("btn_motion_2")]
        private Button _btn_motion_2;
        [AccessedThroughProperty("btn_motion_3")]
        private Button _btn_motion_3;
        [AccessedThroughProperty("btn_motion_4")]
        private Button _btn_motion_4;
        [AccessedThroughProperty("btn_motion_5")]
        private Button _btn_motion_5;
        [AccessedThroughProperty("btn_motion_6")]
        private Button _btn_motion_6;
        [AccessedThroughProperty("btn_motion_7")]
        private Button _btn_motion_7;
        [AccessedThroughProperty("btn_motion_8")]
        private Button _btn_motion_8;
        [AccessedThroughProperty("btn_motion_9")]
        private Button _btn_motion_9;
        [AccessedThroughProperty("btn_motion_cancel")]
        private Button _btn_motion_cancel;
        [AccessedThroughProperty("btn_motion_finish")]
        private Button _btn_motion_finish;
        [AccessedThroughProperty("btn_motions")]
        private Button _btn_motions;
        [AccessedThroughProperty("btn_motionstop")]
        private Button _btn_motionstop;
        [AccessedThroughProperty("btn_next")]
        private Button _btn_next;
        [AccessedThroughProperty("btn_prev")]
        private Button _btn_prev;
        [AccessedThroughProperty("btn_read_close")]
        private Button _btn_read_close;
        [AccessedThroughProperty("btn_roll_cancle")]
        private Button _btn_roll_cancle;
        [AccessedThroughProperty("btn_roll_finish")]
        private Button _btn_roll_finish;
        [AccessedThroughProperty("btn_sessionstart")]
        private Button _btn_sessionstart;
        [AccessedThroughProperty("btn_sfx1")]
        private Button _btn_sfx1;
        [AccessedThroughProperty("btn_sfx2")]
        private Button _btn_sfx2;
        [AccessedThroughProperty("btn_sfx3")]
        private Button _btn_sfx3;
        [AccessedThroughProperty("btn_sfx4")]
        private Button _btn_sfx4;
        [AccessedThroughProperty("btn_sfxquick")]
        private Button _btn_sfxquick;
        [AccessedThroughProperty("btn_sizequick")]
        private Button _btn_sizequick;
        [AccessedThroughProperty("btn_speakerslist")]
        private Button _btn_speakerslist;
        [AccessedThroughProperty("btn_spl_add")]
        private Button _btn_spl_add;
        [AccessedThroughProperty("btn_spl_exit")]
        private Button _btn_spl_exit;
        [AccessedThroughProperty("btn_spl_loadcustom")]
        private Button _btn_spl_loadcustom;
        [AccessedThroughProperty("btn_spl_savecustom")]
        private Button _btn_spl_savecustom;
        [AccessedThroughProperty("btn_spl_start")]
        private Button _btn_spl_start;
        [AccessedThroughProperty("btn_spl_yieldend")]
        private Button _btn_spl_yieldend;
        [AccessedThroughProperty("btn_spl_yieldgo")]
        private Button _btn_spl_yieldgo;
        [AccessedThroughProperty("btn_start_cancel")]
        private Button _btn_start_cancel;
        [AccessedThroughProperty("btn_start_ok")]
        private Button _btn_start_ok;
        [AccessedThroughProperty("btn_system")]
        private Button _btn_system;
        [AccessedThroughProperty("btn_system_1")]
        private Button _btn_system_1;
        [AccessedThroughProperty("btn_system_calcel")]
        private Button _btn_system_calcel;
        [AccessedThroughProperty("btn_umc_close")]
        private Button _btn_umc_close;
        [AccessedThroughProperty("btn_umc_reset")]
        private Button _btn_umc_reset;
        [AccessedThroughProperty("btn_umc_send")]
        private Button _btn_umc_send;
        [AccessedThroughProperty("btn_vote_cancel")]
        private Button _btn_vote_cancel;
        [AccessedThroughProperty("btn_vote_next")]
        private Button _btn_vote_next;
        [AccessedThroughProperty("btn_votectrl")]
        private Button _btn_votectrl;
        [AccessedThroughProperty("btnabst")]
        private Button _btnabst;
        [AccessedThroughProperty("btnexit")]
        private Button _btnexit;
        [AccessedThroughProperty("btnno")]
        private Button _btnno;
        [AccessedThroughProperty("btnpass")]
        private Button _btnpass;
        [AccessedThroughProperty("btnstart")]
        private Button _btnstart;
        [AccessedThroughProperty("btnyes")]
        private Button _btnyes;
        [AccessedThroughProperty("Button1")]
        private Button _Button1;
        [AccessedThroughProperty("Button11")]
        private Button _Button11;
        [AccessedThroughProperty("Button12")]
        private Button _Button12;
        [AccessedThroughProperty("Button2")]
        private Button _Button2;
        [AccessedThroughProperty("Button3")]
        private Button _Button3;
        [AccessedThroughProperty("Button4")]
        private Button _Button4;
        [AccessedThroughProperty("Button5")]
        private Button _Button5;
        [AccessedThroughProperty("cbx_awards")]
        private ComboBox _cbx_awards;
        [AccessedThroughProperty("cbx_fmode")]
        private ComboBox _cbx_fmode;
        [AccessedThroughProperty("cbx_fselcet_2")]
        private ComboBox _cbx_fselcet_2;
        [AccessedThroughProperty("cbx_fselect")]
        private ComboBox _cbx_fselect;
        [AccessedThroughProperty("cbx_ftpye")]
        private ComboBox _cbx_ftpye;
        [AccessedThroughProperty("cbx_mfileselect")]
        private ComboBox _cbx_mfileselect;
        [AccessedThroughProperty("cbx_singledel")]
        private ComboBox _cbx_singledel;
        [AccessedThroughProperty("cbx_spl_yield")]
        private ComboBox _cbx_spl_yield;
        [AccessedThroughProperty("CheckBox1")]
        private CheckBox _CheckBox1;
        [AccessedThroughProperty("CheckBox2")]
        private CheckBox _CheckBox2;
        [AccessedThroughProperty("CheckBox3")]
        private CheckBox _CheckBox3;
        [AccessedThroughProperty("CheckBox4")]
        private CheckBox _CheckBox4;
        [AccessedThroughProperty("CheckBox5")]
        private CheckBox _CheckBox5;
        [AccessedThroughProperty("CheckBox6")]
        private CheckBox _CheckBox6;
        [AccessedThroughProperty("chk_filedl_am")]
        private CheckBox _chk_filedl_am;
        [AccessedThroughProperty("chk_filedl_dd")]
        private CheckBox _chk_filedl_dd;
        [AccessedThroughProperty("chk_filedl_dr")]
        private CheckBox _chk_filedl_dr;
        [AccessedThroughProperty("chk_is_mainimg")]
        private CheckBox _chk_is_mainimg;
        [AccessedThroughProperty("chk_issingle")]
        private CheckBox _chk_issingle;
        [AccessedThroughProperty("chk_istimeruse")]
        private CheckBox _chk_istimeruse;
        [AccessedThroughProperty("chk_noabst")]
        private CheckBox _chk_noabst;
        [AccessedThroughProperty("chk_playback")]
        private CheckBox _chk_playback;
        [AccessedThroughProperty("chk_rule_1")]
        private CheckBox _chk_rule_1;
        [AccessedThroughProperty("chk_sfx_start")]
        private CheckBox _chk_sfx_start;
        [AccessedThroughProperty("chk_sfx_time20")]
        private CheckBox _chk_sfx_time20;
        [AccessedThroughProperty("chk_sfx_time60")]
        private CheckBox _chk_sfx_time60;
        [AccessedThroughProperty("chk_sfx_timeout")]
        private CheckBox _chk_sfx_timeout;
        [AccessedThroughProperty("chk_spl_allowyield")]
        private CheckBox _chk_spl_allowyield;
        [AccessedThroughProperty("chk_vote_foujue")]
        private CheckBox _chk_vote_foujue;
        [AccessedThroughProperty("chk_vote_saveplist")]
        private CheckBox _chk_vote_saveplist;
        [AccessedThroughProperty("clb_nation_main")]
        private CheckedListBox _clb_nation_main;
        [AccessedThroughProperty("clb_nation_vote")]
        private CheckedListBox _clb_nation_vote;
        [AccessedThroughProperty("ComboBox1")]
        private ComboBox _ComboBox1;
        [AccessedThroughProperty("DateTimePicker1")]
        private DateTimePicker _DateTimePicker1;
        [AccessedThroughProperty("FontDialog1")]
        private FontDialog _FontDialog1;
        [AccessedThroughProperty("GroupBox1")]
        private GroupBox _GroupBox1;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("Label10")]
        private Label _Label10;
        [AccessedThroughProperty("Label100")]
        private Label _Label100;
        [AccessedThroughProperty("Label101")]
        private Label _Label101;
        [AccessedThroughProperty("Label102")]
        private Label _Label102;
        [AccessedThroughProperty("Label103")]
        private Label _Label103;
        [AccessedThroughProperty("Label104")]
        private Label _Label104;
        [AccessedThroughProperty("Label105")]
        private Label _Label105;
        [AccessedThroughProperty("Label106")]
        private Label _Label106;
        [AccessedThroughProperty("Label108")]
        private Label _Label108;
        [AccessedThroughProperty("Label109")]
        private Label _Label109;
        [AccessedThroughProperty("Label11")]
        private Label _Label11;
        [AccessedThroughProperty("Label110")]
        private Label _Label110;
        [AccessedThroughProperty("Label111")]
        private Label _Label111;
        [AccessedThroughProperty("Label112")]
        private Label _Label112;
        [AccessedThroughProperty("Label113")]
        private Label _Label113;
        [AccessedThroughProperty("Label114")]
        private Label _Label114;
        [AccessedThroughProperty("Label115")]
        private Label _Label115;
        [AccessedThroughProperty("Label116")]
        private Label _Label116;
        [AccessedThroughProperty("Label117")]
        private Label _Label117;
        [AccessedThroughProperty("Label118")]
        private Label _Label118;
        [AccessedThroughProperty("Label119")]
        private Label _Label119;
        [AccessedThroughProperty("Label12")]
        private Label _Label12;
        [AccessedThroughProperty("Label120")]
        private Label _Label120;
        [AccessedThroughProperty("Label121")]
        private Label _Label121;
        [AccessedThroughProperty("Label122")]
        private Label _Label122;
        [AccessedThroughProperty("Label123")]
        private Label _Label123;
        [AccessedThroughProperty("Label124")]
        private Label _Label124;
        [AccessedThroughProperty("Label125")]
        private Label _Label125;
        [AccessedThroughProperty("Label126")]
        private Label _Label126;
        [AccessedThroughProperty("Label127")]
        private Label _Label127;
        [AccessedThroughProperty("Label128")]
        private Label _Label128;
        [AccessedThroughProperty("Label129")]
        private Label _Label129;
        [AccessedThroughProperty("Label13")]
        private Label _Label13;
        [AccessedThroughProperty("Label130")]
        private Label _Label130;
        [AccessedThroughProperty("Label131")]
        private Label _Label131;
        [AccessedThroughProperty("Label132")]
        private Label _Label132;
        [AccessedThroughProperty("Label133")]
        private Label _Label133;
        [AccessedThroughProperty("Label134")]
        private Label _Label134;
        [AccessedThroughProperty("Label135")]
        private Label _Label135;
        [AccessedThroughProperty("Label136")]
        private Label _Label136;
        [AccessedThroughProperty("Label137")]
        private Label _Label137;
        [AccessedThroughProperty("Label138")]
        private Label _Label138;
        [AccessedThroughProperty("Label139")]
        private Label _Label139;
        [AccessedThroughProperty("Label14")]
        private Label _Label14;
        [AccessedThroughProperty("Label140")]
        private Label _Label140;
        [AccessedThroughProperty("Label141")]
        private Label _Label141;
        [AccessedThroughProperty("Label142")]
        private Label _Label142;
        [AccessedThroughProperty("Label143")]
        private Label _Label143;
        [AccessedThroughProperty("Label144")]
        private Label _Label144;
        [AccessedThroughProperty("Label145")]
        private Label _Label145;
        [AccessedThroughProperty("Label146")]
        private Label _Label146;
        [AccessedThroughProperty("Label147")]
        private Label _Label147;
        [AccessedThroughProperty("Label148")]
        private Label _Label148;
        [AccessedThroughProperty("Label149")]
        private Label _Label149;
        [AccessedThroughProperty("Label150")]
        private Label _Label150;
        [AccessedThroughProperty("Label151")]
        private Label _Label151;
        [AccessedThroughProperty("Label152")]
        private Label _Label152;
        [AccessedThroughProperty("Label153")]
        private Label _Label153;
        [AccessedThroughProperty("Label154")]
        private Label _Label154;
        [AccessedThroughProperty("Label155")]
        private Label _Label155;
        [AccessedThroughProperty("Label156")]
        private Label _Label156;
        [AccessedThroughProperty("Label157")]
        private Label _Label157;
        [AccessedThroughProperty("Label158")]
        private Label _Label158;
        [AccessedThroughProperty("Label159")]
        private Label _Label159;
        [AccessedThroughProperty("Label16")]
        private Label _Label16;
        [AccessedThroughProperty("Label160")]
        private Label _Label160;
        [AccessedThroughProperty("Label161")]
        private Label _Label161;
        [AccessedThroughProperty("Label162")]
        private Label _Label162;
        [AccessedThroughProperty("Label163")]
        private Label _Label163;
        [AccessedThroughProperty("Label164")]
        private Label _Label164;
        [AccessedThroughProperty("Label165")]
        private Label _Label165;
        [AccessedThroughProperty("Label166")]
        private Label _Label166;
        [AccessedThroughProperty("Label167")]
        private Label _Label167;
        [AccessedThroughProperty("Label168")]
        private Label _Label168;
        [AccessedThroughProperty("Label169")]
        private Label _Label169;
        [AccessedThroughProperty("Label17")]
        private Label _Label17;
        [AccessedThroughProperty("Label170")]
        private Label _Label170;
        [AccessedThroughProperty("Label171")]
        private Label _Label171;
        [AccessedThroughProperty("Label172")]
        private Label _Label172;
        [AccessedThroughProperty("Label173")]
        private Label _Label173;
        [AccessedThroughProperty("Label174")]
        private Label _Label174;
        [AccessedThroughProperty("Label175")]
        private Label _Label175;
        [AccessedThroughProperty("Label176")]
        private Label _Label176;
        [AccessedThroughProperty("Label177")]
        private Label _Label177;
        [AccessedThroughProperty("Label178")]
        private Label _Label178;
        [AccessedThroughProperty("Label179")]
        private Label _Label179;
        [AccessedThroughProperty("Label18")]
        private Label _Label18;
        [AccessedThroughProperty("Label180")]
        private Label _Label180;
        [AccessedThroughProperty("Label181")]
        private Label _Label181;
        [AccessedThroughProperty("Label182")]
        private Label _Label182;
        [AccessedThroughProperty("Label183")]
        private Label _Label183;
        [AccessedThroughProperty("Label184")]
        private Label _Label184;
        [AccessedThroughProperty("Label185")]
        private Label _Label185;
        [AccessedThroughProperty("Label186")]
        private Label _Label186;
        [AccessedThroughProperty("Label187")]
        private Label _Label187;
        [AccessedThroughProperty("Label188")]
        private Label _Label188;
        [AccessedThroughProperty("Label189")]
        private Label _Label189;
        [AccessedThroughProperty("Label19")]
        private Label _Label19;
        [AccessedThroughProperty("Label190")]
        private Label _Label190;
        [AccessedThroughProperty("Label191")]
        private Label _Label191;
        [AccessedThroughProperty("Label192")]
        private Label _Label192;
        [AccessedThroughProperty("Label193")]
        private Label _Label193;
        [AccessedThroughProperty("Label194")]
        private Label _Label194;
        [AccessedThroughProperty("Label195")]
        private Label _Label195;
        [AccessedThroughProperty("Label196")]
        private Label _Label196;
        [AccessedThroughProperty("Label197")]
        private Label _Label197;
        [AccessedThroughProperty("Label198")]
        private Label _Label198;
        [AccessedThroughProperty("Label199")]
        private Label _Label199;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("Label20")]
        private Label _Label20;
        [AccessedThroughProperty("Label200")]
        private Label _Label200;
        [AccessedThroughProperty("Label201")]
        private Label _Label201;
        [AccessedThroughProperty("Label202")]
        private Label _Label202;
        [AccessedThroughProperty("Label203")]
        private Label _Label203;
        [AccessedThroughProperty("Label21")]
        private Label _Label21;
        [AccessedThroughProperty("Label22")]
        private Label _Label22;
        [AccessedThroughProperty("Label23")]
        private Label _Label23;
        [AccessedThroughProperty("Label24")]
        private Label _Label24;
        [AccessedThroughProperty("Label25")]
        private Label _Label25;
        [AccessedThroughProperty("Label26")]
        private Label _Label26;
        [AccessedThroughProperty("Label27")]
        private Label _Label27;
        [AccessedThroughProperty("Label28")]
        private Label _Label28;
        [AccessedThroughProperty("Label29")]
        private Label _Label29;
        [AccessedThroughProperty("Label3")]
        private Label _Label3;
        [AccessedThroughProperty("Label30")]
        private Label _Label30;
        [AccessedThroughProperty("Label31")]
        private Label _Label31;
        [AccessedThroughProperty("Label32")]
        private Label _Label32;
        [AccessedThroughProperty("Label33")]
        private Label _Label33;
        [AccessedThroughProperty("Label34")]
        private Label _Label34;
        [AccessedThroughProperty("Label35")]
        private Label _Label35;
        [AccessedThroughProperty("Label36")]
        private Label _Label36;
        [AccessedThroughProperty("Label37")]
        private Label _Label37;
        [AccessedThroughProperty("Label38")]
        private Label _Label38;
        [AccessedThroughProperty("Label39")]
        private Label _Label39;
        [AccessedThroughProperty("Label4")]
        private Label _Label4;
        [AccessedThroughProperty("Label40")]
        private Label _Label40;
        [AccessedThroughProperty("Label41")]
        private Label _Label41;
        [AccessedThroughProperty("Label42")]
        private Label _Label42;
        [AccessedThroughProperty("Label43")]
        private Label _Label43;
        [AccessedThroughProperty("Label44")]
        private Label _Label44;
        [AccessedThroughProperty("Label45")]
        private Label _Label45;
        [AccessedThroughProperty("Label46")]
        private Label _Label46;
        [AccessedThroughProperty("Label47")]
        private Label _Label47;
        [AccessedThroughProperty("Label48")]
        private Label _Label48;
        [AccessedThroughProperty("Label49")]
        private Label _Label49;
        [AccessedThroughProperty("Label5")]
        private Label _Label5;
        [AccessedThroughProperty("Label50")]
        private Label _Label50;
        [AccessedThroughProperty("Label51")]
        private Label _Label51;
        [AccessedThroughProperty("Label52")]
        private Label _Label52;
        [AccessedThroughProperty("Label53")]
        private Label _Label53;
        [AccessedThroughProperty("Label54")]
        private Label _Label54;
        [AccessedThroughProperty("Label55")]
        private Label _Label55;
        [AccessedThroughProperty("Label56")]
        private Label _Label56;
        [AccessedThroughProperty("Label57")]
        private Label _Label57;
        [AccessedThroughProperty("Label58")]
        private Label _Label58;
        [AccessedThroughProperty("Label59")]
        private Label _Label59;
        [AccessedThroughProperty("Label6")]
        private Label _Label6;
        [AccessedThroughProperty("Label60")]
        private Label _Label60;
        [AccessedThroughProperty("Label61")]
        private Label _Label61;
        [AccessedThroughProperty("Label62")]
        private Label _Label62;
        [AccessedThroughProperty("Label63")]
        private Label _Label63;
        [AccessedThroughProperty("Label64")]
        private Label _Label64;
        [AccessedThroughProperty("Label65")]
        private Label _Label65;
        [AccessedThroughProperty("Label66")]
        private Label _Label66;
        [AccessedThroughProperty("Label67")]
        private Label _Label67;
        [AccessedThroughProperty("Label68")]
        private Label _Label68;
        [AccessedThroughProperty("Label69")]
        private Label _Label69;
        [AccessedThroughProperty("Label7")]
        private Label _Label7;
        [AccessedThroughProperty("Label70")]
        private Label _Label70;
        [AccessedThroughProperty("Label71")]
        private Label _Label71;
        [AccessedThroughProperty("Label72")]
        private Label _Label72;
        [AccessedThroughProperty("Label73")]
        private Label _Label73;
        [AccessedThroughProperty("Label74")]
        private Label _Label74;
        [AccessedThroughProperty("Label75")]
        private Label _Label75;
        [AccessedThroughProperty("Label76")]
        private Label _Label76;
        [AccessedThroughProperty("Label77")]
        private Label _Label77;
        [AccessedThroughProperty("Label78")]
        private Label _Label78;
        [AccessedThroughProperty("Label79")]
        private Label _Label79;
        [AccessedThroughProperty("Label8")]
        private Label _Label8;
        [AccessedThroughProperty("Label80")]
        private Label _Label80;
        [AccessedThroughProperty("Label81")]
        private Label _Label81;
        [AccessedThroughProperty("Label82")]
        private Label _Label82;
        [AccessedThroughProperty("Label83")]
        private Label _Label83;
        [AccessedThroughProperty("Label84")]
        private Label _Label84;
        [AccessedThroughProperty("Label85")]
        private Label _Label85;
        [AccessedThroughProperty("Label86")]
        private Label _Label86;
        [AccessedThroughProperty("Label87")]
        private Label _Label87;
        [AccessedThroughProperty("Label88")]
        private Label _Label88;
        [AccessedThroughProperty("Label89")]
        private Label _Label89;
        [AccessedThroughProperty("Label9")]
        private Label _Label9;
        [AccessedThroughProperty("Label90")]
        private Label _Label90;
        [AccessedThroughProperty("Label91")]
        private Label _Label91;
        [AccessedThroughProperty("Label92")]
        private Label _Label92;
        [AccessedThroughProperty("Label93")]
        private Label _Label93;
        [AccessedThroughProperty("Label94")]
        private Label _Label94;
        [AccessedThroughProperty("Label95")]
        private Label _Label95;
        [AccessedThroughProperty("Label96")]
        private Label _Label96;
        [AccessedThroughProperty("Label97")]
        private Label _Label97;
        [AccessedThroughProperty("Label98")]
        private Label _Label98;
        [AccessedThroughProperty("Label99")]
        private Label _Label99;
        [AccessedThroughProperty("lbl_dbqstatus")]
        private Label _lbl_dbqstatus;
        [AccessedThroughProperty("lbl_fileinfo")]
        private Label _lbl_fileinfo;
        [AccessedThroughProperty("lbl_filepath")]
        private Label _lbl_filepath;
        [AccessedThroughProperty("lbl_loaded")]
        private Label _lbl_loaded;
        [AccessedThroughProperty("lbl_manage_about")]
        private Label _lbl_manage_about;
        [AccessedThroughProperty("lbl_manage_conferences")]
        private Label _lbl_manage_conferences;
        [AccessedThroughProperty("lbl_manage_setting")]
        private Label _lbl_manage_setting;
        [AccessedThroughProperty("lbl_mc_total_time")]
        private Label _lbl_mc_total_time;
        [AccessedThroughProperty("lbl_reading")]
        private Label _lbl_reading;
        [AccessedThroughProperty("lbl_sldeldte")]
        private Label _lbl_sldeldte;
        [AccessedThroughProperty("lbl_slist_1")]
        private Label _lbl_slist_1;
        [AccessedThroughProperty("lbl_slist_status_01")]
        private Label _lbl_slist_status_01;
        [AccessedThroughProperty("lbl_slorig")]
        private Label _lbl_slorig;
        [AccessedThroughProperty("lbl_startmode")]
        private Label _lbl_startmode;
        [AccessedThroughProperty("lbl_vote_nation")]
        private Label _lbl_vote_nation;
        [AccessedThroughProperty("lbl_vote_step")]
        private Label _lbl_vote_step;
        [AccessedThroughProperty("lbl20maj")]
        private Label _lbl20maj;
        [AccessedThroughProperty("lbl20maj1")]
        private Label _lbl20maj1;
        [AccessedThroughProperty("lbl50maj")]
        private Label _lbl50maj;
        [AccessedThroughProperty("lbl50maj1")]
        private Label _lbl50maj1;
        [AccessedThroughProperty("lbl67maj")]
        private Label _lbl67maj;
        [AccessedThroughProperty("lbl67maj1")]
        private Label _lbl67maj1;
        [AccessedThroughProperty("lblabst")]
        private Label _lblabst;
        [AccessedThroughProperty("lblabst1")]
        private Label _lblabst1;
        [AccessedThroughProperty("lblconf")]
        private Label _lblconf;
        [AccessedThroughProperty("lblcount")]
        private Label _lblcount;
        [AccessedThroughProperty("lblinfo")]
        private Label _lblinfo;
        [AccessedThroughProperty("lblmain")]
        private Label _lblmain;
        [AccessedThroughProperty("lblmaohao")]
        private Label _lblmaohao;
        [AccessedThroughProperty("lblno")]
        private Label _lblno;
        [AccessedThroughProperty("lblno1")]
        private Label _lblno1;
        [AccessedThroughProperty("lblopic")]
        private Label _lblopic;
        [AccessedThroughProperty("lblpresent")]
        private Label _lblpresent;
        [AccessedThroughProperty("lblpresent1")]
        private Label _lblpresent1;
        [AccessedThroughProperty("lbltime")]
        private Label _lbltime;
        [AccessedThroughProperty("lblyes")]
        private Label _lblyes;
        [AccessedThroughProperty("lblyes1")]
        private Label _lblyes1;
        [AccessedThroughProperty("LinkLabel2")]
        private LinkLabel _LinkLabel2;
        [AccessedThroughProperty("llb_spl_entercustom")]
        private LinkLabel _llb_spl_entercustom;
        [AccessedThroughProperty("NotifyIcon1")]
        private NotifyIcon _NotifyIcon1;
        [AccessedThroughProperty("num_crisis")]
        private NumericUpDown _num_crisis;
        [AccessedThroughProperty("num_dbqtime")]
        private NumericUpDown _num_dbqtime;
        [AccessedThroughProperty("num_fdl_amh")]
        private NumericUpDown _num_fdl_amh;
        [AccessedThroughProperty("num_fdl_amm")]
        private NumericUpDown _num_fdl_amm;
        [AccessedThroughProperty("num_fdl_ddh")]
        private NumericUpDown _num_fdl_ddh;
        [AccessedThroughProperty("num_fdl_ddm")]
        private NumericUpDown _num_fdl_ddm;
        [AccessedThroughProperty("num_fdl_drh")]
        private NumericUpDown _num_fdl_drh;
        [AccessedThroughProperty("num_fdl_drm")]
        private NumericUpDown _num_fdl_drm;
        [AccessedThroughProperty("num_file")]
        private NumericUpDown _num_file;
        [AccessedThroughProperty("num_intro")]
        private NumericUpDown _num_intro;
        [AccessedThroughProperty("num_m_custom")]
        private NumericUpDown _num_m_custom;
        [AccessedThroughProperty("num_m_mc_1")]
        private NumericUpDown _num_m_mc_1;
        [AccessedThroughProperty("num_m_mc_2")]
        private NumericUpDown _num_m_mc_2;
        [AccessedThroughProperty("num_m_spl_1")]
        private NumericUpDown _num_m_spl_1;
        [AccessedThroughProperty("num_m_spl_2")]
        private NumericUpDown _num_m_spl_2;
        [AccessedThroughProperty("num_m_umc")]
        private NumericUpDown _num_m_umc;
        [AccessedThroughProperty("num_mcnumber")]
        private NumericUpDown _num_mcnumber;
        [AccessedThroughProperty("num_spl_timem")]
        private NumericUpDown _num_spl_timem;
        [AccessedThroughProperty("num_spl_times")]
        private NumericUpDown _num_spl_times;
        [AccessedThroughProperty("num_tbtime")]
        private NumericUpDown _num_tbtime;
        [AccessedThroughProperty("num_timeleft")]
        private NumericUpDown _num_timeleft;
        [AccessedThroughProperty("numhh")]
        private NumericUpDown _numhh;
        [AccessedThroughProperty("nummm")]
        private NumericUpDown _nummm;
        [AccessedThroughProperty("numstarth")]
        private NumericUpDown _numstarth;
        [AccessedThroughProperty("numstartm")]
        private NumericUpDown _numstartm;
        [AccessedThroughProperty("numtime")]
        private NumericUpDown _numtime;
        [AccessedThroughProperty("ofd_banner")]
        private OpenFileDialog _ofd_banner;
        [AccessedThroughProperty("ofd_csl")]
        private OpenFileDialog _ofd_csl;
        [AccessedThroughProperty("ofd_doc")]
        private OpenFileDialog _ofd_doc;
        [AccessedThroughProperty("ofd_sfx")]
        private OpenFileDialog _ofd_sfx;
        [AccessedThroughProperty("panel_clock")]
        private Panel _panel_clock;
        [AccessedThroughProperty("panel_csl")]
        private Panel _panel_csl;
        [AccessedThroughProperty("panel_dbq")]
        private Panel _panel_dbq;
        [AccessedThroughProperty("panel_editnationlist")]
        private Panel _panel_editnationlist;
        [AccessedThroughProperty("panel_f_1")]
        private Panel _panel_f_1;
        [AccessedThroughProperty("panel_f_2")]
        private Panel _panel_f_2;
        [AccessedThroughProperty("panel_f_3")]
        private Panel _panel_f_3;
        [AccessedThroughProperty("panel_f_4")]
        private Panel _panel_f_4;
        [AccessedThroughProperty("panel_f_5")]
        private Panel _panel_f_5;
        [AccessedThroughProperty("panel_file_1")]
        private Panel _panel_file_1;
        [AccessedThroughProperty("panel_file_2")]
        private Panel _panel_file_2;
        [AccessedThroughProperty("panel_file_bottom")]
        private Panel _panel_file_bottom;
        [AccessedThroughProperty("panel_file_top")]
        private Panel _panel_file_top;
        [AccessedThroughProperty("panel_files")]
        private Panel _panel_files;
        [AccessedThroughProperty("panel_files_3")]
        private Panel _panel_files_3;
        [AccessedThroughProperty("panel_files_4")]
        private Panel _panel_files_4;
        [AccessedThroughProperty("panel_files_5")]
        private Panel _panel_files_5;
        [AccessedThroughProperty("panel_introtask")]
        private Panel _panel_introtask;
        [AccessedThroughProperty("panel_m_1")]
        private Panel _panel_m_1;
        [AccessedThroughProperty("panel_m_2")]
        private Panel _panel_m_2;
        [AccessedThroughProperty("panel_m_3")]
        private Panel _panel_m_3;
        [AccessedThroughProperty("panel_m_4")]
        private Panel _panel_m_4;
        [AccessedThroughProperty("panel_m_5")]
        private Panel _panel_m_5;
        [AccessedThroughProperty("panel_m_6")]
        private Panel _panel_m_6;
        [AccessedThroughProperty("panel_main")]
        private Panel _panel_main;
        [AccessedThroughProperty("panel_main_screen")]
        private Panel _panel_main_screen;
        [AccessedThroughProperty("panel_main_sidebar")]
        private Panel _panel_main_sidebar;
        [AccessedThroughProperty("panel_main_title")]
        private Panel _panel_main_title;
        [AccessedThroughProperty("panel_manage")]
        private Panel _panel_manage;
        [AccessedThroughProperty("panel_mc")]
        private Panel _panel_mc;
        [AccessedThroughProperty("panel_mcedit")]
        private Panel _panel_mcedit;
        [AccessedThroughProperty("panel_misc")]
        private Panel _panel_misc;
        [AccessedThroughProperty("panel_misc_1")]
        private Panel _panel_misc_1;
        [AccessedThroughProperty("panel_misc_2")]
        private Panel _panel_misc_2;
        [AccessedThroughProperty("panel_misc_3")]
        private Panel _panel_misc_3;
        [AccessedThroughProperty("panel_misc_5")]
        private Panel _panel_misc_5;
        [AccessedThroughProperty("panel_misc_bottom")]
        private Panel _panel_misc_bottom;
        [AccessedThroughProperty("panel_misc_top")]
        private Panel _panel_misc_top;
        [AccessedThroughProperty("panel_modesel")]
        private Panel _panel_modesel;
        [AccessedThroughProperty("panel_motion")]
        private Panel _panel_motion;
        [AccessedThroughProperty("panel_motion_4")]
        private Panel _panel_motion_4;
        [AccessedThroughProperty("panel_motion_5")]
        private Panel _panel_motion_5;
        [AccessedThroughProperty("panel_motion_6")]
        private Panel _panel_motion_6;
        [AccessedThroughProperty("panel_motions_1")]
        private Panel _panel_motions_1;
        [AccessedThroughProperty("panel_motions_2")]
        private Panel _panel_motions_2;
        [AccessedThroughProperty("panel_motions_3")]
        private Panel _panel_motions_3;
        [AccessedThroughProperty("panel_motions_top")]
        private Panel _panel_motions_top;
        [AccessedThroughProperty("panel_ms_1")]
        private Panel _panel_ms_1;
        [AccessedThroughProperty("panel_ms_2")]
        private Panel _panel_ms_2;
        [AccessedThroughProperty("panel_ms_3")]
        private Panel _panel_ms_3;
        [AccessedThroughProperty("panel_ms_5")]
        private Panel _panel_ms_5;
        [AccessedThroughProperty("panel_presents")]
        private Panel _panel_presents;
        [AccessedThroughProperty("panel_readfile")]
        private Panel _panel_readfile;
        [AccessedThroughProperty("panel_selfile")]
        private Panel _panel_selfile;
        [AccessedThroughProperty("panel_sidebar_idle")]
        private Panel _panel_sidebar_idle;
        [AccessedThroughProperty("panel_sidebar_starting")]
        private Panel _panel_sidebar_starting;
        [AccessedThroughProperty("panel_sidebar_timer")]
        private Panel _panel_sidebar_timer;
        [AccessedThroughProperty("panel_signatories")]
        private Panel _panel_signatories;
        [AccessedThroughProperty("panel_singledel")]
        private Panel _panel_singledel;
        [AccessedThroughProperty("panel_spakers_list")]
        private Panel _panel_spakers_list;
        [AccessedThroughProperty("panel_sponsors")]
        private Panel _panel_sponsors;
        [AccessedThroughProperty("panel_startmethod")]
        private Panel _panel_startmethod;
        [AccessedThroughProperty("panel_system")]
        private Panel _panel_system;
        [AccessedThroughProperty("panel_title_idle")]
        private Panel _panel_title_idle;
        [AccessedThroughProperty("panel_umc")]
        private Panel _panel_umc;
        [AccessedThroughProperty("panel_velcome_new")]
        private Panel _panel_velcome_new;
        [AccessedThroughProperty("panel_vote")]
        private Panel _panel_vote;
        [AccessedThroughProperty("panel_vote_bottom")]
        private Panel _panel_vote_bottom;
        [AccessedThroughProperty("panel_vote_config")]
        private Panel _panel_vote_config;
        [AccessedThroughProperty("panel_vote_ctrl")]
        private Panel _panel_vote_ctrl;
        [AccessedThroughProperty("panel_vote_roll")]
        private Panel _panel_vote_roll;
        [AccessedThroughProperty("panel_vote_top")]
        private Panel _panel_vote_top;
        [AccessedThroughProperty("panel_welcome")]
        private Panel _panel_welcome;
        [AccessedThroughProperty("Panel1")]
        private Panel _Panel1;
        [AccessedThroughProperty("Panel2")]
        private Panel _Panel2;
        [AccessedThroughProperty("Panel3")]
        private Panel _Panel3;
        [AccessedThroughProperty("Panel4")]
        private Panel _Panel4;
        [AccessedThroughProperty("Panel5")]
        private Panel _Panel5;
        [AccessedThroughProperty("PictureBox1")]
        private PictureBox _PictureBox1;
        [AccessedThroughProperty("rad_50maj")]
        private RadioButton _rad_50maj;
        [AccessedThroughProperty("rad_67maj")]
        private RadioButton _rad_67maj;
        [AccessedThroughProperty("rad_80maj")]
        private RadioButton _rad_80maj;
        [AccessedThroughProperty("rad_all")]
        private RadioButton _rad_all;
        [AccessedThroughProperty("rad_blue")]
        private RadioButton _rad_blue;
        [AccessedThroughProperty("rad_clockno")]
        private RadioButton _rad_clockno;
        [AccessedThroughProperty("rad_clockyes")]
        private RadioButton _rad_clockyes;
        [AccessedThroughProperty("rad_continue")]
        private RadioButton _rad_continue;
        [AccessedThroughProperty("rad_create")]
        private RadioButton _rad_create;
        [AccessedThroughProperty("rad_darkred")]
        private RadioButton _rad_darkred;
        [AccessedThroughProperty("rad_green")]
        private RadioButton _rad_green;
        [AccessedThroughProperty("rad_immediatestart")]
        private RadioButton _rad_immediatestart;
        [AccessedThroughProperty("rad_load")]
        private RadioButton _rad_load;
        [AccessedThroughProperty("rad_orange")]
        private RadioButton _rad_orange;
        [AccessedThroughProperty("rad_paper")]
        private RadioButton _rad_paper;
        [AccessedThroughProperty("rad_pink")]
        private RadioButton _rad_pink;
        [AccessedThroughProperty("rad_present")]
        private RadioButton _rad_present;
        [AccessedThroughProperty("rad_purple")]
        private RadioButton _rad_purple;
        [AccessedThroughProperty("rad_select")]
        private RadioButton _rad_select;
        [AccessedThroughProperty("rad_teal")]
        private RadioButton _rad_teal;
        [AccessedThroughProperty("rad_timedstart")]
        private RadioButton _rad_timedstart;
        [AccessedThroughProperty("RadioButton4")]
        private RadioButton _RadioButton4;
        [AccessedThroughProperty("RadioButton5")]
        private RadioButton _RadioButton5;
        [AccessedThroughProperty("sfd_csl")]
        private SaveFileDialog _sfd_csl;
        [AccessedThroughProperty("TableLayoutPanel1")]
        private TableLayoutPanel _TableLayoutPanel1;
        [AccessedThroughProperty("TableLayoutPanel2")]
        private TableLayoutPanel _TableLayoutPanel2;
        [AccessedThroughProperty("TextBox1")]
        private TextBox _TextBox1;
        [AccessedThroughProperty("TextBox10")]
        private TextBox _TextBox10;
        [AccessedThroughProperty("TextBox11")]
        private TextBox _TextBox11;
        [AccessedThroughProperty("TextBox12")]
        private TextBox _TextBox12;
        [AccessedThroughProperty("TextBox13")]
        private TextBox _TextBox13;
        [AccessedThroughProperty("TextBox14")]
        private TextBox _TextBox14;
        [AccessedThroughProperty("TextBox15")]
        private TextBox _TextBox15;
        [AccessedThroughProperty("TextBox17")]
        private TextBox _TextBox17;
        [AccessedThroughProperty("TextBox2")]
        private TextBox _TextBox2;
        [AccessedThroughProperty("TextBox3")]
        private TextBox _TextBox3;
        [AccessedThroughProperty("TextBox4")]
        private TextBox _TextBox4;
        [AccessedThroughProperty("TextBox5")]
        private TextBox _TextBox5;
        [AccessedThroughProperty("Timer1")]
        private Timer _Timer1;
        [AccessedThroughProperty("tlp_manage_top")]
        private TableLayoutPanel _tlp_manage_top;
        [AccessedThroughProperty("tlp_screenlist")]
        private TableLayoutPanel _tlp_screenlist;
        [AccessedThroughProperty("tlp_taskbar")]
        private TableLayoutPanel _tlp_taskbar;
        [AccessedThroughProperty("tlp_taskbar2")]
        private TableLayoutPanel _tlp_taskbar2;
        [AccessedThroughProperty("TrackBar1")]
        private TrackBar _TrackBar1;
        [AccessedThroughProperty("txt_awardelg")]
        private TextBox _txt_awardelg;
        [AccessedThroughProperty("txt_awardnat")]
        private TextBox _txt_awardnat;
        [AccessedThroughProperty("txt_awardsch")]
        private TextBox _txt_awardsch;
        [AccessedThroughProperty("txt_custom")]
        private TextBox _txt_custom;
        [AccessedThroughProperty("txt_dbqnation")]
        private TextBox _txt_dbqnation;
        [AccessedThroughProperty("txt_fcrisis")]
        private TextBox _txt_fcrisis;
        [AccessedThroughProperty("txt_file_signatories")]
        private TextBox _txt_file_signatories;
        [AccessedThroughProperty("txt_file_sponsors")]
        private TextBox _txt_file_sponsors;
        [AccessedThroughProperty("txt_filenumber_1")]
        private TextBox _txt_filenumber_1;
        [AccessedThroughProperty("txt_filenumber_2")]
        private TextBox _txt_filenumber_2;
        [AccessedThroughProperty("txt_filenumber_3")]
        private TextBox _txt_filenumber_3;
        [AccessedThroughProperty("txt_fontpreview")]
        private TextBox _txt_fontpreview;
        [AccessedThroughProperty("txt_mainimg")]
        private TextBox _txt_mainimg;
        [AccessedThroughProperty("txt_mc_add")]
        private TextBox _txt_mc_add;
        [AccessedThroughProperty("txt_mc_current")]
        private TextBox _txt_mc_current;
        [AccessedThroughProperty("txt_mc_currentnumber")]
        private TextBox _txt_mc_currentnumber;
        [AccessedThroughProperty("txt_mc_totalnumber")]
        private TextBox _txt_mc_totalnumber;
        [AccessedThroughProperty("txt_mceditnation")]
        private TextBox _txt_mceditnation;
        [AccessedThroughProperty("txt_mnation")]
        private TextBox _txt_mnation;
        [AccessedThroughProperty("txt_mneirong")]
        private TextBox _txt_mneirong;
        [AccessedThroughProperty("txt_mtopic")]
        private TextBox _txt_mtopic;
        [AccessedThroughProperty("txt_sfx1")]
        private TextBox _txt_sfx1;
        [AccessedThroughProperty("txt_sfx2")]
        private TextBox _txt_sfx2;
        [AccessedThroughProperty("txt_sfx3")]
        private TextBox _txt_sfx3;
        [AccessedThroughProperty("txt_sfx4")]
        private TextBox _txt_sfx4;
        [AccessedThroughProperty("txt_spl_add")]
        private TextBox _txt_spl_add;
        [AccessedThroughProperty("txt_spl_current")]
        private TextBox _txt_spl_current;
        [AccessedThroughProperty("txt_spl_currentnunber")]
        private TextBox _txt_spl_currentnunber;
        [AccessedThroughProperty("txt_spl_customtitle")]
        private TextBox _txt_spl_customtitle;
        [AccessedThroughProperty("txt_spl_totalnumber")]
        private TextBox _txt_spl_totalnumber;
        [AccessedThroughProperty("txt_spl_yieldto")]
        private TextBox _txt_spl_yieldto;
        [AccessedThroughProperty("txt_startimg")]
        private TextBox _txt_startimg;
        [AccessedThroughProperty("txt_umccustom")]
        private TextBox _txt_umccustom;
        [AccessedThroughProperty("txthcmotion")]
        private TextBox _txthcmotion;
        [AccessedThroughProperty("txtnationlist")]
        private TextBox _txtnationlist;
        [AccessedThroughProperty("txtsession")]
        private TextBox _txtsession;
        [AccessedThroughProperty("WebBrowser1")]
        private WebBrowser _WebBrowser1;
        private string a1;
        private string a2;
        private int abst;
        private string awardstring;
        private int[] cabinRate;
        private DateTime cabinTime;
        private string committee;
        private IContainer components;
        private string conference;
        private bool cslAllowYield;
        private int cslCurrent;
        private bool cslEdited;
        private bool[] cslIsSpoken;
        private string[] cslNations;
        private string cslPath;
        private int[] cslTime;
        private string cslTitle;
        private int cslTotal;
        private int current;
        public Color darkcolor;
        private string dbqText;
        private string dd;
        private string fileName;
        private int flIndex;
        private string flTitle;
        private string genetext;
        private string hh;
        private string htmlpath;
        private int i;
        private int iLimit;
        private int iminute;
        private string[] infoString;
        public bool isCabinet;
        private bool isCslMode;
        private int isecond;
        private bool isInDbq;
        public bool isInMeeting;
        private bool isMainImg;
        private bool isPlay20;
        private bool isPlaysound;
        private bool isPlayStart;
        private bool isPlayUMC;
        public bool isSingelDel;
        public bool isStarted;
        private bool isTiming;
        public bool isWaiting;
        public bool isWidescr;
        private bool isYield;
        private bool isZhuijia;
        private int iTick;
        private int k;
        private int kminute;
        private int ksecond;
        private int language;
        private string lastPath;
        public Color lightcolor;
        private string line1;
        private int listCapacity;
        private int maj67vote;
        private int maxPage;
        private int mcAdd;
        private int mcAll;
        private int mcCurrent;
        private int mcIndex;
        private bool[] mcIsSpoken;
        private string[] mcNations;
        private int[] mcTime;
        private string mcTitle;
        private int mcTotal;
        public Color midcolor;
        private int miscIndex;
        private string mm;
        private string monthm;
        private string[] motionString;
        private string myBanner;
        public int myColor;
        private Font myFont;
        private string myMainImg;
        private string myPlay20;
        private string myPlaysound;
        private string myPlayStart;
        private string myPlayUMC;
        private int myrule;
        public int myVersion;
        private string[] nations;
        private int no;
        private string[] opini;
        private int p;
        private int page;
        private int[] pnat;
        private string[] presentString;
        public int presentWhenRoll;
        private int q;
        private bool r2;
        private int rate;
        private int rawrate;
        private string screen;
        public int session;
        private int slCurrent;
        private bool[] slIsSpoken;
        private string[] slNations;
        private int[] slTime;
        private int slTotal;
        private string ss;
        private string[] timer;
        private DateTime timeStart;
        public string timingStatus;
        private string[] topic;
        private int topicSelection;
        public int valuePlay20;
        private bool votePresentSaved;
        private int voteStep;
        private string[] voteString;
        private int vtCurrent;
        private int vtTotal;
        private int yes;
        private string[] yieldString;
        private int yieldType;

        public Form1()
        {
            base.FormClosing += new FormClosingEventHandler(this.exitapp);
            base.Resize += new EventHandler(this.Form1_Resize);
            base.Load += new EventHandler(this.Form1_Load);
            __ENCAddToList(this);
            this.topic = new string[2];
            this.infoString = new string[13];
            this.presentString = new string[12];
            this.timer = new string[10];
            this.cabinRate = new int[] { 1, 2, 3, 5, 10, 20, 30, 60, 120, 180, 360, 720, 0x5a0 };
            this.slTime = new int[2];
            this.slNations = new string[0xc2];
            this.yieldString = new string[6];
            this.slIsSpoken = new bool[0xc2];
            this.cslTime = new int[2];
            this.cslNations = new string[0xc2];
            this.cslIsSpoken = new bool[0xc2];
            this.motionString = new string[0x1b];
            this.mcTime = new int[2];
            this.mcNations = new string[0x2e];
            this.mcIsSpoken = new bool[0x2e];
            this.nations = new string[0x65];
            this.opini = new string[0x65];
            this.voteString = new string[9];
            this.pnat = new int[100];
            this.InitializeComponent();
        }

        [DebuggerNonUserCode]
        private static void __ENCAddToList(object value)
        {
            List<WeakReference> list = __ENCList;
            lock (list)
            {
                if (__ENCList.Count == __ENCList.Capacity)
                {
                    int index = 0;
                    int num3 = __ENCList.Count - 1;
                    for (int i = 0; i <= num3; i++)
                    {
                        WeakReference reference = __ENCList[i];
                        if (reference.IsAlive)
                        {
                            if (i != index)
                            {
                                __ENCList[index] = __ENCList[i];
                            }
                            index++;
                        }
                    }
                    __ENCList.RemoveRange(index, __ENCList.Count - index);
                    __ENCList.Capacity = __ENCList.Count;
                }
                __ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
            }
        }

        public void applyColor()
        {
            int num6;
            StreamReader reader = new StreamReader(@"config\color.txt");
            int myColor = this.myColor;
            for (int i = 1; i <= myColor; i++)
            {
                this.darkcolor = Color.FromName(reader.ReadLine());
                this.midcolor = Color.FromName(reader.ReadLine());
                this.lightcolor = Color.FromName(reader.ReadLine());
            }
            RadioButton[] buttonArray4 = new RadioButton[] { this.rad_continue, this.rad_select, this.rad_load, this.rad_create };
            Button[] buttonArray2 = new Button[] { this.Button2, this.btn_create_next, this.btn_backbrowse, this.btn_bannerbrowse, this.btn_sfx1, this.btn_sfx2, this.btn_sfx3, this.btn_sfx4 };
            Button[] buttonArray = new Button[] { this.btn_sessionstart, this.btn_speakerslist, this.btn_motions, this.btn_file, this.btn_misc, this.btn_system, this.btn_modify_presents, this.btn_dabianquan, this.btn_fileplayback, this.btn_sfxquick, this.btn_sizequick };
            Button[] buttonArray3 = new Button[] { this.btn_start_ok, this.btn_roll_finish, this.btn_enl_save, this.btn_motion_finish, this.btn_spl_exit, this.btn_file_ok, this.btn_vote_next, this.btn_ispresent, this.btn_misc_ok, this.btn_system_calcel, this.btn_dbqok, this.btn_dbqstop, this.btn_motionstop, this.btn_umc_send };
            TextBox[] boxArray2 = new TextBox[] { this.txt_spl_currentnunber, this.txt_spl_totalnumber, this.txt_spl_current, this.txt_mc_current, this.txt_mc_currentnumber, this.txt_mc_totalnumber, this.TextBox10 };
            ComboBox[] boxArray = new ComboBox[] { this.cbx_fmode, this.cbx_fselect, this.cbx_singledel, this.cbx_mfileselect, this.cbx_spl_yield, this.cbx_ftpye, this.cbx_singledel, this.cbx_fselcet_2 };
            int index = 0;
            do
            {
                if (index <= 3)
                {
                    buttonArray4[index].FlatAppearance.CheckedBackColor = this.lightcolor;
                }
                if (index <= 6)
                {
                    boxArray2[index].BackColor = this.lightcolor;
                }
                buttonArray2[index].BackColor = this.lightcolor;
                buttonArray[index].FlatAppearance.MouseDownBackColor = this.darkcolor;
                buttonArray[index].FlatAppearance.MouseOverBackColor = this.lightcolor;
                buttonArray3[index].BackColor = this.midcolor;
                index++;
                num6 = 7;
            }
            while (index <= num6);
            int num3 = 8;
            do
            {
                if (num3 <= 10)
                {
                    buttonArray[num3].FlatAppearance.MouseDownBackColor = this.darkcolor;
                    buttonArray[num3].FlatAppearance.MouseOverBackColor = this.lightcolor;
                }
                buttonArray3[num3].BackColor = this.midcolor;
                num3++;
                num6 = 13;
            }
            while (num3 <= num6);
            this.btn_entermanage.FlatAppearance.MouseDownBackColor = this.lightcolor;
            this.btn_modecancel.FlatAppearance.MouseDownBackColor = this.lightcolor;
            this.btn_prev.FlatAppearance.MouseDownBackColor = this.lightcolor;
            this.btn_next.FlatAppearance.MouseDownBackColor = this.lightcolor;
            this.btnstart.BackColor = this.darkcolor;
            this.btn_fontchange.BackColor = this.lightcolor;
            this.lbl_startmode.BackColor = this.lightcolor;
            this.panel_main_title.BackColor = this.lightcolor;
            this.lbltime.BackColor = this.midcolor;
            this.panel_main_sidebar.BackColor = this.darkcolor;
            int num4 = 0;
            do
            {
                if ((num4 % 2) == 0)
                {
                    boxArray[num4].BackColor = this.darkcolor;
                }
                else
                {
                    boxArray[num4].BackColor = this.lightcolor;
                }
                boxArray[6].BackColor = this.lightcolor;
                num4++;
                num6 = 7;
            }
            while (num4 <= num6);
            this.tlp_manage_top.BackColor = this.darkcolor;
            this.lbl_manage_about.ForeColor = this.lightcolor;
            this.lbl_manage_conferences.ForeColor = this.lightcolor;
            this.btn_manage_save.BackColor = this.darkcolor;
            this.llb_spl_entercustom.LinkColor = this.lightcolor;
            this.llb_spl_entercustom.ActiveLinkColor = this.midcolor;
            this.llb_spl_entercustom.VisitedLinkColor = this.lightcolor;
            this.chk_playback.FlatAppearance.CheckedBackColor = this.midcolor;
            this.txt_fontpreview.Font = this.myFont;
            this.lblmain.Font = this.myFont;
        }

        public void autoPage(int pag)
        {
            this.page = pag;
            if (this.panel_spakers_list.Visible)
            {
                this.renderSlist();
            }
            else if (this.panel_mc.Visible)
            {
                this.listAction("clear", 0, "");
                int mcTotal = this.mcTotal;
                for (int i = (pag * this.listCapacity) + 1; i <= mcTotal; i++)
                {
                    if (i <= ((pag * this.listCapacity) + 40))
                    {
                        this.listAction("add", (i - (pag * this.listCapacity)) - 1, this.mcNations[i]);
                    }
                }
                int mcCurrent = this.mcCurrent;
                for (int j = (pag * this.listCapacity) + 1; j <= mcCurrent; j++)
                {
                    if (j <= ((pag * this.listCapacity) + 40))
                    {
                        this.listAction("modify", (j - (pag * this.listCapacity)) - 1, "");
                    }
                }
            }
            else if (this.panel_vote.Visible)
            {
                this.listAction("clear", 0, "");
                this.voteAction(0, 0);
                int vtTotal = this.vtTotal;
                for (int k = (pag * this.listCapacity) + 1; k <= vtTotal; k++)
                {
                    if (k <= ((pag * this.listCapacity) + 40))
                    {
                        this.listAction("add", (k - (pag * this.listCapacity)) - 1, this.nations[k]);
                    }
                }
                int vtCurrent = this.vtCurrent;
                for (int m = (pag * this.listCapacity) + 1; m <= vtCurrent; m++)
                {
                    if (m <= ((pag * this.listCapacity) + 40))
                    {
                        this.voteAction(this.opinion1(this.opini[m]), (m - (pag * this.listCapacity)) - 1);
                    }
                }
            }
        }

        private void btn_bannerbrowse_Click(object sender, EventArgs e)
        {
            this.ofd_banner.Title = "选择起始界面图片";
            if (this.ofd_banner.ShowDialog() != DialogResult.Cancel)
            {
                this.txt_startimg.Text = this.ofd_banner.FileName;
                this.txt_startimg.BackColor = Color.White;
            }
        }

        private void btn_create_back_Click(object sender, EventArgs e)
        {
            this.Panel3.Height += this.panel_velcome_new.Height - this.Panel2.Top;
        }

        private void btn_create_next_Click(object sender, EventArgs e)
        {
            this.Panel3.Height -= this.panel_velcome_new.Height - this.Panel2.Top;
        }

        private void btn_dabianquan_Click(object sender, EventArgs e)
        {
            this.panel_dbq.Visible = true;
            this.lbl_dbqstatus.Text = "会议状态: 空闲";
            switch (this.timingStatus)
            {
                case "SL":
                    this.panel_spakers_list.Visible = false;
                    this.tlp_taskbar.Enabled = false;
                    this.lbl_dbqstatus.Text = "会议状态: \r\n" + this.slNations[this.slCurrent] + "在主发言名单中发言";
                    break;

                case "MC":
                    this.panel_mc.Visible = false;
                    this.lbl_dbqstatus.Text = "会议状态: \r\n" + this.mcNations[this.mcCurrent - 1] + "在有主持核心磋商中发言";
                    break;
            }
        }

        private void btn_dbqcancel_Click(object sender, EventArgs e)
        {
            this.dbqClose();
        }

        private void btn_dbqok_Click(object sender, EventArgs e)
        {
            this.dbqText = this.txt_dbqnation.Text + "代表";
            switch (this.timingStatus)
            {
                case "SL":
                    this.dbqText = this.dbqText + "针对" + this.slNations[this.slCurrent] + "的发言";
                    break;

                case "MC":
                    this.dbqText = this.dbqText + "针对" + this.mcNations[this.mcCurrent - 1] + "的发言";
                    break;
            }
            this.dbqText = this.dbqText + "申请答辩权";
            this.lblmain.Text = this.dbqText;
            if (Interaction.MsgBox("是否通过？", MsgBoxStyle.Question | MsgBoxStyle.YesNo, "答辩权") == MsgBoxResult.Yes)
            {
                this.isInDbq = true;
                if (this.timingStatus == "MC")
                {
                    this.mcTime[0] = this.k;
                    this.mcTime[1] = this.i;
                }
                this.k = Convert.ToInt32(decimal.Multiply(this.num_dbqtime.Value, 60M));
                this.i = Convert.ToInt32(decimal.Multiply(this.num_dbqtime.Value, 60M));
                this.isTiming = true;
                this.btn_dbqstop.Visible = true;
                this.txt_dbqnation.Enabled = false;
                this.num_dbqtime.Enabled = false;
            }
            else
            {
                this.lblmain.Text = this.lblmain.Text + "\r\n未获通过";
                this.txthcmotion.Text = this.lblmain.Text;
                this.dbqClose();
            }
        }

        private void btn_dbqstop_Click(object sender, EventArgs e)
        {
            this.isInDbq = false;
            if (this.timingStatus == "MC")
            {
                this.k = this.mcTime[0];
                this.i = this.mcTime[1];
            }
            this.isTiming = false;
            this.btn_dbqstop.Visible = false;
            this.txt_dbqnation.Enabled = true;
            this.num_dbqtime.Enabled = true;
            this.dbqClose();
        }

        private void btn_enl_cancel_Click(object sender, EventArgs e)
        {
            this.tlp_taskbar.Enabled = true;
            this.btn_system.BackColor = Color.White;
            this.panel_editnationlist.Visible = false;
        }

        private void btn_enl_save_Click(object sender, EventArgs e)
        {
            if (this.txtnationlist.Text != "")
            {
                StreamWriter writer = new StreamWriter(@"saved\" + this.lastPath + @"\nationlist.txt");
                writer.Write(this.txtnationlist.Text);
                writer.Close();
                writer.Dispose();
                StreamWriter writer2 = new StreamWriter(@"saved\" + this.lastPath + @"\nationlist_p.txt");
                writer2.Write("");
                writer2.Close();
                writer2.Dispose();
                this.tlp_taskbar.Enabled = true;
                this.btn_system.BackColor = Color.White;
                this.panel_editnationlist.Visible = false;
            }
        }

        private void btn_entermanage_Click(object sender, EventArgs e)
        {
            this.btnstart.Visible = true;
            this.lbl_startmode.BackColor = this.lightcolor;
            this.lbl_startmode.ForeColor = Color.Black;
            this.panel_modesel.Height = this.lbl_startmode.Height;
            this.panel_welcome.Visible = false;
            this.panel_main.Visible = false;
            this.panel_manage.Visible = true;
            if (this.isInMeeting)
            {
                this.btn_manage_exit.Text = "返回会议";
            }
            else
            {
                this.btn_manage_exit.Text = "返回首页";
            }
            this.txt_startimg.Text = this.myBanner;
            RadioButton[] buttonArray = new RadioButton[] { this.rad_darkred, this.rad_orange, this.rad_green, this.rad_teal, this.rad_blue, this.rad_purple, this.rad_pink };
            buttonArray[this.myColor - 1].Checked = true;
            buttonArray[this.myColor - 1].Image = Image.FromFile(@"ui\colorsel_selected.png");
            this.chk_is_mainimg.Checked = this.isMainImg;
            this.txt_mainimg.Text = this.myMainImg;
            this.chk_sfx_timeout.Checked = this.isPlaysound;
            this.txt_sfx1.Text = this.myPlaysound;
            this.chk_sfx_time20.Checked = this.isPlay20;
            this.txt_sfx2.Text = this.myPlay20;
            this.num_timeleft.Value = new decimal(this.valuePlay20);
            this.chk_sfx_time60.Checked = this.isPlayUMC;
            this.txt_sfx3.Text = this.myPlayUMC;
            this.chk_sfx_start.Checked = this.isPlayStart;
            this.txt_sfx4.Text = this.myPlayStart;
        }

        private void btn_file_1_Click(object sender, EventArgs e)
        {
            int num2;
            Button[] buttonArray = new Button[] { this.btn_file_1, this.btn_file_2, this.btn_files_3, this.btn_files_4, this.btn_files_5 };
            int index = 0;
            do
            {
                if (sender.Equals(buttonArray[index]))
                {
                    break;
                }
                index++;
                num2 = 4;
            }
            while (index <= num2);
            if (buttonArray[index].BackColor == this.midcolor)
            {
                index = 0;
            }
            else
            {
                this.flTitle = buttonArray[index].Text;
                index++;
            }
            PanelsExpanding.flExpand(index);
            this.flIndex = index;
        }

        private void btn_file_browse_Click(object sender, EventArgs e)
        {
            this.ofd_doc.Title = "选择文档";
            this.ofd_doc.Filter = "Microsoft Word Document (*.doc;*.docx)|*.doc;*.docx";
            if (this.ofd_doc.ShowDialog() != DialogResult.Cancel)
            {
                this.lbl_filepath.Text = this.ofd_doc.FileName;
            }
        }

        private void btn_file_cancel_Click(object sender, EventArgs e)
        {
            PanelsExpanding.flExpand(0);
            this.txt_fcrisis.Text = "";
            this.panel_files.Visible = false;
            PanelsExpanding.unlockTaskbar();
        }

        private void btn_file_Click(object sender, EventArgs e)
        {
            PanelsExpanding.taskbarUnslect();
            this.panel_files.Visible = true;
            this.txt_filenumber_1.Text = Conversions.ToString(this.session);
            this.btn_file.ForeColor = Color.White;
            this.btn_file.BackColor = this.darkcolor;
            this.cbx_ftpye.SelectedIndex = 0;
            PanelsExpanding.flExpand(0);
            this.cbx_fselect.Items.Clear();
            this.cbx_fselcet_2.Items.Clear();
            StreamReader reader = new StreamReader(@"saved\" + this.lastPath + @"\files.txt");
            try
            {
                while (reader != null)
                {
                    string item = reader.ReadLine();
                    this.cbx_fselect.Items.Add(item);
                    this.cbx_fselcet_2.Items.Add(item);
                }
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                ProjectData.ClearProjectError();
            }
            reader.Close();
            try
            {
                this.cbx_fselect.SelectedIndex = 0;
                this.cbx_fselcet_2.SelectedIndex = 0;
            }
            catch (Exception exception3)
            {
                ProjectData.SetProjectError(exception3);
                Exception exception2 = exception3;
                ProjectData.ClearProjectError();
            }
        }

        [MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
        private void btn_file_modify_Click(object sender, EventArgs e)
        {
            this.ofd_doc.Title = "选择要回显的文件";
            this.ofd_doc.Filter = "HTML 文档 (*.htm;*.html)|*.htm;*.html";
            this.ofd_doc.InitialDirectory = MyProject.Application.Info.DirectoryPath + @"\html";
            if (this.ofd_doc.ShowDialog() != DialogResult.Cancel)
            {
                this.lbl_fileinfo.Text = this.ofd_doc.FileName;
                this.WebBrowser1.Url = new Uri(this.ofd_doc.FileName);
                this.chk_playback.Enabled = true;
                PanelsExpanding.readPaneHeight(true);
            }
        }

        [MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
        private void btn_file_ok_Click(object sender, EventArgs e)
        {
            bool flag;
            int num;
            switch (this.flIndex)
            {
                case 1:
                case 2:
                {
                    if (this.flIndex != 1)
                    {
                        if (this.cbx_fselect.Text != "")
                        {
                            flag = true;
                        }
                        if (flag)
                        {
                            if (this.language == 1)
                            {
                                this.screen = "介绍" + this.cbx_fselect.Text;
                                if (this.txt_file_sponsors.Text != "")
                                {
                                    this.screen = this.screen + "\r\n发言的国家: " + this.txt_file_sponsors.Text;
                                }
                                this.screen = this.screen + "\r\n时间:" + Conversion.Str(this.num_intro.Value) + "分钟";
                            }
                            else
                            {
                                this.screen = "Introduction of " + this.cbx_fselect.Text;
                                if (this.txt_file_sponsors.Text != "")
                                {
                                    this.screen = this.screen + "\r\nNations coming up speech: " + this.txt_file_sponsors.Text;
                                }
                                this.screen = this.screen + "\r\nTime:" + Conversion.Str(this.num_intro.Value) + " minutes";
                            }
                            if (this.htmlpath != "")
                            {
                                this.lbl_fileinfo.Text = this.htmlpath;
                                this.chk_playback.Enabled = true;
                            }
                            else
                            {
                                this.lbl_fileinfo.Text = "没有选择展示的文件，详见使用说明";
                                this.chk_playback.Enabled = false;
                            }
                            this.lbl_reading.Text = "正在介绍: " + this.fileName;
                            PanelsExpanding.readPaneHeight(true);
                            this.panel_readfile.Visible = true;
                            this.timingStatus = "FS";
                            num = Convert.ToInt32(this.num_intro.Value);
                        }
                        goto Label_0716;
                    }
                    if ((this.cbx_ftpye.Text != "") & (this.txt_filenumber_2.Text != ""))
                    {
                        flag = true;
                    }
                    if (!flag)
                    {
                        goto Label_0716;
                    }
                    this.create();
                    StreamWriter writer = new StreamWriter(@"saved\" + this.lastPath + @"\files.txt", true);
                    writer.WriteLine(this.fileName);
                    writer.Close();
                    if (this.language != 1)
                    {
                        this.screen = "read " + this.fileName;
                        if (this.txt_file_sponsors.Text != "")
                        {
                            this.screen = this.screen + "\r\nSponsors: " + this.txt_file_sponsors.Text;
                        }
                        if (this.txt_file_signatories.Text != "")
                        {
                            this.screen = this.screen + "\r\nSignatories: " + this.txt_file_signatories.Text;
                        }
                        this.screen = this.screen + "\r\nReading time:" + Conversion.Str(this.num_file.Value) + " minutes";
                        this.lblmain.Text = "Please " + this.screen;
                        break;
                    }
                    this.screen = "阅读" + this.fileName;
                    if (this.txt_file_sponsors.Text != "")
                    {
                        this.screen = this.screen + "\r\n起草国: " + this.txt_file_sponsors.Text;
                    }
                    if (this.txt_file_signatories.Text != "")
                    {
                        this.screen = this.screen + "\r\n附议国: " + this.txt_file_signatories.Text;
                    }
                    this.screen = this.screen + "\r\n阅读时间:" + Conversion.Str(this.num_file.Value) + "分钟";
                    this.lblmain.Text = "请" + this.screen;
                    break;
                }
                case 3:
                    this.Votestart(false);
                    return;

                case 4:
                    this.k = 0;
                    this.i = 0;
                    this.numtime.Enabled = false;
                    this.numtime.Value = decimal.Multiply(this.num_crisis.Value, 60M);
                    this.i = Convert.ToInt32(decimal.Multiply(this.num_crisis.Value, 60M));
                    this.k = Convert.ToInt32(decimal.Multiply(this.num_crisis.Value, 60M));
                    this.timingStatus = "CR";
                    this.isTiming = true;
                    if (this.language != 1)
                    {
                        this.screen = "Crisis (Reading time: " + this.num_crisis.Text + " minutes)";
                    }
                    else
                    {
                        this.screen = "阅读危机 (" + this.num_crisis.Text + "分钟)";
                    }
                    if (this.txt_fcrisis.Text != "")
                    {
                        this.screen = this.screen + "\r\n" + this.txt_fcrisis.Text;
                    }
                    this.lblmain.Text = this.screen;
                    this.txthcmotion.Text = this.lblmain.Text;
                    this.Button4.Text = "关闭";
                    this.panel_files.Visible = false;
                    this.panel_sidebar_timer.Visible = true;
                    return;

                case 5:
                    string str;
                    string str2;
                    this.screen = "";
                    if (this.chk_filedl_dr.Checked)
                    {
                        str = Conversions.ToString(this.num_fdl_drh.Value);
                        str2 = Conversions.ToString(this.num_fdl_drm.Value);
                        if (decimal.Compare(this.num_fdl_drm.Value, 10M) < 0)
                        {
                            str2 = "0" + str2;
                        }
                        this.screen = this.screen + this.infoString[9] + str + ":" + str2 + "\r\n";
                    }
                    if (this.chk_filedl_am.Checked)
                    {
                        str = Conversions.ToString(this.num_fdl_amh.Value);
                        str2 = Conversions.ToString(this.num_fdl_amm.Value);
                        if (decimal.Compare(this.num_fdl_amm.Value, 10M) < 0)
                        {
                            str2 = "0" + str2;
                        }
                        this.screen = this.screen + this.infoString[10] + str + ":" + str2 + "\r\n";
                    }
                    if (this.chk_filedl_dd.Checked)
                    {
                        str = Conversions.ToString(this.num_fdl_ddh.Value);
                        str2 = Conversions.ToString(this.num_fdl_ddm.Value);
                        if (decimal.Compare(this.num_fdl_ddm.Value, 10M) < 0)
                        {
                            str2 = "0" + str2;
                        }
                        this.screen = this.screen + this.infoString[11] + str + ":" + str2 + "\r\n";
                    }
                    if (this.screen != "")
                    {
                        this.screen = this.screen + this.infoString[12];
                        this.lblmain.Text = this.screen;
                        this.txthcmotion.Text = this.lblmain.Text;
                        this.panel_files.Visible = false;
                        PanelsExpanding.taskbarUnslect();
                    }
                    return;

                default:
                    return;
            }
            if (this.rad_present.Checked)
            {
                this.htmlpath = MyProject.Application.Info.DirectoryPath + @"\html\" + this.lastPath + "_" + this.fileName + ".html";
                if (this.lbl_filepath.Text == "")
                {
                    Interaction.MsgBox("请选择文件！", MsgBoxStyle.Exclamation, this.btn_file_1.Text);
                    return;
                }
                loadword.ConvertFileWordToHtml(this.lbl_filepath.Text, this.htmlpath);
                this.WebBrowser1.Url = new Uri(this.htmlpath);
                this.chk_playback.Checked = true;
                this.lbl_fileinfo.Text = this.lbl_filepath.Text;
                this.lbl_filepath.Text = "";
            }
            else
            {
                this.chk_playback.Checked = false;
                this.htmlpath = "";
                if (this.txt_file_sponsors.Text == "")
                {
                    this.lbl_fileinfo.Text = "起草国: 未填";
                }
                else
                {
                    this.lbl_fileinfo.Text = "起草国: " + this.txt_file_sponsors.Text;
                }
                if (this.panel_signatories.Visible)
                {
                    if (this.txt_file_sponsors.Text == "")
                    {
                        this.lbl_fileinfo.Text = this.lbl_fileinfo.Text + "\r\n附议国: 未填";
                    }
                    else
                    {
                        this.lbl_fileinfo.Text = this.lbl_fileinfo.Text + "\r\n附议国: " + this.txt_file_signatories.Text;
                    }
                }
            }
            this.lbl_reading.Text = "正在阅读: " + this.fileName;
            PanelsExpanding.readPaneHeight(false);
            this.panel_readfile.Visible = true;
            this.timingStatus = "FI";
            num = Convert.ToInt32(this.num_file.Value);
        Label_0716:
            if (flag)
            {
                this.i = 0;
                this.k = 0;
                this.numtime.Enabled = false;
                this.numtime.Value = new decimal(num * 60);
                this.i = num * 60;
                this.k = num * 60;
                this.txthcmotion.Text = this.screen;
                this.Button4.Text = "关闭";
                this.panel_files.Visible = false;
                this.panel_sidebar_timer.Visible = true;
                this.isTiming = true;
            }
            else
            {
                this.playTone();
            }
        }

        private void btn_fontchange_Click(object sender, EventArgs e)
        {
            if (this.FontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                this.txt_fontpreview.Font = this.FontDialog1.Font;
            }
        }

        private void btn_ispresent_Click(object sender, EventArgs e)
        {
            if (this.btn_ispresent.Text == "Yes")
            {
                this.btn_ispresent.Text = "No";
                this.clb_nation_main.SetItemChecked(this.cbx_singledel.SelectedIndex, false);
            }
            else
            {
                this.btn_ispresent.Text = "Yes";
                this.clb_nation_main.SetItemChecked(this.cbx_singledel.SelectedIndex, true);
            }
            if (Conversion.Val(this.lblpresent.Text) < (this.presentWhenRoll * 0.8))
            {
                Interaction.MsgBox("由于出席国家数已少于点名时出席数量(" + this.presentWhenRoll.ToString() + ")的80%，会议无法继续进行。", MsgBoxStyle.Information, "单代表离席控制");
                this.panel_motion.Visible = false;
                this.panel_sidebar_starting.Visible = true;
                this.btn_motions.BackColor = Color.White;
                this.btn_motions.ForeColor = Color.Black;
                this.btn_sessionstart.BackColor = this.darkcolor;
                this.btn_sessionstart.ForeColor = Color.White;
                this.tlp_taskbar.Enabled = false;
            }
        }

        private void btn_manage_exit_Click(object sender, EventArgs e)
        {
            this.manageExit();
        }

        private void btn_manage_save_Click(object sender, EventArgs e)
        {
            this.myBanner = this.txt_startimg.Text;
            this.myMainImg = this.txt_mainimg.Text;
            this.myPlaysound = this.txt_sfx1.Text;
            this.myPlay20 = this.txt_sfx2.Text;
            this.myPlayUMC = this.txt_sfx3.Text;
            this.myPlayStart = this.txt_sfx4.Text;
            this.valuePlay20 = Convert.ToInt32(this.num_timeleft.Value);
            this.myFont = this.txt_fontpreview.Font;
            this.setsave1();
            this.applyColor();
            this.PictureBox1.Image = Image.FromFile(this.myBanner);
            this.manageExit();
        }

        private void btn_mc_add_Click(object sender, EventArgs e)
        {
            this.mcNationAdd();
        }

        private void btn_mc_end_Click(object sender, EventArgs e)
        {
            this.mcEnd();
        }

        private void btn_mc_next_Click(object sender, EventArgs e)
        {
            this.mcnext();
        }

        private void btn_mc_start_Click(object sender, EventArgs e)
        {
            this.i = Convert.ToInt32(this.numtime.Value);
            this.Label33.Text = "停止发言请点击\"下一个\"";
            this.isTiming = true;
            this.Button3.Text = "暂停";
            this.btn_mc_start.Enabled = false;
            this.btn_mc_next.Visible = true;
            this.txt_mc_add.Enabled = false;
            this.btn_mc_add.Enabled = false;
            this.btn_mc_next.Focus();
            this.timeDisp();
        }

        private void btn_mcedit_cancle_Click(object sender, EventArgs e)
        {
            this.panel_mcedit.Visible = false;
            this.num_mcnumber.Value = decimal.Zero;
        }

        private void btn_mcedit_save_Click(object sender, EventArgs e)
        {
            Label[] labelArray = new Label[] { 
                this.lbl_slist_1, this.Label36, this.Label39, this.Label40, this.Label41, this.Label42, this.Label43, this.Label44, this.Label45, this.Label46, this.Label37, this.Label52, this.Label53, this.Label54, this.Label56, this.Label55, 
                this.Label57, this.Label58, this.Label59, this.Label60, this.Label38, this.Label66, this.Label67, this.Label68, this.Label69, this.Label70, this.Label71, this.Label72, this.Label73, this.Label74, this.Label80, this.Label81, 
                this.Label82, this.Label83, this.Label84, this.Label85, this.Label86, this.Label87, this.Label88, this.Label89
             };
            this.mcNations[Convert.ToInt32(this.num_mcnumber.Value)] = this.txt_mceditnation.Text;
            this.listAction("add", Convert.ToInt32(decimal.Subtract(this.num_mcnumber.Value, decimal.One)), this.txt_mceditnation.Text);
            this.panel_mcedit.Visible = false;
            this.num_mcnumber.Value = decimal.Zero;
        }

        private void btn_misc_4_Click(object sender, EventArgs e)
        {
            this.panel_dbq.Visible = true;
            PanelsExpanding.miscCollapse(0);
            this.panel_misc.Visible = false;
        }

        private void btn_misc_Click(object sender, EventArgs e)
        {
            PanelsExpanding.taskbarUnslect();
            this.panel_misc.Visible = true;
            this.btn_misc.ForeColor = Color.White;
            this.btn_misc.BackColor = this.darkcolor;
        }

        private void btn_motion_1_Click(object sender, EventArgs e)
        {
            int num2;
            Button[] buttonArray = new Button[] { this.btn_motion_1, this.btn_motion_2, this.btn_motion_3, this.btn_motion_4, this.btn_motion_5, this.btn_motion_6, this.btn_motion_7, this.btn_motion_8, this.btn_motion_9 };
            int index = 0;
            do
            {
                if (sender.Equals(buttonArray[index]))
                {
                    break;
                }
                index++;
                num2 = 8;
            }
            while (index <= num2);
            if (buttonArray[index].BackColor == this.midcolor)
            {
                index = 0;
            }
            else
            {
                this.mcTitle = buttonArray[index].Text;
                index++;
            }
            PanelsExpanding.mcExpand(index);
            this.mcIndex = index;
        }

        private void btn_motion_cancel_Click(object sender, EventArgs e)
        {
            this.motionClose();
        }

        private void btn_motion_finish_Click(object sender, EventArgs e)
        {
            string str;
            if (this.txt_mnation.Text == "")
            {
                return;
            }
            switch (this.mcIndex)
            {
                case 1:
                    this.mm = Conversions.ToString(this.num_m_mc_1.Value);
                    this.ss = Conversions.ToString(this.num_m_mc_2.Value);
                    str = this.txt_mnation.Text + this.motionString[4] + "\r\n" + this.motionString[5] + this.txt_mtopic.Text + "\r\n" + this.motionString[6] + this.mm + this.motionString[7] + this.ss + this.motionString[8];
                    goto Label_03B8;

                case 2:
                    str = Conversions.ToString(this.num_m_umc.Value);
                    str = this.txt_mnation.Text + this.motionString[9] + "\r\n" + this.motionString[6] + str + this.motionString[10];
                    goto Label_03B8;

                case 3:
                    this.mm = Conversions.ToString(this.num_m_spl_1.Value);
                    this.ss = Conversions.ToString(this.num_m_spl_2.Value);
                    str = this.txt_mnation.Text + this.motionString[11] + this.mm;
                    if (decimal.Compare(this.num_m_spl_2.Value, decimal.Zero) != 0)
                    {
                        str = str + this.motionString[12] + this.ss + this.motionString[13];
                    }
                    else
                    {
                        str = str + this.motionString[10];
                    }
                    goto Label_03B8;

                case 4:
                    str = Conversions.ToString(Operators.AddObject(Operators.AddObject((this.txt_mnation.Text + this.motionString[0x18]) + "\r\n" + this.motionString[0x19], this.cbx_mfileselect.SelectedItem), this.motionString[0x1a]));
                    goto Label_03B8;

                case 5:
                    str = Conversions.ToString(Operators.AddObject(Operators.AddObject(this.txt_mnation.Text + this.motionString[14], this.cbx_mfileselect.SelectedItem), this.motionString[15]));
                    goto Label_03B8;

                case 6:
                    str = this.txt_mnation.Text + this.motionString[0x10];
                    goto Label_03B8;

                case 7:
                    str = this.txt_mnation.Text + this.motionString[0x11];
                    goto Label_03B8;

                case 8:
                    str = this.txt_mnation.Text + this.motionString[0x12];
                    goto Label_03B8;

                case 9:
                    if (!this.chk_istimeruse.Checked)
                    {
                        str = "";
                        break;
                    }
                    str = Conversions.ToString(this.num_m_custom.Value);
                    str = "\r\n" + this.motionString[6] + str + this.motionString[10];
                    break;

                default:
                    str = "";
                    goto Label_03B8;
            }
            str = this.txt_mnation.Text + this.motionString[0x13] + this.txt_mneirong.Text + str;
        Label_03B8:
            this.lblmain.Text = str;
            if (Interaction.MsgBox(this.motionString[0], MsgBoxStyle.Question | MsgBoxStyle.YesNo, this.mcTitle) == MsgBoxResult.No)
            {
                str = str + "\r\n" + this.motionString[3];
                this.lblmain.Text = str;
                this.txthcmotion.Text = str;
                this.motionClose();
            }
            else if (Interaction.MsgBox(this.motionString[1] + "\r\n" + this.motionString[2], MsgBoxStyle.Question | MsgBoxStyle.YesNo, this.mcTitle) == MsgBoxResult.No)
            {
                str = str + "\r\n" + this.motionString[3];
                this.lblmain.Text = str;
                this.txthcmotion.Text = str;
                this.motionClose();
            }
            else
            {
                switch (this.mcIndex)
                {
                    case 1:
                        this.numtime.Value = this.num_m_mc_2.Value;
                        this.numtime.Enabled = false;
                        this.txthcmotion.Text = str;
                        this.panel_motion.Visible = false;
                        this.panel_sidebar_timer.Visible = true;
                        this.tlp_taskbar.Enabled = false;
                        this.panel_mc.Visible = true;
                        this.k = Convert.ToInt32(decimal.Multiply(this.num_m_mc_1.Value, 60M));
                        this.i = Convert.ToInt32(this.num_m_mc_2.Value);
                        this.timingStatus = "MC";
                        this.mcTimeDisp(Convert.ToInt32(this.num_m_mc_1.Value), 0);
                        this.maxPages();
                        this.Button3.Enabled = false;
                        this.Button4.Enabled = false;
                        this.mcReady();
                        this.txt_mc_add.Text = this.txt_mnation.Text;
                        this.txt_mnation.Text = "";
                        break;

                    case 2:
                    case 6:
                    {
                        if (this.mcIndex != 2)
                        {
                            this.Label100.Text = "茶歇进行中";
                            this.timingStatus = "TB";
                            str = Conversions.ToString(this.num_m_umc.Value);
                            str = this.txt_mnation.Text + this.motionString[0x10] + "\r\n" + this.motionString[20] + str + this.motionString[10] + ")";
                        }
                        else
                        {
                            this.Label100.Text = "自由磋商进行中";
                            this.timingStatus = "UMC";
                        }
                        this.numtime.Value = decimal.Multiply(this.num_m_umc.Value, 60M);
                        this.numtime.Enabled = false;
                        this.txthcmotion.Text = str;
                        this.txt_mnation.Text = "";
                        this.panel_motion.Visible = false;
                        this.panel_umc.Visible = true;
                        this.panel_sidebar_timer.Visible = true;
                        this.tlp_taskbar.Enabled = false;
                        this.k = Convert.ToInt32(this.numtime.Value);
                        this.i = Convert.ToInt32(this.numtime.Value);
                        this.isTiming = true;
                        DateTime time = DateAndTime.Now.AddSeconds((double) this.k);
                        this.Label101.Text = "预计结束时间: \r\n" + Conversions.ToString(time);
                        this.btn_umc_close.Visible = false;
                        return;
                    }
                    case 3:
                        this.loadSlist();
                        this.slTime[1] = Convert.ToInt32(this.num_m_spl_1.Value);
                        this.slTime[0] = Convert.ToInt32(this.num_m_spl_2.Value);
                        this.saveSlist();
                        this.txthcmotion.Text = str;
                        this.motionClose();
                        break;

                    case 4:
                        this.txthcmotion.Text = str;
                        this.motionClose();
                        break;

                    case 5:
                        this.txthcmotion.Text = str;
                        this.Votestart(true);
                        break;

                    case 7:
                    case 8:
                        if (this.mcIndex != 7)
                        {
                            str = Conversions.ToString(this.session);
                            str = this.txt_mnation.Text + this.motionString[0x12] + "\r\n" + this.motionString[0x16] + str + this.motionString[0x17];
                            this.isStarted = false;
                            this.lblopic.Text = this.topic[this.topicSelection];
                            this.txtsession.Enabled = true;
                            this.panel_startmethod.Enabled = true;
                            this.txtsession.Text = "";
                            this.lblmain.Text = str;
                            this.txthcmotion.Text = str;
                            this.motionClose();
                            if (Interaction.MsgBox("是否清除出席信息？", MsgBoxStyle.Question | MsgBoxStyle.YesNo, this.mcTitle) == MsgBoxResult.Yes)
                            {
                                StreamWriter writer = new StreamWriter(@"saved\" + this.lastPath + @"\nationlist_p.txt");
                                writer.Write("");
                                writer.Close();
                                writer.Dispose();
                            }
                            break;
                        }
                        str = str + "\r\n" + this.motionString[0x15];
                        this.lblmain.Text = str;
                        this.txthcmotion.Text = str;
                        this.motionClose();
                        break;

                    case 9:
                        this.txthcmotion.Text = str;
                        if (!this.chk_istimeruse.Checked)
                        {
                            this.motionClose();
                            break;
                        }
                        this.numtime.Value = decimal.Multiply(this.num_m_custom.Value, 60M);
                        this.numtime.Enabled = false;
                        this.panel_sidebar_timer.Visible = true;
                        this.tlp_taskbar.Enabled = false;
                        this.k = Convert.ToInt32(this.numtime.Value);
                        this.i = Convert.ToInt32(this.numtime.Value);
                        this.isTiming = true;
                        this.btn_motionstop.Visible = true;
                        this.panel_singledel.Visible = false;
                        this.btn_motion_finish.Visible = false;
                        break;
                }
            }
        }

        private void btn_motions_Click(object sender, EventArgs e)
        {
            PanelsExpanding.taskbarUnslect();
            this.panel_motion.Visible = true;
            this.btn_motions.ForeColor = Color.White;
            this.btn_motions.BackColor = this.darkcolor;
            this.mcIndex = 0;
            this.cbx_mfileselect.Items.Clear();
            StreamReader reader = new StreamReader(@"saved\" + this.lastPath + @"\files.txt");
            try
            {
                while (reader != null)
                {
                    this.cbx_mfileselect.Items.Add(reader.ReadLine());
                }
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                ProjectData.ClearProjectError();
            }
            reader.Close();
            try
            {
                this.cbx_mfileselect.SelectedIndex = 0;
            }
            catch (Exception exception3)
            {
                ProjectData.SetProjectError(exception3);
                Exception exception2 = exception3;
                ProjectData.ClearProjectError();
            }
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            this.pageAction(true);
        }

        private void btn_roll_finish_Click(object sender, EventArgs e)
        {
            int num;
            int num4;
            TextBox[] boxArray = new TextBox[] { this.txt_spl_add, this.txt_mc_add, this.txt_mnation, this.txt_spl_yieldto, this.txt_dbqnation };
            int index = 0;
            do
            {
                boxArray[index].AutoCompleteCustomSource.Clear();
                index++;
                num4 = 4;
            }
            while (index <= num4);
            StreamWriter writer = new StreamWriter(@"saved\" + this.lastPath + @"\nationlist_p.txt");
            while (num < this.clb_nation_main.Items.Count)
            {
                writer.WriteLine(this.clb_nation_main.GetItemChecked(num));
                if (this.clb_nation_main.GetItemChecked(num))
                {
                    this.clb_nation_main.SetSelected(num, true);
                    string str2 = Conversions.ToString(this.clb_nation_main.SelectedItem);
                    int num3 = 0;
                    do
                    {
                        boxArray[num3].AutoCompleteCustomSource.Add(str2);
                        num3++;
                        num4 = 4;
                    }
                    while (num3 <= num4);
                }
                num++;
            }
            writer.Close();
            if (!this.isStarted)
            {
                string str;
                if (this.language == 1)
                {
                    str = "本次会议实际有" + this.lblpresent.Text + "国家出席\r\n简单多数为" + this.lbl50maj.Text + "\r\n三分之二多数为" + this.lbl67maj.Text + "\r\n20%国家数为" + this.lbl20maj.Text;
                }
                else
                {
                    str = "" + this.lblpresent.Text + " nations present in the conference\r\nSimple majority: " + this.lbl50maj.Text + "\r\n2/3 majority: " + this.lbl67maj.Text + "\r\n20% count of nations: " + this.lbl20maj.Text;
                }
                this.isStarted = true;
                this.lblmain.Text = str;
                this.txthcmotion.Text = str;
                this.presentWhenRoll = (int) Math.Round(Conversion.Val(this.lblpresent.Text));
                PanelsExpanding.unlockTaskbar();
            }
            else if (Conversion.Val(this.lblpresent.Text) < (this.presentWhenRoll * 0.8))
            {
                Interaction.MsgBox("出席情况更新成功，但由于出席数少于点名时出席数量(" + this.presentWhenRoll.ToString() + ")的80%，会议无法继续进行。", MsgBoxStyle.Critical, "点名");
                this.tlp_taskbar.Enabled = false;
            }
            else if (this.timingStatus == "MC")
            {
                this.panel_sidebar_starting.Visible = false;
                this.panel_mc.Visible = true;
                this.panel_sidebar_timer.Visible = true;
            }
            else
            {
                PanelsExpanding.unlockTaskbar();
            }
        }

        private void btn_sessionstart_Click(object sender, EventArgs e)
        {
            switch (this.timingStatus)
            {
                case "SL":
                case "":
                    PanelsExpanding.taskbarUnslect();
                    this.panel_sidebar_starting.Visible = true;
                    this.btn_sessionstart.ForeColor = Color.White;
                    this.btn_sessionstart.BackColor = this.darkcolor;
                    if (this.isStarted)
                    {
                        this.btn_roll_finish.Left = 0x6a;
                        this.btn_roll_finish.Width = 0x6d;
                        this.btn_roll_cancle.Visible = true;
                        this.txtsession.Enabled = false;
                        this.btn_start_ok.Visible = false;
                        this.btn_roll_finish.Visible = true;
                        this.btn_roll_cancle.Visible = true;
                        this.clb_nation_main.Visible = true;
                        this.panel_startmethod.Enabled = false;
                    }
                    else
                    {
                        this.tlp_taskbar.Enabled = false;
                        this.btn_start_cancel.Visible = true;
                        this.btn_start_ok.Visible = true;
                        this.clb_nation_main.Visible = false;
                        this.btn_roll_finish.Visible = false;
                        this.btn_roll_cancle.Visible = false;
                    }
                    break;

                case "MC":
                    this.btn_roll_finish.Left = 0x6a;
                    this.btn_roll_finish.Width = 0x6d;
                    this.btn_roll_cancle.Visible = true;
                    this.txtsession.Enabled = false;
                    this.btn_start_ok.Visible = false;
                    this.btn_roll_finish.Visible = true;
                    this.btn_roll_cancle.Visible = true;
                    this.clb_nation_main.Visible = true;
                    this.panel_startmethod.Enabled = false;
                    this.panel_sidebar_starting.Visible = true;
                    this.panel_mc.Visible = false;
                    this.panel_mcedit.Visible = false;
                    this.panel_sidebar_timer.Visible = false;
                    break;
            }
        }

        private void btn_sfx1_Click(object sender, EventArgs e)
        {
            int num2;
            Button[] buttonArray = new Button[] { this.btn_sfx1, this.btn_sfx2, this.btn_sfx3, this.btn_sfx4 };
            int index = 0;
            do
            {
                if (sender.Equals(buttonArray[index]))
                {
                    break;
                }
                index++;
                num2 = 3;
            }
            while (index <= num2);
            TextBox[] boxArray = new TextBox[] { this.txt_sfx1, this.txt_sfx2, this.txt_sfx3, this.txt_sfx4 };
            if (this.ofd_sfx.ShowDialog() != DialogResult.Cancel)
            {
                boxArray[index].Text = this.ofd_sfx.FileName;
            }
        }

        private void btn_sfxquick_Click(object sender, EventArgs e)
        {
            if (this.isPlaysound)
            {
                this.isPlaysound = false;
                this.isPlayStart = false;
                this.isPlay20 = false;
                this.isPlayUMC = false;
                this.btn_sfxquick.Text = "音效: 关";
            }
            else
            {
                this.isPlaysound = true;
                this.isPlayStart = true;
                this.isPlay20 = true;
                this.isPlayUMC = true;
                this.btn_sfxquick.Text = "音效: 开";
            }
        }

        private void btn_sizequick_Click(object sender, EventArgs e)
        {
            if (this.FontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                this.txt_fontpreview.Font = this.FontDialog1.Font;
                this.lblmain.Font = this.FontDialog1.Font;
                this.myFont = this.FontDialog1.Font;
                this.btn_sizequick.Text = "字号:" + Conversion.Str(this.FontDialog1.Font.Size);
            }
        }

        private void btn_speakerslist_Click(object sender, EventArgs e)
        {
            PanelsExpanding.taskbarUnslect();
            this.panel_spakers_list.Visible = true;
            this.panel_sidebar_timer.Visible = true;
            this.numtime.Enabled = false;
            this.btn_speakerslist.ForeColor = Color.White;
            this.btn_speakerslist.BackColor = this.darkcolor;
            this.cbx_spl_yield.SelectedIndex = 0;
            this.tlp_screenlist.Visible = true;
            this.tlp_screenlist.Top = this.panel_main_screen.Height - this.tlp_screenlist.Height;
            this.Label28.Visible = false;
            this.txt_spl_yieldto.Visible = false;
            this.btn_spl_yieldgo.Visible = false;
            this.btn_spl_yieldend.Visible = false;
            this.tlp_taskbar2.Visible = true;
            this.timingStatus = "SL";
            this.listAction("clear", 0, "");
            if (this.isCslMode)
            {
                this.panel_csl.Visible = true;
                this.loadCSL();
            }
            else
            {
                this.panel_csl.Visible = false;
                this.loadSlist();
            }
            this.autoPage(this.slCurrent / this.listCapacity);
            this.maxPages();
        }

        private void btn_spl_add_Click(object sender, EventArgs e)
        {
            this.slNationAdd();
            if (this.isCslMode)
            {
                this.cslEdited = true;
            }
        }

        private void btn_spl_exit_Click(object sender, EventArgs e)
        {
            PanelsExpanding.unlockTaskbar();
        }

        private void btn_spl_loadcustom_Click(object sender, EventArgs e)
        {
            if (this.ofd_csl.ShowDialog() != DialogResult.Cancel)
            {
                if (!this.cslEdited)
                {
                    this.cslPath = this.ofd_csl.FileName;
                    this.loadCSL();
                    this.cslEdited = false;
                }
                else
                {
                    switch (((int) Interaction.MsgBox("此操作将覆盖原自定名单，但您还没有保存它。\r\n是否需要保存该列表？", MsgBoxStyle.Question | MsgBoxStyle.YesNoCancel, "自定发言名单")))
                    {
                        case 6:
                            if (this.cslPath != "")
                            {
                                this.saveCSL();
                                this.cslPath = this.ofd_csl.FileName;
                                this.loadCSL();
                                this.cslEdited = false;
                                break;
                            }
                            this.cslSaveTo(true);
                            break;

                        case 7:
                            this.cslPath = this.ofd_csl.FileName;
                            this.loadCSL();
                            this.cslEdited = false;
                            break;
                    }
                }
            }
        }

        private void btn_spl_savecustom_Click(object sender, EventArgs e)
        {
            this.sfd_csl.FileName = this.committee + "_" + this.cslTitle + ".csl.txt";
            this.cslSaveTo(false);
        }

        private void btn_spl_start_Click(object sender, EventArgs e)
        {
            if (this.btn_spl_start.Text == "开始")
            {
                this.tlp_taskbar.Enabled = false;
                this.timingStatus = "SL";
                this.btn_spl_start.Text = "暂停";
                this.btn_spl_exit.Enabled = false;
                this.cbx_spl_yield.Enabled = false;
                this.llb_spl_entercustom.Enabled = false;
                if (this.isCslMode)
                {
                    if (this.page != (this.cslCurrent / this.listCapacity))
                    {
                        this.autoPage(this.cslCurrent / this.listCapacity);
                        this.maxPages();
                    }
                    this.cslStringGenerare();
                    this.cslEdited = true;
                }
                else
                {
                    if (this.page != (this.slCurrent / this.listCapacity))
                    {
                        this.autoPage(this.slCurrent / this.listCapacity);
                        this.maxPages();
                    }
                    this.slStringGenerake();
                }
                this.k = Convert.ToInt32(this.numtime.Value);
                this.i = Convert.ToInt32(this.numtime.Value);
                this.isTiming = true;
                this.Button3.Enabled = false;
                this.Button4.Enabled = false;
                this.btn_spl_add.Enabled = false;
                this.txt_spl_add.Enabled = false;
            }
            else if (this.btn_spl_start.Text == "暂停")
            {
                this.btn_spl_start.Text = "继续";
                this.lblmain.Text = this.lblmain.Text + " - 已暂停";
                this.isTiming = false;
                this.iTick = 0;
                this.lblcount.ForeColor = this.lightcolor;
                this.cbx_spl_yield.Enabled = true;
            }
            else
            {
                this.isTiming = true;
                this.btn_spl_start.Text = "暂停";
                this.cbx_spl_yield.Enabled = false;
            }
        }

        private void btn_spl_yieldend_Click(object sender, EventArgs e)
        {
            if (this.isCslMode && !this.cslAllowYield)
            {
                this.speakerend(false);
                this.slSpeakNext();
            }
            else
            {
                this.yieldAct(this.yieldType, false, false);
            }
        }

        private void btn_spl_yieldgo_Click(object sender, EventArgs e)
        {
            if ((this.btn_spl_yieldgo.Text == "开始") | (this.btn_spl_yieldgo.Text == "回答开始"))
            {
                this.yieldAct(this.yieldType, true, false);
                if (this.cbx_spl_yield.SelectedIndex == 1)
                {
                    this.btn_spl_yieldgo.Visible = false;
                }
                else
                {
                    this.btn_spl_yieldgo.Text = "完成并准备下一个";
                }
            }
            else if (this.btn_spl_yieldgo.Text == "完成并准备下一个")
            {
                this.timerControl(0);
                this.txt_spl_yieldto.Text = "";
                this.txt_spl_yieldto.Select();
                this.btn_spl_yieldgo.Text = "开始下一个";
            }
            else
            {
                this.yieldAct(this.yieldType, true, true);
                this.btn_spl_yieldgo.Text = "完成并准备下一个";
            }
        }

        private void btn_start_ok_Click(object sender, EventArgs e)
        {
            if (this.txtsession.Text == "")
            {
                this.txtsession.BackColor = Color.Yellow;
            }
            else
            {
                this.lblmain.Text = this.infoString[6] + this.conference + "\r\n" + this.committee + "\r\n" + this.topic[this.topicSelection] + "\r\n" + this.infoString[2] + this.txtsession.Text + this.infoString[3];
                this.lblopic.Text = this.lblopic.Text + this.infoString[5] + this.infoString[2] + this.txtsession.Text + this.infoString[3];
                if (this.rad_immediatestart.Checked)
                {
                    StreamWriter writer = new StreamWriter(@"saved\" + this.lastPath + @"\record.txt", true);
                    writer.Write(Conversions.ToString(DateTime.Today) + " " + Conversions.ToString(DateAndTime.TimeOfDay) + "\r\n" + this.conference + "\r\n" + this.committee + "\r\n" + this.topic[this.topicSelection] + "\r\n" + this.infoString[2] + this.txtsession.Text + this.infoString[3] + this.infoString[4] + "\r\n\r\n");
                    writer.Close();
                    writer.Dispose();
                    this.clb_nation_main.Visible = true;
                    this.btn_roll_finish.Visible = true;
                }
                else
                {
                    this.isWaiting = true;
                    this.timeStart = new DateTime(DateAndTime.Today.Year, DateAndTime.Today.Month, DateAndTime.Today.Day, Convert.ToInt32(this.numstarth.Value), Convert.ToInt32(this.numstartm.Value), 0);
                    if (DateTime.Compare(this.timeStart, DateTime.Now) < 0)
                    {
                        this.timeStart.AddDays(1.0);
                    }
                    this.hh = Conversions.ToString(this.numstarth.Value);
                    this.mm = Conversions.ToString(this.numstartm.Value);
                    if (decimal.Compare(this.numstartm.Value, 10M) < 0)
                    {
                        this.mm = "0" + this.mm;
                    }
                    this.Label17.Visible = true;
                    this.lblmain.Text = this.lblmain.Text + "\r\n" + this.infoString[7] + this.hh + ":" + this.mm + this.infoString[8];
                    this.Label17.Text = Conversions.ToString(this.timeStart);
                    this.Label17.Text = "会议开始后在这里显示国家列表。\r\n开始时间: " + this.Label17.Text;
                }
                this.session = Conversions.ToInteger(this.txtsession.Text);
                this.btn_start_cancel.Visible = false;
                this.btn_start_ok.Visible = false;
                this.txtsession.Enabled = false;
                this.panel_startmethod.Enabled = false;
                if (!this.isStarted)
                {
                    this.btn_roll_finish.Left = 0;
                    this.btn_roll_finish.Width = 0xd8;
                }
                else
                {
                    this.btn_roll_cancle.Visible = true;
                }
                this.loadRollcall();
            }
        }

        private void btn_system_calcel_Ck(object sender, EventArgs e)
        {
            PanelsExpanding.miscCollapse(0);
            this.panel_misc.Visible = false;
            PanelsExpanding.unlockTaskbar();
        }

        private void btn_system_calcel_Click(object sender, EventArgs e)
        {
            this.panel_system.Visible = false;
            PanelsExpanding.unlockTaskbar();
        }

        private void btn_system_Click(object sender, EventArgs e)
        {
            PanelsExpanding.taskbarUnslect();
            this.panel_system.Visible = true;
            this.btn_system.ForeColor = Color.White;
            this.btn_system.BackColor = this.darkcolor;
        }

        private void btn_teabreak_ok_Click(object sender, EventArgs e)
        {
            string str;
            switch (this.miscIndex)
            {
                case 1:
                    PanelsExpanding.miscCollapse(0);
                    this.panel_misc.Visible = false;
                    str = Conversions.ToString(this.num_tbtime.Value);
                    if (this.language != 1)
                    {
                        str = "Tea-break (" + str + " minutes)";
                        break;
                    }
                    str = "茶歇 (" + str + "分钟)";
                    break;

                case 2:
                {
                    PanelsExpanding.miscCollapse(0);
                    this.panel_misc.Visible = false;
                    PanelsExpanding.unlockTaskbar();
                    DateTime time2 = new DateTime(DateAndTime.Year(this.DateTimePicker1.Value), DateAndTime.Month(this.DateTimePicker1.Value), DateAndTime.Day(this.DateTimePicker1.Value), Convert.ToInt32(this.numhh.Value), Convert.ToInt32(this.nummm.Value), 0);
                    this.isCabinet = this.rad_clockyes.Checked;
                    this.rawrate = this.TrackBar1.Value;
                    this.rate = this.cabinRate[this.rawrate];
                    StreamWriter writer = new StreamWriter(@"saved\" + this.lastPath + @"\clock.txt");
                    writer.WriteLine(this.isCabinet);
                    writer.WriteLine(time2);
                    writer.WriteLine(this.rawrate);
                    writer.Close();
                    this.cabingo();
                    return;
                }
                case 3:
                    PanelsExpanding.miscCollapse(0);
                    this.panel_misc.Visible = false;
                    if (this.language != 1)
                    {
                        this.awardstring = this.cbx_awards.Text + "\r\nAward to delegate of " + this.txt_awardnat.Text + ",\r\n" + this.txt_awardelg.Text + "\r\nFrom " + this.txt_awardsch.Text + "\r\nCongratulations!!";
                    }
                    else
                    {
                        this.awardstring = this.cbx_awards.Text + "\r\n授予" + this.txt_awardnat.Text + "代表\r\n来自" + this.txt_awardsch.Text + "的" + this.txt_awardelg.Text + "\r\n祝贺！";
                    }
                    this.lblmain.Text = this.awardstring;
                    this.txthcmotion.Text = this.awardstring;
                    this.cbx_awards.Text = "";
                    this.txt_awardelg.Text = "";
                    this.txt_awardnat.Text = "";
                    return;

                case 4:
                    if (this.txt_custom.Text == "")
                    {
                        Interaction.MsgBox("请填写消息内容！", MsgBoxStyle.Exclamation, "自定义消息");
                        return;
                    }
                    this.lblmain.Text = this.txt_custom.Text;
                    this.txthcmotion.Text = this.txt_custom.Text;
                    this.txt_custom.Text = "";
                    PanelsExpanding.miscCollapse(0);
                    this.panel_misc.Visible = false;
                    PanelsExpanding.unlockTaskbar();
                    return;

                default:
                    return;
            }
            this.Label100.Text = "茶歇进行中";
            this.timingStatus = "TB";
            this.numtime.Value = decimal.Multiply(this.num_tbtime.Value, 60M);
            this.numtime.Enabled = false;
            this.txthcmotion.Text = str;
            this.txt_mnation.Text = "";
            this.panel_motion.Visible = false;
            this.panel_sidebar_timer.Visible = true;
            this.panel_umc.Visible = true;
            this.k = Convert.ToInt32(this.numtime.Value);
            this.i = Convert.ToInt32(this.numtime.Value);
            this.isTiming = true;
            DateTime time = DateAndTime.Now.AddSeconds((double) this.k);
            this.Label101.Text = "预计结束时间: \r\n" + Conversions.ToString(time);
        }

        private void btn_umc_reset_Click(object sender, EventArgs e)
        {
        }

        private void btn_umc_send_Click(object sender, EventArgs e)
        {
            this.txthcmotion.Text = this.txt_umccustom.Text;
            this.lblmain.Text = this.txt_umccustom.Text;
            this.txt_umccustom.Text = "";
        }

        private void btn_vote_next_Click(object sender, EventArgs e)
        {
            switch (this.voteStep)
            {
                case 1:
                    int num;
                    while (num < this.clb_nation_vote.Items.Count)
                    {
                        if (this.clb_nation_vote.GetItemChecked(num))
                        {
                            if (num < 40)
                            {
                                this.listAction("add", this.vtTotal, Conversions.ToString(this.clb_nation_vote.Items[num]));
                            }
                            this.vtTotal++;
                            this.nations[this.vtTotal] = Conversions.ToString(this.clb_nation_vote.Items[num]);
                        }
                        num++;
                    }
                    this.tlp_screenlist.Visible = true;
                    this.maxPages();
                    this.autoPage(0);
                    this.lblpresent.Text = Conversions.ToString(this.vtTotal);
                    this.lbl50maj.Text = Conversions.ToString((int) ((this.vtTotal / 2) + 1));
                    this.lbl67maj.Text = Conversions.ToString((int) (((this.vtTotal * 2) / 3) + 1));
                    this.maj67vote = this.vtTotal;
                    this.lbl_vote_step.Text = "第2步: 进行第1轮投票";
                    this.lbl_vote_nation.Text = this.nations[1];
                    this.panel_vote_config.Visible = true;
                    this.panel_vote_ctrl.Visible = true;
                    this.vtCurrent = 1;
                    if (this.chk_vote_saveplist.Checked)
                    {
                        int num2;
                        StreamWriter writer = new StreamWriter(@"saved\" + this.lastPath + @"\nationlist_p.txt");
                        while (num2 < this.clb_nation_vote.Items.Count)
                        {
                            writer.WriteLine(this.clb_nation_vote.GetItemChecked(num2));
                            num2++;
                        }
                        this.votePresentSaved = true;
                        writer.Close();
                    }
                    else
                    {
                        this.votePresentSaved = false;
                    }
                    this.voteDisp();
                    this.btnyes.Enabled = true;
                    this.btnno.Enabled = true;
                    this.btnabst.Enabled = true;
                    this.btnpass.Enabled = true;
                    this.panel_vote_roll.Visible = false;
                    this.btn_vote_next.Enabled = false;
                    this.btn_votectrl.Enabled = true;
                    this.btn_votectrl.Focus();
                    this.voteStep = 2;
                    return;

                case 2:
                    if (this.p <= 0)
                    {
                        this.lbl_vote_step.Text = "第4步: 确认否决权和通过条件设定";
                        this.panel_vote_ctrl.Visible = false;
                        this.btn_vote_next.Text = "完成";
                        this.voteStep = 4;
                        return;
                    }
                    this.lbl_vote_step.Text = "第3步: 进行第2轮投票";
                    this.lbl_vote_nation.Text = this.nations[this.pnat[1]];
                    this.autoPage(this.pnat[1] / this.listCapacity);
                    this.maxPages();
                    this.btnyes.Enabled = true;
                    this.btnno.Enabled = true;
                    this.btn_vote_next.Enabled = false;
                    this.r2 = true;
                    this.q = 1;
                    this.btn_votectrl.Enabled = true;
                    this.btn_votectrl.Focus();
                    this.voteStep = 3;
                    return;

                case 3:
                    this.lbl_vote_step.Text = "第4步: 确认否决权和通过条件设定";
                    this.panel_vote_ctrl.Visible = false;
                    this.btn_vote_next.Text = "完成";
                    this.voteStep = 4;
                    return;

                case 4:
                    this.lbl_vote_step.Text = "投票已结束！";
                    this.panel_vote_config.Visible = false;
                    this.autoPage(0);
                    this.maxPages();
                    if (this.yes < this.votePass())
                    {
                        this.a2 = this.voteString[0] + this.cbx_fselect.Text + this.voteString[2];
                        this.record(false);
                        break;
                    }
                    if (this.vetoPower() != this.voteString[6])
                    {
                        this.a2 = this.voteString[0] + this.cbx_fselect.Text + this.voteString[2];
                        this.record(false);
                        break;
                    }
                    this.a2 = this.voteString[0] + this.cbx_fselect.Text + this.voteString[1];
                    this.record(true);
                    break;

                case 5:
                    this.lbl_vote_step.Text = "第1步: 投票点名";
                    this.Label108.Text = "下一国家:";
                    this.btn_vote_next.Text = "下一步";
                    this.btn_vote_next.Width = 0x6d;
                    this.btn_vote_next.Left = 0x6b;
                    this.btn_vote_cancel.Visible = true;
                    this.panel_vote.Visible = false;
                    this.tlp_screenlist.Visible = false;
                    this.listAction("clear", 0, "");
                    this.voteAction(0, 0);
                    PanelsExpanding.unlockTaskbar();
                    this.voteClear();
                    return;

                default:
                    return;
            }
            this.lblmain.Text = this.a2;
            if (this.chk_vote_foujue.Checked)
            {
                this.lblmain.Text = this.lblmain.Text + "\r\n" + this.vetoPower();
            }
            this.btn_vote_next.Text = "关闭";
            this.btn_vote_next.Width = 0xd8;
            this.btn_vote_next.Left = 0;
            this.btn_vote_cancel.Visible = false;
            this.voteStep = 5;
        }

        private void btnabst_Click(object sender, EventArgs e)
        {
            this.vote(3, this.r2);
            this.btn_votectrl.Focus();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnno_Click(object sender, EventArgs e)
        {
            this.vote(2, this.r2);
            this.btn_votectrl.Focus();
        }

        private void btnpass_Click(object sender, EventArgs e)
        {
            this.vote(4, this.r2);
            this.btn_votectrl.Focus();
        }

        private void btnyes_Click(object sender, EventArgs e)
        {
            this.vote(1, this.r2);
            this.btn_votectrl.Focus();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!this.isCabinet)
            {
                DateTime time = new DateTime(DateAndTime.Year(DateAndTime.Today), DateAndTime.Month(DateAndTime.Today), DateAndTime.Day(DateAndTime.Today), DateAndTime.Hour(DateAndTime.Now), DateAndTime.Minute(DateAndTime.Now), 0);
            }
            if (this.rad_select.Checked)
            {
                try
                {
                    this.loadSelection(Conversions.ToString(this.ComboBox1.SelectedItem));
                    this.lastPath = Conversions.ToString(this.ComboBox1.SelectedItem);
                    StreamWriter writer = new StreamWriter("lastsave.txt");
                    writer.WriteLine(RuntimeHelpers.GetObjectValue(this.ComboBox1.SelectedItem));
                    writer.Close();
                    this.lblconf.Text = this.conference + "  " + this.committee;
                    this.lblopic.Text = this.topic[this.topicSelection];
                    if (-(this.isStarted > false))
                    {
                        this.lblopic.Text = Conversions.ToString((double) ((Conversions.ToDouble(this.lblopic.Text + "  第") + this.session) + Conversions.ToDouble("会期")));
                        this.txtsession.Text = Conversions.ToString(this.session);
                    }
                    this.loadLanguageScript();
                    this.panel_welcome.Visible = false;
                    this.panel_main.Visible = true;
                    this.isInMeeting = true;
                }
                catch (Exception exception1)
                {
                    ProjectData.SetProjectError(exception1);
                    Exception exception = exception1;
                    this.ComboBox1.BackColor = Color.Yellow;
                    ProjectData.ClearProjectError();
                }
            }
            else if (this.rad_create.Checked)
            {
                bool flag2 = true;
                if (this.TextBox1.Text == "")
                {
                    flag2 = false;
                    this.TextBox1.BackColor = Color.Yellow;
                }
                if (this.TextBox2.Text == "")
                {
                    flag2 = false;
                    this.TextBox2.BackColor = Color.Yellow;
                }
                if (this.TextBox3.Text == "")
                {
                    flag2 = false;
                    this.TextBox3.BackColor = Color.Yellow;
                }
                if ((this.TextBox4.Text == "") && this.CheckBox1.Checked)
                {
                    this.CheckBox1.Checked = false;
                }
                if (this.TextBox5.Text == "")
                {
                    flag2 = false;
                    this.TextBox5.BackColor = Color.Yellow;
                }
                if (flag2)
                {
                    if (this.RadioButton4.Checked)
                    {
                        this.language = 1;
                    }
                    if (this.RadioButton5.Checked)
                    {
                        this.language = 2;
                    }
                    if (this.TextBox4.Text == "")
                    {
                        this.topicSelection = 0;
                    }
                    else
                    {
                        this.topicSelection = 2;
                    }
                    this.conference = this.TextBox1.Text;
                    this.committee = this.TextBox2.Text;
                    this.topic[0] = this.TextBox3.Text;
                    this.topic[1] = this.TextBox4.Text;
                    this.lastPath = this.TextBox5.Text;
                    this.isStarted = false;
                    this.myrule = 0;
                    this.session = 0;
                    this.presentWhenRoll = 0;
                    this.isSingelDel = this.chk_issingle.Checked;
                    this.lastPath.Replace(@"\", "_");
                    this.lastPath.Replace("/", "_");
                    this.lastPath.Replace(":", "_");
                    this.lastPath.Replace("*", "_");
                    this.lastPath.Replace("?", "_");
                    this.lastPath.Replace("\"", "_");
                    this.lastPath.Replace("<", "_");
                    this.lastPath.Replace(">", "_");
                    this.lastPath.Replace("|", "_");
                    if (!MyProject.Computer.FileSystem.DirectoryExists(@"saved\" + this.TextBox5.Text))
                    {
                        MyProject.Computer.FileSystem.CreateDirectory(@"saved\" + this.TextBox5.Text);
                    }
                    this.saveConfig();
                    StreamWriter writer2 = new StreamWriter("lastsave.txt");
                    writer2.WriteLine(this.TextBox5.Text);
                    writer2.Close();
                    this.lblconf.Text = this.conference + "  " + this.committee;
                    this.lblopic.Text = this.topic[this.topicSelection];
                    this.panel_editnationlist.Visible = true;
                    this.panel_editnationlist.Top = 0x37;
                    this.panel_editnationlist.Left = 0;
                    this.panel_welcome.Visible = false;
                    if (this.isSingelDel)
                    {
                        this.panel_singledel.Visible = true;
                    }
                    else
                    {
                        this.panel_singledel.Visible = false;
                    }
                    this.loadENL(true);
                    this.loadLanguageScript();
                    this.createFile(this.TextBox5.Text);
                    this.panel_main.Visible = true;
                    this.isInMeeting = true;
                }
            }
            else
            {
                this.lblconf.Text = this.conference + "  " + this.committee;
                this.lblopic.Text = this.topic[this.topicSelection];
                if (this.isStarted)
                {
                    this.txtsession.Text = Conversions.ToString(this.session);
                    this.lblopic.Text = this.lblopic.Text + "  第" + this.txtsession.Text + "会期";
                    this.loadRollcall();
                    this.btn_start_cancel.Visible = false;
                }
                this.loadLanguageScript();
                this.loadClock();
                this.panel_welcome.Visible = false;
                this.panel_main.Visible = true;
                this.isInMeeting = true;
            }
            this.newMsg();
            string committee = this.committee;
            if ((((committee == "UNSC") || (committee == "Security Council")) || ((committee == "United Nations Security Council") || (committee == "安理会"))) || ((committee == "联合国安理会") || (committee == "联合国安全理事会")))
            {
                this.chk_vote_foujue.Checked = true;
            }
            else
            {
                this.chk_vote_foujue.Checked = false;
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            this.btn_sessionstart.BackColor = Color.White;
            this.btn_sessionstart.ForeColor = Color.Black;
            this.tlp_taskbar.Enabled = true;
            this.panel_sidebar_starting.Visible = false;
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            this.pageAction(false);
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            this.isTiming = false;
            this.btn_motionstop.Visible = false;
            this.btn_motion_finish.Visible = true;
            this.motionClose();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.generate();
            this.TextBox5.Text = this.TextBox1.Text + this.genetext;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (this.Button3.Text == "开始")
            {
                this.countStart();
            }
            else if (this.Button3.Text == "暂停")
            {
                this.isTiming = false;
                this.iTick = 0;
                this.lblmaohao.Visible = false;
                this.Button3.Text = "继续";
                if (this.timingStatus != "")
                {
                }
                this.lblcount.ForeColor = this.lightcolor;
            }
            else
            {
                this.isTiming = true;
                this.lblcount.ForeColor = Color.White;
                this.Button3.Text = "暂停";
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            PanelsExpanding.unlockTaskbar();
            this.isTiming = false;
            this.iTick = 0;
            this.k = 0;
            this.i = 0;
            this.numtime.Value = 60M;
            this.panel_sidebar_timer.Visible = false;
            this.WebBrowser1.Visible = false;
            if (this.Button4.Text == "关闭")
            {
                this.Button4.Text = "清除";
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.lblcount.Text = "00:00";
            this.lblcount.ForeColor = Color.White;
            this.panel_sidebar_timer.Visible = false;
            this.panel_umc.Visible = false;
            this.tlp_screenlist.Visible = false;
            this.numtime.Enabled = true;
            this.btn_umc_close.Visible = false;
            this.panel_readfile.Visible = false;
            this.chk_playback.Checked = false;
            PanelsExpanding.unlockTaskbar();
        }

        public void cabingo()
        {
            StreamReader reader = new StreamReader(@"saved\" + this.lastPath + @"\clock.txt");
            this.isCabinet = Conversions.ToBoolean(reader.ReadLine());
            this.cabinTime = Conversions.ToDate(reader.ReadLine());
            this.rawrate = Conversions.ToInteger(reader.ReadLine());
            this.rate = this.cabinRate[this.rawrate];
            reader.Close();
        }

        private void cancelvote(object sender, EventArgs e)
        {
            if (Interaction.MsgBox("确实要取消投票吗？", MsgBoxStyle.Question | MsgBoxStyle.YesNo, "投票") == MsgBoxResult.Yes)
            {
                this.lbl_vote_step.Text = "第1步: 投票点名";
                this.Label108.Text = "下一国家:";
                this.btn_vote_next.Text = "下一步";
                this.btn_vote_next.Width = 0x6d;
                this.btn_vote_next.Left = 0x6b;
                this.btn_vote_cancel.Visible = true;
                this.panel_vote.Visible = false;
                this.tlp_screenlist.Visible = false;
                this.listAction("clear", 0, "");
                this.voteAction(0, 0);
                PanelsExpanding.unlockTaskbar();
                this.voteClear();
                this.lblmain.Text = this.voteString[8];
                this.txthcmotion.Text = this.voteString[8];
            }
        }

        private void cbx_fmode_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Label103.Visible = false;
            this.cbx_ftpye.Visible = false;
            this.txt_fcrisis.Visible = false;
            this.txt_filenumber_1.Visible = false;
            this.txt_filenumber_2.Visible = false;
            this.txt_filenumber_3.Visible = false;
            this.panel_sponsors.Visible = false;
            if (this.cbx_fmode.SelectedIndex == 0)
            {
                this.Label35.Visible = false;
                this.cbx_fselect.Visible = false;
                this.btn_file_ok.Visible = false;
                this.btn_file_cancel.Top = 0x42;
            }
            else
            {
                this.Label35.Visible = true;
                this.btn_file_ok.Visible = true;
                if (this.cbx_fmode.SelectedIndex == 3)
                {
                    this.cbx_fselect.Visible = true;
                    this.Label35.Text = "对文件　　　　　　　　　　 投票";
                    this.cbx_fselect.Width = 0x73;
                    this.cbx_fselect.Left = 0x39;
                    this.btn_file_cancel.Top = 0x5f;
                    this.btn_file_ok.Top = 0x5f;
                }
                else
                {
                    this.cbx_fselect.Visible = false;
                    this.panel_sponsors.Visible = true;
                    this.cbx_fselect.Width = 0x79;
                    this.cbx_fselect.Left = 0x4d;
                    this.Label103.Visible = true;
                    if (this.cbx_fmode.SelectedIndex == 1)
                    {
                        this.cbx_ftpye.Visible = true;
                        this.txt_filenumber_1.Visible = true;
                        this.txt_filenumber_2.Visible = true;
                        this.panel_sponsors.Top = 0x79;
                        this.panel_sponsors.Height = 0x56;
                        this.Label35.Text = "文件类型";
                        this.Label103.Text = "编号　　　.　　";
                        this.Label104.Text = "阅读时间　　　　 分钟";
                        this.Label105.Text = "起草国";
                        this.btn_file_cancel.Top = 0xd7;
                        this.btn_file_ok.Top = 0xd7;
                        this.txt_file_sponsors.Left = 0x3b;
                        this.txt_file_sponsors.Width = 0x8b;
                    }
                    else if (this.cbx_fmode.SelectedIndex == 4)
                    {
                        this.panel_sponsors.Top = 0x41;
                        this.panel_sponsors.Height = 0x1f;
                        this.txt_fcrisis.Visible = true;
                        this.Label103.Text = "危机正文 (选填)";
                        this.Label104.Text = "阅读时间　　　　 分钟";
                        this.btn_file_cancel.Top = 0xff;
                        this.btn_file_ok.Top = 0xff;
                    }
                    else
                    {
                        this.cbx_fselect.Visible = true;
                        this.panel_sponsors.Top = 90;
                        this.panel_sponsors.Height = 0x39;
                        this.Label105.Text = "介绍的国家";
                        this.Label104.Text = "介绍时间　　　　 分钟";
                        this.Label35.Text = "介绍文件";
                        this.txt_file_sponsors.Left = 0x53;
                        this.txt_file_sponsors.Width = 0x73;
                        this.btn_file_cancel.Top = 0x99;
                        this.btn_file_ok.Top = 0x99;
                    }
                }
            }
        }

        private void cbx_ftpye_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbx_ftpye.Text == "修正案")
            {
                this.Label103.Text = "编号　　　　.　　.";
                this.txt_filenumber_3.Visible = true;
                this.panel_signatories.Visible = false;
            }
            else if (this.cbx_ftpye.Text == "Amendment")
            {
                this.Label103.Text = "编号　　　　.　　.";
                this.txt_filenumber_3.Visible = true;
                this.panel_signatories.Visible = false;
            }
            else
            {
                this.Label103.Text = "编号　　　　.　　";
                this.txt_filenumber_3.Visible = false;
                this.panel_signatories.Visible = true;
            }
            this.signatories();
        }

        private void cbx_singledel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.clb_nation_main.GetItemChecked(this.cbx_singledel.SelectedIndex))
            {
                this.btn_ispresent.Text = "Yes";
            }
            else
            {
                this.btn_ispresent.Text = "No";
            }
        }

        private void cbx_spl_yield_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.cbx_spl_yield.SelectedIndex)
            {
                case 0:
                    this.Label28.Visible = false;
                    this.txt_spl_yieldto.Visible = false;
                    this.btn_spl_yieldgo.Visible = false;
                    this.btn_spl_yieldend.Visible = false;
                    return;

                case 4:
                    this.yieldAct(4, false, false);
                    return;
            }
            this.yieldAction(this.cbx_spl_yield.SelectedIndex);
            this.Label28.Visible = true;
            this.txt_spl_yieldto.Visible = true;
            this.btn_spl_yieldgo.Visible = true;
            this.btn_spl_yieldend.Visible = true;
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckBox1.Checked)
            {
                this.TextBox4.Enabled = true;
            }
            else
            {
                this.TextBox4.Enabled = false;
            }
        }

        private void chk_is_mainimg_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk_sfx_timeout.Checked)
            {
                this.txt_sfx1.Enabled = true;
                this.btn_sfx1.Enabled = true;
                this.isPlaysound = true;
            }
            else
            {
                this.txt_sfx1.Enabled = false;
                this.btn_sfx1.Enabled = false;
                this.isPlaysound = false;
            }
        }

        private void chk_playback_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk_playback.Checked)
            {
                this.WebBrowser1.Visible = true;
            }
            else
            {
                this.WebBrowser1.Visible = false;
            }
        }

        private void chk_sfx_start_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk_sfx_start.Checked)
            {
                this.txt_sfx4.Enabled = true;
                this.btn_sfx4.Enabled = true;
                this.isPlayStart = true;
            }
            else
            {
                this.txt_sfx4.Enabled = false;
                this.btn_sfx4.Enabled = false;
                this.isPlayStart = false;
            }
        }

        private void chk_sfx_time20_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk_sfx_time20.Checked)
            {
                this.txt_sfx2.Enabled = true;
                this.btn_sfx2.Enabled = true;
                this.num_timeleft.Enabled = true;
                this.Label171.Enabled = true;
                this.isPlay20 = true;
            }
            else
            {
                this.txt_sfx2.Enabled = false;
                this.btn_sfx2.Enabled = false;
                this.num_timeleft.Enabled = false;
                this.Label171.Enabled = false;
                this.isPlay20 = false;
            }
        }

        private void chk_sfx_time60_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk_sfx_time60.Checked)
            {
                this.txt_sfx3.Enabled = true;
                this.btn_sfx3.Enabled = true;
                this.isPlayUMC = true;
            }
            else
            {
                this.txt_sfx3.Enabled = false;
                this.btn_sfx3.Enabled = false;
                this.isPlayUMC = false;
            }
        }

        private void chk_spl_allowyield_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk_spl_allowyield.Checked != this.cslAllowYield)
            {
                this.cslEdited = true;
            }
            if (this.chk_spl_allowyield.Checked)
            {
                this.cslAllowYield = true;
                this.btn_spl_yieldend.Visible = false;
                this.cbx_spl_yield.Visible = true;
                this.btn_spl_yieldend.Top = this.btn_spl_yieldgo.Top;
            }
            else
            {
                this.cslAllowYield = false;
                this.btn_spl_yieldend.Visible = true;
                this.cbx_spl_yield.Visible = false;
                this.btn_spl_yieldend.Top = this.cbx_spl_yield.Top;
            }
        }

        private void chk_vote_foujue_CheckedChanged(object sender, EventArgs e)
        {
            int num3;
            CheckBox[] boxArray = new CheckBox[] { this.CheckBox2, this.CheckBox3, this.CheckBox4, this.CheckBox5, this.CheckBox6 };
            if (this.chk_vote_foujue.Checked)
            {
                int index = 0;
                do
                {
                    boxArray[index].Enabled = true;
                    index++;
                    num3 = 4;
                }
                while (index <= num3);
            }
            else
            {
                int num2 = 0;
                do
                {
                    boxArray[num2].Enabled = false;
                    num2++;
                    num3 = 4;
                }
                while (num2 <= num3);
            }
        }

        private void ComboBox1_TextChanged(object sender, EventArgs e)
        {
            this.loadSelection(this.ComboBox1.Text);
        }

        public void countStart()
        {
            if (this.timingStatus == "")
            {
                this.k = Convert.ToInt32(this.numtime.Value);
                this.i = Convert.ToInt32(this.numtime.Value);
                this.numtime.Enabled = false;
            }
            this.isTiming = true;
            this.Button3.Text = "暂停";
            this.timeDisp();
            this.lblmaohao.Visible = false;
        }

        public void create()
        {
            this.fileName = this.cbx_ftpye.Text + this.txt_filenumber_1.Text + "." + this.txt_filenumber_2.Text;
            if (this.cbx_ftpye.Text == "Amendment")
            {
                this.fileName = this.fileName + "." + this.txt_filenumber_3.Text;
            }
            else if (this.cbx_ftpye.Text == "修正案")
            {
                this.fileName = this.fileName + "." + this.txt_filenumber_3.Text;
            }
        }

        public void createFile(string path)
        {
            StreamWriter writer = new StreamWriter(@"saved\" + path + @"\files.txt");
            writer.Close();
            writer.Dispose();
            StreamWriter writer2 = new StreamWriter(@"saved\" + path + @"\speakers.txt");
            writer2.Write("0\r\n0\r\n2\r\n0");
            writer2.Close();
            writer2.Dispose();
            StreamWriter writer3 = new StreamWriter(@"saved\" + path + @"\clock.txt");
            writer3.WriteLine("False");
            writer3.WriteLine(this.cabinTime);
            writer3.WriteLine(this.TrackBar1.Value);
            writer3.Close();
            writer3.Dispose();
        }

        public void cslSaveTo(bool rewrite)
        {
            if (this.sfd_csl.ShowDialog() != DialogResult.Cancel)
            {
                this.cslPath = this.sfd_csl.FileName;
                this.saveCSL();
                this.cslEdited = false;
                if (rewrite)
                {
                    this.cslPath = this.ofd_csl.FileName;
                    this.loadCSL();
                    this.cslEdited = false;
                }
            }
        }

        public void cslStringGenerare()
        {
            string str;
            this.mm = Conversions.ToString(this.cslTime[0]);
            this.ss = Conversions.ToString(this.cslTime[1]);
            if (this.language == 1)
            {
                str = "自定发言名单: " + this.cslTitle + " (" + this.mm;
                if (this.cslTime[1] == 0)
                {
                    str = str + "分钟)";
                }
                else
                {
                    str = str + "分" + this.ss + "秒)";
                }
                str = str + "\r\n当前发言: " + this.cslNations[this.cslCurrent + 1];
            }
            else
            {
                str = "Custom Speakers' List: " + this.cslTitle + " (" + this.mm;
                if (this.cslTime[1] == 0)
                {
                    str = str + " minutes)";
                }
                else
                {
                    str = str + "m " + this.ss + "s)";
                }
                str = str + "\r\nCurrent: " + this.cslNations[this.cslCurrent + 1];
            }
            this.txthcmotion.Text = str;
        }

        public void dbqClose()
        {
            this.panel_dbq.Visible = false;
            this.isInDbq = false;
            this.dbqText = "";
            this.txt_dbqnation.Text = "";
            string timingStatus = this.timingStatus;
            if (timingStatus == "SL")
            {
                this.panel_spakers_list.Visible = true;
                this.tlp_taskbar.Enabled = true;
            }
            else if (timingStatus == "MC")
            {
                this.panel_mc.Visible = true;
            }
            else
            {
                PanelsExpanding.taskbarUnslect();
            }
        }

        [DebuggerNonUserCode]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && (this.components != null))
                {
                    this.components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        private void exitapp(object sender, EventArgs e)
        {
            if (this.isInMeeting)
            {
                if (this.cslEdited)
                {
                    switch (((int) Interaction.MsgBox("自定发言名单\"" + this.cslTitle + "\"还未保存。\r\n是否需要保存该名单？", MsgBoxStyle.Question | MsgBoxStyle.YesNo, "自定发言名单")))
                    {
                        case 6:
                            if (this.cslPath != "")
                            {
                                this.saveCSL();
                                break;
                            }
                            this.cslSaveTo(false);
                            break;
                    }
                }
                this.saveConfig();
                StreamWriter writer = new StreamWriter(@"saved\" + this.lastPath + @"\clock.txt");
                writer.WriteLine(this.isCabinet);
                writer.WriteLine(this.cabinTime);
                writer.WriteLine(this.rawrate);
                writer.Close();
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((this.voteStep == 2) | (this.voteStep == 3))
            {
                switch (((char) (e.KeyChar - '1')))
                {
                    case '\0':
                        this.vote(1, this.r2);
                        break;

                    case '\x0001':
                        this.vote(2, this.r2);
                        break;

                    case '\x0002':
                        if (this.voteStep != 2)
                        {
                            return;
                        }
                        this.vote(3, this.r2);
                        break;

                    case '\x0003':
                        if (this.voteStep != 2)
                        {
                            return;
                        }
                        this.vote(4, this.r2);
                        break;
                }
                this.btn_votectrl.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Label61.Top = 11;
            this.Label61.Left = 7;
            this.Label164.Top = this.Label176.Top;
            this.Label164.Left = this.TextBox10.Left + this.TextBox10.Width;
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            PanelsExpanding.dockPanels();
            this.panel_main.Visible = false;
            if (this.Width > 0x4e2)
            {
                this.tlp_screenlist.Width = this.panel_main_screen.Width;
                this.isWidescr = true;
                this.listCapacity = 40;
            }
            else
            {
                this.tlp_screenlist.Width = (int) Math.Round((double) (((double) ((this.panel_main_screen.Width - 10) * 4)) / 3.0));
                this.isWidescr = false;
                this.listCapacity = 30;
            }
            StreamReader reader2 = new StreamReader(@"config\setting.txt");
            this.myColor = Conversions.ToInteger(reader2.ReadLine());
            this.myBanner = reader2.ReadLine();
            this.isMainImg = Conversions.ToBoolean(reader2.ReadLine());
            this.myMainImg = reader2.ReadLine();
            this.isPlaysound = Conversions.ToBoolean(reader2.ReadLine());
            this.myPlaysound = reader2.ReadLine();
            this.isPlay20 = Conversions.ToBoolean(reader2.ReadLine());
            this.myPlay20 = reader2.ReadLine();
            this.valuePlay20 = Conversions.ToInteger(reader2.ReadLine());
            this.isPlayUMC = Conversions.ToBoolean(reader2.ReadLine());
            this.myPlayUMC = reader2.ReadLine();
            this.isPlayStart = Conversions.ToBoolean(reader2.ReadLine());
            this.myPlayStart = reader2.ReadLine();
            string familyName = reader2.ReadLine();
            float emSize = Conversions.ToSingle(reader2.ReadLine());
            FontStyle style = (FontStyle) Conversions.ToInteger(reader2.ReadLine());
            this.myFont = new Font(familyName, emSize, style);
            reader2.Close();
            this.FontDialog1.Font = this.myFont;
            this.btn_sizequick.Text = "字号:" + Conversion.Str(this.myFont.Size);
            this.loadColor();
            this.applyColor();
            try
            {
                this.PictureBox1.BackgroundImage = Image.FromFile(this.myBanner);
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                this.PictureBox1.BackgroundImage = Image.FromFile(@"ui\banner.jpg");
                this.txt_startimg.BackColor = Color.Red;
                ProjectData.ClearProjectError();
            }
            this.lbl_startmode.Image = Image.FromFile(@"ui\start_taskbar.png");
            this.myVersion = Conversions.ToInteger(loadword.loadVersion());
            StreamReader reader = new StreamReader("lastsave.txt");
            this.lastPath = reader.ReadLine();
            reader.Close();
            if (this.loadSelection(this.lastPath))
            {
                this.rad_select.Checked = true;
            }
            try
            {
                this.ComboBox1.Items.Clear();
                foreach (string str2 in Directory.GetDirectories("saved"))
                {
                    this.ComboBox1.Items.Add(Path.GetFileName(str2));
                }
            }
            catch (Exception exception3)
            {
                ProjectData.SetProjectError(exception3);
                Exception exception2 = exception3;
                this.rad_create.Checked = true;
                this.rad_select.Enabled = false;
                this.ComboBox1.Text = "没有可用的会议档案";
                ProjectData.ClearProjectError();
            }
            if (this.ComboBox1.Items.Count == 0)
            {
                this.rad_create.Checked = true;
                this.rad_select.Enabled = false;
                this.ComboBox1.Text = "没有可用的会议档案";
            }
            this.voteAction(0, 0);
            this.cslEdited = false;
            this.tlp_screenlist.Height = (this.lbl_slist_1.Height * 11) + 50;
            this.tlp_screenlist.Top = this.panel_main_screen.Height - this.tlp_screenlist.Height;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.tlp_screenlist.Top = this.panel_main_screen.Height - this.tlp_screenlist.Height;
            this.maxPages();
            if (this.Width > 0x4e2)
            {
                this.tlp_screenlist.Width = this.panel_main_screen.Width;
                this.isWidescr = true;
                this.listCapacity = 40;
            }
            else
            {
                this.tlp_screenlist.Width = (int) Math.Round((double) (((double) ((this.panel_main_screen.Width - 10) * 4)) / 3.0));
                this.isWidescr = false;
                this.listCapacity = 30;
            }
            if (!((this.Label38.Text == "") & (this.page == 0)))
            {
            }
        }

        public void generate()
        {
            this.monthm = Conversions.ToString(DateAndTime.Today.Month);
            if (DateAndTime.Today.Month < 10)
            {
                this.monthm = "0" + this.monthm;
            }
            this.dd = Conversions.ToString(DateAndTime.Today.Day);
            if (DateAndTime.Today.Day < 10)
            {
                this.dd = "0" + this.dd;
            }
            this.hh = Conversions.ToString(DateAndTime.TimeOfDay.Hour);
            if (DateAndTime.TimeOfDay.Hour < 10)
            {
                this.hh = "0" + this.hh;
            }
            this.mm = Conversions.ToString(DateAndTime.TimeOfDay.Minute);
            if (DateAndTime.TimeOfDay.Minute < 10)
            {
                this.mm = "0" + this.mm;
            }
            this.ss = Conversions.ToString(DateAndTime.TimeOfDay.Second);
            if (DateAndTime.TimeOfDay.Second < 10)
            {
                this.ss = "0" + this.ss;
            }
            this.genetext = "_" + this.monthm + this.dd + "_" + this.hh + this.mm + this.ss;
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(Form1));
            this.panel_welcome = new Panel();
            this.panel_velcome_new = new Panel();
            this.panel_modesel = new Panel();
            this.btn_entermanage = new Button();
            this.lbl_startmode = new Label();
            this.btn_modecancel = new Button();
            this.rad_create = new RadioButton();
            this.rad_continue = new RadioButton();
            this.rad_load = new RadioButton();
            this.rad_select = new RadioButton();
            this.Panel3 = new Panel();
            this.chk_issingle = new CheckBox();
            this.btn_create_next = new Button();
            this.btn_create_back = new Button();
            this.CheckBox1 = new CheckBox();
            this.TextBox4 = new TextBox();
            this.Button2 = new Button();
            this.TextBox1 = new TextBox();
            this.TextBox2 = new TextBox();
            this.Label4 = new Label();
            this.Label3 = new Label();
            this.Label10 = new Label();
            this.TextBox3 = new TextBox();
            this.RadioButton4 = new RadioButton();
            this.RadioButton5 = new RadioButton();
            this.Label2 = new Label();
            this.TextBox5 = new TextBox();
            this.Label1 = new Label();
            this.Label8 = new Label();
            this.Label7 = new Label();
            this.Panel2 = new Panel();
            this.Label5 = new Label();
            this.ComboBox1 = new ComboBox();
            this.lbl_loaded = new Label();
            this.btnstart = new Button();
            this.PictureBox1 = new PictureBox();
            this.panel_main = new Panel();
            this.tlp_taskbar2 = new TableLayoutPanel();
            this.btn_modify_presents = new Button();
            this.btn_dabianquan = new Button();
            this.btn_sfxquick = new Button();
            this.btn_sizequick = new Button();
            this.btn_fileplayback = new Button();
            this.lbl_sldeldte = new Label();
            this.lbl_slorig = new Label();
            this.panel_main_screen = new Panel();
            this.txthcmotion = new TextBox();
            this.WebBrowser1 = new WebBrowser();
            this.tlp_screenlist = new TableLayoutPanel();
            this.lbl_slist_status_01 = new Label();
            this.lbl_slist_1 = new Label();
            this.Label37 = new Label();
            this.Label38 = new Label();
            this.Label36 = new Label();
            this.Label39 = new Label();
            this.Label40 = new Label();
            this.Label41 = new Label();
            this.Label42 = new Label();
            this.Label43 = new Label();
            this.Label44 = new Label();
            this.Label45 = new Label();
            this.Label46 = new Label();
            this.Label47 = new Label();
            this.Label48 = new Label();
            this.Label49 = new Label();
            this.Label50 = new Label();
            this.Label51 = new Label();
            this.Label52 = new Label();
            this.Label53 = new Label();
            this.Label54 = new Label();
            this.Label55 = new Label();
            this.Label56 = new Label();
            this.Label57 = new Label();
            this.Label58 = new Label();
            this.Label59 = new Label();
            this.Label60 = new Label();
            this.Label62 = new Label();
            this.Label63 = new Label();
            this.Label64 = new Label();
            this.Label65 = new Label();
            this.Label66 = new Label();
            this.Label67 = new Label();
            this.Label68 = new Label();
            this.Label69 = new Label();
            this.Label70 = new Label();
            this.Label71 = new Label();
            this.Label72 = new Label();
            this.Label73 = new Label();
            this.Label74 = new Label();
            this.Label76 = new Label();
            this.Label77 = new Label();
            this.Label78 = new Label();
            this.Label79 = new Label();
            this.Label80 = new Label();
            this.Label81 = new Label();
            this.Label82 = new Label();
            this.Label83 = new Label();
            this.Label84 = new Label();
            this.Label85 = new Label();
            this.Label86 = new Label();
            this.Label87 = new Label();
            this.Label88 = new Label();
            this.Label89 = new Label();
            this.Label92 = new Label();
            this.Label93 = new Label();
            this.Label94 = new Label();
            this.Label109 = new Label();
            this.Label110 = new Label();
            this.Label112 = new Label();
            this.Label113 = new Label();
            this.Label114 = new Label();
            this.Label115 = new Label();
            this.Label116 = new Label();
            this.Label117 = new Label();
            this.Label118 = new Label();
            this.Label120 = new Label();
            this.Label121 = new Label();
            this.Label122 = new Label();
            this.Label123 = new Label();
            this.Label124 = new Label();
            this.Label125 = new Label();
            this.Label126 = new Label();
            this.Label127 = new Label();
            this.Label128 = new Label();
            this.Label129 = new Label();
            this.Label130 = new Label();
            this.Label131 = new Label();
            this.Label132 = new Label();
            this.Label133 = new Label();
            this.Label135 = new Label();
            this.Label136 = new Label();
            this.Label137 = new Label();
            this.Label138 = new Label();
            this.Label139 = new Label();
            this.Label140 = new Label();
            this.Label141 = new Label();
            this.Label142 = new Label();
            this.Label143 = new Label();
            this.Label144 = new Label();
            this.Label145 = new Label();
            this.Label146 = new Label();
            this.Label147 = new Label();
            this.Label148 = new Label();
            this.Label150 = new Label();
            this.Label151 = new Label();
            this.Label152 = new Label();
            this.Label153 = new Label();
            this.Label154 = new Label();
            this.Label155 = new Label();
            this.Label156 = new Label();
            this.Label157 = new Label();
            this.Label158 = new Label();
            this.Label159 = new Label();
            this.Label160 = new Label();
            this.Label161 = new Label();
            this.Label162 = new Label();
            this.Label163 = new Label();
            this.Label165 = new Label();
            this.Label166 = new Label();
            this.Label167 = new Label();
            this.Label168 = new Label();
            this.TableLayoutPanel1 = new TableLayoutPanel();
            this.btn_prev = new Button();
            this.btn_next = new Button();
            this.lblmain = new Label();
            this.panel_main_title = new Panel();
            this.TableLayoutPanel2 = new TableLayoutPanel();
            this.lblconf = new Label();
            this.lblopic = new Label();
            this.lbltime = new Label();
            this.panel_title_idle = new Panel();
            this.panel_main_sidebar = new Panel();
            this.panel_dbq = new Panel();
            this.btn_dbqstop = new Button();
            this.btn_dbqok = new Button();
            this.num_dbqtime = new NumericUpDown();
            this.btn_dbqcancel = new Button();
            this.Label200 = new Label();
            this.Label199 = new Label();
            this.txt_dbqnation = new TextBox();
            this.lbl_dbqstatus = new Label();
            this.Label195 = new Label();
            this.panel_readfile = new Panel();
            this.panel_introtask = new Panel();
            this.Label192 = new Label();
            this.chk_playback = new CheckBox();
            this.btn_file_modify = new Button();
            this.btn_read_close = new Button();
            this.lbl_fileinfo = new Label();
            this.lbl_reading = new Label();
            this.panel_mcedit = new Panel();
            this.btn_mcedit_save = new Button();
            this.btn_mcedit_cancle = new Button();
            this.Label188 = new Label();
            this.Label98 = new Label();
            this.txt_mceditnation = new TextBox();
            this.num_mcnumber = new NumericUpDown();
            this.Label11 = new Label();
            this.panel_files = new Panel();
            this.panel_file_bottom = new Panel();
            this.btn_file_ok = new Button();
            this.btn_file_cancel = new Button();
            this.panel_files_5 = new Panel();
            this.panel_f_5 = new Panel();
            this.num_fdl_ddm = new NumericUpDown();
            this.num_fdl_ddh = new NumericUpDown();
            this.num_fdl_amm = new NumericUpDown();
            this.num_fdl_amh = new NumericUpDown();
            this.num_fdl_drm = new NumericUpDown();
            this.num_fdl_drh = new NumericUpDown();
            this.chk_filedl_dr = new CheckBox();
            this.chk_filedl_am = new CheckBox();
            this.chk_filedl_dd = new CheckBox();
            this.btn_files_5 = new Button();
            this.panel_files_4 = new Panel();
            this.panel_f_4 = new Panel();
            this.Label194 = new Label();
            this.txt_fcrisis = new TextBox();
            this.num_crisis = new NumericUpDown();
            this.Label202 = new Label();
            this.btn_files_4 = new Button();
            this.panel_files_3 = new Panel();
            this.panel_f_3 = new Panel();
            this.cbx_fselcet_2 = new ComboBox();
            this.Label193 = new Label();
            this.btn_files_3 = new Button();
            this.panel_file_2 = new Panel();
            this.panel_f_2 = new Panel();
            this.TextBox17 = new TextBox();
            this.Label196 = new Label();
            this.Label197 = new Label();
            this.num_intro = new NumericUpDown();
            this.cbx_fselect = new ComboBox();
            this.Label198 = new Label();
            this.btn_file_2 = new Button();
            this.panel_file_1 = new Panel();
            this.panel_selfile = new Panel();
            this.btn_file_browse = new Button();
            this.lbl_filepath = new Label();
            this.Label191 = new Label();
            this.panel_signatories = new Panel();
            this.txt_file_signatories = new TextBox();
            this.Label106 = new Label();
            this.panel_sponsors = new Panel();
            this.txt_file_sponsors = new TextBox();
            this.Label105 = new Label();
            this.panel_f_1 = new Panel();
            this.txt_filenumber_2 = new TextBox();
            this.rad_present = new RadioButton();
            this.txt_filenumber_1 = new TextBox();
            this.rad_paper = new RadioButton();
            this.Label35 = new Label();
            this.Label103 = new Label();
            this.cbx_ftpye = new ComboBox();
            this.txt_filenumber_3 = new TextBox();
            this.num_file = new NumericUpDown();
            this.Label104 = new Label();
            this.btn_file_1 = new Button();
            this.panel_file_top = new Panel();
            this.Label190 = new Label();
            this.Label34 = new Label();
            this.panel_misc = new Panel();
            this.panel_misc_bottom = new Panel();
            this.btn_misc_cancel = new Button();
            this.btn_misc_ok = new Button();
            this.panel_misc_5 = new Panel();
            this.panel_ms_5 = new Panel();
            this.txt_custom = new TextBox();
            this.Label201 = new Label();
            this.btn_misc_5 = new Button();
            this.btn_misc_4 = new Button();
            this.panel_misc_3 = new Panel();
            this.panel_ms_3 = new Panel();
            this.Label180 = new Label();
            this.cbx_awards = new ComboBox();
            this.txt_awardsch = new TextBox();
            this.Label91 = new Label();
            this.txt_awardnat = new TextBox();
            this.txt_awardelg = new TextBox();
            this.Label134 = new Label();
            this.Label149 = new Label();
            this.btn_misc_3 = new Button();
            this.panel_misc_2 = new Panel();
            this.btn_misc_2 = new Button();
            this.panel_ms_2 = new Panel();
            this.panel_clock = new Panel();
            this.Label179 = new Label();
            this.Label178 = new Label();
            this.TrackBar1 = new TrackBar();
            this.TextBox10 = new TextBox();
            this.DateTimePicker1 = new DateTimePicker();
            this.Label164 = new Label();
            this.numhh = new NumericUpDown();
            this.Label176 = new Label();
            this.nummm = new NumericUpDown();
            this.Label177 = new Label();
            this.rad_clockyes = new RadioButton();
            this.rad_clockno = new RadioButton();
            this.panel_misc_1 = new Panel();
            this.panel_ms_1 = new Panel();
            this.num_tbtime = new NumericUpDown();
            this.Label119 = new Label();
            this.btn_misc_1 = new Button();
            this.panel_misc_top = new Panel();
            this.Label90 = new Label();
            this.Label75 = new Label();
            this.panel_vote = new Panel();
            this.panel_vote_config = new Panel();
            this.chk_noabst = new CheckBox();
            this.rad_all = new RadioButton();
            this.rad_80maj = new RadioButton();
            this.rad_67maj = new RadioButton();
            this.rad_50maj = new RadioButton();
            this.CheckBox6 = new CheckBox();
            this.CheckBox5 = new CheckBox();
            this.CheckBox4 = new CheckBox();
            this.CheckBox3 = new CheckBox();
            this.CheckBox2 = new CheckBox();
            this.chk_vote_foujue = new CheckBox();
            this.panel_vote_ctrl = new Panel();
            this.Label108 = new Label();
            this.btnpass = new Button();
            this.btnabst = new Button();
            this.btnno = new Button();
            this.btnyes = new Button();
            this.lbl_vote_nation = new Label();
            this.panel_vote_roll = new Panel();
            this.chk_vote_saveplist = new CheckBox();
            this.clb_nation_vote = new CheckedListBox();
            this.panel_vote_top = new Panel();
            this.Label111 = new Label();
            this.lbl_vote_step = new Label();
            this.panel_vote_bottom = new Panel();
            this.lblabst1 = new Label();
            this.lblno1 = new Label();
            this.btn_vote_next = new Button();
            this.btn_vote_cancel = new Button();
            this.lblno = new Label();
            this.lblyes1 = new Label();
            this.lblyes = new Label();
            this.lblabst = new Label();
            this.panel_motion = new Panel();
            this.Panel5 = new Panel();
            this.btn_motionstop = new Button();
            this.btn_motion_finish = new Button();
            this.btn_motion_cancel = new Button();
            this.panel_motion_6 = new Panel();
            this.panel_m_6 = new Panel();
            this.Label187 = new Label();
            this.txt_mneirong = new TextBox();
            this.chk_istimeruse = new CheckBox();
            this.num_m_custom = new NumericUpDown();
            this.Label189 = new Label();
            this.btn_motion_9 = new Button();
            this.btn_motion_8 = new Button();
            this.panel_motion_5 = new Panel();
            this.btn_motion_7 = new Button();
            this.btn_motion_6 = new Button();
            this.btn_motion_5 = new Button();
            this.panel_motion_4 = new Panel();
            this.panel_m_4 = new Panel();
            this.cbx_mfileselect = new ComboBox();
            this.Label99 = new Label();
            this.btn_motion_4 = new Button();
            this.panel_motions_3 = new Panel();
            this.panel_m_3 = new Panel();
            this.num_m_spl_1 = new NumericUpDown();
            this.num_m_spl_2 = new NumericUpDown();
            this.Label185 = new Label();
            this.btn_motion_3 = new Button();
            this.panel_motions_2 = new Panel();
            this.panel_m_2 = new Panel();
            this.num_m_umc = new NumericUpDown();
            this.Label186 = new Label();
            this.btn_motion_2 = new Button();
            this.panel_singledel = new Panel();
            this.btn_ispresent = new Button();
            this.Label175 = new Label();
            this.Label174 = new Label();
            this.cbx_singledel = new ComboBox();
            this.Label173 = new Label();
            this.panel_motions_1 = new Panel();
            this.panel_m_1 = new Panel();
            this.num_m_mc_1 = new NumericUpDown();
            this.Label97 = new Label();
            this.txt_mtopic = new TextBox();
            this.num_m_mc_2 = new NumericUpDown();
            this.Label183 = new Label();
            this.Label184 = new Label();
            this.btn_motion_1 = new Button();
            this.panel_motions_top = new Panel();
            this.Label95 = new Label();
            this.Label96 = new Label();
            this.txt_mnation = new TextBox();
            this.panel_sidebar_starting = new Panel();
            this.panel_startmethod = new Panel();
            this.numstartm = new NumericUpDown();
            this.rad_immediatestart = new RadioButton();
            this.numstarth = new NumericUpDown();
            this.rad_timedstart = new RadioButton();
            this.btn_start_cancel = new Button();
            this.btn_start_ok = new Button();
            this.btn_roll_finish = new Button();
            this.btn_roll_cancle = new Button();
            this.Label17 = new Label();
            this.Label16 = new Label();
            this.txtsession = new TextBox();
            this.Label14 = new Label();
            this.Label13 = new Label();
            this.clb_nation_main = new CheckedListBox();
            this.panel_spakers_list = new Panel();
            this.panel_csl = new Panel();
            this.btn_spl_loadcustom = new Button();
            this.btn_spl_savecustom = new Button();
            this.Label21 = new Label();
            this.txt_spl_customtitle = new TextBox();
            this.chk_spl_allowyield = new CheckBox();
            this.num_spl_timem = new NumericUpDown();
            this.num_spl_times = new NumericUpDown();
            this.Label29 = new Label();
            this.txt_spl_yieldto = new TextBox();
            this.btn_spl_exit = new Button();
            this.btn_spl_yieldend = new Button();
            this.btn_spl_yieldgo = new Button();
            this.Label28 = new Label();
            this.cbx_spl_yield = new ComboBox();
            this.btn_spl_start = new Button();
            this.btn_spl_add = new Button();
            this.txt_spl_current = new TextBox();
            this.txt_spl_currentnunber = new TextBox();
            this.txt_spl_add = new TextBox();
            this.txt_spl_totalnumber = new TextBox();
            this.Label23 = new Label();
            this.Label22 = new Label();
            this.llb_spl_entercustom = new LinkLabel();
            this.Label20 = new Label();
            this.panel_system = new Panel();
            this.Label61 = new Label();
            this.btn_system_calcel = new Button();
            this.btnexit = new Button();
            this.Button12 = new Button();
            this.Button11 = new Button();
            this.btn_system_1 = new Button();
            this.panel_editnationlist = new Panel();
            this.btn_enl_save = new Button();
            this.btn_enl_cancel = new Button();
            this.txtnationlist = new TextBox();
            this.Label19 = new Label();
            this.Label18 = new Label();
            this.panel_mc = new Panel();
            this.btn_mc_next = new Button();
            this.Label33 = new Label();
            this.btn_mc_end = new Button();
            this.Label30 = new Label();
            this.Label102 = new Label();
            this.lbl_mc_total_time = new Label();
            this.btn_mc_start = new Button();
            this.Label31 = new Label();
            this.Label32 = new Label();
            this.txt_mc_totalnumber = new TextBox();
            this.txt_mc_add = new TextBox();
            this.txt_mc_currentnumber = new TextBox();
            this.txt_mc_current = new TextBox();
            this.btn_mc_add = new Button();
            this.panel_umc = new Panel();
            this.btn_umc_send = new Button();
            this.btn_umc_reset = new Button();
            this.txt_umccustom = new TextBox();
            this.Label182 = new Label();
            this.Label101 = new Label();
            this.btn_umc_close = new Button();
            this.Label181 = new Label();
            this.Label100 = new Label();
            this.panel_presents = new Panel();
            this.lbl20maj1 = new Label();
            this.lbl67maj1 = new Label();
            this.lbl50maj1 = new Label();
            this.lbl20maj = new Label();
            this.lbl67maj = new Label();
            this.lbl50maj = new Label();
            this.lblpresent = new Label();
            this.lblpresent1 = new Label();
            this.panel_sidebar_timer = new Panel();
            this.lblmaohao = new Label();
            this.numtime = new NumericUpDown();
            this.Panel1 = new Panel();
            this.Button1 = new Button();
            this.Button5 = new Button();
            this.TextBox11 = new TextBox();
            this.TextBox12 = new TextBox();
            this.TextBox13 = new TextBox();
            this.TextBox14 = new TextBox();
            this.TextBox15 = new TextBox();
            this.Label24 = new Label();
            this.Label25 = new Label();
            this.Label26 = new Label();
            this.LinkLabel2 = new LinkLabel();
            this.Label27 = new Label();
            this.Button4 = new Button();
            this.Button3 = new Button();
            this.Label12 = new Label();
            this.lblcount = new Label();
            this.panel_sidebar_idle = new Panel();
            this.tlp_taskbar = new TableLayoutPanel();
            this.btn_sessionstart = new Button();
            this.btn_speakerslist = new Button();
            this.btn_motions = new Button();
            this.btn_file = new Button();
            this.btn_misc = new Button();
            this.btn_system = new Button();
            this.cbx_fmode = new ComboBox();
            this.Timer1 = new Timer(this.components);
            this.panel_manage = new Panel();
            this.chk_rule_1 = new CheckBox();
            this.Label203 = new Label();
            this.btn_fontchange = new Button();
            this.Label169 = new Label();
            this.GroupBox1 = new GroupBox();
            this.txt_fontpreview = new TextBox();
            this.btn_sfx4 = new Button();
            this.btn_sfx3 = new Button();
            this.btn_sfx2 = new Button();
            this.btn_sfx1 = new Button();
            this.num_timeleft = new NumericUpDown();
            this.txt_sfx4 = new TextBox();
            this.txt_sfx3 = new TextBox();
            this.txt_sfx2 = new TextBox();
            this.txt_sfx1 = new TextBox();
            this.chk_sfx_start = new CheckBox();
            this.chk_sfx_time60 = new CheckBox();
            this.chk_sfx_time20 = new CheckBox();
            this.chk_sfx_timeout = new CheckBox();
            this.chk_is_mainimg = new CheckBox();
            this.Panel4 = new Panel();
            this.btn_manage_exit = new Button();
            this.btn_manage_save = new Button();
            this.btn_backbrowse = new Button();
            this.btn_bannerbrowse = new Button();
            this.txt_mainimg = new TextBox();
            this.txt_startimg = new TextBox();
            this.Label172 = new Label();
            this.Label170 = new Label();
            this.Label9 = new Label();
            this.Label6 = new Label();
            this.tlp_manage_top = new TableLayoutPanel();
            this.lbl_manage_setting = new Label();
            this.lblinfo = new Label();
            this.lbl_manage_conferences = new Label();
            this.lbl_manage_about = new Label();
            this.rad_pink = new RadioButton();
            this.rad_purple = new RadioButton();
            this.rad_blue = new RadioButton();
            this.rad_teal = new RadioButton();
            this.rad_green = new RadioButton();
            this.rad_orange = new RadioButton();
            this.rad_darkred = new RadioButton();
            this.Label171 = new Label();
            this.ofd_banner = new OpenFileDialog();
            this.ofd_sfx = new OpenFileDialog();
            this.panel_m_5 = new Panel();
            this.ofd_doc = new OpenFileDialog();
            this.ofd_csl = new OpenFileDialog();
            this.sfd_csl = new SaveFileDialog();
            this.FontDialog1 = new FontDialog();
            this.NotifyIcon1 = new NotifyIcon(this.components);
            this.btn_votectrl = new Button();
            this.panel_welcome.SuspendLayout();
            this.panel_velcome_new.SuspendLayout();
            this.panel_modesel.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.Panel2.SuspendLayout();
            ((ISupportInitialize) this.PictureBox1).BeginInit();
            this.panel_main.SuspendLayout();
            this.tlp_taskbar2.SuspendLayout();
            this.panel_main_screen.SuspendLayout();
            this.tlp_screenlist.SuspendLayout();
            this.TableLayoutPanel1.SuspendLayout();
            this.panel_main_title.SuspendLayout();
            this.TableLayoutPanel2.SuspendLayout();
            this.panel_main_sidebar.SuspendLayout();
            this.panel_dbq.SuspendLayout();
            this.num_dbqtime.BeginInit();
            this.panel_readfile.SuspendLayout();
            this.panel_introtask.SuspendLayout();
            this.panel_mcedit.SuspendLayout();
            this.num_mcnumber.BeginInit();
            this.panel_files.SuspendLayout();
            this.panel_file_bottom.SuspendLayout();
            this.panel_files_5.SuspendLayout();
            this.panel_f_5.SuspendLayout();
            this.num_fdl_ddm.BeginInit();
            this.num_fdl_ddh.BeginInit();
            this.num_fdl_amm.BeginInit();
            this.num_fdl_amh.BeginInit();
            this.num_fdl_drm.BeginInit();
            this.num_fdl_drh.BeginInit();
            this.panel_files_4.SuspendLayout();
            this.panel_f_4.SuspendLayout();
            this.num_crisis.BeginInit();
            this.panel_files_3.SuspendLayout();
            this.panel_f_3.SuspendLayout();
            this.panel_file_2.SuspendLayout();
            this.panel_f_2.SuspendLayout();
            this.num_intro.BeginInit();
            this.panel_file_1.SuspendLayout();
            this.panel_selfile.SuspendLayout();
            this.panel_signatories.SuspendLayout();
            this.panel_sponsors.SuspendLayout();
            this.panel_f_1.SuspendLayout();
            this.num_file.BeginInit();
            this.panel_file_top.SuspendLayout();
            this.panel_misc.SuspendLayout();
            this.panel_misc_bottom.SuspendLayout();
            this.panel_misc_5.SuspendLayout();
            this.panel_ms_5.SuspendLayout();
            this.panel_misc_3.SuspendLayout();
            this.panel_ms_3.SuspendLayout();
            this.panel_misc_2.SuspendLayout();
            this.panel_ms_2.SuspendLayout();
            this.panel_clock.SuspendLayout();
            this.TrackBar1.BeginInit();
            this.numhh.BeginInit();
            this.nummm.BeginInit();
            this.panel_misc_1.SuspendLayout();
            this.panel_ms_1.SuspendLayout();
            this.num_tbtime.BeginInit();
            this.panel_misc_top.SuspendLayout();
            this.panel_vote.SuspendLayout();
            this.panel_vote_config.SuspendLayout();
            this.panel_vote_ctrl.SuspendLayout();
            this.panel_vote_roll.SuspendLayout();
            this.panel_vote_top.SuspendLayout();
            this.panel_vote_bottom.SuspendLayout();
            this.panel_motion.SuspendLayout();
            this.Panel5.SuspendLayout();
            this.panel_motion_6.SuspendLayout();
            this.panel_m_6.SuspendLayout();
            this.num_m_custom.BeginInit();
            this.panel_motion_5.SuspendLayout();
            this.panel_motion_4.SuspendLayout();
            this.panel_m_4.SuspendLayout();
            this.panel_motions_3.SuspendLayout();
            this.panel_m_3.SuspendLayout();
            this.num_m_spl_1.BeginInit();
            this.num_m_spl_2.BeginInit();
            this.panel_motions_2.SuspendLayout();
            this.panel_m_2.SuspendLayout();
            this.num_m_umc.BeginInit();
            this.panel_singledel.SuspendLayout();
            this.panel_motions_1.SuspendLayout();
            this.panel_m_1.SuspendLayout();
            this.num_m_mc_1.BeginInit();
            this.num_m_mc_2.BeginInit();
            this.panel_motions_top.SuspendLayout();
            this.panel_sidebar_starting.SuspendLayout();
            this.panel_startmethod.SuspendLayout();
            this.numstartm.BeginInit();
            this.numstarth.BeginInit();
            this.panel_spakers_list.SuspendLayout();
            this.panel_csl.SuspendLayout();
            this.num_spl_timem.BeginInit();
            this.num_spl_times.BeginInit();
            this.panel_system.SuspendLayout();
            this.panel_editnationlist.SuspendLayout();
            this.panel_mc.SuspendLayout();
            this.panel_umc.SuspendLayout();
            this.panel_presents.SuspendLayout();
            this.panel_sidebar_timer.SuspendLayout();
            this.numtime.BeginInit();
            this.Panel1.SuspendLayout();
            this.tlp_taskbar.SuspendLayout();
            this.panel_manage.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.num_timeleft.BeginInit();
            this.Panel4.SuspendLayout();
            this.tlp_manage_top.SuspendLayout();
            this.SuspendLayout();
            this.panel_welcome.Controls.Add(this.panel_velcome_new);
            this.panel_welcome.Controls.Add(this.PictureBox1);
            Point point2 = new Point(3, 13);
            this.panel_welcome.Location = point2;
            Padding padding2 = new Padding(3, 4, 3, 4);
            this.panel_welcome.Margin = padding2;
            this.panel_welcome.Name = "panel_welcome";
            Size size2 = new Size(0x3f2, 0x2f6);
            this.panel_welcome.Size = size2;
            this.panel_welcome.TabIndex = 2;
            this.panel_velcome_new.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            this.panel_velcome_new.Controls.Add(this.panel_modesel);
            this.panel_velcome_new.Controls.Add(this.Panel3);
            this.panel_velcome_new.Controls.Add(this.Label8);
            this.panel_velcome_new.Controls.Add(this.Label7);
            this.panel_velcome_new.Controls.Add(this.Panel2);
            this.panel_velcome_new.Controls.Add(this.btnstart);
            point2 = new Point(0x2de, 0x1a5);
            this.panel_velcome_new.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_velcome_new.Margin = padding2;
            this.panel_velcome_new.Name = "panel_velcome_new";
            size2 = new Size(240, 0x150);
            this.panel_velcome_new.Size = size2;
            this.panel_velcome_new.TabIndex = 0x16;
            this.panel_modesel.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.panel_modesel.Controls.Add(this.btn_entermanage);
            this.panel_modesel.Controls.Add(this.lbl_startmode);
            this.panel_modesel.Controls.Add(this.btn_modecancel);
            this.panel_modesel.Controls.Add(this.rad_create);
            this.panel_modesel.Controls.Add(this.rad_continue);
            this.panel_modesel.Controls.Add(this.rad_load);
            this.panel_modesel.Controls.Add(this.rad_select);
            point2 = new Point(0, 0x6a);
            this.panel_modesel.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_modesel.Margin = padding2;
            this.panel_modesel.Name = "panel_modesel";
            size2 = new Size(240, 0x16);
            this.panel_modesel.Size = size2;
            this.panel_modesel.TabIndex = 0x13;
            this.btn_entermanage.FlatAppearance.BorderSize = 0;
            this.btn_entermanage.FlatAppearance.MouseDownBackColor = Color.Thistle;
            this.btn_entermanage.FlatStyle = FlatStyle.Flat;
            this.btn_entermanage.Font = new Font("微软雅黑", 12f);
            this.btn_entermanage.ImeMode = ImeMode.NoControl;
            point2 = new Point(0, 0x94);
            this.btn_entermanage.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_entermanage.Margin = padding2;
            this.btn_entermanage.Name = "btn_entermanage";
            size2 = new Size(240, 0x1f);
            this.btn_entermanage.Size = size2;
            this.btn_entermanage.TabIndex = 20;
            this.btn_entermanage.Text = "进入后台管理界面";
            this.btn_entermanage.UseVisualStyleBackColor = true;
            this.lbl_startmode.BackColor = Color.Thistle;
            this.lbl_startmode.FlatStyle = FlatStyle.Flat;
            this.lbl_startmode.Font = new Font("Segoe UI", 12f);
            this.lbl_startmode.ImeMode = ImeMode.NoControl;
            point2 = new Point(0, 0);
            this.lbl_startmode.Location = point2;
            this.lbl_startmode.Name = "lbl_startmode";
            size2 = new Size(240, 0x16);
            this.lbl_startmode.Size = size2;
            this.lbl_startmode.TabIndex = 0;
            this.lbl_startmode.Text = "请选择功能项";
            this.lbl_startmode.TextAlign = ContentAlignment.TopCenter;
            this.btn_modecancel.FlatAppearance.BorderSize = 0;
            this.btn_modecancel.FlatAppearance.MouseDownBackColor = Color.Thistle;
            this.btn_modecancel.FlatStyle = FlatStyle.Flat;
            this.btn_modecancel.Font = new Font("微软雅黑", 12f);
            this.btn_modecancel.ImeMode = ImeMode.NoControl;
            point2 = new Point(0, 180);
            this.btn_modecancel.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_modecancel.Margin = padding2;
            this.btn_modecancel.Name = "btn_modecancel";
            size2 = new Size(240, 0x1f);
            this.btn_modecancel.Size = size2;
            this.btn_modecancel.TabIndex = 0x13;
            this.btn_modecancel.Text = "取消";
            this.btn_modecancel.UseVisualStyleBackColor = true;
            this.rad_create.Appearance = Appearance.Button;
            this.rad_create.Checked = true;
            this.rad_create.FlatAppearance.BorderSize = 0;
            this.rad_create.FlatAppearance.CheckedBackColor = Color.Thistle;
            this.rad_create.FlatStyle = FlatStyle.Flat;
            this.rad_create.Font = new Font("微软雅黑", 12f);
            this.rad_create.ImeMode = ImeMode.NoControl;
            point2 = new Point(0, 0x75);
            this.rad_create.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.rad_create.Margin = padding2;
            this.rad_create.Name = "rad_create";
            size2 = new Size(240, 0x1f);
            this.rad_create.Size = size2;
            this.rad_create.TabIndex = 13;
            this.rad_create.TabStop = true;
            this.rad_create.Text = "创建新的档案";
            this.rad_create.TextAlign = ContentAlignment.MiddleCenter;
            this.rad_create.UseVisualStyleBackColor = true;
            this.rad_continue.Appearance = Appearance.Button;
            this.rad_continue.FlatAppearance.BorderColor = Color.White;
            this.rad_continue.FlatAppearance.CheckedBackColor = Color.Thistle;
            this.rad_continue.FlatStyle = FlatStyle.Flat;
            this.rad_continue.Font = new Font("微软雅黑", 12f);
            this.rad_continue.ImeMode = ImeMode.NoControl;
            point2 = new Point(0, 0x16);
            this.rad_continue.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.rad_continue.Margin = padding2;
            this.rad_continue.Name = "rad_continue";
            size2 = new Size(240, 0x1f);
            this.rad_continue.Size = size2;
            this.rad_continue.TabIndex = 11;
            this.rad_continue.Text = "继续上一次会议";
            this.rad_continue.TextAlign = ContentAlignment.MiddleCenter;
            this.rad_continue.UseVisualStyleBackColor = true;
            this.rad_load.Appearance = Appearance.Button;
            this.rad_load.FlatAppearance.BorderSize = 0;
            this.rad_load.FlatAppearance.CheckedBackColor = Color.Thistle;
            this.rad_load.FlatStyle = FlatStyle.Flat;
            this.rad_load.Font = new Font("微软雅黑", 12f);
            this.rad_load.ImeMode = ImeMode.NoControl;
            point2 = new Point(0, 0x56);
            this.rad_load.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.rad_load.Margin = padding2;
            this.rad_load.Name = "rad_load";
            size2 = new Size(240, 0x1f);
            this.rad_load.Size = size2;
            this.rad_load.TabIndex = 12;
            this.rad_load.Text = "从外部文件读取";
            this.rad_load.TextAlign = ContentAlignment.MiddleCenter;
            this.rad_load.UseVisualStyleBackColor = true;
            this.rad_select.Appearance = Appearance.Button;
            this.rad_select.FlatAppearance.BorderSize = 0;
            this.rad_select.FlatAppearance.CheckedBackColor = Color.Thistle;
            this.rad_select.FlatStyle = FlatStyle.Flat;
            this.rad_select.Font = new Font("微软雅黑", 12f);
            this.rad_select.ImeMode = ImeMode.NoControl;
            point2 = new Point(0, 0x36);
            this.rad_select.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.rad_select.Margin = padding2;
            this.rad_select.Name = "rad_select";
            size2 = new Size(240, 0x1f);
            this.rad_select.Size = size2;
            this.rad_select.TabIndex = 0x12;
            this.rad_select.Text = "选择已保存的档案";
            this.rad_select.TextAlign = ContentAlignment.MiddleCenter;
            this.rad_select.UseVisualStyleBackColor = true;
            this.Panel3.Controls.Add(this.chk_issingle);
            this.Panel3.Controls.Add(this.btn_create_next);
            this.Panel3.Controls.Add(this.btn_create_back);
            this.Panel3.Controls.Add(this.CheckBox1);
            this.Panel3.Controls.Add(this.TextBox4);
            this.Panel3.Controls.Add(this.Button2);
            this.Panel3.Controls.Add(this.TextBox1);
            this.Panel3.Controls.Add(this.TextBox2);
            this.Panel3.Controls.Add(this.Label4);
            this.Panel3.Controls.Add(this.Label3);
            this.Panel3.Controls.Add(this.Label10);
            this.Panel3.Controls.Add(this.TextBox3);
            this.Panel3.Controls.Add(this.RadioButton4);
            this.Panel3.Controls.Add(this.RadioButton5);
            this.Panel3.Controls.Add(this.Label2);
            this.Panel3.Controls.Add(this.TextBox5);
            this.Panel3.Controls.Add(this.Label1);
            point2 = new Point(0, 0x81);
            this.Panel3.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.Panel3.Margin = padding2;
            this.Panel3.Name = "Panel3";
            size2 = new Size(240, 0x149);
            this.Panel3.Size = size2;
            this.Panel3.TabIndex = 0x10;
            this.chk_issingle.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.chk_issingle.AutoSize = true;
            this.chk_issingle.ImeMode = ImeMode.NoControl;
            point2 = new Point(13, 0x111);
            this.chk_issingle.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.chk_issingle.Margin = padding2;
            this.chk_issingle.Name = "chk_issingle";
            size2 = new Size(0x4a, 0x11);
            this.chk_issingle.Size = size2;
            this.chk_issingle.TabIndex = 20;
            this.chk_issingle.Text = "单代表制";
            this.chk_issingle.UseVisualStyleBackColor = true;
            this.btn_create_next.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.btn_create_next.BackColor = Color.Thistle;
            this.btn_create_next.Cursor = Cursors.Default;
            this.btn_create_next.FlatAppearance.BorderSize = 0;
            this.btn_create_next.FlatStyle = FlatStyle.Flat;
            this.btn_create_next.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x84, 0xa8);
            this.btn_create_next.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_create_next.Margin = padding2;
            this.btn_create_next.Name = "btn_create_next";
            size2 = new Size(0x62, 0x19);
            this.btn_create_next.Size = size2;
            this.btn_create_next.TabIndex = 0x13;
            this.btn_create_next.Text = "下一步";
            this.btn_create_next.UseVisualStyleBackColor = false;
            this.btn_create_back.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.btn_create_back.Cursor = Cursors.Default;
            this.btn_create_back.FlatAppearance.BorderSize = 0;
            this.btn_create_back.FlatStyle = FlatStyle.Flat;
            this.btn_create_back.ImeMode = ImeMode.NoControl;
            point2 = new Point(13, 0x129);
            this.btn_create_back.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_create_back.Margin = padding2;
            this.btn_create_back.Name = "btn_create_back";
            size2 = new Size(0x62, 0x19);
            this.btn_create_back.Size = size2;
            this.btn_create_back.TabIndex = 0x12;
            this.btn_create_back.Text = "返回";
            this.btn_create_back.UseVisualStyleBackColor = true;
            this.CheckBox1.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.CheckAlign = ContentAlignment.MiddleRight;
            this.CheckBox1.ImeMode = ImeMode.NoControl;
            point2 = new Point(10, 0x60);
            this.CheckBox1.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.CheckBox1.Margin = padding2;
            this.CheckBox1.Name = "CheckBox1";
            size2 = new Size(0x38, 0x11);
            this.CheckBox1.Size = size2;
            this.CheckBox1.TabIndex = 11;
            this.CheckBox1.Text = "议题2";
            this.CheckBox1.UseVisualStyleBackColor = true;
            this.TextBox4.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.TextBox4.Enabled = false;
            point2 = new Point(70, 0x5f);
            this.TextBox4.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.TextBox4.Margin = padding2;
            this.TextBox4.Name = "TextBox4";
            size2 = new Size(160, 20);
            this.TextBox4.Size = size2;
            this.TextBox4.TabIndex = 6;
            this.Button2.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.Button2.BackColor = Color.Thistle;
            this.Button2.FlatAppearance.BorderSize = 0;
            this.Button2.FlatStyle = FlatStyle.Flat;
            this.Button2.ForeColor = SystemColors.ControlText;
            this.Button2.ImeMode = ImeMode.NoControl;
            point2 = new Point(0xb6, 0xf1);
            this.Button2.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.Button2.Margin = padding2;
            this.Button2.Name = "Button2";
            size2 = new Size(0x2f, 0x19);
            this.Button2.Size = size2;
            this.Button2.TabIndex = 0x11;
            this.Button2.Text = "生成";
            this.Button2.UseVisualStyleBackColor = false;
            this.TextBox1.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            point2 = new Point(70, 8);
            this.TextBox1.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.TextBox1.Margin = padding2;
            this.TextBox1.Name = "TextBox1";
            size2 = new Size(160, 20);
            this.TextBox1.Size = size2;
            this.TextBox1.TabIndex = 3;
            this.TextBox2.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            point2 = new Point(70, 0x25);
            this.TextBox2.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.TextBox2.Margin = padding2;
            this.TextBox2.Name = "TextBox2";
            size2 = new Size(160, 20);
            this.TextBox2.Size = size2;
            this.TextBox2.TabIndex = 4;
            this.Label4.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.Label4.AutoSize = true;
            this.Label4.ImeMode = ImeMode.NoControl;
            point2 = new Point(11, 0xdb);
            this.Label4.Location = point2;
            this.Label4.Name = "Label4";
            size2 = new Size(0x37, 13);
            this.Label4.Size = size2;
            this.Label4.TabIndex = 12;
            this.Label4.Text = "工作语言";
            this.Label3.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.Label3.AutoSize = true;
            this.Label3.ImeMode = ImeMode.NoControl;
            point2 = new Point(11, 0x45);
            this.Label3.Location = point2;
            this.Label3.Name = "Label3";
            size2 = new Size(0x1f, 13);
            this.Label3.Size = size2;
            this.Label3.TabIndex = 9;
            this.Label3.Text = "议题";
            this.Label10.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.Label10.AutoSize = true;
            this.Label10.ImeMode = ImeMode.NoControl;
            point2 = new Point(11, 0xf6);
            this.Label10.Location = point2;
            this.Label10.Name = "Label10";
            size2 = new Size(0x37, 13);
            this.Label10.Size = size2;
            this.Label10.TabIndex = 0x10;
            this.Label10.Text = "档案名称";
            this.TextBox3.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            point2 = new Point(70, 0x41);
            this.TextBox3.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.TextBox3.Margin = padding2;
            this.TextBox3.Name = "TextBox3";
            size2 = new Size(160, 20);
            this.TextBox3.Size = size2;
            this.TextBox3.TabIndex = 5;
            this.RadioButton4.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.RadioButton4.AutoSize = true;
            this.RadioButton4.Checked = true;
            this.RadioButton4.ImeMode = ImeMode.NoControl;
            point2 = new Point(70, 0xd9);
            this.RadioButton4.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.RadioButton4.Margin = padding2;
            this.RadioButton4.Name = "RadioButton4";
            size2 = new Size(0x49, 0x11);
            this.RadioButton4.Size = size2;
            this.RadioButton4.TabIndex = 13;
            this.RadioButton4.TabStop = true;
            this.RadioButton4.Text = "简体中文";
            this.RadioButton4.UseVisualStyleBackColor = true;
            this.RadioButton5.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.RadioButton5.AutoSize = true;
            this.RadioButton5.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x9d, 0xd9);
            this.RadioButton5.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.RadioButton5.Margin = padding2;
            this.RadioButton5.Name = "RadioButton5";
            size2 = new Size(0x3b, 0x11);
            this.RadioButton5.Size = size2;
            this.RadioButton5.TabIndex = 14;
            this.RadioButton5.Text = "English";
            this.RadioButton5.UseVisualStyleBackColor = true;
            this.Label2.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.Label2.AutoSize = true;
            this.Label2.ImeMode = ImeMode.NoControl;
            point2 = new Point(11, 40);
            this.Label2.Location = point2;
            this.Label2.Name = "Label2";
            size2 = new Size(0x2b, 13);
            this.Label2.Size = size2;
            this.Label2.TabIndex = 8;
            this.Label2.Text = "委员会";
            this.TextBox5.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            point2 = new Point(70, 0xf3);
            this.TextBox5.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.TextBox5.Margin = padding2;
            this.TextBox5.Name = "TextBox5";
            size2 = new Size(0x6a, 20);
            this.TextBox5.Size = size2;
            this.TextBox5.TabIndex = 15;
            this.Label1.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.Label1.AutoSize = true;
            this.Label1.ImeMode = ImeMode.NoControl;
            point2 = new Point(11, 11);
            this.Label1.Location = point2;
            this.Label1.Name = "Label1";
            size2 = new Size(0x37, 13);
            this.Label1.Size = size2;
            this.Label1.TabIndex = 7;
            this.Label1.Text = "大会名称";
            this.Label8.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.Label8.AutoSize = true;
            this.Label8.Font = new Font("Segoe UI Light", 12f);
            this.Label8.ImeMode = ImeMode.NoControl;
            point2 = new Point(9, 0x39);
            this.Label8.Location = point2;
            this.Label8.Name = "Label8";
            size2 = new Size(0xe3, 0x2a);
            this.Label8.Size = size2;
            this.Label8.TabIndex = 0x13;
            this.Label8.Text = "Copyright (c) illumer Community\r\nVersion 2.01beta  build 401";
            this.Label8.TextAlign = ContentAlignment.TopCenter;
            this.Label7.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.Label7.AutoSize = true;
            this.Label7.BackColor = Color.Transparent;
            this.Label7.Font = new Font("Segoe UI Light", 32f);
            this.Label7.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x24, 0);
            this.Label7.Location = point2;
            this.Label7.Name = "Label7";
            size2 = new Size(0xab, 0x3b);
            this.Label7.Size = size2;
            this.Label7.TabIndex = 0x12;
            this.Label7.Text = "Console";
            this.Panel2.Controls.Add(this.Label5);
            this.Panel2.Controls.Add(this.ComboBox1);
            this.Panel2.Controls.Add(this.lbl_loaded);
            point2 = new Point(0, 0x81);
            this.Panel2.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.Panel2.Margin = padding2;
            this.Panel2.Name = "Panel2";
            size2 = new Size(240, 0x90);
            this.Panel2.Size = size2;
            this.Panel2.TabIndex = 0x16;
            this.Label5.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.Label5.ImeMode = ImeMode.NoControl;
            point2 = new Point(11, 0x26);
            this.Label5.Location = point2;
            this.Label5.Name = "Label5";
            size2 = new Size(0xda, 0x4e);
            this.Label5.Size = size2;
            this.Label5.TabIndex = 12;
            this.Label5.Text = "档案名称:\r\n大会:\r\n委员会:\r\n议题:\r\n工作语言:\r\n创建时间:";
            this.ComboBox1.Anchor = AnchorStyles.Top;
            this.ComboBox1.FormattingEnabled = true;
            point2 = new Point(13, 8);
            this.ComboBox1.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.ComboBox1.Margin = padding2;
            this.ComboBox1.Name = "ComboBox1";
            size2 = new Size(0xd8, 0x15);
            this.ComboBox1.Size = size2;
            this.ComboBox1.TabIndex = 0x11;
            this.ComboBox1.Text = "选择一个会议档案";
            this.lbl_loaded.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.lbl_loaded.ImeMode = ImeMode.NoControl;
            point2 = new Point(14, 11);
            this.lbl_loaded.Location = point2;
            this.lbl_loaded.Name = "lbl_loaded";
            size2 = new Size(0xd7, 0x11);
            this.lbl_loaded.Size = size2;
            this.lbl_loaded.TabIndex = 14;
            this.lbl_loaded.Text = "点击以读取文件";
            this.btnstart.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            this.btnstart.BackColor = Color.Indigo;
            this.btnstart.BackgroundImage = (Image) manager.GetObject("btnstart.BackgroundImage");
            this.btnstart.FlatStyle = FlatStyle.Flat;
            this.btnstart.Font = new Font("微软雅黑", 12f);
            this.btnstart.ForeColor = SystemColors.ControlLightLight;
            this.btnstart.ImeMode = ImeMode.NoControl;
            point2 = new Point(13, 0x120);
            this.btnstart.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btnstart.Margin = padding2;
            this.btnstart.Name = "btnstart";
            size2 = new Size(0xd8, 0x23);
            this.btnstart.Size = size2;
            this.btnstart.TabIndex = 1;
            this.btnstart.Text = "开始";
            this.btnstart.UseVisualStyleBackColor = false;
            this.PictureBox1.BackColor = Color.Transparent;
            this.PictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            this.PictureBox1.Dock = DockStyle.Fill;
            this.PictureBox1.ImeMode = ImeMode.NoControl;
            point2 = new Point(0, 0);
            this.PictureBox1.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.PictureBox1.Margin = padding2;
            this.PictureBox1.Name = "PictureBox1";
            size2 = new Size(0x3f2, 0x2f6);
            this.PictureBox1.Size = size2;
            this.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 2;
            this.PictureBox1.TabStop = false;
            this.panel_main.Controls.Add(this.tlp_taskbar2);
            this.panel_main.Controls.Add(this.lbl_sldeldte);
            this.panel_main.Controls.Add(this.lbl_slorig);
            this.panel_main.Controls.Add(this.panel_main_screen);
            this.panel_main.Controls.Add(this.panel_main_title);
            this.panel_main.Controls.Add(this.panel_main_sidebar);
            this.panel_main.Controls.Add(this.tlp_taskbar);
            point2 = new Point(0x152, 0x2b3);
            this.panel_main.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_main.Margin = padding2;
            this.panel_main.Name = "panel_main";
            size2 = new Size(0x3f2, 0x2f6);
            this.panel_main.Size = size2;
            this.panel_main.TabIndex = 3;
            this.tlp_taskbar2.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.tlp_taskbar2.ColumnCount = 6;
            this.tlp_taskbar2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667f));
            this.tlp_taskbar2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667f));
            this.tlp_taskbar2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667f));
            this.tlp_taskbar2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667f));
            this.tlp_taskbar2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667f));
            this.tlp_taskbar2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667f));
            this.tlp_taskbar2.Controls.Add(this.btn_modify_presents, 0, 0);
            this.tlp_taskbar2.Controls.Add(this.btn_dabianquan, 1, 0);
            this.tlp_taskbar2.Controls.Add(this.btn_sfxquick, 3, 0);
            this.tlp_taskbar2.Controls.Add(this.btn_sizequick, 4, 0);
            this.tlp_taskbar2.Controls.Add(this.btn_fileplayback, 2, 0);
            point2 = new Point(0, 0x2cb);
            this.tlp_taskbar2.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.tlp_taskbar2.Margin = padding2;
            this.tlp_taskbar2.Name = "tlp_taskbar2";
            this.tlp_taskbar2.RowCount = 1;
            this.tlp_taskbar2.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            size2 = new Size(0x303, 0x2b);
            this.tlp_taskbar2.Size = size2;
            this.tlp_taskbar2.TabIndex = 9;
            this.tlp_taskbar2.Visible = false;
            this.btn_modify_presents.Dock = DockStyle.Fill;
            this.btn_modify_presents.FlatAppearance.BorderSize = 0;
            this.btn_modify_presents.FlatAppearance.MouseDownBackColor = Color.Teal;
            this.btn_modify_presents.FlatAppearance.MouseOverBackColor = Color.PaleTurquoise;
            this.btn_modify_presents.FlatStyle = FlatStyle.Flat;
            this.btn_modify_presents.Font = new Font("Segoe UI", 12f);
            this.btn_modify_presents.ImeMode = ImeMode.NoControl;
            point2 = new Point(3, 4);
            this.btn_modify_presents.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_modify_presents.Margin = padding2;
            this.btn_modify_presents.Name = "btn_modify_presents";
            size2 = new Size(0x7a, 0x23);
            this.btn_modify_presents.Size = size2;
            this.btn_modify_presents.TabIndex = 0;
            this.btn_modify_presents.Text = "修改出席情况";
            this.btn_modify_presents.UseVisualStyleBackColor = true;
            this.btn_dabianquan.Dock = DockStyle.Fill;
            this.btn_dabianquan.FlatAppearance.BorderSize = 0;
            this.btn_dabianquan.FlatAppearance.MouseOverBackColor = Color.PaleTurquoise;
            this.btn_dabianquan.FlatStyle = FlatStyle.Flat;
            this.btn_dabianquan.Font = new Font("Segoe UI", 12f);
            this.btn_dabianquan.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x83, 4);
            this.btn_dabianquan.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_dabianquan.Margin = padding2;
            this.btn_dabianquan.Name = "btn_dabianquan";
            size2 = new Size(0x7a, 0x23);
            this.btn_dabianquan.Size = size2;
            this.btn_dabianquan.TabIndex = 1;
            this.btn_dabianquan.Text = "答辩权";
            this.btn_dabianquan.UseVisualStyleBackColor = true;
            this.btn_sfxquick.Dock = DockStyle.Fill;
            this.btn_sfxquick.FlatAppearance.BorderSize = 0;
            this.btn_sfxquick.FlatStyle = FlatStyle.Flat;
            this.btn_sfxquick.Font = new Font("Segoe UI", 12f);
            point2 = new Point(0x183, 3);
            this.btn_sfxquick.Location = point2;
            this.btn_sfxquick.Name = "btn_sfxquick";
            size2 = new Size(0x7a, 0x25);
            this.btn_sfxquick.Size = size2;
            this.btn_sfxquick.TabIndex = 2;
            this.btn_sfxquick.Text = "音效: 开";
            this.btn_sfxquick.UseVisualStyleBackColor = true;
            this.btn_sizequick.Dock = DockStyle.Fill;
            this.btn_sizequick.FlatAppearance.BorderSize = 0;
            this.btn_sizequick.FlatStyle = FlatStyle.Flat;
            this.btn_sizequick.Font = new Font("Segoe UI", 12f);
            point2 = new Point(0x203, 3);
            this.btn_sizequick.Location = point2;
            this.btn_sizequick.Name = "btn_sizequick";
            size2 = new Size(0x7a, 0x25);
            this.btn_sizequick.Size = size2;
            this.btn_sizequick.TabIndex = 3;
            this.btn_sizequick.Text = "字号: 20.25";
            this.btn_sizequick.UseVisualStyleBackColor = true;
            this.btn_fileplayback.Dock = DockStyle.Fill;
            this.btn_fileplayback.FlatAppearance.BorderSize = 0;
            this.btn_fileplayback.FlatStyle = FlatStyle.Flat;
            this.btn_fileplayback.Font = new Font("Segoe UI", 12f);
            point2 = new Point(0x103, 3);
            this.btn_fileplayback.Location = point2;
            this.btn_fileplayback.Name = "btn_fileplayback";
            size2 = new Size(0x7a, 0x25);
            this.btn_fileplayback.Size = size2;
            this.btn_fileplayback.TabIndex = 4;
            this.btn_fileplayback.Text = "回显文件";
            this.btn_fileplayback.UseVisualStyleBackColor = true;
            this.lbl_sldeldte.AutoSize = true;
            this.lbl_sldeldte.Font = new Font("Segoe UI", 15.75f, FontStyle.Strikeout);
            this.lbl_sldeldte.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x11f, -39);
            this.lbl_sldeldte.Location = point2;
            this.lbl_sldeldte.Name = "lbl_sldeldte";
            size2 = new Size(0x54, 30);
            this.lbl_sldeldte.Size = size2;
            this.lbl_sldeldte.TabIndex = 8;
            this.lbl_sldeldte.Text = "Label99";
            this.lbl_sldeldte.Visible = false;
            this.lbl_slorig.AutoSize = true;
            this.lbl_slorig.Font = new Font("Segoe UI", 15.75f);
            this.lbl_slorig.ImeMode = ImeMode.NoControl;
            point2 = new Point(0xbb, -46);
            this.lbl_slorig.Location = point2;
            this.lbl_slorig.Name = "lbl_slorig";
            size2 = new Size(0x54, 30);
            this.lbl_slorig.Size = size2;
            this.lbl_slorig.TabIndex = 7;
            this.lbl_slorig.Text = "Label11";
            this.lbl_slorig.Visible = false;
            this.panel_main_screen.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.panel_main_screen.Controls.Add(this.txthcmotion);
            this.panel_main_screen.Controls.Add(this.WebBrowser1);
            this.panel_main_screen.Controls.Add(this.tlp_screenlist);
            this.panel_main_screen.Controls.Add(this.lblmain);
            point2 = new Point(0, 0x3d);
            this.panel_main_screen.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_main_screen.Margin = padding2;
            this.panel_main_screen.Name = "panel_main_screen";
            size2 = new Size(0x303, 610);
            this.panel_main_screen.Size = size2;
            this.panel_main_screen.TabIndex = 6;
            this.txthcmotion.BorderStyle = BorderStyle.None;
            point2 = new Point(0, 0);
            this.txthcmotion.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.txthcmotion.Margin = padding2;
            this.txthcmotion.Multiline = true;
            this.txthcmotion.Name = "txthcmotion";
            size2 = new Size(0xac, 0x36);
            this.txthcmotion.Size = size2;
            this.txthcmotion.TabIndex = 7;
            this.txthcmotion.Text = "Debug";
            this.txthcmotion.Visible = false;
            point2 = new Point(0x1ee, 13);
            this.WebBrowser1.Location = point2;
            size2 = new Size(20, 20);
            this.WebBrowser1.MinimumSize = size2;
            this.WebBrowser1.Name = "WebBrowser1";
            size2 = new Size(0xda, 0x71);
            this.WebBrowser1.Size = size2;
            this.WebBrowser1.TabIndex = 9;
            this.WebBrowser1.Visible = false;
            this.tlp_screenlist.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.tlp_screenlist.BackColor = Color.Transparent;
            this.tlp_screenlist.ColumnCount = 13;
            this.tlp_screenlist.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10f));
            this.tlp_screenlist.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));
            this.tlp_screenlist.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70f));
            this.tlp_screenlist.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10f));
            this.tlp_screenlist.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));
            this.tlp_screenlist.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70f));
            this.tlp_screenlist.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10f));
            this.tlp_screenlist.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));
            this.tlp_screenlist.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70f));
            this.tlp_screenlist.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10f));
            this.tlp_screenlist.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));
            this.tlp_screenlist.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70f));
            this.tlp_screenlist.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 11f));
            this.tlp_screenlist.Controls.Add(this.lbl_slist_status_01, 2, 0);
            this.tlp_screenlist.Controls.Add(this.lbl_slist_1, 1, 0);
            this.tlp_screenlist.Controls.Add(this.Label37, 4, 0);
            this.tlp_screenlist.Controls.Add(this.Label38, 7, 0);
            this.tlp_screenlist.Controls.Add(this.Label36, 1, 2);
            this.tlp_screenlist.Controls.Add(this.Label39, 1, 4);
            this.tlp_screenlist.Controls.Add(this.Label40, 1, 6);
            this.tlp_screenlist.Controls.Add(this.Label41, 1, 8);
            this.tlp_screenlist.Controls.Add(this.Label42, 1, 10);
            this.tlp_screenlist.Controls.Add(this.Label43, 1, 12);
            this.tlp_screenlist.Controls.Add(this.Label44, 1, 14);
            this.tlp_screenlist.Controls.Add(this.Label45, 1, 0x10);
            this.tlp_screenlist.Controls.Add(this.Label46, 1, 0x12);
            this.tlp_screenlist.Controls.Add(this.Label47, 1, 20);
            this.tlp_screenlist.Controls.Add(this.Label48, 1, 0x15);
            this.tlp_screenlist.Controls.Add(this.Label49, 1, 0x16);
            this.tlp_screenlist.Controls.Add(this.Label50, 1, 0x17);
            this.tlp_screenlist.Controls.Add(this.Label51, 1, 0x18);
            this.tlp_screenlist.Controls.Add(this.Label52, 4, 2);
            this.tlp_screenlist.Controls.Add(this.Label53, 4, 4);
            this.tlp_screenlist.Controls.Add(this.Label54, 4, 6);
            this.tlp_screenlist.Controls.Add(this.Label55, 4, 10);
            this.tlp_screenlist.Controls.Add(this.Label56, 4, 8);
            this.tlp_screenlist.Controls.Add(this.Label57, 4, 12);
            this.tlp_screenlist.Controls.Add(this.Label58, 4, 14);
            this.tlp_screenlist.Controls.Add(this.Label59, 4, 0x10);
            this.tlp_screenlist.Controls.Add(this.Label60, 4, 0x12);
            this.tlp_screenlist.Controls.Add(this.Label62, 4, 0x15);
            this.tlp_screenlist.Controls.Add(this.Label63, 4, 0x16);
            this.tlp_screenlist.Controls.Add(this.Label64, 4, 0x17);
            this.tlp_screenlist.Controls.Add(this.Label65, 4, 0x18);
            this.tlp_screenlist.Controls.Add(this.Label66, 7, 2);
            this.tlp_screenlist.Controls.Add(this.Label67, 7, 4);
            this.tlp_screenlist.Controls.Add(this.Label68, 7, 6);
            this.tlp_screenlist.Controls.Add(this.Label69, 7, 8);
            this.tlp_screenlist.Controls.Add(this.Label70, 7, 10);
            this.tlp_screenlist.Controls.Add(this.Label71, 7, 12);
            this.tlp_screenlist.Controls.Add(this.Label72, 7, 14);
            this.tlp_screenlist.Controls.Add(this.Label73, 7, 0x10);
            this.tlp_screenlist.Controls.Add(this.Label74, 7, 0x12);
            this.tlp_screenlist.Controls.Add(this.Label76, 7, 0x15);
            this.tlp_screenlist.Controls.Add(this.Label77, 7, 0x16);
            this.tlp_screenlist.Controls.Add(this.Label78, 7, 0x17);
            this.tlp_screenlist.Controls.Add(this.Label79, 7, 0x18);
            this.tlp_screenlist.Controls.Add(this.Label80, 10, 0);
            this.tlp_screenlist.Controls.Add(this.Label81, 10, 2);
            this.tlp_screenlist.Controls.Add(this.Label82, 10, 4);
            this.tlp_screenlist.Controls.Add(this.Label83, 10, 6);
            this.tlp_screenlist.Controls.Add(this.Label84, 10, 8);
            this.tlp_screenlist.Controls.Add(this.Label85, 10, 10);
            this.tlp_screenlist.Controls.Add(this.Label86, 10, 12);
            this.tlp_screenlist.Controls.Add(this.Label87, 10, 14);
            this.tlp_screenlist.Controls.Add(this.Label88, 10, 0x10);
            this.tlp_screenlist.Controls.Add(this.Label89, 10, 0x12);
            this.tlp_screenlist.Controls.Add(this.Label92, 10, 0x16);
            this.tlp_screenlist.Controls.Add(this.Label93, 10, 0x17);
            this.tlp_screenlist.Controls.Add(this.Label94, 10, 0x18);
            this.tlp_screenlist.Controls.Add(this.Label109, 2, 2);
            this.tlp_screenlist.Controls.Add(this.Label110, 2, 4);
            this.tlp_screenlist.Controls.Add(this.Label112, 2, 6);
            this.tlp_screenlist.Controls.Add(this.Label113, 2, 8);
            this.tlp_screenlist.Controls.Add(this.Label114, 2, 10);
            this.tlp_screenlist.Controls.Add(this.Label115, 2, 12);
            this.tlp_screenlist.Controls.Add(this.Label116, 2, 14);
            this.tlp_screenlist.Controls.Add(this.Label117, 2, 0x10);
            this.tlp_screenlist.Controls.Add(this.Label118, 2, 0x12);
            this.tlp_screenlist.Controls.Add(this.Label120, 2, 0x15);
            this.tlp_screenlist.Controls.Add(this.Label121, 2, 0x16);
            this.tlp_screenlist.Controls.Add(this.Label122, 2, 0x17);
            this.tlp_screenlist.Controls.Add(this.Label123, 2, 0x18);
            this.tlp_screenlist.Controls.Add(this.Label124, 5, 0);
            this.tlp_screenlist.Controls.Add(this.Label125, 5, 2);
            this.tlp_screenlist.Controls.Add(this.Label126, 5, 4);
            this.tlp_screenlist.Controls.Add(this.Label127, 5, 6);
            this.tlp_screenlist.Controls.Add(this.Label128, 5, 8);
            this.tlp_screenlist.Controls.Add(this.Label129, 5, 10);
            this.tlp_screenlist.Controls.Add(this.Label130, 5, 12);
            this.tlp_screenlist.Controls.Add(this.Label131, 5, 14);
            this.tlp_screenlist.Controls.Add(this.Label132, 5, 0x10);
            this.tlp_screenlist.Controls.Add(this.Label133, 5, 0x12);
            this.tlp_screenlist.Controls.Add(this.Label135, 5, 0x15);
            this.tlp_screenlist.Controls.Add(this.Label136, 5, 0x16);
            this.tlp_screenlist.Controls.Add(this.Label137, 5, 0x17);
            this.tlp_screenlist.Controls.Add(this.Label138, 5, 0x18);
            this.tlp_screenlist.Controls.Add(this.Label139, 8, 0);
            this.tlp_screenlist.Controls.Add(this.Label140, 8, 2);
            this.tlp_screenlist.Controls.Add(this.Label141, 8, 4);
            this.tlp_screenlist.Controls.Add(this.Label142, 8, 6);
            this.tlp_screenlist.Controls.Add(this.Label143, 8, 8);
            this.tlp_screenlist.Controls.Add(this.Label144, 8, 10);
            this.tlp_screenlist.Controls.Add(this.Label145, 8, 12);
            this.tlp_screenlist.Controls.Add(this.Label146, 8, 14);
            this.tlp_screenlist.Controls.Add(this.Label147, 8, 0x10);
            this.tlp_screenlist.Controls.Add(this.Label148, 8, 0x12);
            this.tlp_screenlist.Controls.Add(this.Label150, 8, 0x15);
            this.tlp_screenlist.Controls.Add(this.Label151, 8, 0x16);
            this.tlp_screenlist.Controls.Add(this.Label152, 8, 0x17);
            this.tlp_screenlist.Controls.Add(this.Label153, 8, 0x18);
            this.tlp_screenlist.Controls.Add(this.Label154, 11, 0);
            this.tlp_screenlist.Controls.Add(this.Label155, 11, 2);
            this.tlp_screenlist.Controls.Add(this.Label156, 11, 4);
            this.tlp_screenlist.Controls.Add(this.Label157, 11, 6);
            this.tlp_screenlist.Controls.Add(this.Label158, 11, 8);
            this.tlp_screenlist.Controls.Add(this.Label159, 11, 10);
            this.tlp_screenlist.Controls.Add(this.Label160, 11, 12);
            this.tlp_screenlist.Controls.Add(this.Label161, 11, 14);
            this.tlp_screenlist.Controls.Add(this.Label162, 11, 0x10);
            this.tlp_screenlist.Controls.Add(this.Label163, 11, 0x12);
            this.tlp_screenlist.Controls.Add(this.Label165, 11, 0x15);
            this.tlp_screenlist.Controls.Add(this.Label166, 11, 0x16);
            this.tlp_screenlist.Controls.Add(this.Label167, 11, 0x17);
            this.tlp_screenlist.Controls.Add(this.Label168, 11, 0x18);
            this.tlp_screenlist.Controls.Add(this.TableLayoutPanel1, 2, 20);
            this.tlp_screenlist.Font = new Font("Segoe UI", 15.75f);
            point2 = new Point(0, 0xc7);
            this.tlp_screenlist.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.tlp_screenlist.Margin = padding2;
            this.tlp_screenlist.Name = "tlp_screenlist";
            this.tlp_screenlist.RowCount = 0x19;
            this.tlp_screenlist.RowStyles.Add(new RowStyle(SizeType.Absolute, 33f));
            this.tlp_screenlist.RowStyles.Add(new RowStyle(SizeType.Absolute, 5f));
            this.tlp_screenlist.RowStyles.Add(new RowStyle(SizeType.Absolute, 33f));
            this.tlp_screenlist.RowStyles.Add(new RowStyle(SizeType.Absolute, 5f));
            this.tlp_screenlist.RowStyles.Add(new RowStyle(SizeType.Absolute, 33f));
            this.tlp_screenlist.RowStyles.Add(new RowStyle(SizeType.Absolute, 5f));
            this.tlp_screenlist.RowStyles.Add(new RowStyle(SizeType.Absolute, 33f));
            this.tlp_screenlist.RowStyles.Add(new RowStyle(SizeType.Absolute, 5f));
            this.tlp_screenlist.RowStyles.Add(new RowStyle(SizeType.Absolute, 33f));
            this.tlp_screenlist.RowStyles.Add(new RowStyle(SizeType.Absolute, 5f));
            this.tlp_screenlist.RowStyles.Add(new RowStyle(SizeType.Absolute, 33f));
            this.tlp_screenlist.RowStyles.Add(new RowStyle(SizeType.Absolute, 5f));
            this.tlp_screenlist.RowStyles.Add(new RowStyle(SizeType.Absolute, 33f));
            this.tlp_screenlist.RowStyles.Add(new RowStyle(SizeType.Absolute, 5f));
            this.tlp_screenlist.RowStyles.Add(new RowStyle(SizeType.Absolute, 33f));
            this.tlp_screenlist.RowStyles.Add(new RowStyle(SizeType.Absolute, 5f));
            this.tlp_screenlist.RowStyles.Add(new RowStyle(SizeType.Absolute, 33f));
            this.tlp_screenlist.RowStyles.Add(new RowStyle(SizeType.Absolute, 5f));
            this.tlp_screenlist.RowStyles.Add(new RowStyle(SizeType.Absolute, 33f));
            this.tlp_screenlist.RowStyles.Add(new RowStyle(SizeType.Absolute, 5f));
            this.tlp_screenlist.RowStyles.Add(new RowStyle(SizeType.Absolute, 33f));
            this.tlp_screenlist.RowStyles.Add(new RowStyle(SizeType.Absolute, 33f));
            this.tlp_screenlist.RowStyles.Add(new RowStyle(SizeType.Absolute, 33f));
            this.tlp_screenlist.RowStyles.Add(new RowStyle(SizeType.Absolute, 33f));
            this.tlp_screenlist.RowStyles.Add(new RowStyle(SizeType.Absolute, 22f));
            size2 = new Size(0x303, 0x19c);
            this.tlp_screenlist.Size = size2;
            this.tlp_screenlist.TabIndex = 1;
            this.tlp_screenlist.Visible = false;
            this.lbl_slist_status_01.BackColor = Color.Yellow;
            this.lbl_slist_status_01.Dock = DockStyle.Fill;
            this.lbl_slist_status_01.Font = new Font("Segoe UI", 15.75f);
            this.lbl_slist_status_01.ForeColor = Color.DarkGoldenrod;
            this.lbl_slist_status_01.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x7b, 0);
            this.lbl_slist_status_01.Location = point2;
            this.lbl_slist_status_01.Name = "lbl_slist_status_01";
            size2 = new Size(0x40, 0x21);
            this.lbl_slist_status_01.Size = size2;
            this.lbl_slist_status_01.TabIndex = 0;
            this.lbl_slist_status_01.Text = "Abst.";
            this.lbl_slist_status_01.TextAlign = ContentAlignment.MiddleCenter;
            this.lbl_slist_1.Dock = DockStyle.Fill;
            this.lbl_slist_1.ImeMode = ImeMode.NoControl;
            point2 = new Point(13, 0);
            this.lbl_slist_1.Location = point2;
            this.lbl_slist_1.Name = "lbl_slist_1";
            size2 = new Size(0x68, 0x21);
            this.lbl_slist_1.Size = size2;
            this.lbl_slist_1.TabIndex = 1;
            this.lbl_slist_1.Text = "0,89";
            this.Label37.Dock = DockStyle.Fill;
            this.Label37.ImeMode = ImeMode.NoControl;
            point2 = new Point(0xcb, 0);
            this.Label37.Location = point2;
            this.Label37.Name = "Label37";
            size2 = new Size(0x68, 0x21);
            this.Label37.Size = size2;
            this.Label37.TabIndex = 2;
            this.Label37.Text = "Label37";
            this.Label38.Dock = DockStyle.Fill;
            this.Label38.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x189, 0);
            this.Label38.Location = point2;
            this.Label38.Name = "Label38";
            size2 = new Size(0x68, 0x21);
            this.Label38.Size = size2;
            this.Label38.TabIndex = 3;
            this.Label38.Text = "Label38";
            this.Label36.Dock = DockStyle.Fill;
            this.Label36.ImeMode = ImeMode.NoControl;
            point2 = new Point(13, 0x26);
            this.Label36.Location = point2;
            this.Label36.Name = "Label36";
            size2 = new Size(0x68, 0x21);
            this.Label36.Size = size2;
            this.Label36.TabIndex = 4;
            this.Label36.Text = "Label36";
            this.Label39.Dock = DockStyle.Fill;
            this.Label39.ImeMode = ImeMode.NoControl;
            point2 = new Point(13, 0x4c);
            this.Label39.Location = point2;
            this.Label39.Name = "Label39";
            size2 = new Size(0x68, 0x21);
            this.Label39.Size = size2;
            this.Label39.TabIndex = 5;
            this.Label39.Text = "Label39";
            this.Label40.Dock = DockStyle.Fill;
            this.Label40.ImeMode = ImeMode.NoControl;
            point2 = new Point(13, 0x72);
            this.Label40.Location = point2;
            this.Label40.Name = "Label40";
            size2 = new Size(0x68, 0x21);
            this.Label40.Size = size2;
            this.Label40.TabIndex = 6;
            this.Label40.Text = "Label40";
            this.Label41.Dock = DockStyle.Fill;
            this.Label41.ImeMode = ImeMode.NoControl;
            point2 = new Point(13, 0x98);
            this.Label41.Location = point2;
            this.Label41.Name = "Label41";
            size2 = new Size(0x68, 0x21);
            this.Label41.Size = size2;
            this.Label41.TabIndex = 7;
            this.Label41.Text = "Label41";
            this.Label42.Dock = DockStyle.Fill;
            this.Label42.ImeMode = ImeMode.NoControl;
            point2 = new Point(13, 190);
            this.Label42.Location = point2;
            this.Label42.Name = "Label42";
            size2 = new Size(0x68, 0x21);
            this.Label42.Size = size2;
            this.Label42.TabIndex = 8;
            this.Label42.Text = "Label42";
            this.Label43.Dock = DockStyle.Fill;
            this.Label43.ImeMode = ImeMode.NoControl;
            point2 = new Point(13, 0xe4);
            this.Label43.Location = point2;
            this.Label43.Name = "Label43";
            size2 = new Size(0x68, 0x21);
            this.Label43.Size = size2;
            this.Label43.TabIndex = 9;
            this.Label43.Text = "Label43";
            this.Label44.Dock = DockStyle.Fill;
            this.Label44.ImeMode = ImeMode.NoControl;
            point2 = new Point(13, 0x10a);
            this.Label44.Location = point2;
            this.Label44.Name = "Label44";
            size2 = new Size(0x68, 0x21);
            this.Label44.Size = size2;
            this.Label44.TabIndex = 10;
            this.Label44.Text = "Label44";
            this.Label45.Dock = DockStyle.Fill;
            this.Label45.ImeMode = ImeMode.NoControl;
            point2 = new Point(13, 0x130);
            this.Label45.Location = point2;
            this.Label45.Name = "Label45";
            size2 = new Size(0x68, 0x21);
            this.Label45.Size = size2;
            this.Label45.TabIndex = 11;
            this.Label45.Text = "Label45";
            this.Label46.Dock = DockStyle.Fill;
            this.Label46.ImeMode = ImeMode.NoControl;
            point2 = new Point(13, 0x156);
            this.Label46.Location = point2;
            this.Label46.Name = "Label46";
            size2 = new Size(0x68, 0x21);
            this.Label46.Size = size2;
            this.Label46.TabIndex = 12;
            this.Label46.Text = "Label46";
            this.Label47.Dock = DockStyle.Fill;
            this.Label47.ImeMode = ImeMode.NoControl;
            point2 = new Point(13, 380);
            this.Label47.Location = point2;
            this.Label47.Name = "Label47";
            size2 = new Size(0x68, 0x21);
            this.Label47.Size = size2;
            this.Label47.TabIndex = 13;
            this.Label47.Text = "页数 1/1";
            this.Label48.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.Label48.ImeMode = ImeMode.NoControl;
            point2 = new Point(13, 0x19d);
            this.Label48.Location = point2;
            this.Label48.Name = "Label48";
            size2 = new Size(0x68, 0x21);
            this.Label48.Size = size2;
            this.Label48.TabIndex = 14;
            this.Label48.Text = "Label48";
            this.Label49.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.Label49.ImeMode = ImeMode.NoControl;
            point2 = new Point(13, 0x1be);
            this.Label49.Location = point2;
            this.Label49.Name = "Label49";
            size2 = new Size(0x68, 0x21);
            this.Label49.Size = size2;
            this.Label49.TabIndex = 15;
            this.Label49.Text = "Label49";
            this.Label50.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.Label50.ImeMode = ImeMode.NoControl;
            point2 = new Point(13, 0x1df);
            this.Label50.Location = point2;
            this.Label50.Name = "Label50";
            size2 = new Size(0x68, 0x21);
            this.Label50.Size = size2;
            this.Label50.TabIndex = 0x10;
            this.Label50.Text = "Label50";
            this.Label51.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.Label51.ImeMode = ImeMode.NoControl;
            point2 = new Point(13, 0x200);
            this.Label51.Location = point2;
            this.Label51.Name = "Label51";
            size2 = new Size(0x68, 0x16);
            this.Label51.Size = size2;
            this.Label51.TabIndex = 0x11;
            this.Label51.Text = "Label51";
            this.Label52.Dock = DockStyle.Fill;
            this.Label52.ImeMode = ImeMode.NoControl;
            point2 = new Point(0xcb, 0x26);
            this.Label52.Location = point2;
            this.Label52.Name = "Label52";
            size2 = new Size(0x68, 0x21);
            this.Label52.Size = size2;
            this.Label52.TabIndex = 0x12;
            this.Label52.Text = "Label52";
            this.Label53.Dock = DockStyle.Fill;
            this.Label53.ImeMode = ImeMode.NoControl;
            point2 = new Point(0xcb, 0x4c);
            this.Label53.Location = point2;
            this.Label53.Name = "Label53";
            size2 = new Size(0x68, 0x21);
            this.Label53.Size = size2;
            this.Label53.TabIndex = 0x13;
            this.Label53.Text = "Label53";
            this.Label54.Dock = DockStyle.Fill;
            this.Label54.ImeMode = ImeMode.NoControl;
            point2 = new Point(0xcb, 0x72);
            this.Label54.Location = point2;
            this.Label54.Name = "Label54";
            size2 = new Size(0x68, 0x21);
            this.Label54.Size = size2;
            this.Label54.TabIndex = 20;
            this.Label54.Text = "Label54";
            this.Label55.Dock = DockStyle.Fill;
            this.Label55.ImeMode = ImeMode.NoControl;
            point2 = new Point(0xcb, 190);
            this.Label55.Location = point2;
            this.Label55.Name = "Label55";
            size2 = new Size(0x68, 0x21);
            this.Label55.Size = size2;
            this.Label55.TabIndex = 0x15;
            this.Label55.Text = "Label55";
            this.Label56.Dock = DockStyle.Fill;
            this.Label56.ImeMode = ImeMode.NoControl;
            point2 = new Point(0xcb, 0x98);
            this.Label56.Location = point2;
            this.Label56.Name = "Label56";
            size2 = new Size(0x68, 0x21);
            this.Label56.Size = size2;
            this.Label56.TabIndex = 0x16;
            this.Label56.Text = "Label56";
            this.Label57.Dock = DockStyle.Fill;
            this.Label57.ImeMode = ImeMode.NoControl;
            point2 = new Point(0xcb, 0xe4);
            this.Label57.Location = point2;
            this.Label57.Name = "Label57";
            size2 = new Size(0x68, 0x21);
            this.Label57.Size = size2;
            this.Label57.TabIndex = 0x17;
            this.Label57.Text = "Label57";
            this.Label58.Dock = DockStyle.Fill;
            this.Label58.ImeMode = ImeMode.NoControl;
            point2 = new Point(0xcb, 0x10a);
            this.Label58.Location = point2;
            this.Label58.Name = "Label58";
            size2 = new Size(0x68, 0x21);
            this.Label58.Size = size2;
            this.Label58.TabIndex = 0x18;
            this.Label58.Text = "Label58";
            this.Label59.Dock = DockStyle.Fill;
            this.Label59.ImeMode = ImeMode.NoControl;
            point2 = new Point(0xcb, 0x130);
            this.Label59.Location = point2;
            this.Label59.Name = "Label59";
            size2 = new Size(0x68, 0x21);
            this.Label59.Size = size2;
            this.Label59.TabIndex = 0x19;
            this.Label59.Text = "Label59";
            this.Label60.Dock = DockStyle.Fill;
            this.Label60.ImeMode = ImeMode.NoControl;
            point2 = new Point(0xcb, 0x156);
            this.Label60.Location = point2;
            this.Label60.Name = "Label60";
            size2 = new Size(0x68, 0x21);
            this.Label60.Size = size2;
            this.Label60.TabIndex = 0x1a;
            this.Label60.Text = "Label60";
            this.Label62.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.Label62.ImeMode = ImeMode.NoControl;
            point2 = new Point(0xcb, 0x19d);
            this.Label62.Location = point2;
            this.Label62.Name = "Label62";
            size2 = new Size(0x68, 0x21);
            this.Label62.Size = size2;
            this.Label62.TabIndex = 0x1c;
            this.Label62.Text = "Label62";
            this.Label63.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.Label63.ImeMode = ImeMode.NoControl;
            point2 = new Point(0xcb, 0x1be);
            this.Label63.Location = point2;
            this.Label63.Name = "Label63";
            size2 = new Size(0x68, 0x21);
            this.Label63.Size = size2;
            this.Label63.TabIndex = 0x1d;
            this.Label63.Text = "Label63";
            this.Label64.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.Label64.ImeMode = ImeMode.NoControl;
            point2 = new Point(0xcb, 0x1df);
            this.Label64.Location = point2;
            this.Label64.Name = "Label64";
            size2 = new Size(0x68, 0x21);
            this.Label64.Size = size2;
            this.Label64.TabIndex = 30;
            this.Label64.Text = "Label64";
            this.Label65.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.Label65.ImeMode = ImeMode.NoControl;
            point2 = new Point(0xcb, 0x200);
            this.Label65.Location = point2;
            this.Label65.Name = "Label65";
            size2 = new Size(0x68, 0x16);
            this.Label65.Size = size2;
            this.Label65.TabIndex = 0x1f;
            this.Label65.Text = "Label65";
            this.Label66.Dock = DockStyle.Fill;
            this.Label66.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x189, 0x26);
            this.Label66.Location = point2;
            this.Label66.Name = "Label66";
            size2 = new Size(0x68, 0x21);
            this.Label66.Size = size2;
            this.Label66.TabIndex = 0x20;
            this.Label66.Text = "Label66";
            this.Label67.Dock = DockStyle.Fill;
            this.Label67.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x189, 0x4c);
            this.Label67.Location = point2;
            this.Label67.Name = "Label67";
            size2 = new Size(0x68, 0x21);
            this.Label67.Size = size2;
            this.Label67.TabIndex = 0x21;
            this.Label67.Text = "Label67";
            this.Label68.Dock = DockStyle.Fill;
            this.Label68.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x189, 0x72);
            this.Label68.Location = point2;
            this.Label68.Name = "Label68";
            size2 = new Size(0x68, 0x21);
            this.Label68.Size = size2;
            this.Label68.TabIndex = 0x22;
            this.Label68.Text = "Label68";
            this.Label69.Dock = DockStyle.Fill;
            this.Label69.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x189, 0x98);
            this.Label69.Location = point2;
            this.Label69.Name = "Label69";
            size2 = new Size(0x68, 0x21);
            this.Label69.Size = size2;
            this.Label69.TabIndex = 0x23;
            this.Label69.Text = "Label69";
            this.Label70.Dock = DockStyle.Fill;
            this.Label70.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x189, 190);
            this.Label70.Location = point2;
            this.Label70.Name = "Label70";
            size2 = new Size(0x68, 0x21);
            this.Label70.Size = size2;
            this.Label70.TabIndex = 0x24;
            this.Label70.Text = "Label70";
            this.Label71.Dock = DockStyle.Fill;
            this.Label71.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x189, 0xe4);
            this.Label71.Location = point2;
            this.Label71.Name = "Label71";
            size2 = new Size(0x68, 0x21);
            this.Label71.Size = size2;
            this.Label71.TabIndex = 0x25;
            this.Label71.Text = "Label71";
            this.Label72.Dock = DockStyle.Fill;
            this.Label72.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x189, 0x10a);
            this.Label72.Location = point2;
            this.Label72.Name = "Label72";
            size2 = new Size(0x68, 0x21);
            this.Label72.Size = size2;
            this.Label72.TabIndex = 0x26;
            this.Label72.Text = "Label72";
            this.Label73.Dock = DockStyle.Fill;
            this.Label73.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x189, 0x130);
            this.Label73.Location = point2;
            this.Label73.Name = "Label73";
            size2 = new Size(0x68, 0x21);
            this.Label73.Size = size2;
            this.Label73.TabIndex = 0x27;
            this.Label73.Text = "Label73";
            this.Label74.Dock = DockStyle.Fill;
            this.Label74.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x189, 0x156);
            this.Label74.Location = point2;
            this.Label74.Name = "Label74";
            size2 = new Size(0x68, 0x21);
            this.Label74.Size = size2;
            this.Label74.TabIndex = 40;
            this.Label74.Text = "Label74";
            this.Label76.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.Label76.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x189, 0x19d);
            this.Label76.Location = point2;
            this.Label76.Name = "Label76";
            size2 = new Size(0x68, 0x21);
            this.Label76.Size = size2;
            this.Label76.TabIndex = 0x2a;
            this.Label76.Text = "Label76";
            this.Label77.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.Label77.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x189, 0x1be);
            this.Label77.Location = point2;
            this.Label77.Name = "Label77";
            size2 = new Size(0x68, 0x21);
            this.Label77.Size = size2;
            this.Label77.TabIndex = 0x2b;
            this.Label77.Text = "Label77";
            this.Label78.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.Label78.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x189, 0x1df);
            this.Label78.Location = point2;
            this.Label78.Name = "Label78";
            size2 = new Size(0x68, 0x21);
            this.Label78.Size = size2;
            this.Label78.TabIndex = 0x2c;
            this.Label78.Text = "Label78";
            this.Label79.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.Label79.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x189, 0x200);
            this.Label79.Location = point2;
            this.Label79.Name = "Label79";
            size2 = new Size(0x68, 0x16);
            this.Label79.Size = size2;
            this.Label79.TabIndex = 0x2d;
            this.Label79.Text = "Label79";
            this.Label80.Dock = DockStyle.Fill;
            this.Label80.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x247, 0);
            this.Label80.Location = point2;
            this.Label80.Name = "Label80";
            size2 = new Size(0x68, 0x21);
            this.Label80.Size = size2;
            this.Label80.TabIndex = 0x2e;
            this.Label80.Text = "Label80";
            this.Label81.Dock = DockStyle.Fill;
            this.Label81.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x247, 0x26);
            this.Label81.Location = point2;
            this.Label81.Name = "Label81";
            size2 = new Size(0x68, 0x21);
            this.Label81.Size = size2;
            this.Label81.TabIndex = 0x2f;
            this.Label81.Text = "Label81";
            this.Label82.Dock = DockStyle.Fill;
            this.Label82.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x247, 0x4c);
            this.Label82.Location = point2;
            this.Label82.Name = "Label82";
            size2 = new Size(0x68, 0x21);
            this.Label82.Size = size2;
            this.Label82.TabIndex = 0x30;
            this.Label82.Text = "Label82";
            this.Label83.Dock = DockStyle.Fill;
            this.Label83.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x247, 0x72);
            this.Label83.Location = point2;
            this.Label83.Name = "Label83";
            size2 = new Size(0x68, 0x21);
            this.Label83.Size = size2;
            this.Label83.TabIndex = 0x31;
            this.Label83.Text = "Label83";
            this.Label84.Dock = DockStyle.Fill;
            this.Label84.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x247, 0x98);
            this.Label84.Location = point2;
            this.Label84.Name = "Label84";
            size2 = new Size(0x68, 0x21);
            this.Label84.Size = size2;
            this.Label84.TabIndex = 50;
            this.Label84.Text = "Label84";
            this.Label85.Dock = DockStyle.Fill;
            this.Label85.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x247, 190);
            this.Label85.Location = point2;
            this.Label85.Name = "Label85";
            size2 = new Size(0x68, 0x21);
            this.Label85.Size = size2;
            this.Label85.TabIndex = 0x33;
            this.Label85.Text = "Label85";
            this.Label86.Dock = DockStyle.Fill;
            this.Label86.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x247, 0xe4);
            this.Label86.Location = point2;
            this.Label86.Name = "Label86";
            size2 = new Size(0x68, 0x21);
            this.Label86.Size = size2;
            this.Label86.TabIndex = 0x34;
            this.Label86.Text = "Label86";
            this.Label87.Dock = DockStyle.Fill;
            this.Label87.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x247, 0x10a);
            this.Label87.Location = point2;
            this.Label87.Name = "Label87";
            size2 = new Size(0x68, 0x21);
            this.Label87.Size = size2;
            this.Label87.TabIndex = 0x35;
            this.Label87.Text = "Label87";
            this.Label88.Dock = DockStyle.Fill;
            this.Label88.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x247, 0x130);
            this.Label88.Location = point2;
            this.Label88.Name = "Label88";
            size2 = new Size(0x68, 0x21);
            this.Label88.Size = size2;
            this.Label88.TabIndex = 0x36;
            this.Label88.Text = "Label88";
            this.Label89.Dock = DockStyle.Fill;
            this.Label89.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x247, 0x156);
            this.Label89.Location = point2;
            this.Label89.Name = "Label89";
            size2 = new Size(0x68, 0x21);
            this.Label89.Size = size2;
            this.Label89.TabIndex = 0x37;
            this.Label89.Text = "Label89";
            this.Label92.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.Label92.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x247, 0x1be);
            this.Label92.Location = point2;
            this.Label92.Name = "Label92";
            size2 = new Size(0x68, 0x21);
            this.Label92.Size = size2;
            this.Label92.TabIndex = 0x3a;
            this.Label92.Text = "Label92";
            this.Label93.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.Label93.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x247, 0x1df);
            this.Label93.Location = point2;
            this.Label93.Name = "Label93";
            size2 = new Size(0x68, 0x21);
            this.Label93.Size = size2;
            this.Label93.TabIndex = 0x3b;
            this.Label93.Text = "Label93";
            this.Label94.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.Label94.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x247, 0x200);
            this.Label94.Location = point2;
            this.Label94.Name = "Label94";
            size2 = new Size(0x68, 0x16);
            this.Label94.Size = size2;
            this.Label94.TabIndex = 60;
            this.Label94.Text = "Label94";
            this.Label109.BackColor = Color.MistyRose;
            this.Label109.Dock = DockStyle.Fill;
            this.Label109.ForeColor = Color.Firebrick;
            this.Label109.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x7b, 0x26);
            this.Label109.Location = point2;
            this.Label109.Name = "Label109";
            size2 = new Size(0x40, 0x21);
            this.Label109.Size = size2;
            this.Label109.TabIndex = 0x3d;
            this.Label109.Text = "Yes";
            this.Label109.TextAlign = ContentAlignment.MiddleCenter;
            this.Label110.BackColor = Color.PowderBlue;
            this.Label110.Dock = DockStyle.Fill;
            this.Label110.ForeColor = Color.RoyalBlue;
            this.Label110.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x7b, 0x4c);
            this.Label110.Location = point2;
            this.Label110.Name = "Label110";
            size2 = new Size(0x40, 0x21);
            this.Label110.Size = size2;
            this.Label110.TabIndex = 0x3e;
            this.Label110.Text = "110";
            this.Label110.TextAlign = ContentAlignment.MiddleCenter;
            this.Label112.Dock = DockStyle.Fill;
            this.Label112.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x7b, 0x72);
            this.Label112.Location = point2;
            this.Label112.Name = "Label112";
            size2 = new Size(0x40, 0x21);
            this.Label112.Size = size2;
            this.Label112.TabIndex = 0x3f;
            this.Label112.Text = "l112";
            this.Label112.TextAlign = ContentAlignment.MiddleCenter;
            this.Label113.Dock = DockStyle.Fill;
            this.Label113.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x7b, 0x98);
            this.Label113.Location = point2;
            this.Label113.Name = "Label113";
            size2 = new Size(0x40, 0x21);
            this.Label113.Size = size2;
            this.Label113.TabIndex = 0x40;
            this.Label113.Text = "Label113";
            this.Label113.TextAlign = ContentAlignment.MiddleCenter;
            this.Label114.Dock = DockStyle.Fill;
            this.Label114.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x7b, 190);
            this.Label114.Location = point2;
            this.Label114.Name = "Label114";
            size2 = new Size(0x40, 0x21);
            this.Label114.Size = size2;
            this.Label114.TabIndex = 0x41;
            this.Label114.Text = "Label114";
            this.Label114.TextAlign = ContentAlignment.MiddleCenter;
            this.Label115.Dock = DockStyle.Fill;
            this.Label115.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x7b, 0xe4);
            this.Label115.Location = point2;
            this.Label115.Name = "Label115";
            size2 = new Size(0x40, 0x21);
            this.Label115.Size = size2;
            this.Label115.TabIndex = 0x42;
            this.Label115.Text = "Label115";
            this.Label115.TextAlign = ContentAlignment.MiddleCenter;
            this.Label116.Dock = DockStyle.Fill;
            this.Label116.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x7b, 0x10a);
            this.Label116.Location = point2;
            this.Label116.Name = "Label116";
            size2 = new Size(0x40, 0x21);
            this.Label116.Size = size2;
            this.Label116.TabIndex = 0x43;
            this.Label116.Text = "Label116";
            this.Label116.TextAlign = ContentAlignment.MiddleCenter;
            this.Label117.Dock = DockStyle.Fill;
            this.Label117.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x7b, 0x130);
            this.Label117.Location = point2;
            this.Label117.Name = "Label117";
            size2 = new Size(0x40, 0x21);
            this.Label117.Size = size2;
            this.Label117.TabIndex = 0x44;
            this.Label117.Text = "Label117";
            this.Label117.TextAlign = ContentAlignment.MiddleCenter;
            this.Label118.Dock = DockStyle.Fill;
            this.Label118.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x7b, 0x156);
            this.Label118.Location = point2;
            this.Label118.Name = "Label118";
            size2 = new Size(0x40, 0x21);
            this.Label118.Size = size2;
            this.Label118.TabIndex = 0x45;
            this.Label118.Text = "Label118";
            this.Label118.TextAlign = ContentAlignment.MiddleCenter;
            this.Label120.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x7b, 0x19d);
            this.Label120.Location = point2;
            this.Label120.Name = "Label120";
            size2 = new Size(0x40, 0x21);
            this.Label120.Size = size2;
            this.Label120.TabIndex = 0x47;
            this.Label120.Text = "Label120";
            this.Label120.TextAlign = ContentAlignment.MiddleCenter;
            this.Label121.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x7b, 0x1be);
            this.Label121.Location = point2;
            this.Label121.Name = "Label121";
            size2 = new Size(0x40, 0x21);
            this.Label121.Size = size2;
            this.Label121.TabIndex = 0x48;
            this.Label121.Text = "Label121";
            this.Label121.TextAlign = ContentAlignment.MiddleCenter;
            this.Label122.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x7b, 0x1df);
            this.Label122.Location = point2;
            this.Label122.Name = "Label122";
            size2 = new Size(0x40, 0x21);
            this.Label122.Size = size2;
            this.Label122.TabIndex = 0x49;
            this.Label122.Text = "Label122";
            this.Label122.TextAlign = ContentAlignment.MiddleCenter;
            this.Label123.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x7b, 0x200);
            this.Label123.Location = point2;
            this.Label123.Name = "Label123";
            size2 = new Size(0x40, 0x16);
            this.Label123.Size = size2;
            this.Label123.TabIndex = 0x4a;
            this.Label123.Text = "Label123";
            this.Label123.TextAlign = ContentAlignment.MiddleCenter;
            this.Label124.Dock = DockStyle.Fill;
            this.Label124.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x139, 0);
            this.Label124.Location = point2;
            this.Label124.Name = "Label124";
            size2 = new Size(0x40, 0x21);
            this.Label124.Size = size2;
            this.Label124.TabIndex = 0x4b;
            this.Label124.Text = "Label124";
            this.Label124.TextAlign = ContentAlignment.MiddleCenter;
            this.Label125.Dock = DockStyle.Fill;
            this.Label125.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x139, 0x26);
            this.Label125.Location = point2;
            this.Label125.Name = "Label125";
            size2 = new Size(0x40, 0x21);
            this.Label125.Size = size2;
            this.Label125.TabIndex = 0x4c;
            this.Label125.Text = "Label125";
            this.Label125.TextAlign = ContentAlignment.MiddleCenter;
            this.Label126.Dock = DockStyle.Fill;
            this.Label126.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x139, 0x4c);
            this.Label126.Location = point2;
            this.Label126.Name = "Label126";
            size2 = new Size(0x40, 0x21);
            this.Label126.Size = size2;
            this.Label126.TabIndex = 0x4d;
            this.Label126.Text = "Label126";
            this.Label126.TextAlign = ContentAlignment.MiddleCenter;
            this.Label127.Dock = DockStyle.Fill;
            this.Label127.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x139, 0x72);
            this.Label127.Location = point2;
            this.Label127.Name = "Label127";
            size2 = new Size(0x40, 0x21);
            this.Label127.Size = size2;
            this.Label127.TabIndex = 0x4e;
            this.Label127.Text = "Label127";
            this.Label127.TextAlign = ContentAlignment.MiddleCenter;
            this.Label128.Dock = DockStyle.Fill;
            this.Label128.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x139, 0x98);
            this.Label128.Location = point2;
            this.Label128.Name = "Label128";
            size2 = new Size(0x40, 0x21);
            this.Label128.Size = size2;
            this.Label128.TabIndex = 0x4f;
            this.Label128.Text = "Label128";
            this.Label128.TextAlign = ContentAlignment.MiddleCenter;
            this.Label129.Dock = DockStyle.Fill;
            this.Label129.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x139, 190);
            this.Label129.Location = point2;
            this.Label129.Name = "Label129";
            size2 = new Size(0x40, 0x21);
            this.Label129.Size = size2;
            this.Label129.TabIndex = 80;
            this.Label129.Text = "Label129";
            this.Label129.TextAlign = ContentAlignment.MiddleCenter;
            this.Label130.Dock = DockStyle.Fill;
            this.Label130.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x139, 0xe4);
            this.Label130.Location = point2;
            this.Label130.Name = "Label130";
            size2 = new Size(0x40, 0x21);
            this.Label130.Size = size2;
            this.Label130.TabIndex = 0x51;
            this.Label130.Text = "Label130";
            this.Label130.TextAlign = ContentAlignment.MiddleCenter;
            this.Label131.Dock = DockStyle.Fill;
            this.Label131.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x139, 0x10a);
            this.Label131.Location = point2;
            this.Label131.Name = "Label131";
            size2 = new Size(0x40, 0x21);
            this.Label131.Size = size2;
            this.Label131.TabIndex = 0x52;
            this.Label131.Text = "Label131";
            this.Label131.TextAlign = ContentAlignment.MiddleCenter;
            this.Label132.Dock = DockStyle.Fill;
            this.Label132.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x139, 0x130);
            this.Label132.Location = point2;
            this.Label132.Name = "Label132";
            size2 = new Size(0x40, 0x21);
            this.Label132.Size = size2;
            this.Label132.TabIndex = 0x53;
            this.Label132.Text = "Label132";
            this.Label132.TextAlign = ContentAlignment.MiddleCenter;
            this.Label133.Dock = DockStyle.Fill;
            this.Label133.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x139, 0x156);
            this.Label133.Location = point2;
            this.Label133.Name = "Label133";
            size2 = new Size(0x40, 0x21);
            this.Label133.Size = size2;
            this.Label133.TabIndex = 0x54;
            this.Label133.Text = "Label133";
            this.Label133.TextAlign = ContentAlignment.MiddleCenter;
            this.Label135.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x139, 0x19d);
            this.Label135.Location = point2;
            this.Label135.Name = "Label135";
            size2 = new Size(0x40, 0x21);
            this.Label135.Size = size2;
            this.Label135.TabIndex = 0x56;
            this.Label135.Text = "Label135";
            this.Label135.TextAlign = ContentAlignment.MiddleCenter;
            this.Label136.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x139, 0x1be);
            this.Label136.Location = point2;
            this.Label136.Name = "Label136";
            size2 = new Size(0x40, 0x21);
            this.Label136.Size = size2;
            this.Label136.TabIndex = 0x57;
            this.Label136.Text = "Label136";
            this.Label136.TextAlign = ContentAlignment.MiddleCenter;
            this.Label137.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x139, 0x1df);
            this.Label137.Location = point2;
            this.Label137.Name = "Label137";
            size2 = new Size(0x40, 0x21);
            this.Label137.Size = size2;
            this.Label137.TabIndex = 0x58;
            this.Label137.Text = "Label137";
            this.Label137.TextAlign = ContentAlignment.MiddleCenter;
            this.Label138.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x139, 0x200);
            this.Label138.Location = point2;
            this.Label138.Name = "Label138";
            size2 = new Size(0x40, 0x16);
            this.Label138.Size = size2;
            this.Label138.TabIndex = 0x59;
            this.Label138.Text = "Label138";
            this.Label138.TextAlign = ContentAlignment.MiddleCenter;
            this.Label139.Dock = DockStyle.Fill;
            this.Label139.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x1f7, 0);
            this.Label139.Location = point2;
            this.Label139.Name = "Label139";
            size2 = new Size(0x40, 0x21);
            this.Label139.Size = size2;
            this.Label139.TabIndex = 90;
            this.Label139.Text = "Label139";
            this.Label139.TextAlign = ContentAlignment.MiddleCenter;
            this.Label140.Dock = DockStyle.Fill;
            this.Label140.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x1f7, 0x26);
            this.Label140.Location = point2;
            this.Label140.Name = "Label140";
            size2 = new Size(0x40, 0x21);
            this.Label140.Size = size2;
            this.Label140.TabIndex = 0x5b;
            this.Label140.Text = "Label140";
            this.Label140.TextAlign = ContentAlignment.MiddleCenter;
            this.Label141.Dock = DockStyle.Fill;
            this.Label141.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x1f7, 0x4c);
            this.Label141.Location = point2;
            this.Label141.Name = "Label141";
            size2 = new Size(0x40, 0x21);
            this.Label141.Size = size2;
            this.Label141.TabIndex = 0x5c;
            this.Label141.Text = "Label141";
            this.Label141.TextAlign = ContentAlignment.MiddleCenter;
            this.Label142.Dock = DockStyle.Fill;
            this.Label142.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x1f7, 0x72);
            this.Label142.Location = point2;
            this.Label142.Name = "Label142";
            size2 = new Size(0x40, 0x21);
            this.Label142.Size = size2;
            this.Label142.TabIndex = 0x5d;
            this.Label142.Text = "Label142";
            this.Label142.TextAlign = ContentAlignment.MiddleCenter;
            this.Label143.Dock = DockStyle.Fill;
            this.Label143.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x1f7, 0x98);
            this.Label143.Location = point2;
            this.Label143.Name = "Label143";
            size2 = new Size(0x40, 0x21);
            this.Label143.Size = size2;
            this.Label143.TabIndex = 0x5e;
            this.Label143.Text = "Label143";
            this.Label143.TextAlign = ContentAlignment.MiddleCenter;
            this.Label144.Dock = DockStyle.Fill;
            this.Label144.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x1f7, 190);
            this.Label144.Location = point2;
            this.Label144.Name = "Label144";
            size2 = new Size(0x40, 0x21);
            this.Label144.Size = size2;
            this.Label144.TabIndex = 0x5f;
            this.Label144.Text = "Label144";
            this.Label144.TextAlign = ContentAlignment.MiddleCenter;
            this.Label145.Dock = DockStyle.Fill;
            this.Label145.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x1f7, 0xe4);
            this.Label145.Location = point2;
            this.Label145.Name = "Label145";
            size2 = new Size(0x40, 0x21);
            this.Label145.Size = size2;
            this.Label145.TabIndex = 0x60;
            this.Label145.Text = "Label145";
            this.Label145.TextAlign = ContentAlignment.MiddleCenter;
            this.Label146.Dock = DockStyle.Fill;
            this.Label146.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x1f7, 0x10a);
            this.Label146.Location = point2;
            this.Label146.Name = "Label146";
            size2 = new Size(0x40, 0x21);
            this.Label146.Size = size2;
            this.Label146.TabIndex = 0x61;
            this.Label146.Text = "Label146";
            this.Label146.TextAlign = ContentAlignment.MiddleCenter;
            this.Label147.Dock = DockStyle.Fill;
            this.Label147.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x1f7, 0x130);
            this.Label147.Location = point2;
            this.Label147.Name = "Label147";
            size2 = new Size(0x40, 0x21);
            this.Label147.Size = size2;
            this.Label147.TabIndex = 0x62;
            this.Label147.Text = "Label147";
            this.Label147.TextAlign = ContentAlignment.MiddleCenter;
            this.Label148.Dock = DockStyle.Fill;
            this.Label148.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x1f7, 0x156);
            this.Label148.Location = point2;
            this.Label148.Name = "Label148";
            size2 = new Size(0x40, 0x21);
            this.Label148.Size = size2;
            this.Label148.TabIndex = 0x63;
            this.Label148.Text = "Label148";
            this.Label148.TextAlign = ContentAlignment.MiddleCenter;
            this.Label150.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x1f7, 0x19d);
            this.Label150.Location = point2;
            this.Label150.Name = "Label150";
            size2 = new Size(0x40, 0x21);
            this.Label150.Size = size2;
            this.Label150.TabIndex = 0x65;
            this.Label150.Text = "Label150";
            this.Label150.TextAlign = ContentAlignment.MiddleCenter;
            this.Label151.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x1f7, 0x1be);
            this.Label151.Location = point2;
            this.Label151.Name = "Label151";
            size2 = new Size(0x40, 0x21);
            this.Label151.Size = size2;
            this.Label151.TabIndex = 0x66;
            this.Label151.Text = "Label151";
            this.Label151.TextAlign = ContentAlignment.MiddleCenter;
            this.Label152.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x1f7, 0x1df);
            this.Label152.Location = point2;
            this.Label152.Name = "Label152";
            size2 = new Size(0x40, 0x21);
            this.Label152.Size = size2;
            this.Label152.TabIndex = 0x67;
            this.Label152.Text = "Label152";
            this.Label152.TextAlign = ContentAlignment.MiddleCenter;
            this.Label153.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x1f7, 0x200);
            this.Label153.Location = point2;
            this.Label153.Name = "Label153";
            size2 = new Size(0x40, 0x16);
            this.Label153.Size = size2;
            this.Label153.TabIndex = 0x68;
            this.Label153.Text = "Label153";
            this.Label153.TextAlign = ContentAlignment.MiddleCenter;
            this.Label154.Dock = DockStyle.Fill;
            this.Label154.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x2b5, 0);
            this.Label154.Location = point2;
            this.Label154.Name = "Label154";
            size2 = new Size(0x40, 0x21);
            this.Label154.Size = size2;
            this.Label154.TabIndex = 0x69;
            this.Label154.Text = "Label154";
            this.Label154.TextAlign = ContentAlignment.MiddleCenter;
            this.Label155.Dock = DockStyle.Fill;
            this.Label155.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x2b5, 0x26);
            this.Label155.Location = point2;
            this.Label155.Name = "Label155";
            size2 = new Size(0x40, 0x21);
            this.Label155.Size = size2;
            this.Label155.TabIndex = 0x6a;
            this.Label155.Text = "Label155";
            this.Label155.TextAlign = ContentAlignment.MiddleCenter;
            this.Label156.Dock = DockStyle.Fill;
            this.Label156.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x2b5, 0x4c);
            this.Label156.Location = point2;
            this.Label156.Name = "Label156";
            size2 = new Size(0x40, 0x21);
            this.Label156.Size = size2;
            this.Label156.TabIndex = 0x6b;
            this.Label156.Text = "Label156";
            this.Label156.TextAlign = ContentAlignment.MiddleCenter;
            this.Label157.Dock = DockStyle.Fill;
            this.Label157.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x2b5, 0x72);
            this.Label157.Location = point2;
            this.Label157.Name = "Label157";
            size2 = new Size(0x40, 0x21);
            this.Label157.Size = size2;
            this.Label157.TabIndex = 0x6c;
            this.Label157.Text = "Label157";
            this.Label157.TextAlign = ContentAlignment.MiddleCenter;
            this.Label158.Dock = DockStyle.Fill;
            this.Label158.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x2b5, 0x98);
            this.Label158.Location = point2;
            this.Label158.Name = "Label158";
            size2 = new Size(0x40, 0x21);
            this.Label158.Size = size2;
            this.Label158.TabIndex = 0x6d;
            this.Label158.Text = "Label158";
            this.Label158.TextAlign = ContentAlignment.MiddleCenter;
            this.Label159.Dock = DockStyle.Fill;
            this.Label159.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x2b5, 190);
            this.Label159.Location = point2;
            this.Label159.Name = "Label159";
            size2 = new Size(0x40, 0x21);
            this.Label159.Size = size2;
            this.Label159.TabIndex = 110;
            this.Label159.Text = "Label159";
            this.Label159.TextAlign = ContentAlignment.MiddleCenter;
            this.Label160.Dock = DockStyle.Fill;
            this.Label160.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x2b5, 0xe4);
            this.Label160.Location = point2;
            this.Label160.Name = "Label160";
            size2 = new Size(0x40, 0x21);
            this.Label160.Size = size2;
            this.Label160.TabIndex = 0x6f;
            this.Label160.Text = "Label160";
            this.Label160.TextAlign = ContentAlignment.MiddleCenter;
            this.Label161.Dock = DockStyle.Fill;
            this.Label161.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x2b5, 0x10a);
            this.Label161.Location = point2;
            this.Label161.Name = "Label161";
            size2 = new Size(0x40, 0x21);
            this.Label161.Size = size2;
            this.Label161.TabIndex = 0x70;
            this.Label161.Text = "Label161";
            this.Label161.TextAlign = ContentAlignment.MiddleCenter;
            this.Label162.Dock = DockStyle.Fill;
            this.Label162.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x2b5, 0x130);
            this.Label162.Location = point2;
            this.Label162.Name = "Label162";
            size2 = new Size(0x40, 0x21);
            this.Label162.Size = size2;
            this.Label162.TabIndex = 0x71;
            this.Label162.Text = "Label162";
            this.Label162.TextAlign = ContentAlignment.MiddleCenter;
            this.Label163.Dock = DockStyle.Fill;
            this.Label163.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x2b5, 0x156);
            this.Label163.Location = point2;
            this.Label163.Name = "Label163";
            size2 = new Size(0x40, 0x21);
            this.Label163.Size = size2;
            this.Label163.TabIndex = 0x72;
            this.Label163.Text = "Label163";
            this.Label163.TextAlign = ContentAlignment.MiddleCenter;
            this.Label165.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x2b5, 0x19d);
            this.Label165.Location = point2;
            this.Label165.Name = "Label165";
            size2 = new Size(0x40, 0x21);
            this.Label165.Size = size2;
            this.Label165.TabIndex = 0x74;
            this.Label165.Text = "Label165";
            this.Label165.TextAlign = ContentAlignment.MiddleCenter;
            this.Label166.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x2b5, 0x1be);
            this.Label166.Location = point2;
            this.Label166.Name = "Label166";
            size2 = new Size(0x40, 0x21);
            this.Label166.Size = size2;
            this.Label166.TabIndex = 0x75;
            this.Label166.Text = "Label166";
            this.Label166.TextAlign = ContentAlignment.MiddleCenter;
            this.Label167.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x2b5, 0x1df);
            this.Label167.Location = point2;
            this.Label167.Name = "Label167";
            size2 = new Size(0x40, 0x21);
            this.Label167.Size = size2;
            this.Label167.TabIndex = 0x76;
            this.Label167.Text = "Label167";
            this.Label167.TextAlign = ContentAlignment.MiddleCenter;
            this.Label168.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x2b5, 0x200);
            this.Label168.Location = point2;
            this.Label168.Name = "Label168";
            size2 = new Size(0x40, 0x16);
            this.Label168.Size = size2;
            this.Label168.TabIndex = 0x77;
            this.Label168.Text = "Label168";
            this.Label168.TextAlign = ContentAlignment.MiddleCenter;
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            this.TableLayoutPanel1.Controls.Add(this.btn_prev, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.btn_next, 1, 0);
            this.TableLayoutPanel1.Dock = DockStyle.Fill;
            point2 = new Point(0x7b, 380);
            this.TableLayoutPanel1.Location = point2;
            padding2 = new Padding(3, 0, 3, 0);
            this.TableLayoutPanel1.Margin = padding2;
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            size2 = new Size(0x40, 0x21);
            this.TableLayoutPanel1.Size = size2;
            this.TableLayoutPanel1.TabIndex = 120;
            this.btn_prev.BackgroundImage = (Image) manager.GetObject("btn_prev.BackgroundImage");
            this.btn_prev.Dock = DockStyle.Fill;
            this.btn_prev.FlatAppearance.BorderSize = 0;
            this.btn_prev.FlatStyle = FlatStyle.Flat;
            this.btn_prev.ImeMode = ImeMode.NoControl;
            point2 = new Point(3, 4);
            this.btn_prev.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_prev.Margin = padding2;
            this.btn_prev.Name = "btn_prev";
            size2 = new Size(0x1a, 0x19);
            this.btn_prev.Size = size2;
            this.btn_prev.TabIndex = 0;
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_next.BackgroundImage = (Image) manager.GetObject("btn_next.BackgroundImage");
            this.btn_next.Dock = DockStyle.Fill;
            this.btn_next.FlatAppearance.BorderSize = 0;
            this.btn_next.FlatStyle = FlatStyle.Flat;
            this.btn_next.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x23, 4);
            this.btn_next.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_next.Margin = padding2;
            this.btn_next.Name = "btn_next";
            size2 = new Size(0x1a, 0x19);
            this.btn_next.Size = size2;
            this.btn_next.TabIndex = 1;
            this.btn_next.UseVisualStyleBackColor = true;
            this.lblmain.BackColor = Color.Transparent;
            this.lblmain.Dock = DockStyle.Fill;
            this.lblmain.Font = new Font("Segoe UI", 20.25f);
            this.lblmain.ImeMode = ImeMode.NoControl;
            point2 = new Point(0, 0);
            this.lblmain.Location = point2;
            this.lblmain.Name = "lblmain";
            size2 = new Size(0x303, 610);
            this.lblmain.Size = size2;
            this.lblmain.TabIndex = 0;
            this.lblmain.TextAlign = ContentAlignment.TopCenter;
            this.panel_main_title.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.panel_main_title.BackColor = Color.PaleTurquoise;
            this.panel_main_title.Controls.Add(this.TableLayoutPanel2);
            this.panel_main_title.Controls.Add(this.lbltime);
            this.panel_main_title.Controls.Add(this.panel_title_idle);
            point2 = new Point(0, 30);
            this.panel_main_title.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_main_title.Margin = padding2;
            this.panel_main_title.Name = "panel_main_title";
            size2 = new Size(0x3f2, 30);
            this.panel_main_title.Size = size2;
            this.panel_main_title.TabIndex = 3;
            this.TableLayoutPanel2.ColumnCount = 4;
            this.TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 3f));
            this.TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            this.TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            this.TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 4f));
            this.TableLayoutPanel2.Controls.Add(this.lblconf, 1, 0);
            this.TableLayoutPanel2.Controls.Add(this.lblopic, 2, 0);
            this.TableLayoutPanel2.Dock = DockStyle.Fill;
            point2 = new Point(0, 0);
            this.TableLayoutPanel2.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.TableLayoutPanel2.Margin = padding2;
            this.TableLayoutPanel2.Name = "TableLayoutPanel2";
            this.TableLayoutPanel2.RowCount = 1;
            this.TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            size2 = new Size(0x303, 30);
            this.TableLayoutPanel2.Size = size2;
            this.TableLayoutPanel2.TabIndex = 5;
            this.lblconf.Dock = DockStyle.Fill;
            this.lblconf.Font = new Font("Segoe UI", 14.25f);
            this.lblconf.ForeColor = SystemColors.ControlText;
            this.lblconf.ImeMode = ImeMode.NoControl;
            point2 = new Point(6, 0);
            this.lblconf.Location = point2;
            this.lblconf.Name = "lblconf";
            size2 = new Size(0x178, 30);
            this.lblconf.Size = size2;
            this.lblconf.TabIndex = 0;
            this.lblconf.Text = "BJMUNC2013  联合国粮农组织";
            this.lblconf.TextAlign = ContentAlignment.MiddleLeft;
            this.lblopic.Dock = DockStyle.Fill;
            this.lblopic.Font = new Font("Segoe UI", 14.25f);
            this.lblopic.ForeColor = SystemColors.ControlText;
            this.lblopic.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x184, 0);
            this.lblopic.Location = point2;
            this.lblopic.Name = "lblopic";
            size2 = new Size(0x178, 30);
            this.lblopic.Size = size2;
            this.lblopic.TabIndex = 1;
            this.lblopic.Text = "长期性的非洲粮食问题 第1会期";
            this.lblopic.TextAlign = ContentAlignment.MiddleRight;
            this.lbltime.BackColor = Color.LightSeaGreen;
            this.lbltime.Dock = DockStyle.Right;
            this.lbltime.Font = new Font("Segoe UI", 15.75f);
            this.lbltime.ForeColor = SystemColors.ControlLightLight;
            this.lbltime.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x303, 0);
            this.lbltime.Location = point2;
            this.lbltime.Name = "lbltime";
            size2 = new Size(0xd8, 30);
            this.lbltime.Size = size2;
            this.lbltime.TabIndex = 2;
            this.lbltime.Text = "2014-12-15 13:14:16";
            this.lbltime.TextAlign = ContentAlignment.MiddleCenter;
            this.panel_title_idle.Dock = DockStyle.Right;
            point2 = new Point(0x3db, 0);
            this.panel_title_idle.Location = point2;
            this.panel_title_idle.Name = "panel_title_idle";
            size2 = new Size(0x17, 30);
            this.panel_title_idle.Size = size2;
            this.panel_title_idle.TabIndex = 6;
            this.panel_main_sidebar.Anchor = AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top;
            this.panel_main_sidebar.BackColor = Color.Teal;
            this.panel_main_sidebar.Controls.Add(this.panel_dbq);
            this.panel_main_sidebar.Controls.Add(this.panel_readfile);
            this.panel_main_sidebar.Controls.Add(this.panel_mcedit);
            this.panel_main_sidebar.Controls.Add(this.panel_files);
            this.panel_main_sidebar.Controls.Add(this.panel_misc);
            this.panel_main_sidebar.Controls.Add(this.panel_vote);
            this.panel_main_sidebar.Controls.Add(this.panel_motion);
            this.panel_main_sidebar.Controls.Add(this.panel_sidebar_starting);
            this.panel_main_sidebar.Controls.Add(this.panel_spakers_list);
            this.panel_main_sidebar.Controls.Add(this.panel_system);
            this.panel_main_sidebar.Controls.Add(this.panel_editnationlist);
            this.panel_main_sidebar.Controls.Add(this.panel_mc);
            this.panel_main_sidebar.Controls.Add(this.panel_umc);
            this.panel_main_sidebar.Controls.Add(this.panel_presents);
            this.panel_main_sidebar.Controls.Add(this.panel_sidebar_timer);
            this.panel_main_sidebar.Controls.Add(this.panel_sidebar_idle);
            this.panel_main_sidebar.ForeColor = SystemColors.ControlLightLight;
            point2 = new Point(0x303, 0);
            this.panel_main_sidebar.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_main_sidebar.Margin = padding2;
            this.panel_main_sidebar.Name = "panel_main_sidebar";
            size2 = new Size(0xd8, 0x2f6);
            this.panel_main_sidebar.Size = size2;
            this.panel_main_sidebar.TabIndex = 4;
            this.panel_dbq.Controls.Add(this.btn_dbqstop);
            this.panel_dbq.Controls.Add(this.btn_dbqok);
            this.panel_dbq.Controls.Add(this.num_dbqtime);
            this.panel_dbq.Controls.Add(this.btn_dbqcancel);
            this.panel_dbq.Controls.Add(this.Label200);
            this.panel_dbq.Controls.Add(this.Label199);
            this.panel_dbq.Controls.Add(this.txt_dbqnation);
            this.panel_dbq.Controls.Add(this.lbl_dbqstatus);
            this.panel_dbq.Controls.Add(this.Label195);
            point2 = new Point(0x84, 0x12a);
            this.panel_dbq.Location = point2;
            this.panel_dbq.Name = "panel_dbq";
            size2 = new Size(0xd8, 0xb1);
            this.panel_dbq.Size = size2;
            this.panel_dbq.TabIndex = 14;
            this.panel_dbq.Visible = false;
            this.btn_dbqstop.BackColor = Color.LightSeaGreen;
            this.btn_dbqstop.Cursor = Cursors.Default;
            this.btn_dbqstop.FlatAppearance.BorderSize = 0;
            this.btn_dbqstop.FlatStyle = FlatStyle.Flat;
            this.btn_dbqstop.Font = new Font("Segoe UI", 12f);
            this.btn_dbqstop.ImeMode = ImeMode.NoControl;
            point2 = new Point(0, 0x83);
            this.btn_dbqstop.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_dbqstop.Margin = padding2;
            this.btn_dbqstop.Name = "btn_dbqstop";
            size2 = new Size(0xd8, 0x23);
            this.btn_dbqstop.Size = size2;
            this.btn_dbqstop.TabIndex = 2;
            this.btn_dbqstop.Text = "停止计时";
            this.btn_dbqstop.UseVisualStyleBackColor = false;
            this.btn_dbqstop.Visible = false;
            this.btn_dbqok.BackColor = Color.LightSeaGreen;
            this.btn_dbqok.Cursor = Cursors.Default;
            this.btn_dbqok.FlatAppearance.BorderSize = 0;
            this.btn_dbqok.FlatStyle = FlatStyle.Flat;
            this.btn_dbqok.Font = new Font("Segoe UI", 12f);
            this.btn_dbqok.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x6c, 0x83);
            this.btn_dbqok.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_dbqok.Margin = padding2;
            this.btn_dbqok.Name = "btn_dbqok";
            size2 = new Size(0x6d, 0x23);
            this.btn_dbqok.Size = size2;
            this.btn_dbqok.TabIndex = 2;
            this.btn_dbqok.Text = "确定";
            this.btn_dbqok.UseVisualStyleBackColor = false;
            this.num_dbqtime.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(0x4a, 0x65);
            this.num_dbqtime.Location = point2;
            this.num_dbqtime.Name = "num_dbqtime";
            size2 = new Size(0x22, 20);
            this.num_dbqtime.Size = size2;
            this.num_dbqtime.TabIndex = 5;
            decimal num = new decimal(new int[] { 1, 0, 0, 0 });
            this.num_dbqtime.Value = num;
            this.btn_dbqcancel.Cursor = Cursors.Default;
            this.btn_dbqcancel.FlatAppearance.BorderSize = 0;
            this.btn_dbqcancel.FlatStyle = FlatStyle.Flat;
            this.btn_dbqcancel.Font = new Font("Segoe UI", 12f);
            this.btn_dbqcancel.ImeMode = ImeMode.NoControl;
            point2 = new Point(0, 0x83);
            this.btn_dbqcancel.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_dbqcancel.Margin = padding2;
            this.btn_dbqcancel.Name = "btn_dbqcancel";
            size2 = new Size(0x6d, 0x23);
            this.btn_dbqcancel.Size = size2;
            this.btn_dbqcancel.TabIndex = 1;
            this.btn_dbqcancel.Text = "取消";
            this.btn_dbqcancel.UseVisualStyleBackColor = true;
            this.Label200.AutoSize = true;
            this.Label200.ForeColor = SystemColors.ControlLightLight;
            this.Label200.ImeMode = ImeMode.NoControl;
            point2 = new Point(13, 0x67);
            this.Label200.Location = point2;
            this.Label200.Name = "Label200";
            size2 = new Size(130, 13);
            this.Label200.Size = size2;
            this.Label200.TabIndex = 4;
            this.Label200.Text = "发言时间 　　　　分钟";
            this.Label199.AutoSize = true;
            point2 = new Point(120, 0x4d);
            this.Label199.Location = point2;
            this.Label199.Name = "Label199";
            size2 = new Size(0x43, 13);
            this.Label199.Size = size2;
            this.Label199.TabIndex = 3;
            this.Label199.Text = "申请答辩权";
            this.txt_dbqnation.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.txt_dbqnation.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.txt_dbqnation.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(14, 0x4b);
            this.txt_dbqnation.Location = point2;
            this.txt_dbqnation.Name = "txt_dbqnation";
            size2 = new Size(100, 20);
            this.txt_dbqnation.Size = size2;
            this.txt_dbqnation.TabIndex = 2;
            this.lbl_dbqstatus.AutoSize = true;
            point2 = new Point(12, 40);
            this.lbl_dbqstatus.Location = point2;
            this.lbl_dbqstatus.Name = "lbl_dbqstatus";
            size2 = new Size(0x55, 13);
            this.lbl_dbqstatus.Size = size2;
            this.lbl_dbqstatus.TabIndex = 1;
            this.lbl_dbqstatus.Text = "会议进程: 空闲";
            this.Label195.AutoSize = true;
            this.Label195.Font = new Font("Segoe UI", 12f);
            point2 = new Point(7, 11);
            this.Label195.Location = point2;
            this.Label195.Name = "Label195";
            size2 = new Size(0x3d, 0x15);
            this.Label195.Size = size2;
            this.Label195.TabIndex = 0;
            this.Label195.Text = "答辩权";
            this.panel_readfile.Controls.Add(this.panel_introtask);
            this.panel_readfile.Controls.Add(this.btn_read_close);
            this.panel_readfile.Controls.Add(this.lbl_fileinfo);
            this.panel_readfile.Controls.Add(this.lbl_reading);
            point2 = new Point(0x8a, 0x123);
            this.panel_readfile.Location = point2;
            this.panel_readfile.Name = "panel_readfile";
            size2 = new Size(0xd8, 0xa3);
            this.panel_readfile.Size = size2;
            this.panel_readfile.TabIndex = 13;
            this.panel_readfile.Visible = false;
            this.panel_introtask.Controls.Add(this.Label192);
            this.panel_introtask.Controls.Add(this.chk_playback);
            this.panel_introtask.Controls.Add(this.btn_file_modify);
            point2 = new Point(0, 0x60);
            this.panel_introtask.Location = point2;
            this.panel_introtask.Name = "panel_introtask";
            size2 = new Size(0xd8, 0x15);
            this.panel_introtask.Size = size2;
            this.panel_introtask.TabIndex = 6;
            point2 = new Point(12, 0);
            this.Label192.Location = point2;
            padding2 = new Padding(3);
            this.Label192.Margin = padding2;
            this.Label192.Name = "Label192";
            size2 = new Size(0x25, 0x17);
            this.Label192.Size = size2;
            this.Label192.TabIndex = 5;
            this.Label192.Text = "操作:";
            this.Label192.TextAlign = ContentAlignment.MiddleLeft;
            this.chk_playback.Appearance = Appearance.Button;
            this.chk_playback.AutoSize = true;
            this.chk_playback.FlatAppearance.BorderSize = 0;
            this.chk_playback.FlatStyle = FlatStyle.Flat;
            point2 = new Point(0x86, 0);
            this.chk_playback.Location = point2;
            this.chk_playback.Name = "chk_playback";
            size2 = new Size(0x29, 0x17);
            this.chk_playback.Size = size2;
            this.chk_playback.TabIndex = 4;
            this.chk_playback.Text = "回显";
            this.chk_playback.UseVisualStyleBackColor = true;
            this.btn_file_modify.FlatAppearance.BorderSize = 0;
            this.btn_file_modify.FlatStyle = FlatStyle.Flat;
            point2 = new Point(0x37, 0);
            this.btn_file_modify.Location = point2;
            this.btn_file_modify.Name = "btn_file_modify";
            size2 = new Size(0x4b, 0x17);
            this.btn_file_modify.Size = size2;
            this.btn_file_modify.TabIndex = 2;
            this.btn_file_modify.Text = "更改文件";
            this.btn_file_modify.UseVisualStyleBackColor = true;
            this.btn_read_close.FlatAppearance.BorderSize = 0;
            this.btn_read_close.FlatStyle = FlatStyle.Flat;
            this.btn_read_close.Font = new Font("Segoe UI", 12f);
            point2 = new Point(0, 0x79);
            this.btn_read_close.Location = point2;
            this.btn_read_close.Name = "btn_read_close";
            size2 = new Size(0xd8, 0x21);
            this.btn_read_close.Size = size2;
            this.btn_read_close.TabIndex = 3;
            this.btn_read_close.Text = "关闭";
            this.btn_read_close.UseVisualStyleBackColor = true;
            this.lbl_fileinfo.AutoSize = true;
            point2 = new Point(12, 40);
            this.lbl_fileinfo.Location = point2;
            padding2 = new Padding(3);
            this.lbl_fileinfo.Margin = padding2;
            size2 = new Size(190, 0);
            this.lbl_fileinfo.MaximumSize = size2;
            this.lbl_fileinfo.Name = "lbl_fileinfo";
            size2 = new Size(0x33, 13);
            this.lbl_fileinfo.Size = size2;
            this.lbl_fileinfo.TabIndex = 1;
            this.lbl_fileinfo.Text = "Label192";
            this.lbl_reading.AutoSize = true;
            this.lbl_reading.Font = new Font("Segoe UI", 12f);
            point2 = new Point(7, 11);
            this.lbl_reading.Location = point2;
            this.lbl_reading.Name = "lbl_reading";
            size2 = new Size(0x4a, 0x15);
            this.lbl_reading.Size = size2;
            this.lbl_reading.TabIndex = 0;
            this.lbl_reading.Text = "Label192";
            this.panel_mcedit.Controls.Add(this.btn_mcedit_save);
            this.panel_mcedit.Controls.Add(this.btn_mcedit_cancle);
            this.panel_mcedit.Controls.Add(this.Label188);
            this.panel_mcedit.Controls.Add(this.Label98);
            this.panel_mcedit.Controls.Add(this.txt_mceditnation);
            this.panel_mcedit.Controls.Add(this.num_mcnumber);
            this.panel_mcedit.Controls.Add(this.Label11);
            point2 = new Point(0x1f, 460);
            this.panel_mcedit.Location = point2;
            this.panel_mcedit.Name = "panel_mcedit";
            size2 = new Size(0xd8, 0x71);
            this.panel_mcedit.Size = size2;
            this.panel_mcedit.TabIndex = 8;
            this.panel_mcedit.Visible = false;
            this.btn_mcedit_save.FlatAppearance.BorderSize = 0;
            this.btn_mcedit_save.FlatStyle = FlatStyle.Flat;
            point2 = new Point(0x6f, 0x51);
            this.btn_mcedit_save.Location = point2;
            this.btn_mcedit_save.Name = "btn_mcedit_save";
            size2 = new Size(0x59, 0x17);
            this.btn_mcedit_save.Size = size2;
            this.btn_mcedit_save.TabIndex = 6;
            this.btn_mcedit_save.Text = "保存";
            this.btn_mcedit_save.UseVisualStyleBackColor = true;
            this.btn_mcedit_cancle.FlatAppearance.BorderSize = 0;
            this.btn_mcedit_cancle.FlatStyle = FlatStyle.Flat;
            point2 = new Point(15, 0x51);
            this.btn_mcedit_cancle.Location = point2;
            this.btn_mcedit_cancle.Name = "btn_mcedit_cancle";
            size2 = new Size(0x59, 0x17);
            this.btn_mcedit_cancle.Size = size2;
            this.btn_mcedit_cancle.TabIndex = 5;
            this.btn_mcedit_cancle.Text = "取消";
            this.btn_mcedit_cancle.UseVisualStyleBackColor = true;
            this.Label188.AutoSize = true;
            point2 = new Point(0x43, 0x27);
            this.Label188.Location = point2;
            this.Label188.Name = "Label188";
            size2 = new Size(0x1f, 13);
            this.Label188.Size = size2;
            this.Label188.TabIndex = 4;
            this.Label188.Text = "国家";
            this.Label98.AutoSize = true;
            point2 = new Point(12, 0x27);
            this.Label98.Location = point2;
            this.Label98.Name = "Label98";
            size2 = new Size(0x1f, 13);
            this.Label98.Size = size2;
            this.Label98.TabIndex = 3;
            this.Label98.Text = "序号";
            this.txt_mceditnation.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(70, 0x37);
            this.txt_mceditnation.Location = point2;
            this.txt_mceditnation.Name = "txt_mceditnation";
            size2 = new Size(130, 20);
            this.txt_mceditnation.Size = size2;
            this.txt_mceditnation.TabIndex = 2;
            this.num_mcnumber.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(15, 0x37);
            this.num_mcnumber.Location = point2;
            num = new decimal(new int[] { 40, 0, 0, 0 });
            this.num_mcnumber.Maximum = num;
            this.num_mcnumber.Name = "num_mcnumber";
            size2 = new Size(0x31, 20);
            this.num_mcnumber.Size = size2;
            this.num_mcnumber.TabIndex = 1;
            this.Label11.AutoSize = true;
            this.Label11.Font = new Font("Segoe UI", 12f);
            point2 = new Point(7, 11);
            this.Label11.Location = point2;
            this.Label11.Name = "Label11";
            size2 = new Size(0x4e, 0x15);
            this.Label11.Size = size2;
            this.Label11.TabIndex = 0;
            this.Label11.Text = "编辑列表";
            this.panel_files.Controls.Add(this.panel_file_bottom);
            this.panel_files.Controls.Add(this.panel_files_5);
            this.panel_files.Controls.Add(this.panel_files_4);
            this.panel_files.Controls.Add(this.panel_files_3);
            this.panel_files.Controls.Add(this.panel_file_2);
            this.panel_files.Controls.Add(this.panel_file_1);
            this.panel_files.Controls.Add(this.panel_file_top);
            point2 = new Point(0x89, 0xc4);
            this.panel_files.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_files.Margin = padding2;
            this.panel_files.Name = "panel_files";
            size2 = new Size(0xd8, 0x1ca);
            this.panel_files.Size = size2;
            this.panel_files.TabIndex = 8;
            this.panel_files.Visible = false;
            this.panel_file_bottom.Controls.Add(this.btn_file_ok);
            this.panel_file_bottom.Controls.Add(this.btn_file_cancel);
            this.panel_file_bottom.Dock = DockStyle.Top;
            point2 = new Point(0, 0xab);
            this.panel_file_bottom.Location = point2;
            this.panel_file_bottom.Name = "panel_file_bottom";
            size2 = new Size(0xd8, 0x37);
            this.panel_file_bottom.Size = size2;
            this.panel_file_bottom.TabIndex = 11;
            this.btn_file_ok.BackColor = Color.LightSeaGreen;
            this.btn_file_ok.Cursor = Cursors.Default;
            this.btn_file_ok.FlatAppearance.BorderSize = 0;
            this.btn_file_ok.FlatStyle = FlatStyle.Flat;
            this.btn_file_ok.Font = new Font("Segoe UI", 12f);
            this.btn_file_ok.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x6c, 7);
            this.btn_file_ok.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_file_ok.Margin = padding2;
            this.btn_file_ok.Name = "btn_file_ok";
            size2 = new Size(0x6d, 0x23);
            this.btn_file_ok.Size = size2;
            this.btn_file_ok.TabIndex = 2;
            this.btn_file_ok.Text = "确定";
            this.btn_file_ok.UseVisualStyleBackColor = false;
            this.btn_file_ok.Visible = false;
            this.btn_file_cancel.Cursor = Cursors.Default;
            this.btn_file_cancel.FlatAppearance.BorderSize = 0;
            this.btn_file_cancel.FlatStyle = FlatStyle.Flat;
            this.btn_file_cancel.Font = new Font("Segoe UI", 12f);
            this.btn_file_cancel.ImeMode = ImeMode.NoControl;
            point2 = new Point(0, 7);
            this.btn_file_cancel.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_file_cancel.Margin = padding2;
            this.btn_file_cancel.Name = "btn_file_cancel";
            size2 = new Size(0x6d, 0x23);
            this.btn_file_cancel.Size = size2;
            this.btn_file_cancel.TabIndex = 1;
            this.btn_file_cancel.Text = "取消";
            this.btn_file_cancel.UseVisualStyleBackColor = true;
            this.panel_files_5.Controls.Add(this.panel_f_5);
            this.panel_files_5.Controls.Add(this.btn_files_5);
            this.panel_files_5.Dock = DockStyle.Top;
            point2 = new Point(0, 0x95);
            this.panel_files_5.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_files_5.Margin = padding2;
            this.panel_files_5.Name = "panel_files_5";
            size2 = new Size(0xd8, 0x16);
            this.panel_files_5.Size = size2;
            this.panel_files_5.TabIndex = 11;
            this.panel_f_5.Controls.Add(this.num_fdl_ddm);
            this.panel_f_5.Controls.Add(this.num_fdl_ddh);
            this.panel_f_5.Controls.Add(this.num_fdl_amm);
            this.panel_f_5.Controls.Add(this.num_fdl_amh);
            this.panel_f_5.Controls.Add(this.num_fdl_drm);
            this.panel_f_5.Controls.Add(this.num_fdl_drh);
            this.panel_f_5.Controls.Add(this.chk_filedl_dr);
            this.panel_f_5.Controls.Add(this.chk_filedl_am);
            this.panel_f_5.Controls.Add(this.chk_filedl_dd);
            this.panel_f_5.Dock = DockStyle.Top;
            point2 = new Point(0, 0x16);
            this.panel_f_5.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_f_5.Margin = padding2;
            this.panel_f_5.Name = "panel_f_5";
            size2 = new Size(0xd8, 0xa1);
            this.panel_f_5.Size = size2;
            this.panel_f_5.TabIndex = 13;
            this.num_fdl_ddm.BorderStyle = BorderStyle.FixedSingle;
            num = new decimal(new int[] { 5, 0, 0, 0 });
            this.num_fdl_ddm.Increment = num;
            point2 = new Point(0x73, 0x83);
            this.num_fdl_ddm.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.num_fdl_ddm.Margin = padding2;
            num = new decimal(new int[] { 0x37, 0, 0, 0 });
            this.num_fdl_ddm.Maximum = num;
            this.num_fdl_ddm.Name = "num_fdl_ddm";
            size2 = new Size(0x23, 20);
            this.num_fdl_ddm.Size = size2;
            this.num_fdl_ddm.TabIndex = 0;
            this.num_fdl_ddh.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(0x37, 0x83);
            this.num_fdl_ddh.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.num_fdl_ddh.Margin = padding2;
            num = new decimal(new int[] { 0x17, 0, 0, 0 });
            this.num_fdl_ddh.Maximum = num;
            this.num_fdl_ddh.Name = "num_fdl_ddh";
            size2 = new Size(0x23, 20);
            this.num_fdl_ddh.Size = size2;
            this.num_fdl_ddh.TabIndex = 0;
            num = new decimal(new int[] { 0x10, 0, 0, 0 });
            this.num_fdl_ddh.Value = num;
            this.num_fdl_amm.BorderStyle = BorderStyle.FixedSingle;
            num = new decimal(new int[] { 5, 0, 0, 0 });
            this.num_fdl_amm.Increment = num;
            point2 = new Point(0x73, 0x52);
            this.num_fdl_amm.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.num_fdl_amm.Margin = padding2;
            num = new decimal(new int[] { 0x37, 0, 0, 0 });
            this.num_fdl_amm.Maximum = num;
            this.num_fdl_amm.Name = "num_fdl_amm";
            size2 = new Size(0x23, 20);
            this.num_fdl_amm.Size = size2;
            this.num_fdl_amm.TabIndex = 0;
            num = new decimal(new int[] { 30, 0, 0, 0 });
            this.num_fdl_amm.Value = num;
            this.num_fdl_amh.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(0x37, 0x52);
            this.num_fdl_amh.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.num_fdl_amh.Margin = padding2;
            num = new decimal(new int[] { 0x17, 0, 0, 0 });
            this.num_fdl_amh.Maximum = num;
            this.num_fdl_amh.Name = "num_fdl_amh";
            size2 = new Size(0x23, 20);
            this.num_fdl_amh.Size = size2;
            this.num_fdl_amh.TabIndex = 0;
            num = new decimal(new int[] { 10, 0, 0, 0 });
            this.num_fdl_amh.Value = num;
            this.num_fdl_drm.BorderStyle = BorderStyle.FixedSingle;
            num = new decimal(new int[] { 5, 0, 0, 0 });
            this.num_fdl_drm.Increment = num;
            point2 = new Point(0x73, 0x22);
            this.num_fdl_drm.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.num_fdl_drm.Margin = padding2;
            num = new decimal(new int[] { 0x37, 0, 0, 0 });
            this.num_fdl_drm.Maximum = num;
            this.num_fdl_drm.Name = "num_fdl_drm";
            size2 = new Size(0x23, 20);
            this.num_fdl_drm.Size = size2;
            this.num_fdl_drm.TabIndex = 0;
            num = new decimal(new int[] { 30, 0, 0, 0 });
            this.num_fdl_drm.Value = num;
            this.num_fdl_drh.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(0x37, 0x22);
            this.num_fdl_drh.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.num_fdl_drh.Margin = padding2;
            num = new decimal(new int[] { 0x17, 0, 0, 0 });
            this.num_fdl_drh.Maximum = num;
            this.num_fdl_drh.Name = "num_fdl_drh";
            size2 = new Size(0x23, 20);
            this.num_fdl_drh.Size = size2;
            this.num_fdl_drh.TabIndex = 0;
            num = new decimal(new int[] { 9, 0, 0, 0 });
            this.num_fdl_drh.Value = num;
            this.chk_filedl_dr.AutoSize = true;
            this.chk_filedl_dr.CheckAlign = ContentAlignment.TopLeft;
            this.chk_filedl_dr.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x10, 10);
            this.chk_filedl_dr.Location = point2;
            this.chk_filedl_dr.Name = "chk_filedl_dr";
            size2 = new Size(0x9e, 0x2b);
            this.chk_filedl_dr.Size = size2;
            this.chk_filedl_dr.TabIndex = 0;
            this.chk_filedl_dr.Text = "决议草案上交截止时间\r\n\r\n　　　　　时　　　　分";
            this.chk_filedl_dr.UseVisualStyleBackColor = true;
            this.chk_filedl_am.AutoSize = true;
            this.chk_filedl_am.CheckAlign = ContentAlignment.TopLeft;
            point2 = new Point(0x10, 0x3b);
            this.chk_filedl_am.Location = point2;
            this.chk_filedl_am.Name = "chk_filedl_am";
            size2 = new Size(0x9e, 0x2b);
            this.chk_filedl_am.Size = size2;
            this.chk_filedl_am.TabIndex = 1;
            this.chk_filedl_am.Text = "修正案上交截止时间\r\n\r\n　　　　　时　　　　分";
            this.chk_filedl_am.UseVisualStyleBackColor = true;
            this.chk_filedl_dd.AutoSize = true;
            this.chk_filedl_dd.CheckAlign = ContentAlignment.TopLeft;
            point2 = new Point(0x10, 0x6b);
            this.chk_filedl_dd.Location = point2;
            this.chk_filedl_dd.Name = "chk_filedl_dd";
            size2 = new Size(0x9e, 0x2b);
            this.chk_filedl_dd.Size = size2;
            this.chk_filedl_dd.TabIndex = 2;
            this.chk_filedl_dd.Text = "指令草案上交截止时间\r\n\r\n　　　　　时　　　　分";
            this.chk_filedl_dd.UseVisualStyleBackColor = true;
            this.btn_files_5.Dock = DockStyle.Top;
            this.btn_files_5.FlatAppearance.BorderSize = 0;
            this.btn_files_5.FlatStyle = FlatStyle.Flat;
            this.btn_files_5.ImeMode = ImeMode.NoControl;
            point2 = new Point(0, 0);
            this.btn_files_5.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_files_5.Margin = padding2;
            this.btn_files_5.Name = "btn_files_5";
            size2 = new Size(0xd8, 0x16);
            this.btn_files_5.Size = size2;
            this.btn_files_5.TabIndex = 0;
            this.btn_files_5.Text = "文件上交时间";
            this.btn_files_5.UseVisualStyleBackColor = true;
            this.panel_files_4.Controls.Add(this.panel_f_4);
            this.panel_files_4.Controls.Add(this.btn_files_4);
            this.panel_files_4.Dock = DockStyle.Top;
            point2 = new Point(0, 0x80);
            this.panel_files_4.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_files_4.Margin = padding2;
            this.panel_files_4.Name = "panel_files_4";
            size2 = new Size(0xd8, 0x15);
            this.panel_files_4.Size = size2;
            this.panel_files_4.TabIndex = 11;
            this.panel_f_4.Controls.Add(this.Label194);
            this.panel_f_4.Controls.Add(this.txt_fcrisis);
            this.panel_f_4.Controls.Add(this.num_crisis);
            this.panel_f_4.Controls.Add(this.Label202);
            this.panel_f_4.Dock = DockStyle.Top;
            point2 = new Point(0, 0x16);
            this.panel_f_4.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_f_4.Margin = padding2;
            this.panel_f_4.Name = "panel_f_4";
            size2 = new Size(0xd8, 0xd7);
            this.panel_f_4.Size = size2;
            this.panel_f_4.TabIndex = 13;
            this.Label194.AutoSize = true;
            this.Label194.ImeMode = ImeMode.NoControl;
            point2 = new Point(15, 0x29);
            this.Label194.Location = point2;
            this.Label194.Name = "Label194";
            size2 = new Size(0x58, 13);
            this.Label194.Size = size2;
            this.Label194.TabIndex = 14;
            this.Label194.Text = "危机正文 (选填)";
            this.txt_fcrisis.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(0x12, 60);
            this.txt_fcrisis.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.txt_fcrisis.Margin = padding2;
            this.txt_fcrisis.Multiline = true;
            this.txt_fcrisis.Name = "txt_fcrisis";
            this.txt_fcrisis.ScrollBars = ScrollBars.Vertical;
            size2 = new Size(0xb8, 140);
            this.txt_fcrisis.Size = size2;
            this.txt_fcrisis.TabIndex = 12;
            this.num_crisis.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(0x4c, 9);
            this.num_crisis.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.num_crisis.Margin = padding2;
            num = new decimal(new int[] { 60, 0, 0, 0 });
            this.num_crisis.Maximum = num;
            this.num_crisis.Name = "num_crisis";
            size2 = new Size(0x23, 20);
            this.num_crisis.Size = size2;
            this.num_crisis.TabIndex = 0;
            num = new decimal(new int[] { 3, 0, 0, 0 });
            this.num_crisis.Value = num;
            this.Label202.AutoSize = true;
            this.Label202.ImeMode = ImeMode.NoControl;
            point2 = new Point(15, 12);
            this.Label202.Location = point2;
            this.Label202.Name = "Label202";
            size2 = new Size(0x7f, 13);
            this.Label202.Size = size2;
            this.Label202.TabIndex = 1;
            this.Label202.Text = "阅读时间　　　　分钟";
            this.btn_files_4.Dock = DockStyle.Top;
            this.btn_files_4.FlatAppearance.BorderSize = 0;
            this.btn_files_4.FlatStyle = FlatStyle.Flat;
            this.btn_files_4.ImeMode = ImeMode.NoControl;
            point2 = new Point(0, 0);
            this.btn_files_4.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_files_4.Margin = padding2;
            this.btn_files_4.Name = "btn_files_4";
            size2 = new Size(0xd8, 0x16);
            this.btn_files_4.Size = size2;
            this.btn_files_4.TabIndex = 0;
            this.btn_files_4.Text = "发布危机";
            this.btn_files_4.UseVisualStyleBackColor = true;
            this.panel_files_3.Controls.Add(this.panel_f_3);
            this.panel_files_3.Controls.Add(this.btn_files_3);
            this.panel_files_3.Dock = DockStyle.Top;
            point2 = new Point(0, 0x6a);
            this.panel_files_3.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_files_3.Margin = padding2;
            this.panel_files_3.Name = "panel_files_3";
            size2 = new Size(0xd8, 0x16);
            this.panel_files_3.Size = size2;
            this.panel_files_3.TabIndex = 11;
            this.panel_f_3.Controls.Add(this.cbx_fselcet_2);
            this.panel_f_3.Controls.Add(this.Label193);
            this.panel_f_3.Dock = DockStyle.Top;
            point2 = new Point(0, 0x16);
            this.panel_f_3.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_f_3.Margin = padding2;
            this.panel_f_3.Name = "panel_f_3";
            size2 = new Size(0xd8, 0x26);
            this.panel_f_3.Size = size2;
            this.panel_f_3.TabIndex = 13;
            this.cbx_fselcet_2.BackColor = Color.PaleTurquoise;
            this.cbx_fselcet_2.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbx_fselcet_2.FlatStyle = FlatStyle.Flat;
            this.cbx_fselcet_2.FormattingEnabled = true;
            point2 = new Point(0x38, 9);
            this.cbx_fselcet_2.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.cbx_fselcet_2.Margin = padding2;
            this.cbx_fselcet_2.Name = "cbx_fselcet_2";
            size2 = new Size(0x73, 0x15);
            this.cbx_fselcet_2.Size = size2;
            this.cbx_fselcet_2.TabIndex = 15;
            this.Label193.AutoSize = true;
            this.Label193.ImeMode = ImeMode.NoControl;
            point2 = new Point(13, 13);
            this.Label193.Location = point2;
            this.Label193.Name = "Label193";
            size2 = new Size(190, 13);
            this.Label193.Size = size2;
            this.Label193.TabIndex = 14;
            this.Label193.Text = "对文件 　　　　　　　　　　投票";
            this.btn_files_3.Dock = DockStyle.Top;
            this.btn_files_3.FlatAppearance.BorderSize = 0;
            this.btn_files_3.FlatStyle = FlatStyle.Flat;
            this.btn_files_3.ImeMode = ImeMode.NoControl;
            point2 = new Point(0, 0);
            this.btn_files_3.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_files_3.Margin = padding2;
            this.btn_files_3.Name = "btn_files_3";
            size2 = new Size(0xd8, 0x16);
            this.btn_files_3.Size = size2;
            this.btn_files_3.TabIndex = 0;
            this.btn_files_3.Text = "对文件投票";
            this.btn_files_3.UseVisualStyleBackColor = true;
            this.panel_file_2.Controls.Add(this.panel_f_2);
            this.panel_file_2.Controls.Add(this.btn_file_2);
            this.panel_file_2.Dock = DockStyle.Top;
            point2 = new Point(0, 0x55);
            this.panel_file_2.Location = point2;
            this.panel_file_2.Name = "panel_file_2";
            size2 = new Size(0xd8, 0x15);
            this.panel_file_2.Size = size2;
            this.panel_file_2.TabIndex = 10;
            this.panel_f_2.Controls.Add(this.TextBox17);
            this.panel_f_2.Controls.Add(this.Label196);
            this.panel_f_2.Controls.Add(this.Label197);
            this.panel_f_2.Controls.Add(this.num_intro);
            this.panel_f_2.Controls.Add(this.cbx_fselect);
            this.panel_f_2.Controls.Add(this.Label198);
            this.panel_f_2.Dock = DockStyle.Top;
            point2 = new Point(0, 0x16);
            this.panel_f_2.Location = point2;
            this.panel_f_2.Name = "panel_f_2";
            size2 = new Size(0xd8, 0x60);
            this.panel_f_2.Size = size2;
            this.panel_f_2.TabIndex = 10;
            this.TextBox17.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(0x55, 0x42);
            this.TextBox17.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.TextBox17.Margin = padding2;
            this.TextBox17.Name = "TextBox17";
            size2 = new Size(0x73, 20);
            this.TextBox17.Size = size2;
            this.TextBox17.TabIndex = 4;
            this.Label196.AutoSize = true;
            this.Label196.ImeMode = ImeMode.NoControl;
            point2 = new Point(12, 70);
            this.Label196.Location = point2;
            this.Label196.Name = "Label196";
            size2 = new Size(0x43, 13);
            this.Label196.Size = size2;
            this.Label196.TabIndex = 2;
            this.Label196.Text = "介绍的国家";
            this.Label197.AutoSize = true;
            this.Label197.ImeMode = ImeMode.NoControl;
            point2 = new Point(12, 12);
            this.Label197.Location = point2;
            this.Label197.Name = "Label197";
            size2 = new Size(0x37, 13);
            this.Label197.Size = size2;
            this.Label197.TabIndex = 4;
            this.Label197.Text = "介绍文件";
            this.num_intro.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(0x49, 0x26);
            this.num_intro.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.num_intro.Margin = padding2;
            num = new decimal(new int[] { 60, 0, 0, 0 });
            this.num_intro.Maximum = num;
            this.num_intro.Name = "num_intro";
            size2 = new Size(0x23, 20);
            this.num_intro.Size = size2;
            this.num_intro.TabIndex = 0;
            num = new decimal(new int[] { 3, 0, 0, 0 });
            this.num_intro.Value = num;
            this.cbx_fselect.BackColor = Color.PaleTurquoise;
            this.cbx_fselect.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbx_fselect.FlatStyle = FlatStyle.Flat;
            this.cbx_fselect.FormattingEnabled = true;
            point2 = new Point(0x49, 8);
            this.cbx_fselect.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.cbx_fselect.Margin = padding2;
            this.cbx_fselect.Name = "cbx_fselect";
            size2 = new Size(0x79, 0x15);
            this.cbx_fselect.Size = size2;
            this.cbx_fselect.TabIndex = 11;
            this.Label198.AutoSize = true;
            this.Label198.ImeMode = ImeMode.NoControl;
            point2 = new Point(12, 0x29);
            this.Label198.Location = point2;
            this.Label198.Name = "Label198";
            size2 = new Size(0x7f, 13);
            this.Label198.Size = size2;
            this.Label198.TabIndex = 1;
            this.Label198.Text = "介绍时间　　　　分钟";
            this.btn_file_2.Dock = DockStyle.Top;
            this.btn_file_2.FlatAppearance.BorderSize = 0;
            this.btn_file_2.FlatStyle = FlatStyle.Flat;
            this.btn_file_2.ImeMode = ImeMode.NoControl;
            point2 = new Point(0, 0);
            this.btn_file_2.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_file_2.Margin = padding2;
            this.btn_file_2.Name = "btn_file_2";
            size2 = new Size(0xd8, 0x16);
            this.btn_file_2.Size = size2;
            this.btn_file_2.TabIndex = 1;
            this.btn_file_2.Text = "介绍文件";
            this.btn_file_2.UseVisualStyleBackColor = true;
            this.panel_file_1.Controls.Add(this.panel_selfile);
            this.panel_file_1.Controls.Add(this.panel_signatories);
            this.panel_file_1.Controls.Add(this.panel_sponsors);
            this.panel_file_1.Controls.Add(this.panel_f_1);
            this.panel_file_1.Controls.Add(this.btn_file_1);
            this.panel_file_1.Dock = DockStyle.Top;
            point2 = new Point(0, 0x40);
            this.panel_file_1.Location = point2;
            this.panel_file_1.Name = "panel_file_1";
            size2 = new Size(0xd8, 0x15);
            this.panel_file_1.Size = size2;
            this.panel_file_1.TabIndex = 10;
            this.panel_selfile.Controls.Add(this.btn_file_browse);
            this.panel_selfile.Controls.Add(this.lbl_filepath);
            this.panel_selfile.Controls.Add(this.Label191);
            this.panel_selfile.Dock = DockStyle.Top;
            point2 = new Point(0, 0xdb);
            this.panel_selfile.Location = point2;
            this.panel_selfile.Name = "panel_selfile";
            size2 = new Size(0xd8, 0x37);
            this.panel_selfile.Size = size2;
            this.panel_selfile.TabIndex = 11;
            this.btn_file_browse.FlatAppearance.BorderSize = 0;
            this.btn_file_browse.FlatStyle = FlatStyle.Flat;
            point2 = new Point(0x83, 0);
            this.btn_file_browse.Location = point2;
            this.btn_file_browse.Name = "btn_file_browse";
            size2 = new Size(0x45, 0x15);
            this.btn_file_browse.Size = size2;
            this.btn_file_browse.TabIndex = 2;
            this.btn_file_browse.Text = "浏览(&B)...";
            this.btn_file_browse.UseVisualStyleBackColor = true;
            point2 = new Point(12, 0x18);
            this.lbl_filepath.Location = point2;
            this.lbl_filepath.Name = "lbl_filepath";
            size2 = new Size(0xbc, 0x1f);
            this.lbl_filepath.Size = size2;
            this.lbl_filepath.TabIndex = 1;
            this.lbl_filepath.Text = "lbl_filepath";
            this.Label191.AutoSize = true;
            this.Label191.ImeMode = ImeMode.NoControl;
            point2 = new Point(12, 4);
            this.Label191.Location = point2;
            this.Label191.Name = "Label191";
            size2 = new Size(0x37, 13);
            this.Label191.Size = size2;
            this.Label191.TabIndex = 0;
            this.Label191.Text = "选择文件";
            this.panel_signatories.Controls.Add(this.txt_file_signatories);
            this.panel_signatories.Controls.Add(this.Label106);
            this.panel_signatories.Dock = DockStyle.Top;
            point2 = new Point(0, 0xbf);
            this.panel_signatories.Location = point2;
            this.panel_signatories.Name = "panel_signatories";
            size2 = new Size(0xd8, 0x1c);
            this.panel_signatories.Size = size2;
            this.panel_signatories.TabIndex = 5;
            this.txt_file_signatories.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(0x3d, 1);
            this.txt_file_signatories.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.txt_file_signatories.Margin = padding2;
            this.txt_file_signatories.Name = "txt_file_signatories";
            size2 = new Size(0x8b, 20);
            this.txt_file_signatories.Size = size2;
            this.txt_file_signatories.TabIndex = 5;
            this.Label106.AutoSize = true;
            this.Label106.ImeMode = ImeMode.NoControl;
            point2 = new Point(12, 4);
            this.Label106.Location = point2;
            this.Label106.Name = "Label106";
            size2 = new Size(0x2b, 13);
            this.Label106.Size = size2;
            this.Label106.TabIndex = 3;
            this.Label106.Text = "附议国";
            this.panel_sponsors.Controls.Add(this.txt_file_sponsors);
            this.panel_sponsors.Controls.Add(this.Label105);
            this.panel_sponsors.Dock = DockStyle.Top;
            point2 = new Point(0, 0xa3);
            this.panel_sponsors.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_sponsors.Margin = padding2;
            this.panel_sponsors.Name = "panel_sponsors";
            size2 = new Size(0xd8, 0x1c);
            this.panel_sponsors.Size = size2;
            this.panel_sponsors.TabIndex = 10;
            this.txt_file_sponsors.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(0x3d, 0);
            this.txt_file_sponsors.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.txt_file_sponsors.Margin = padding2;
            this.txt_file_sponsors.Name = "txt_file_sponsors";
            size2 = new Size(0x8b, 20);
            this.txt_file_sponsors.Size = size2;
            this.txt_file_sponsors.TabIndex = 4;
            this.Label105.AutoSize = true;
            this.Label105.ImeMode = ImeMode.NoControl;
            point2 = new Point(12, 4);
            this.Label105.Location = point2;
            this.Label105.Name = "Label105";
            size2 = new Size(0x2b, 13);
            this.Label105.Size = size2;
            this.Label105.TabIndex = 2;
            this.Label105.Text = "起草国";
            this.panel_f_1.Controls.Add(this.txt_filenumber_2);
            this.panel_f_1.Controls.Add(this.rad_present);
            this.panel_f_1.Controls.Add(this.txt_filenumber_1);
            this.panel_f_1.Controls.Add(this.rad_paper);
            this.panel_f_1.Controls.Add(this.Label35);
            this.panel_f_1.Controls.Add(this.Label103);
            this.panel_f_1.Controls.Add(this.cbx_ftpye);
            this.panel_f_1.Controls.Add(this.txt_filenumber_3);
            this.panel_f_1.Controls.Add(this.num_file);
            this.panel_f_1.Controls.Add(this.Label104);
            this.panel_f_1.Dock = DockStyle.Top;
            point2 = new Point(0, 0x16);
            this.panel_f_1.Location = point2;
            this.panel_f_1.Name = "panel_f_1";
            size2 = new Size(0xd8, 0x8d);
            this.panel_f_1.Size = size2;
            this.panel_f_1.TabIndex = 10;
            this.txt_filenumber_2.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(0x5d, 0x25);
            this.txt_filenumber_2.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.txt_filenumber_2.Margin = padding2;
            this.txt_filenumber_2.Name = "txt_filenumber_2";
            size2 = new Size(0x12, 20);
            this.txt_filenumber_2.Size = size2;
            this.txt_filenumber_2.TabIndex = 8;
            this.rad_present.AutoSize = true;
            point2 = new Point(15, 0x74);
            this.rad_present.Location = point2;
            this.rad_present.Name = "rad_present";
            size2 = new Size(0x55, 0x11);
            this.rad_present.Size = size2;
            this.rad_present.TabIndex = 11;
            this.rad_present.Text = "在屏幕展示";
            this.rad_present.UseVisualStyleBackColor = true;
            this.txt_filenumber_1.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(0x41, 0x25);
            this.txt_filenumber_1.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.txt_filenumber_1.Margin = padding2;
            this.txt_filenumber_1.Name = "txt_filenumber_1";
            size2 = new Size(0x12, 20);
            this.txt_filenumber_1.Size = size2;
            this.txt_filenumber_1.TabIndex = 7;
            this.rad_paper.AutoSize = true;
            this.rad_paper.Checked = true;
            point2 = new Point(15, 0x5e);
            this.rad_paper.Location = point2;
            this.rad_paper.Name = "rad_paper";
            size2 = new Size(0x61, 0x11);
            this.rad_paper.Size = size2;
            this.rad_paper.TabIndex = 10;
            this.rad_paper.TabStop = true;
            this.rad_paper.Text = "下发纸质文件";
            this.rad_paper.UseVisualStyleBackColor = true;
            this.Label35.AutoSize = true;
            this.Label35.ImeMode = ImeMode.NoControl;
            point2 = new Point(12, 13);
            this.Label35.Location = point2;
            this.Label35.Name = "Label35";
            size2 = new Size(0x37, 13);
            this.Label35.Size = size2;
            this.Label35.TabIndex = 4;
            this.Label35.Text = "文件类型";
            this.Label103.AutoSize = true;
            this.Label103.ImeMode = ImeMode.NoControl;
            point2 = new Point(12, 0x2a);
            this.Label103.Location = point2;
            this.Label103.Name = "Label103";
            size2 = new Size(0x6d, 13);
            this.Label103.Size = size2;
            this.Label103.TabIndex = 5;
            this.Label103.Text = "编号　　　　.　　.";
            this.cbx_ftpye.BackColor = Color.PaleTurquoise;
            this.cbx_ftpye.FlatStyle = FlatStyle.Flat;
            this.cbx_ftpye.FormattingEnabled = true;
            point2 = new Point(0x49, 9);
            this.cbx_ftpye.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.cbx_ftpye.Margin = padding2;
            this.cbx_ftpye.Name = "cbx_ftpye";
            size2 = new Size(0x79, 0x15);
            this.cbx_ftpye.Size = size2;
            this.cbx_ftpye.TabIndex = 6;
            this.txt_filenumber_3.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(0x79, 0x25);
            this.txt_filenumber_3.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.txt_filenumber_3.Margin = padding2;
            this.txt_filenumber_3.Name = "txt_filenumber_3";
            size2 = new Size(0x12, 20);
            this.txt_filenumber_3.Size = size2;
            this.txt_filenumber_3.TabIndex = 9;
            this.num_file.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(0x49, 0x42);
            this.num_file.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.num_file.Margin = padding2;
            num = new decimal(new int[] { 60, 0, 0, 0 });
            this.num_file.Maximum = num;
            this.num_file.Name = "num_file";
            size2 = new Size(0x23, 20);
            this.num_file.Size = size2;
            this.num_file.TabIndex = 0;
            num = new decimal(new int[] { 3, 0, 0, 0 });
            this.num_file.Value = num;
            this.Label104.AutoSize = true;
            this.Label104.ImeMode = ImeMode.NoControl;
            point2 = new Point(12, 0x45);
            this.Label104.Location = point2;
            this.Label104.Name = "Label104";
            size2 = new Size(0x7f, 13);
            this.Label104.Size = size2;
            this.Label104.TabIndex = 1;
            this.Label104.Text = "阅读时间　　　　分钟";
            this.btn_file_1.Dock = DockStyle.Top;
            this.btn_file_1.FlatAppearance.BorderSize = 0;
            this.btn_file_1.FlatStyle = FlatStyle.Flat;
            this.btn_file_1.ImeMode = ImeMode.NoControl;
            point2 = new Point(0, 0);
            this.btn_file_1.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_file_1.Margin = padding2;
            this.btn_file_1.Name = "btn_file_1";
            size2 = new Size(0xd8, 0x16);
            this.btn_file_1.Size = size2;
            this.btn_file_1.TabIndex = 1;
            this.btn_file_1.Text = "发布新文件";
            this.btn_file_1.UseVisualStyleBackColor = true;
            this.panel_file_top.Controls.Add(this.Label190);
            this.panel_file_top.Controls.Add(this.Label34);
            this.panel_file_top.Dock = DockStyle.Top;
            point2 = new Point(0, 0);
            this.panel_file_top.Location = point2;
            this.panel_file_top.Name = "panel_file_top";
            size2 = new Size(0xd8, 0x40);
            this.panel_file_top.Size = size2;
            this.panel_file_top.TabIndex = 10;
            this.Label190.AutoSize = true;
            point2 = new Point(12, 40);
            this.Label190.Location = point2;
            this.Label190.Name = "Label190";
            size2 = new Size(0x52, 13);
            this.Label190.Size = size2;
            this.Label190.TabIndex = 1;
            this.Label190.Text = "请选择功能项:";
            this.Label34.AutoSize = true;
            this.Label34.Font = new Font("Segoe UI", 12f);
            this.Label34.ImeMode = ImeMode.NoControl;
            point2 = new Point(7, 11);
            this.Label34.Location = point2;
            this.Label34.Name = "Label34";
            size2 = new Size(0x2c, 0x15);
            this.Label34.Size = size2;
            this.Label34.TabIndex = 0;
            this.Label34.Text = "文件";
            this.panel_misc.Controls.Add(this.panel_misc_bottom);
            this.panel_misc.Controls.Add(this.panel_misc_5);
            this.panel_misc.Controls.Add(this.btn_misc_4);
            this.panel_misc.Controls.Add(this.panel_misc_3);
            this.panel_misc.Controls.Add(this.panel_misc_2);
            this.panel_misc.Controls.Add(this.panel_misc_1);
            this.panel_misc.Controls.Add(this.panel_misc_top);
            point2 = new Point(0x97, 0x10d);
            this.panel_misc.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_misc.Margin = padding2;
            this.panel_misc.Name = "panel_misc";
            size2 = new Size(0xd8, 0x1e5);
            this.panel_misc.Size = size2;
            this.panel_misc.TabIndex = 12;
            this.panel_misc.Visible = false;
            this.panel_misc_bottom.Controls.Add(this.btn_misc_cancel);
            this.panel_misc_bottom.Controls.Add(this.btn_misc_ok);
            this.panel_misc_bottom.Dock = DockStyle.Top;
            point2 = new Point(0, 170);
            this.panel_misc_bottom.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_misc_bottom.Margin = padding2;
            this.panel_misc_bottom.Name = "panel_misc_bottom";
            size2 = new Size(0xd8, 0x35);
            this.panel_misc_bottom.Size = size2;
            this.panel_misc_bottom.TabIndex = 7;
            this.btn_misc_cancel.FlatAppearance.BorderSize = 0;
            this.btn_misc_cancel.FlatStyle = FlatStyle.Flat;
            this.btn_misc_cancel.Font = new Font("Segoe UI", 12f);
            this.btn_misc_cancel.ImeMode = ImeMode.NoControl;
            point2 = new Point(0, 7);
            this.btn_misc_cancel.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_misc_cancel.Margin = padding2;
            this.btn_misc_cancel.Name = "btn_misc_cancel";
            size2 = new Size(0x6c, 0x23);
            this.btn_misc_cancel.Size = size2;
            this.btn_misc_cancel.TabIndex = 5;
            this.btn_misc_cancel.Text = "取消";
            this.btn_misc_cancel.UseVisualStyleBackColor = false;
            this.btn_misc_ok.BackColor = Color.LightSeaGreen;
            this.btn_misc_ok.FlatAppearance.BorderSize = 0;
            this.btn_misc_ok.FlatStyle = FlatStyle.Flat;
            this.btn_misc_ok.Font = new Font("Segoe UI", 12f);
            this.btn_misc_ok.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x6c, 7);
            this.btn_misc_ok.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_misc_ok.Margin = padding2;
            this.btn_misc_ok.Name = "btn_misc_ok";
            size2 = new Size(0x6c, 0x23);
            this.btn_misc_ok.Size = size2;
            this.btn_misc_ok.TabIndex = 6;
            this.btn_misc_ok.Text = "确定";
            this.btn_misc_ok.UseVisualStyleBackColor = false;
            this.btn_misc_ok.Visible = false;
            this.panel_misc_5.Controls.Add(this.panel_ms_5);
            this.panel_misc_5.Controls.Add(this.btn_misc_5);
            this.panel_misc_5.Dock = DockStyle.Top;
            point2 = new Point(0, 0x95);
            this.panel_misc_5.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_misc_5.Margin = padding2;
            this.panel_misc_5.Name = "panel_misc_5";
            size2 = new Size(0xd8, 0x15);
            this.panel_misc_5.Size = size2;
            this.panel_misc_5.TabIndex = 0;
            this.panel_ms_5.Controls.Add(this.txt_custom);
            this.panel_ms_5.Controls.Add(this.Label201);
            this.panel_ms_5.Dock = DockStyle.Top;
            point2 = new Point(0, 0x16);
            this.panel_ms_5.Location = point2;
            this.panel_ms_5.Name = "panel_ms_5";
            size2 = new Size(0xd8, 0x90);
            this.panel_ms_5.Size = size2;
            this.panel_ms_5.TabIndex = 11;
            this.txt_custom.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(15, 0x1b);
            this.txt_custom.Location = point2;
            this.txt_custom.Multiline = true;
            this.txt_custom.Name = "txt_custom";
            size2 = new Size(0xbb, 0x6b);
            this.txt_custom.Size = size2;
            this.txt_custom.TabIndex = 12;
            this.Label201.AutoSize = true;
            point2 = new Point(12, 11);
            this.Label201.Location = point2;
            this.Label201.Name = "Label201";
            size2 = new Size(130, 13);
            this.Label201.Size = size2;
            this.Label201.TabIndex = 11;
            this.Label201.Text = "请输入您要发布的信息:";
            this.btn_misc_5.Dock = DockStyle.Top;
            this.btn_misc_5.FlatAppearance.BorderSize = 0;
            this.btn_misc_5.FlatStyle = FlatStyle.Flat;
            this.btn_misc_5.ImeMode = ImeMode.NoControl;
            point2 = new Point(0, 0);
            this.btn_misc_5.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_misc_5.Margin = padding2;
            this.btn_misc_5.Name = "btn_misc_5";
            size2 = new Size(0xd8, 0x16);
            this.btn_misc_5.Size = size2;
            this.btn_misc_5.TabIndex = 10;
            this.btn_misc_5.Text = "自定义消息";
            this.btn_misc_5.UseVisualStyleBackColor = true;
            this.btn_misc_4.Dock = DockStyle.Top;
            this.btn_misc_4.FlatAppearance.BorderSize = 0;
            this.btn_misc_4.FlatStyle = FlatStyle.Flat;
            this.btn_misc_4.ImeMode = ImeMode.NoControl;
            point2 = new Point(0, 0x7f);
            this.btn_misc_4.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_misc_4.Margin = padding2;
            this.btn_misc_4.Name = "btn_misc_4";
            size2 = new Size(0xd8, 0x16);
            this.btn_misc_4.Size = size2;
            this.btn_misc_4.TabIndex = 11;
            this.btn_misc_4.Text = "答辩权";
            this.btn_misc_4.UseVisualStyleBackColor = true;
            this.panel_misc_3.Controls.Add(this.panel_ms_3);
            this.panel_misc_3.Controls.Add(this.btn_misc_3);
            this.panel_misc_3.Dock = DockStyle.Top;
            point2 = new Point(0, 0x6a);
            this.panel_misc_3.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_misc_3.Margin = padding2;
            this.panel_misc_3.Name = "panel_misc_3";
            size2 = new Size(0xd8, 0x15);
            this.panel_misc_3.Size = size2;
            this.panel_misc_3.TabIndex = 0;
            this.panel_ms_3.Controls.Add(this.Label180);
            this.panel_ms_3.Controls.Add(this.cbx_awards);
            this.panel_ms_3.Controls.Add(this.txt_awardsch);
            this.panel_ms_3.Controls.Add(this.Label91);
            this.panel_ms_3.Controls.Add(this.txt_awardnat);
            this.panel_ms_3.Controls.Add(this.txt_awardelg);
            this.panel_ms_3.Controls.Add(this.Label134);
            this.panel_ms_3.Controls.Add(this.Label149);
            this.panel_ms_3.Dock = DockStyle.Top;
            point2 = new Point(0, 0x16);
            this.panel_ms_3.Location = point2;
            this.panel_ms_3.Name = "panel_ms_3";
            size2 = new Size(0xd8, 0x74);
            this.panel_ms_3.Size = size2;
            this.panel_ms_3.TabIndex = 0x16;
            this.Label180.AutoSize = true;
            this.Label180.ImeMode = ImeMode.NoControl;
            point2 = new Point(12, 13);
            this.Label180.Location = point2;
            this.Label180.Name = "Label180";
            size2 = new Size(0x1f, 13);
            this.Label180.Size = size2;
            this.Label180.TabIndex = 0x12;
            this.Label180.Text = "奖项";
            this.cbx_awards.FlatStyle = FlatStyle.Flat;
            this.cbx_awards.FormattingEnabled = true;
            this.cbx_awards.Items.AddRange(new object[] { "Best Delegates", "Outstandng Delegates", "Best Position Paper", "Best Colleagues", "Best Styles" });
            point2 = new Point(0x31, 10);
            this.cbx_awards.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.cbx_awards.Margin = padding2;
            this.cbx_awards.Name = "cbx_awards";
            size2 = new Size(0x93, 0x15);
            this.cbx_awards.Size = size2;
            this.cbx_awards.TabIndex = 14;
            this.txt_awardsch.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(0x49, 0x58);
            this.txt_awardsch.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.txt_awardsch.Margin = padding2;
            this.txt_awardsch.Name = "txt_awardsch";
            size2 = new Size(0x7c, 20);
            this.txt_awardsch.Size = size2;
            this.txt_awardsch.TabIndex = 0x11;
            this.Label91.AutoSize = true;
            this.Label91.ImeMode = ImeMode.NoControl;
            point2 = new Point(11, 0x5b);
            this.Label91.Location = point2;
            this.Label91.Name = "Label91";
            size2 = new Size(0x37, 13);
            this.Label91.Size = size2;
            this.Label91.TabIndex = 0x15;
            this.Label91.Text = "所在学校";
            this.txt_awardnat.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(0x30, 0x24);
            this.txt_awardnat.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.txt_awardnat.Margin = padding2;
            this.txt_awardnat.Name = "txt_awardnat";
            size2 = new Size(0x6f, 20);
            this.txt_awardnat.Size = size2;
            this.txt_awardnat.TabIndex = 15;
            this.txt_awardelg.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(0x49, 0x3e);
            this.txt_awardelg.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.txt_awardelg.Margin = padding2;
            this.txt_awardelg.Name = "txt_awardelg";
            size2 = new Size(0x7c, 20);
            this.txt_awardelg.Size = size2;
            this.txt_awardelg.TabIndex = 0x10;
            this.Label134.AutoSize = true;
            this.Label134.ImeMode = ImeMode.NoControl;
            point2 = new Point(11, 0x41);
            this.Label134.Location = point2;
            this.Label134.Name = "Label134";
            size2 = new Size(0x37, 13);
            this.Label134.Size = size2;
            this.Label134.TabIndex = 20;
            this.Label134.Text = "代表姓名";
            this.Label149.AutoSize = true;
            this.Label149.ImeMode = ImeMode.NoControl;
            point2 = new Point(12, 0x27);
            this.Label149.Location = point2;
            this.Label149.Name = "Label149";
            size2 = new Size(0xbb, 13);
            this.Label149.Size = size2;
            this.Label149.TabIndex = 0x13;
            this.Label149.Text = "授予　　　　　　　　　　　代表";
            this.btn_misc_3.Dock = DockStyle.Top;
            this.btn_misc_3.FlatAppearance.BorderSize = 0;
            this.btn_misc_3.FlatStyle = FlatStyle.Flat;
            this.btn_misc_3.ImeMode = ImeMode.NoControl;
            point2 = new Point(0, 0);
            this.btn_misc_3.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_misc_3.Margin = padding2;
            this.btn_misc_3.Name = "btn_misc_3";
            size2 = new Size(0xd8, 0x16);
            this.btn_misc_3.Size = size2;
            this.btn_misc_3.TabIndex = 10;
            this.btn_misc_3.Text = "颁奖";
            this.btn_misc_3.UseVisualStyleBackColor = true;
            this.panel_misc_2.Controls.Add(this.btn_misc_2);
            this.panel_misc_2.Controls.Add(this.panel_ms_2);
            this.panel_misc_2.Dock = DockStyle.Top;
            point2 = new Point(0, 0x55);
            this.panel_misc_2.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_misc_2.Margin = padding2;
            this.panel_misc_2.Name = "panel_misc_2";
            size2 = new Size(0xd8, 0x15);
            this.panel_misc_2.Size = size2;
            this.panel_misc_2.TabIndex = 0;
            this.btn_misc_2.Dock = DockStyle.Top;
            this.btn_misc_2.FlatAppearance.BorderSize = 0;
            this.btn_misc_2.FlatStyle = FlatStyle.Flat;
            this.btn_misc_2.ImeMode = ImeMode.NoControl;
            point2 = new Point(0, 0);
            this.btn_misc_2.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_misc_2.Margin = padding2;
            this.btn_misc_2.Name = "btn_misc_2";
            size2 = new Size(0xd8, 0x16);
            this.btn_misc_2.Size = size2;
            this.btn_misc_2.TabIndex = 10;
            this.btn_misc_2.Text = "虚拟时钟设定";
            this.btn_misc_2.UseVisualStyleBackColor = true;
            this.panel_ms_2.Controls.Add(this.panel_clock);
            this.panel_ms_2.Controls.Add(this.rad_clockyes);
            this.panel_ms_2.Controls.Add(this.rad_clockno);
            point2 = new Point(0, 0x17);
            this.panel_ms_2.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_ms_2.Margin = padding2;
            this.panel_ms_2.Name = "panel_ms_2";
            size2 = new Size(0xd8, 0xb3);
            this.panel_ms_2.Size = size2;
            this.panel_ms_2.TabIndex = 9;
            this.panel_clock.Controls.Add(this.Label179);
            this.panel_clock.Controls.Add(this.Label178);
            this.panel_clock.Controls.Add(this.TrackBar1);
            this.panel_clock.Controls.Add(this.TextBox10);
            this.panel_clock.Controls.Add(this.DateTimePicker1);
            this.panel_clock.Controls.Add(this.Label164);
            this.panel_clock.Controls.Add(this.numhh);
            this.panel_clock.Controls.Add(this.Label176);
            this.panel_clock.Controls.Add(this.nummm);
            this.panel_clock.Controls.Add(this.Label177);
            point2 = new Point(0, 0x30);
            this.panel_clock.Location = point2;
            this.panel_clock.Name = "panel_clock";
            size2 = new Size(0xd8, 0x83);
            this.panel_clock.Size = size2;
            this.panel_clock.TabIndex = 0x16;
            this.Label179.AutoSize = true;
            this.Label179.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x2c, 100);
            this.Label179.Location = point2;
            this.Label179.Name = "Label179";
            size2 = new Size(100, 13);
            this.Label179.Size = size2;
            this.Label179.TabIndex = 0x15;
            this.Label179.Text = "1分钟   1小时  1天";
            this.Label178.AutoSize = true;
            this.Label178.ImeMode = ImeMode.NoControl;
            point2 = new Point(13, 10);
            this.Label178.Location = point2;
            this.Label178.Name = "Label178";
            size2 = new Size(0x3d, 13);
            this.Label178.Size = size2;
            this.Label178.TabIndex = 13;
            this.Label178.Text = "起始日期: ";
            this.TrackBar1.ImeMode = ImeMode.NoControl;
            this.TrackBar1.LargeChange = 1;
            point2 = new Point(0x2c, 0x44);
            this.TrackBar1.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.TrackBar1.Margin = padding2;
            this.TrackBar1.Maximum = 12;
            this.TrackBar1.Name = "TrackBar1";
            size2 = new Size(100, 0x2d);
            this.TrackBar1.Size = size2;
            this.TrackBar1.TabIndex = 0x13;
            this.TextBox10.BackColor = Color.PaleTurquoise;
            this.TextBox10.BorderStyle = BorderStyle.FixedSingle;
            this.TextBox10.Enabled = false;
            point2 = new Point(0x97, 0x44);
            this.TextBox10.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.TextBox10.Margin = padding2;
            this.TextBox10.Name = "TextBox10";
            this.TextBox10.ReadOnly = true;
            this.TextBox10.RightToLeft = RightToLeft.Yes;
            size2 = new Size(0x22, 20);
            this.TextBox10.Size = size2;
            this.TextBox10.TabIndex = 20;
            this.TextBox10.Text = "1";
            this.DateTimePicker1.Format = DateTimePickerFormat.Short;
            point2 = new Point(0x4e, 7);
            this.DateTimePicker1.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.DateTimePicker1.Margin = padding2;
            this.DateTimePicker1.Name = "DateTimePicker1";
            size2 = new Size(0x80, 20);
            this.DateTimePicker1.Size = size2;
            this.DateTimePicker1.TabIndex = 12;
            this.Label164.AutoSize = true;
            this.Label164.ImeMode = ImeMode.NoControl;
            point2 = new Point(0xbb, 0x48);
            this.Label164.Location = point2;
            this.Label164.Name = "Label164";
            size2 = new Size(0x13, 13);
            this.Label164.Size = size2;
            this.Label164.TabIndex = 0x12;
            this.Label164.Text = "倍";
            this.numhh.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(0x63, 0x25);
            this.numhh.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.numhh.Margin = padding2;
            num = new decimal(new int[] { 0x17, 0, 0, 0 });
            this.numhh.Maximum = num;
            this.numhh.Name = "numhh";
            size2 = new Size(0x22, 20);
            this.numhh.Size = size2;
            this.numhh.TabIndex = 15;
            this.Label176.AutoSize = true;
            this.Label176.ImeMode = ImeMode.NoControl;
            point2 = new Point(13, 0x48);
            this.Label176.Location = point2;
            this.Label176.Name = "Label176";
            size2 = new Size(0x22, 13);
            this.Label176.Size = size2;
            this.Label176.TabIndex = 0x11;
            this.Label176.Text = "倍率:";
            this.nummm.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(0x9a, 0x25);
            this.nummm.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.nummm.Margin = padding2;
            num = new decimal(new int[] { 0x3b, 0, 0, 0 });
            this.nummm.Maximum = num;
            this.nummm.Name = "nummm";
            size2 = new Size(0x22, 20);
            this.nummm.Size = size2;
            this.nummm.TabIndex = 0x10;
            num = new decimal(new int[] { 0x3b, 0, 0, 0 });
            this.nummm.Value = num;
            this.Label177.AutoSize = true;
            this.Label177.ImeMode = ImeMode.NoControl;
            point2 = new Point(13, 40);
            this.Label177.Location = point2;
            this.Label177.Name = "Label177";
            size2 = new Size(0xc1, 13);
            this.Label177.Size = size2;
            this.Label177.TabIndex = 14;
            this.Label177.Text = "起始时间:　　　　　　时　　　 分";
            this.rad_clockyes.AutoSize = true;
            this.rad_clockyes.ImeMode = ImeMode.NoControl;
            point2 = new Point(11, 0x1c);
            this.rad_clockyes.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.rad_clockyes.Margin = padding2;
            this.rad_clockyes.Name = "rad_clockyes";
            size2 = new Size(0x79, 0x11);
            this.rad_clockyes.Size = size2;
            this.rad_clockyes.TabIndex = 8;
            this.rad_clockyes.Text = "显示会议自定时间";
            this.rad_clockyes.UseVisualStyleBackColor = true;
            this.rad_clockno.AutoSize = true;
            this.rad_clockno.Checked = true;
            this.rad_clockno.ImeMode = ImeMode.NoControl;
            point2 = new Point(11, 7);
            this.rad_clockno.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.rad_clockno.Margin = padding2;
            this.rad_clockno.Name = "rad_clockno";
            size2 = new Size(0x61, 0x11);
            this.rad_clockno.Size = size2;
            this.rad_clockno.TabIndex = 7;
            this.rad_clockno.TabStop = true;
            this.rad_clockno.Text = "显示系统时间";
            this.rad_clockno.UseVisualStyleBackColor = true;
            this.panel_misc_1.Controls.Add(this.panel_ms_1);
            this.panel_misc_1.Controls.Add(this.btn_misc_1);
            this.panel_misc_1.Dock = DockStyle.Top;
            point2 = new Point(0, 0x40);
            this.panel_misc_1.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_misc_1.Margin = padding2;
            this.panel_misc_1.Name = "panel_misc_1";
            size2 = new Size(0xd8, 0x15);
            this.panel_misc_1.Size = size2;
            this.panel_misc_1.TabIndex = 0;
            this.panel_ms_1.Controls.Add(this.num_tbtime);
            this.panel_ms_1.Controls.Add(this.Label119);
            this.panel_ms_1.Dock = DockStyle.Top;
            point2 = new Point(0, 0x16);
            this.panel_ms_1.Location = point2;
            this.panel_ms_1.Name = "panel_ms_1";
            size2 = new Size(0xd8, 0x21);
            this.panel_ms_1.Size = size2;
            this.panel_ms_1.TabIndex = 8;
            this.num_tbtime.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(0x42, 7);
            this.num_tbtime.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.num_tbtime.Margin = padding2;
            num = new decimal(new int[] { 60, 0, 0, 0 });
            this.num_tbtime.Maximum = num;
            this.num_tbtime.Name = "num_tbtime";
            size2 = new Size(0x25, 20);
            this.num_tbtime.Size = size2;
            this.num_tbtime.TabIndex = 3;
            num = new decimal(new int[] { 20, 0, 0, 0 });
            this.num_tbtime.Value = num;
            this.Label119.AutoSize = true;
            this.Label119.ImeMode = ImeMode.NoControl;
            point2 = new Point(12, 9);
            this.Label119.Location = point2;
            this.Label119.Name = "Label119";
            size2 = new Size(130, 13);
            this.Label119.Size = size2;
            this.Label119.TabIndex = 1;
            this.Label119.Text = "总时长:　　　　　分钟";
            this.btn_misc_1.Dock = DockStyle.Top;
            this.btn_misc_1.FlatAppearance.BorderSize = 0;
            this.btn_misc_1.FlatStyle = FlatStyle.Flat;
            this.btn_misc_1.ImeMode = ImeMode.NoControl;
            point2 = new Point(0, 0);
            this.btn_misc_1.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_misc_1.Margin = padding2;
            this.btn_misc_1.Name = "btn_misc_1";
            size2 = new Size(0xd8, 0x16);
            this.btn_misc_1.Size = size2;
            this.btn_misc_1.TabIndex = 7;
            this.btn_misc_1.Text = "开始茶歇";
            this.btn_misc_1.UseVisualStyleBackColor = true;
            this.panel_misc_top.Controls.Add(this.Label90);
            this.panel_misc_top.Controls.Add(this.Label75);
            this.panel_misc_top.Dock = DockStyle.Top;
            point2 = new Point(0, 0);
            this.panel_misc_top.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_misc_top.Margin = padding2;
            this.panel_misc_top.Name = "panel_misc_top";
            size2 = new Size(0xd8, 0x40);
            this.panel_misc_top.Size = size2;
            this.panel_misc_top.TabIndex = 6;
            this.Label90.AutoSize = true;
            this.Label90.ImeMode = ImeMode.NoControl;
            point2 = new Point(12, 40);
            this.Label90.Location = point2;
            this.Label90.Name = "Label90";
            size2 = new Size(0x52, 13);
            this.Label90.Size = size2;
            this.Label90.TabIndex = 1;
            this.Label90.Text = "请选择功能项:";
            this.Label90.TextAlign = ContentAlignment.MiddleCenter;
            this.Label75.Font = new Font("Segoe UI", 12f);
            this.Label75.ImeMode = ImeMode.NoControl;
            point2 = new Point(7, 11);
            this.Label75.Location = point2;
            this.Label75.Name = "Label75";
            size2 = new Size(0x2c, 0x15);
            this.Label75.Size = size2;
            this.Label75.TabIndex = 0;
            this.Label75.Text = "杂项";
            this.panel_vote.Anchor = AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.panel_vote.Controls.Add(this.panel_vote_config);
            this.panel_vote.Controls.Add(this.panel_vote_ctrl);
            this.panel_vote.Controls.Add(this.panel_vote_roll);
            this.panel_vote.Controls.Add(this.panel_vote_top);
            this.panel_vote.Controls.Add(this.panel_vote_bottom);
            point2 = new Point(0x63, 0x135);
            this.panel_vote.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_vote.Margin = padding2;
            this.panel_vote.Name = "panel_vote";
            size2 = new Size(0xd8, 0x17e);
            this.panel_vote.Size = size2;
            this.panel_vote.TabIndex = 9;
            this.panel_vote.Visible = false;
            this.panel_vote_config.Controls.Add(this.chk_noabst);
            this.panel_vote_config.Controls.Add(this.rad_all);
            this.panel_vote_config.Controls.Add(this.rad_80maj);
            this.panel_vote_config.Controls.Add(this.rad_67maj);
            this.panel_vote_config.Controls.Add(this.rad_50maj);
            this.panel_vote_config.Controls.Add(this.CheckBox6);
            this.panel_vote_config.Controls.Add(this.CheckBox5);
            this.panel_vote_config.Controls.Add(this.CheckBox4);
            this.panel_vote_config.Controls.Add(this.CheckBox3);
            this.panel_vote_config.Controls.Add(this.CheckBox2);
            this.panel_vote_config.Controls.Add(this.chk_vote_foujue);
            this.panel_vote_config.Dock = DockStyle.Top;
            point2 = new Point(0, 0x197);
            this.panel_vote_config.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_vote_config.Margin = padding2;
            this.panel_vote_config.Name = "panel_vote_config";
            size2 = new Size(0xd8, 150);
            this.panel_vote_config.Size = size2;
            this.panel_vote_config.TabIndex = 0x10;
            this.panel_vote_config.Visible = false;
            this.chk_noabst.AutoSize = true;
            this.chk_noabst.Checked = true;
            this.chk_noabst.CheckState = CheckState.Checked;
            this.chk_noabst.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x70, 0x79);
            this.chk_noabst.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.chk_noabst.Margin = padding2;
            this.chk_noabst.Name = "chk_noabst";
            size2 = new Size(0x56, 0x11);
            this.chk_noabst.Size = size2;
            this.chk_noabst.TabIndex = 10;
            this.chk_noabst.Text = "不计弃权票";
            this.chk_noabst.UseVisualStyleBackColor = true;
            this.rad_all.AutoSize = true;
            this.rad_all.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x70, 100);
            this.rad_all.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.rad_all.Margin = padding2;
            this.rad_all.Name = "rad_all";
            size2 = new Size(0x31, 0x11);
            this.rad_all.Size = size2;
            this.rad_all.TabIndex = 9;
            this.rad_all.Text = "全部";
            this.rad_all.UseVisualStyleBackColor = true;
            this.rad_80maj.AutoSize = true;
            this.rad_80maj.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x70, 0x4e);
            this.rad_80maj.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.rad_80maj.Margin = padding2;
            this.rad_80maj.Name = "rad_80maj";
            size2 = new Size(0x2d, 0x11);
            this.rad_80maj.Size = size2;
            this.rad_80maj.TabIndex = 8;
            this.rad_80maj.Text = "80%";
            this.rad_80maj.UseVisualStyleBackColor = true;
            this.rad_67maj.AutoSize = true;
            this.rad_67maj.Checked = true;
            this.rad_67maj.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x70, 0x38);
            this.rad_67maj.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.rad_67maj.Margin = padding2;
            this.rad_67maj.Name = "rad_67maj";
            size2 = new Size(0x61, 0x11);
            this.rad_67maj.Size = size2;
            this.rad_67maj.TabIndex = 7;
            this.rad_67maj.TabStop = true;
            this.rad_67maj.Text = "三分之二多数";
            this.rad_67maj.UseVisualStyleBackColor = true;
            this.rad_50maj.AutoSize = true;
            this.rad_50maj.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x70, 0x23);
            this.rad_50maj.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.rad_50maj.Margin = padding2;
            this.rad_50maj.Name = "rad_50maj";
            size2 = new Size(0x49, 0x11);
            this.rad_50maj.Size = size2;
            this.rad_50maj.TabIndex = 6;
            this.rad_50maj.Text = "简单多数";
            this.rad_50maj.UseVisualStyleBackColor = true;
            this.CheckBox6.AutoSize = true;
            this.CheckBox6.Enabled = false;
            this.CheckBox6.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x12, 0x71);
            this.CheckBox6.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.CheckBox6.Margin = padding2;
            this.CheckBox6.Name = "CheckBox6";
            size2 = new Size(0x3a, 0x11);
            this.CheckBox6.Size = size2;
            this.CheckBox6.TabIndex = 5;
            this.CheckBox6.Text = "Russia";
            this.CheckBox6.UseVisualStyleBackColor = true;
            this.CheckBox5.AutoSize = true;
            this.CheckBox5.Enabled = false;
            this.CheckBox5.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x12, 0x5d);
            this.CheckBox5.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.CheckBox5.Margin = padding2;
            this.CheckBox5.Name = "CheckBox5";
            size2 = new Size(0x3b, 0x11);
            this.CheckBox5.Size = size2;
            this.CheckBox5.TabIndex = 4;
            this.CheckBox5.Text = "France";
            this.CheckBox5.UseVisualStyleBackColor = true;
            this.CheckBox4.AutoSize = true;
            this.CheckBox4.Enabled = false;
            this.CheckBox4.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x12, 0x4a);
            this.CheckBox4.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.CheckBox4.Margin = padding2;
            this.CheckBox4.Name = "CheckBox4";
            size2 = new Size(0x29, 0x11);
            this.CheckBox4.Size = size2;
            this.CheckBox4.TabIndex = 3;
            this.CheckBox4.Text = "UK";
            this.CheckBox4.UseVisualStyleBackColor = true;
            this.CheckBox3.AutoSize = true;
            this.CheckBox3.Enabled = false;
            this.CheckBox3.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x12, 0x36);
            this.CheckBox3.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.CheckBox3.Margin = padding2;
            this.CheckBox3.Name = "CheckBox3";
            size2 = new Size(0x30, 0x11);
            this.CheckBox3.Size = size2;
            this.CheckBox3.TabIndex = 2;
            this.CheckBox3.Text = "USA";
            this.CheckBox3.UseVisualStyleBackColor = true;
            this.CheckBox2.AutoSize = true;
            this.CheckBox2.Enabled = false;
            this.CheckBox2.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x12, 0x23);
            this.CheckBox2.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.CheckBox2.Margin = padding2;
            this.CheckBox2.Name = "CheckBox2";
            size2 = new Size(0x35, 0x11);
            this.CheckBox2.Size = size2;
            this.CheckBox2.TabIndex = 1;
            this.CheckBox2.Text = "China";
            this.CheckBox2.UseVisualStyleBackColor = true;
            this.chk_vote_foujue.AutoSize = true;
            this.chk_vote_foujue.ImeMode = ImeMode.NoControl;
            point2 = new Point(11, 11);
            this.chk_vote_foujue.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.chk_vote_foujue.Margin = padding2;
            this.chk_vote_foujue.Name = "chk_vote_foujue";
            size2 = new Size(0x95, 0x11);
            this.chk_vote_foujue.Size = size2;
            this.chk_vote_foujue.TabIndex = 0;
            this.chk_vote_foujue.Text = "启用否决权    通过条件:";
            this.chk_vote_foujue.UseVisualStyleBackColor = true;
            this.panel_vote_ctrl.Controls.Add(this.Label108);
            this.panel_vote_ctrl.Controls.Add(this.btnpass);
            this.panel_vote_ctrl.Controls.Add(this.btnabst);
            this.panel_vote_ctrl.Controls.Add(this.btnno);
            this.panel_vote_ctrl.Controls.Add(this.btnyes);
            this.panel_vote_ctrl.Controls.Add(this.lbl_vote_nation);
            this.panel_vote_ctrl.Dock = DockStyle.Top;
            point2 = new Point(0, 0x133);
            this.panel_vote_ctrl.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_vote_ctrl.Margin = padding2;
            this.panel_vote_ctrl.Name = "panel_vote_ctrl";
            size2 = new Size(0xd8, 100);
            this.panel_vote_ctrl.Size = size2;
            this.panel_vote_ctrl.TabIndex = 15;
            this.panel_vote_ctrl.Visible = false;
            this.Label108.AutoSize = true;
            this.Label108.ImeMode = ImeMode.NoControl;
            point2 = new Point(12, 8);
            this.Label108.Location = point2;
            this.Label108.Name = "Label108";
            size2 = new Size(0x3a, 13);
            this.Label108.Size = size2;
            this.Label108.TabIndex = 5;
            this.Label108.Text = "下一国家:";
            this.btnpass.FlatAppearance.BorderSize = 0;
            this.btnpass.FlatStyle = FlatStyle.Flat;
            this.btnpass.ImeMode = ImeMode.NoControl;
            point2 = new Point(0xa3, 0x42);
            this.btnpass.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btnpass.Margin = padding2;
            this.btnpass.Name = "btnpass";
            size2 = new Size(0x2e, 0x19);
            this.btnpass.Size = size2;
            this.btnpass.TabIndex = 4;
            this.btnpass.Text = "Pass";
            this.btnpass.UseVisualStyleBackColor = false;
            this.btnabst.FlatAppearance.BorderSize = 0;
            this.btnabst.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            this.btnabst.FlatStyle = FlatStyle.Flat;
            this.btnabst.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x70, 0x42);
            this.btnabst.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btnabst.Margin = padding2;
            this.btnabst.Name = "btnabst";
            size2 = new Size(0x2e, 0x19);
            this.btnabst.Size = size2;
            this.btnabst.TabIndex = 3;
            this.btnabst.Text = "弃权";
            this.btnabst.UseVisualStyleBackColor = false;
            this.btnno.FlatAppearance.BorderSize = 0;
            this.btnno.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            this.btnno.FlatStyle = FlatStyle.Flat;
            this.btnno.ImeMode = ImeMode.NoControl;
            point2 = new Point(60, 0x42);
            this.btnno.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btnno.Margin = padding2;
            this.btnno.Name = "btnno";
            size2 = new Size(0x2e, 0x19);
            this.btnno.Size = size2;
            this.btnno.TabIndex = 2;
            this.btnno.Text = "反对";
            this.btnno.UseVisualStyleBackColor = false;
            this.btnyes.FlatAppearance.BorderSize = 0;
            this.btnyes.FlatAppearance.MouseOverBackColor = Color.Firebrick;
            this.btnyes.FlatStyle = FlatStyle.Flat;
            this.btnyes.ImeMode = ImeMode.NoControl;
            point2 = new Point(9, 0x42);
            this.btnyes.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btnyes.Margin = padding2;
            this.btnyes.Name = "btnyes";
            size2 = new Size(0x2e, 0x19);
            this.btnyes.Size = size2;
            this.btnyes.TabIndex = 1;
            this.btnyes.Text = "赞成";
            this.btnyes.UseVisualStyleBackColor = false;
            this.lbl_vote_nation.Font = new Font("Segoe UI", 12f);
            this.lbl_vote_nation.ImeMode = ImeMode.NoControl;
            point2 = new Point(10, 0x1c);
            this.lbl_vote_nation.Location = point2;
            this.lbl_vote_nation.Name = "lbl_vote_nation";
            size2 = new Size(0xc1, 30);
            this.lbl_vote_nation.Size = size2;
            this.lbl_vote_nation.TabIndex = 0;
            this.lbl_vote_nation.Text = "Label108";
            this.lbl_vote_nation.TextAlign = ContentAlignment.MiddleCenter;
            this.panel_vote_roll.Controls.Add(this.chk_vote_saveplist);
            this.panel_vote_roll.Controls.Add(this.clb_nation_vote);
            this.panel_vote_roll.Dock = DockStyle.Top;
            point2 = new Point(0, 0x38);
            this.panel_vote_roll.Location = point2;
            this.panel_vote_roll.Name = "panel_vote_roll";
            size2 = new Size(0xd8, 0xfb);
            this.panel_vote_roll.Size = size2;
            this.panel_vote_roll.TabIndex = 0x10;
            this.chk_vote_saveplist.AutoSize = true;
            point2 = new Point(0x11, 8);
            this.chk_vote_saveplist.Location = point2;
            this.chk_vote_saveplist.Name = "chk_vote_saveplist";
            size2 = new Size(0x62, 0x11);
            this.chk_vote_saveplist.Size = size2;
            this.chk_vote_saveplist.TabIndex = 13;
            this.chk_vote_saveplist.Text = "保存点名状态";
            this.chk_vote_saveplist.UseVisualStyleBackColor = true;
            this.clb_nation_vote.Anchor = AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.clb_nation_vote.CheckOnClick = true;
            this.clb_nation_vote.FormattingEnabled = true;
            point2 = new Point(14, 0x1c);
            this.clb_nation_vote.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.clb_nation_vote.Margin = padding2;
            this.clb_nation_vote.Name = "clb_nation_vote";
            this.clb_nation_vote.ScrollAlwaysVisible = true;
            size2 = new Size(0xbf, 0xc7);
            this.clb_nation_vote.Size = size2;
            this.clb_nation_vote.TabIndex = 12;
            this.panel_vote_top.Controls.Add(this.Label111);
            this.panel_vote_top.Controls.Add(this.lbl_vote_step);
            this.panel_vote_top.Dock = DockStyle.Top;
            point2 = new Point(0, 0);
            this.panel_vote_top.Location = point2;
            this.panel_vote_top.Name = "panel_vote_top";
            size2 = new Size(0xd8, 0x38);
            this.panel_vote_top.Size = size2;
            this.panel_vote_top.TabIndex = 10;
            this.Label111.AutoSize = true;
            this.Label111.Font = new Font("Segoe UI", 12f);
            this.Label111.ImeMode = ImeMode.NoControl;
            point2 = new Point(7, 11);
            this.Label111.Location = point2;
            this.Label111.Name = "Label111";
            size2 = new Size(0x2c, 0x15);
            this.Label111.Size = size2;
            this.Label111.TabIndex = 10;
            this.Label111.Text = "投票";
            this.lbl_vote_step.AutoSize = true;
            this.lbl_vote_step.ImeMode = ImeMode.NoControl;
            point2 = new Point(12, 40);
            this.lbl_vote_step.Location = point2;
            this.lbl_vote_step.Name = "lbl_vote_step";
            size2 = new Size(0x5b, 13);
            this.lbl_vote_step.Size = size2;
            this.lbl_vote_step.TabIndex = 11;
            this.lbl_vote_step.Text = "第1步: 投票点名";
            this.panel_vote_bottom.Controls.Add(this.lblabst1);
            this.panel_vote_bottom.Controls.Add(this.lblno1);
            this.panel_vote_bottom.Controls.Add(this.btn_vote_next);
            this.panel_vote_bottom.Controls.Add(this.btn_vote_cancel);
            this.panel_vote_bottom.Controls.Add(this.lblno);
            this.panel_vote_bottom.Controls.Add(this.lblyes1);
            this.panel_vote_bottom.Controls.Add(this.lblyes);
            this.panel_vote_bottom.Controls.Add(this.lblabst);
            this.panel_vote_bottom.Dock = DockStyle.Bottom;
            point2 = new Point(0, 0xcb);
            this.panel_vote_bottom.Location = point2;
            this.panel_vote_bottom.Name = "panel_vote_bottom";
            size2 = new Size(0xd8, 0xb3);
            this.panel_vote_bottom.Size = size2;
            this.panel_vote_bottom.TabIndex = 15;
            this.lblabst1.AutoSize = true;
            this.lblabst1.Font = new Font("Segoe UI", 12f);
            point2 = new Point(7, 0x91);
            this.lblabst1.Location = point2;
            this.lblabst1.Name = "lblabst1";
            size2 = new Size(0x41, 0x15);
            this.lblabst1.Size = size2;
            this.lblabst1.TabIndex = 0x10;
            this.lblabst1.Text = "Abstain:";
            this.lblno1.AutoSize = true;
            this.lblno1.Font = new Font("Segoe UI", 12f);
            point2 = new Point(7, 0x65);
            this.lblno1.Location = point2;
            this.lblno1.Name = "lblno1";
            size2 = new Size(0x22, 0x15);
            this.lblno1.Size = size2;
            this.lblno1.TabIndex = 15;
            this.lblno1.Text = "No:";
            this.btn_vote_next.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.btn_vote_next.BackColor = Color.LightSeaGreen;
            this.btn_vote_next.FlatAppearance.BorderSize = 0;
            this.btn_vote_next.FlatStyle = FlatStyle.Flat;
            this.btn_vote_next.Font = new Font("Segoe UI", 12f);
            this.btn_vote_next.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x6b, 7);
            this.btn_vote_next.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_vote_next.Margin = padding2;
            this.btn_vote_next.Name = "btn_vote_next";
            size2 = new Size(0x6d, 0x23);
            this.btn_vote_next.Size = size2;
            this.btn_vote_next.TabIndex = 14;
            this.btn_vote_next.Text = "下一步";
            this.btn_vote_next.UseVisualStyleBackColor = false;
            this.btn_vote_cancel.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.btn_vote_cancel.FlatAppearance.BorderSize = 0;
            this.btn_vote_cancel.FlatStyle = FlatStyle.Flat;
            this.btn_vote_cancel.Font = new Font("Segoe UI", 12f);
            this.btn_vote_cancel.ImeMode = ImeMode.NoControl;
            point2 = new Point(0, 7);
            this.btn_vote_cancel.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_vote_cancel.Margin = padding2;
            this.btn_vote_cancel.Name = "btn_vote_cancel";
            size2 = new Size(0x6d, 0x23);
            this.btn_vote_cancel.Size = size2;
            this.btn_vote_cancel.TabIndex = 13;
            this.btn_vote_cancel.Text = "取消";
            this.btn_vote_cancel.UseVisualStyleBackColor = true;
            this.lblno.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.lblno.Font = new Font("Segoe UI", 20f);
            this.lblno.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x7f, 0x5c);
            this.lblno.Location = point2;
            this.lblno.Name = "lblno";
            size2 = new Size(0x52, 0x21);
            this.lblno.Size = size2;
            this.lblno.TabIndex = 8;
            this.lblno.Text = "0";
            this.lblno.TextAlign = ContentAlignment.TopRight;
            this.lblyes1.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.lblyes1.AutoSize = true;
            this.lblyes1.Font = new Font("Segoe UI", 12f);
            this.lblyes1.ImeMode = ImeMode.NoControl;
            point2 = new Point(7, 0x37);
            this.lblyes1.Location = point2;
            this.lblyes1.Name = "lblyes1";
            size2 = new Size(0x25, 0x15);
            this.lblyes1.Size = size2;
            this.lblyes1.TabIndex = 6;
            this.lblyes1.Text = "Yes:";
            this.lblyes.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.lblyes.Font = new Font("Segoe UI", 20f);
            this.lblyes.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x62, 0x2e);
            this.lblyes.Location = point2;
            this.lblyes.Name = "lblyes";
            size2 = new Size(0x6f, 0x21);
            this.lblyes.Size = size2;
            this.lblyes.TabIndex = 7;
            this.lblyes.Text = "0/0";
            this.lblyes.TextAlign = ContentAlignment.TopRight;
            this.lblabst.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.lblabst.Font = new Font("Segoe UI", 20f);
            this.lblabst.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x7f, 0x89);
            this.lblabst.Location = point2;
            this.lblabst.Name = "lblabst";
            size2 = new Size(0x52, 0x21);
            this.lblabst.Size = size2;
            this.lblabst.TabIndex = 9;
            this.lblabst.Text = "0";
            this.lblabst.TextAlign = ContentAlignment.TopRight;
            this.panel_motion.Controls.Add(this.Panel5);
            this.panel_motion.Controls.Add(this.panel_motion_6);
            this.panel_motion.Controls.Add(this.btn_motion_8);
            this.panel_motion.Controls.Add(this.panel_motion_5);
            this.panel_motion.Controls.Add(this.btn_motion_6);
            this.panel_motion.Controls.Add(this.btn_motion_5);
            this.panel_motion.Controls.Add(this.panel_motion_4);
            this.panel_motion.Controls.Add(this.panel_motions_3);
            this.panel_motion.Controls.Add(this.panel_motions_2);
            this.panel_motion.Controls.Add(this.panel_singledel);
            this.panel_motion.Controls.Add(this.panel_motions_1);
            this.panel_motion.Controls.Add(this.panel_motions_top);
            point2 = new Point(0x81, 0x106);
            this.panel_motion.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_motion.Margin = padding2;
            this.panel_motion.Name = "panel_motion";
            size2 = new Size(0xd8, 0x1e5);
            this.panel_motion.Size = size2;
            this.panel_motion.TabIndex = 5;
            this.panel_motion.Visible = false;
            this.Panel5.Controls.Add(this.btn_motionstop);
            this.Panel5.Controls.Add(this.btn_motion_finish);
            this.Panel5.Controls.Add(this.btn_motion_cancel);
            this.Panel5.Dock = DockStyle.Top;
            point2 = new Point(0, 0x106);
            this.Panel5.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.Panel5.Margin = padding2;
            this.Panel5.Name = "Panel5";
            size2 = new Size(0xd8, 0x2b);
            this.Panel5.Size = size2;
            this.Panel5.TabIndex = 0x12;
            this.btn_motionstop.BackColor = Color.LightSeaGreen;
            this.btn_motionstop.Cursor = Cursors.Default;
            this.btn_motionstop.FlatAppearance.BorderSize = 0;
            this.btn_motionstop.FlatStyle = FlatStyle.Flat;
            this.btn_motionstop.Font = new Font("Segoe UI", 12f);
            this.btn_motionstop.ImeMode = ImeMode.NoControl;
            point2 = new Point(0, 4);
            this.btn_motionstop.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_motionstop.Margin = padding2;
            this.btn_motionstop.Name = "btn_motionstop";
            size2 = new Size(0xd8, 0x23);
            this.btn_motionstop.Size = size2;
            this.btn_motionstop.TabIndex = 2;
            this.btn_motionstop.Text = "停止计时";
            this.btn_motionstop.UseVisualStyleBackColor = false;
            this.btn_motionstop.Visible = false;
            this.btn_motion_finish.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.btn_motion_finish.BackColor = Color.LightSeaGreen;
            this.btn_motion_finish.FlatAppearance.BorderSize = 0;
            this.btn_motion_finish.FlatStyle = FlatStyle.Flat;
            this.btn_motion_finish.Font = new Font("Segoe UI", 12f);
            this.btn_motion_finish.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x6c, 4);
            this.btn_motion_finish.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_motion_finish.Margin = padding2;
            this.btn_motion_finish.Name = "btn_motion_finish";
            size2 = new Size(0x6c, 0x23);
            this.btn_motion_finish.Size = size2;
            this.btn_motion_finish.TabIndex = 5;
            this.btn_motion_finish.Text = "完成";
            this.btn_motion_finish.UseVisualStyleBackColor = false;
            this.btn_motion_finish.Visible = false;
            this.btn_motion_cancel.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.btn_motion_cancel.FlatAppearance.BorderSize = 0;
            this.btn_motion_cancel.FlatStyle = FlatStyle.Flat;
            this.btn_motion_cancel.Font = new Font("Segoe UI", 12f);
            this.btn_motion_cancel.ImeMode = ImeMode.NoControl;
            point2 = new Point(0, 4);
            this.btn_motion_cancel.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_motion_cancel.Margin = padding2;
            this.btn_motion_cancel.Name = "btn_motion_cancel";
            size2 = new Size(0x6c, 0x23);
            this.btn_motion_cancel.Size = size2;
            this.btn_motion_cancel.TabIndex = 4;
            this.btn_motion_cancel.Text = "取消";
            this.btn_motion_cancel.UseVisualStyleBackColor = true;
            this.panel_motion_6.Controls.Add(this.panel_m_6);
            this.panel_motion_6.Controls.Add(this.btn_motion_9);
            this.panel_motion_6.Dock = DockStyle.Top;
            point2 = new Point(0, 240);
            this.panel_motion_6.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_motion_6.Margin = padding2;
            this.panel_motion_6.Name = "panel_motion_6";
            size2 = new Size(0xd8, 0x16);
            this.panel_motion_6.Size = size2;
            this.panel_motion_6.TabIndex = 6;
            this.panel_m_6.Controls.Add(this.Label187);
            this.panel_m_6.Controls.Add(this.txt_mneirong);
            this.panel_m_6.Controls.Add(this.chk_istimeruse);
            this.panel_m_6.Controls.Add(this.num_m_custom);
            this.panel_m_6.Controls.Add(this.Label189);
            this.panel_m_6.Dock = DockStyle.Top;
            point2 = new Point(0, 0x16);
            this.panel_m_6.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_m_6.Margin = padding2;
            this.panel_m_6.Name = "panel_m_6";
            size2 = new Size(0xd8, 0x53);
            this.panel_m_6.Size = size2;
            this.panel_m_6.TabIndex = 13;
            this.Label187.AutoSize = true;
            this.Label187.ImeMode = ImeMode.NoControl;
            point2 = new Point(13, 9);
            this.Label187.Location = point2;
            this.Label187.Name = "Label187";
            size2 = new Size(0x2b, 13);
            this.Label187.Size = size2;
            this.Label187.TabIndex = 6;
            this.Label187.Text = "内容为";
            this.txt_mneirong.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(60, 7);
            this.txt_mneirong.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.txt_mneirong.Margin = padding2;
            this.txt_mneirong.Name = "txt_mneirong";
            size2 = new Size(0x92, 20);
            this.txt_mneirong.Size = size2;
            this.txt_mneirong.TabIndex = 9;
            this.chk_istimeruse.AutoSize = true;
            this.chk_istimeruse.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x10, 0x22);
            this.chk_istimeruse.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.chk_istimeruse.Margin = padding2;
            this.chk_istimeruse.Name = "chk_istimeruse";
            size2 = new Size(0x56, 0x11);
            this.chk_istimeruse.Size = size2;
            this.chk_istimeruse.TabIndex = 8;
            this.chk_istimeruse.Text = "使用计时器";
            this.chk_istimeruse.UseVisualStyleBackColor = true;
            this.num_m_custom.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.num_m_custom.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(0x4c, 0x38);
            this.num_m_custom.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.num_m_custom.Margin = padding2;
            this.num_m_custom.Name = "num_m_custom";
            size2 = new Size(0x24, 20);
            this.num_m_custom.Size = size2;
            this.num_m_custom.TabIndex = 11;
            num = new decimal(new int[] { 5, 0, 0, 0 });
            this.num_m_custom.Value = num;
            this.Label189.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.Label189.AutoSize = true;
            this.Label189.ImeMode = ImeMode.NoControl;
            point2 = new Point(13, 0x3b);
            this.Label189.Location = point2;
            this.Label189.Name = "Label189";
            size2 = new Size(130, 13);
            this.Label189.Size = size2;
            this.Label189.TabIndex = 12;
            this.Label189.Text = "总时长 　　　　　分钟";
            this.btn_motion_9.Dock = DockStyle.Top;
            this.btn_motion_9.FlatAppearance.BorderSize = 0;
            this.btn_motion_9.FlatStyle = FlatStyle.Flat;
            this.btn_motion_9.ImeMode = ImeMode.NoControl;
            point2 = new Point(0, 0);
            this.btn_motion_9.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_motion_9.Margin = padding2;
            this.btn_motion_9.Name = "btn_motion_9";
            size2 = new Size(0xd8, 0x16);
            this.btn_motion_9.Size = size2;
            this.btn_motion_9.TabIndex = 0;
            this.btn_motion_9.Text = "自定义";
            this.btn_motion_9.UseVisualStyleBackColor = true;
            this.btn_motion_8.Dock = DockStyle.Top;
            this.btn_motion_8.FlatAppearance.BorderSize = 0;
            this.btn_motion_8.FlatStyle = FlatStyle.Flat;
            this.btn_motion_8.ImeMode = ImeMode.NoControl;
            point2 = new Point(0, 0xda);
            this.btn_motion_8.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_motion_8.Margin = padding2;
            this.btn_motion_8.Name = "btn_motion_8";
            size2 = new Size(0xd8, 0x16);
            this.btn_motion_8.Size = size2;
            this.btn_motion_8.TabIndex = 0;
            this.btn_motion_8.Text = "休会";
            this.btn_motion_8.UseVisualStyleBackColor = true;
            this.panel_motion_5.Controls.Add(this.btn_motion_7);
            this.panel_motion_5.Dock = DockStyle.Top;
            point2 = new Point(0, 0xc4);
            this.panel_motion_5.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_motion_5.Margin = padding2;
            this.panel_motion_5.Name = "panel_motion_5";
            size2 = new Size(0xd8, 0x16);
            this.panel_motion_5.Size = size2;
            this.panel_motion_5.TabIndex = 7;
            this.btn_motion_7.Dock = DockStyle.Fill;
            this.btn_motion_7.FlatAppearance.BorderSize = 0;
            this.btn_motion_7.FlatStyle = FlatStyle.Flat;
            this.btn_motion_7.ImeMode = ImeMode.NoControl;
            point2 = new Point(0, 0);
            this.btn_motion_7.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_motion_7.Margin = padding2;
            this.btn_motion_7.Name = "btn_motion_7";
            size2 = new Size(0xd8, 0x16);
            this.btn_motion_7.Size = size2;
            this.btn_motion_7.TabIndex = 0;
            this.btn_motion_7.Text = "结束辩论";
            this.btn_motion_7.UseVisualStyleBackColor = true;
            this.btn_motion_6.Dock = DockStyle.Top;
            this.btn_motion_6.FlatAppearance.BorderSize = 0;
            this.btn_motion_6.FlatStyle = FlatStyle.Flat;
            this.btn_motion_6.ImeMode = ImeMode.NoControl;
            point2 = new Point(0, 0xae);
            this.btn_motion_6.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_motion_6.Margin = padding2;
            this.btn_motion_6.Name = "btn_motion_6";
            size2 = new Size(0xd8, 0x16);
            this.btn_motion_6.Size = size2;
            this.btn_motion_6.TabIndex = 0;
            this.btn_motion_6.Text = "开始茶歇";
            this.btn_motion_6.UseVisualStyleBackColor = true;
            this.btn_motion_5.Dock = DockStyle.Top;
            this.btn_motion_5.FlatAppearance.BorderSize = 0;
            this.btn_motion_5.FlatStyle = FlatStyle.Flat;
            this.btn_motion_5.ImeMode = ImeMode.NoControl;
            point2 = new Point(0, 0x98);
            this.btn_motion_5.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_motion_5.Margin = padding2;
            this.btn_motion_5.Name = "btn_motion_5";
            size2 = new Size(0xd8, 0x16);
            this.btn_motion_5.Size = size2;
            this.btn_motion_5.TabIndex = 0;
            this.btn_motion_5.Text = "对文件投票";
            this.btn_motion_5.UseVisualStyleBackColor = true;
            this.panel_motion_4.Controls.Add(this.panel_m_4);
            this.panel_motion_4.Controls.Add(this.btn_motion_4);
            this.panel_motion_4.Dock = DockStyle.Top;
            point2 = new Point(0, 130);
            this.panel_motion_4.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_motion_4.Margin = padding2;
            this.panel_motion_4.Name = "panel_motion_4";
            size2 = new Size(0xd8, 0x16);
            this.panel_motion_4.Size = size2;
            this.panel_motion_4.TabIndex = 6;
            this.panel_m_4.Controls.Add(this.cbx_mfileselect);
            this.panel_m_4.Controls.Add(this.Label99);
            this.panel_m_4.Dock = DockStyle.Top;
            point2 = new Point(0, 0x16);
            this.panel_m_4.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_m_4.Margin = padding2;
            this.panel_m_4.Name = "panel_m_4";
            size2 = new Size(0xd8, 0x26);
            this.panel_m_4.Size = size2;
            this.panel_m_4.TabIndex = 13;
            this.cbx_mfileselect.BackColor = Color.PaleTurquoise;
            this.cbx_mfileselect.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbx_mfileselect.FlatStyle = FlatStyle.Flat;
            this.cbx_mfileselect.FormattingEnabled = true;
            point2 = new Point(0x38, 9);
            this.cbx_mfileselect.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.cbx_mfileselect.Margin = padding2;
            this.cbx_mfileselect.Name = "cbx_mfileselect";
            size2 = new Size(0x73, 0x15);
            this.cbx_mfileselect.Size = size2;
            this.cbx_mfileselect.TabIndex = 15;
            this.Label99.AutoSize = true;
            this.Label99.ImeMode = ImeMode.NoControl;
            point2 = new Point(13, 13);
            this.Label99.Location = point2;
            this.Label99.Name = "Label99";
            size2 = new Size(190, 13);
            this.Label99.Size = size2;
            this.Label99.TabIndex = 14;
            this.Label99.Text = "优先对 　　　　　　　　　　投票";
            this.btn_motion_4.Dock = DockStyle.Top;
            this.btn_motion_4.FlatAppearance.BorderSize = 0;
            this.btn_motion_4.FlatStyle = FlatStyle.Flat;
            this.btn_motion_4.ImeMode = ImeMode.NoControl;
            point2 = new Point(0, 0);
            this.btn_motion_4.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_motion_4.Margin = padding2;
            this.btn_motion_4.Name = "btn_motion_4";
            size2 = new Size(0xd8, 0x16);
            this.btn_motion_4.Size = size2;
            this.btn_motion_4.TabIndex = 0;
            this.btn_motion_4.Text = "调整投票顺序";
            this.btn_motion_4.UseVisualStyleBackColor = true;
            this.panel_motions_3.Controls.Add(this.panel_m_3);
            this.panel_motions_3.Controls.Add(this.btn_motion_3);
            this.panel_motions_3.Dock = DockStyle.Top;
            point2 = new Point(0, 0x6c);
            this.panel_motions_3.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_motions_3.Margin = padding2;
            this.panel_motions_3.Name = "panel_motions_3";
            size2 = new Size(0xd8, 0x16);
            this.panel_motions_3.Size = size2;
            this.panel_motions_3.TabIndex = 6;
            this.panel_m_3.Controls.Add(this.num_m_spl_1);
            this.panel_m_3.Controls.Add(this.num_m_spl_2);
            this.panel_m_3.Controls.Add(this.Label185);
            this.panel_m_3.Dock = DockStyle.Top;
            point2 = new Point(0, 0x16);
            this.panel_m_3.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_m_3.Margin = padding2;
            this.panel_m_3.Name = "panel_m_3";
            size2 = new Size(0xd8, 0x26);
            this.panel_m_3.Size = size2;
            this.panel_m_3.TabIndex = 13;
            this.num_m_spl_1.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(0x4a, 9);
            this.num_m_spl_1.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.num_m_spl_1.Margin = padding2;
            this.num_m_spl_1.Name = "num_m_spl_1";
            size2 = new Size(0x24, 20);
            this.num_m_spl_1.Size = size2;
            this.num_m_spl_1.TabIndex = 10;
            num = new decimal(new int[] { 2, 0, 0, 0 });
            this.num_m_spl_1.Value = num;
            this.num_m_spl_2.BorderStyle = BorderStyle.FixedSingle;
            num = new decimal(new int[] { 5, 0, 0, 0 });
            this.num_m_spl_2.Increment = num;
            point2 = new Point(0x86, 9);
            this.num_m_spl_2.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.num_m_spl_2.Margin = padding2;
            num = new decimal(new int[] { 0x37, 0, 0, 0 });
            this.num_m_spl_2.Maximum = num;
            this.num_m_spl_2.Name = "num_m_spl_2";
            size2 = new Size(0x24, 20);
            this.num_m_spl_2.Size = size2;
            this.num_m_spl_2.TabIndex = 11;
            this.Label185.AutoSize = true;
            this.Label185.ImeMode = ImeMode.NoControl;
            point2 = new Point(13, 12);
            this.Label185.Location = point2;
            this.Label185.Name = "Label185";
            size2 = new Size(0xb2, 13);
            this.Label185.Size = size2;
            this.Label185.TabIndex = 7;
            this.Label185.Text = "调整为 　　　　　分　　　　秒";
            this.btn_motion_3.Dock = DockStyle.Top;
            this.btn_motion_3.FlatAppearance.BorderSize = 0;
            this.btn_motion_3.FlatStyle = FlatStyle.Flat;
            this.btn_motion_3.ImeMode = ImeMode.NoControl;
            point2 = new Point(0, 0);
            this.btn_motion_3.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_motion_3.Margin = padding2;
            this.btn_motion_3.Name = "btn_motion_3";
            size2 = new Size(0xd8, 0x16);
            this.btn_motion_3.Size = size2;
            this.btn_motion_3.TabIndex = 0;
            this.btn_motion_3.Text = "调整发言时间";
            this.btn_motion_3.UseVisualStyleBackColor = true;
            this.panel_motions_2.Controls.Add(this.panel_m_2);
            this.panel_motions_2.Controls.Add(this.btn_motion_2);
            this.panel_motions_2.Dock = DockStyle.Top;
            point2 = new Point(0, 0x56);
            this.panel_motions_2.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_motions_2.Margin = padding2;
            this.panel_motions_2.Name = "panel_motions_2";
            size2 = new Size(0xd8, 0x16);
            this.panel_motions_2.Size = size2;
            this.panel_motions_2.TabIndex = 6;
            this.panel_m_2.Controls.Add(this.num_m_umc);
            this.panel_m_2.Controls.Add(this.Label186);
            this.panel_m_2.Dock = DockStyle.Top;
            point2 = new Point(0, 0x16);
            this.panel_m_2.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_m_2.Margin = padding2;
            this.panel_m_2.Name = "panel_m_2";
            size2 = new Size(0xd8, 0x26);
            this.panel_m_2.Size = size2;
            this.panel_m_2.TabIndex = 13;
            this.num_m_umc.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(0x4a, 9);
            this.num_m_umc.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.num_m_umc.Margin = padding2;
            this.num_m_umc.Name = "num_m_umc";
            size2 = new Size(0x24, 20);
            this.num_m_umc.Size = size2;
            this.num_m_umc.TabIndex = 10;
            num = new decimal(new int[] { 5, 0, 0, 0 });
            this.num_m_umc.Value = num;
            this.Label186.AutoSize = true;
            this.Label186.ImeMode = ImeMode.NoControl;
            point2 = new Point(13, 12);
            this.Label186.Location = point2;
            this.Label186.Name = "Label186";
            size2 = new Size(130, 13);
            this.Label186.Size = size2;
            this.Label186.TabIndex = 7;
            this.Label186.Text = "总时长 　　　　　分钟";
            this.btn_motion_2.Dock = DockStyle.Top;
            this.btn_motion_2.FlatAppearance.BorderSize = 0;
            this.btn_motion_2.FlatStyle = FlatStyle.Flat;
            this.btn_motion_2.ImeMode = ImeMode.NoControl;
            point2 = new Point(0, 0);
            this.btn_motion_2.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_motion_2.Margin = padding2;
            this.btn_motion_2.Name = "btn_motion_2";
            size2 = new Size(0xd8, 0x16);
            this.btn_motion_2.Size = size2;
            this.btn_motion_2.TabIndex = 0;
            this.btn_motion_2.Text = "自由磋商";
            this.btn_motion_2.UseVisualStyleBackColor = true;
            this.panel_singledel.Controls.Add(this.btn_ispresent);
            this.panel_singledel.Controls.Add(this.Label175);
            this.panel_singledel.Controls.Add(this.Label174);
            this.panel_singledel.Controls.Add(this.cbx_singledel);
            this.panel_singledel.Controls.Add(this.Label173);
            this.panel_singledel.Dock = DockStyle.Bottom;
            point2 = new Point(0, 0x181);
            this.panel_singledel.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_singledel.Margin = padding2;
            this.panel_singledel.Name = "panel_singledel";
            size2 = new Size(0xd8, 100);
            this.panel_singledel.Size = size2;
            this.panel_singledel.TabIndex = 0x10;
            this.btn_ispresent.BackColor = Color.LightSeaGreen;
            this.btn_ispresent.FlatAppearance.BorderSize = 0;
            this.btn_ispresent.FlatStyle = FlatStyle.Flat;
            this.btn_ispresent.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x63, 0x43);
            this.btn_ispresent.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_ispresent.Margin = padding2;
            this.btn_ispresent.Name = "btn_ispresent";
            size2 = new Size(0x38, 20);
            this.btn_ispresent.Size = size2;
            this.btn_ispresent.TabIndex = 4;
            this.btn_ispresent.Text = "Yes";
            this.btn_ispresent.UseVisualStyleBackColor = false;
            this.Label175.AutoSize = true;
            this.Label175.ImeMode = ImeMode.NoControl;
            point2 = new Point(12, 0x48);
            this.Label175.Location = point2;
            this.Label175.Name = "Label175";
            size2 = new Size(0x52, 13);
            this.Label175.Size = size2;
            this.Label175.TabIndex = 3;
            this.Label175.Text = "当前出席状态:";
            this.Label174.AutoSize = true;
            this.Label174.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x8b, 0x2b);
            this.Label174.Location = point2;
            this.Label174.Name = "Label174";
            size2 = new Size(0x1f, 13);
            this.Label174.Size = size2;
            this.Label174.TabIndex = 2;
            this.Label174.Text = "代表";
            this.cbx_singledel.BackColor = Color.PaleTurquoise;
            this.cbx_singledel.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbx_singledel.FlatStyle = FlatStyle.Flat;
            this.cbx_singledel.FormattingEnabled = true;
            point2 = new Point(14, 0x27);
            this.cbx_singledel.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.cbx_singledel.Margin = padding2;
            this.cbx_singledel.Name = "cbx_singledel";
            size2 = new Size(0x79, 0x15);
            this.cbx_singledel.Size = size2;
            this.cbx_singledel.TabIndex = 1;
            this.Label173.AutoSize = true;
            this.Label173.Font = new Font("Segoe UI", 12f);
            this.Label173.ImeMode = ImeMode.NoControl;
            point2 = new Point(7, 11);
            this.Label173.Location = point2;
            this.Label173.Name = "Label173";
            size2 = new Size(0x81, 0x15);
            this.Label173.Size = size2;
            this.Label173.TabIndex = 0;
            this.Label173.Text = "单代表离席控制";
            this.panel_motions_1.Controls.Add(this.panel_m_1);
            this.panel_motions_1.Controls.Add(this.btn_motion_1);
            this.panel_motions_1.Dock = DockStyle.Top;
            point2 = new Point(0, 0x40);
            this.panel_motions_1.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_motions_1.Margin = padding2;
            this.panel_motions_1.Name = "panel_motions_1";
            size2 = new Size(0xd8, 0x16);
            this.panel_motions_1.Size = size2;
            this.panel_motions_1.TabIndex = 6;
            this.panel_m_1.Controls.Add(this.num_m_mc_1);
            this.panel_m_1.Controls.Add(this.Label97);
            this.panel_m_1.Controls.Add(this.txt_mtopic);
            this.panel_m_1.Controls.Add(this.num_m_mc_2);
            this.panel_m_1.Controls.Add(this.Label183);
            this.panel_m_1.Controls.Add(this.Label184);
            this.panel_m_1.Dock = DockStyle.Top;
            point2 = new Point(0, 0x16);
            this.panel_m_1.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_m_1.Margin = padding2;
            this.panel_m_1.Name = "panel_m_1";
            size2 = new Size(0xd8, 0x68);
            this.panel_m_1.Size = size2;
            this.panel_m_1.TabIndex = 13;
            this.num_m_mc_1.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.num_m_mc_1.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(0x86, 0x2e);
            this.num_m_mc_1.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.num_m_mc_1.Margin = padding2;
            this.num_m_mc_1.Name = "num_m_mc_1";
            size2 = new Size(0x24, 20);
            this.num_m_mc_1.Size = size2;
            this.num_m_mc_1.TabIndex = 10;
            num = new decimal(new int[] { 5, 0, 0, 0 });
            this.num_m_mc_1.Value = num;
            this.Label97.AutoSize = true;
            this.Label97.ImeMode = ImeMode.NoControl;
            point2 = new Point(13, 9);
            this.Label97.Location = point2;
            this.Label97.Name = "Label97";
            size2 = new Size(0x2b, 13);
            this.Label97.Size = size2;
            this.Label97.TabIndex = 6;
            this.Label97.Text = "议题为";
            this.txt_mtopic.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(60, 7);
            this.txt_mtopic.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.txt_mtopic.Margin = padding2;
            this.txt_mtopic.Name = "txt_mtopic";
            size2 = new Size(0x92, 20);
            this.txt_mtopic.Size = size2;
            this.txt_mtopic.TabIndex = 9;
            this.num_m_mc_2.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.num_m_mc_2.BorderStyle = BorderStyle.FixedSingle;
            num = new decimal(new int[] { 5, 0, 0, 0 });
            this.num_m_mc_2.Increment = num;
            point2 = new Point(0x86, 0x49);
            this.num_m_mc_2.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.num_m_mc_2.Margin = padding2;
            this.num_m_mc_2.Name = "num_m_mc_2";
            size2 = new Size(0x24, 20);
            this.num_m_mc_2.Size = size2;
            this.num_m_mc_2.TabIndex = 11;
            num = new decimal(new int[] { 60, 0, 0, 0 });
            this.num_m_mc_2.Value = num;
            this.Label183.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.Label183.AutoSize = true;
            this.Label183.ImeMode = ImeMode.NoControl;
            point2 = new Point(13, 0x30);
            this.Label183.Location = point2;
            this.Label183.Name = "Label183";
            size2 = new Size(190, 13);
            this.Label183.Size = size2;
            this.Label183.TabIndex = 7;
            this.Label183.Text = "总时长 　　　　　　　　　　分钟";
            this.Label184.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.Label184.AutoSize = true;
            this.Label184.ImeMode = ImeMode.NoControl;
            point2 = new Point(13, 0x4c);
            this.Label184.Location = point2;
            this.Label184.Name = "Label184";
            size2 = new Size(0xb2, 13);
            this.Label184.Size = size2;
            this.Label184.TabIndex = 12;
            this.Label184.Text = "每位代表发言时间 　　　　　秒";
            this.btn_motion_1.Dock = DockStyle.Top;
            this.btn_motion_1.FlatAppearance.BorderSize = 0;
            this.btn_motion_1.FlatStyle = FlatStyle.Flat;
            this.btn_motion_1.ImeMode = ImeMode.NoControl;
            point2 = new Point(0, 0);
            this.btn_motion_1.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_motion_1.Margin = padding2;
            this.btn_motion_1.Name = "btn_motion_1";
            size2 = new Size(0xd8, 0x16);
            this.btn_motion_1.Size = size2;
            this.btn_motion_1.TabIndex = 0;
            this.btn_motion_1.Text = "有主持核心磋商";
            this.btn_motion_1.UseVisualStyleBackColor = true;
            this.panel_motions_top.Controls.Add(this.Label95);
            this.panel_motions_top.Controls.Add(this.Label96);
            this.panel_motions_top.Controls.Add(this.txt_mnation);
            this.panel_motions_top.Dock = DockStyle.Top;
            point2 = new Point(0, 0);
            this.panel_motions_top.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_motions_top.Margin = padding2;
            this.panel_motions_top.Name = "panel_motions_top";
            size2 = new Size(0xd8, 0x40);
            this.panel_motions_top.Size = size2;
            this.panel_motions_top.TabIndex = 0x11;
            this.Label95.AutoSize = true;
            this.Label95.Font = new Font("Segoe UI", 12f);
            this.Label95.ImeMode = ImeMode.NoControl;
            point2 = new Point(7, 11);
            this.Label95.Location = point2;
            this.Label95.Name = "Label95";
            size2 = new Size(0x2c, 0x15);
            this.Label95.Size = size2;
            this.Label95.TabIndex = 0;
            this.Label95.Text = "动议";
            this.Label96.AutoSize = true;
            this.Label96.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x90, 0x29);
            this.Label96.Location = point2;
            this.Label96.Name = "Label96";
            size2 = new Size(0x3d, 13);
            this.Label96.Size = size2;
            this.Label96.TabIndex = 1;
            this.Label96.Text = "动议(一个)";
            this.txt_mnation.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.txt_mnation.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.txt_mnation.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(14, 0x25);
            this.txt_mnation.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.txt_mnation.Margin = padding2;
            this.txt_mnation.Name = "txt_mnation";
            size2 = new Size(0x7c, 20);
            this.txt_mnation.Size = size2;
            this.txt_mnation.TabIndex = 2;
            this.panel_sidebar_starting.Controls.Add(this.panel_startmethod);
            this.panel_sidebar_starting.Controls.Add(this.btn_start_cancel);
            this.panel_sidebar_starting.Controls.Add(this.btn_start_ok);
            this.panel_sidebar_starting.Controls.Add(this.btn_roll_finish);
            this.panel_sidebar_starting.Controls.Add(this.btn_roll_cancle);
            this.panel_sidebar_starting.Controls.Add(this.Label17);
            this.panel_sidebar_starting.Controls.Add(this.Label16);
            this.panel_sidebar_starting.Controls.Add(this.txtsession);
            this.panel_sidebar_starting.Controls.Add(this.Label14);
            this.panel_sidebar_starting.Controls.Add(this.Label13);
            this.panel_sidebar_starting.Controls.Add(this.clb_nation_main);
            point2 = new Point(0xba, 0xec);
            this.panel_sidebar_starting.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_sidebar_starting.Margin = padding2;
            this.panel_sidebar_starting.Name = "panel_sidebar_starting";
            size2 = new Size(0xd8, 0x1e5);
            this.panel_sidebar_starting.Size = size2;
            this.panel_sidebar_starting.TabIndex = 1;
            this.panel_sidebar_starting.Visible = false;
            this.panel_startmethod.Controls.Add(this.numstartm);
            this.panel_startmethod.Controls.Add(this.rad_immediatestart);
            this.panel_startmethod.Controls.Add(this.numstarth);
            this.panel_startmethod.Controls.Add(this.rad_timedstart);
            point2 = new Point(0, 0x3f);
            this.panel_startmethod.Location = point2;
            this.panel_startmethod.Name = "panel_startmethod";
            size2 = new Size(0xd8, 0x2f);
            this.panel_startmethod.Size = size2;
            this.panel_startmethod.TabIndex = 15;
            num = new decimal(new int[] { 5, 0, 0, 0 });
            this.numstartm.Increment = num;
            point2 = new Point(0x66, 0x1c);
            this.numstartm.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.numstartm.Margin = padding2;
            num = new decimal(new int[] { 60, 0, 0, 0 });
            this.numstartm.Maximum = num;
            this.numstartm.Name = "numstartm";
            size2 = new Size(0x20, 20);
            this.numstartm.Size = size2;
            this.numstartm.TabIndex = 5;
            this.rad_immediatestart.AutoSize = true;
            this.rad_immediatestart.Checked = true;
            this.rad_immediatestart.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x10, 4);
            this.rad_immediatestart.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.rad_immediatestart.Margin = padding2;
            this.rad_immediatestart.Name = "rad_immediatestart";
            size2 = new Size(0x49, 0x11);
            this.rad_immediatestart.Size = size2;
            this.rad_immediatestart.TabIndex = 10;
            this.rad_immediatestart.TabStop = true;
            this.rad_immediatestart.Text = "立即开始";
            this.rad_immediatestart.UseVisualStyleBackColor = true;
            point2 = new Point(50, 0x1c);
            this.numstarth.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.numstarth.Margin = padding2;
            num = new decimal(new int[] { 0x18, 0, 0, 0 });
            this.numstarth.Maximum = num;
            this.numstarth.Name = "numstarth";
            size2 = new Size(0x20, 20);
            this.numstarth.Size = size2;
            this.numstarth.TabIndex = 4;
            num = new decimal(new int[] { 6, 0, 0, 0 });
            this.numstarth.Value = num;
            this.rad_timedstart.AutoSize = true;
            this.rad_timedstart.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x10, 0x1d);
            this.rad_timedstart.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.rad_timedstart.Margin = padding2;
            this.rad_timedstart.Name = "rad_timedstart";
            size2 = new Size(0xa3, 0x11);
            this.rad_timedstart.Size = size2;
            this.rad_timedstart.TabIndex = 11;
            this.rad_timedstart.Text = "于　　　 时　　　 分开始";
            this.rad_timedstart.UseVisualStyleBackColor = true;
            this.btn_start_cancel.FlatAppearance.BorderSize = 0;
            this.btn_start_cancel.FlatStyle = FlatStyle.Flat;
            this.btn_start_cancel.Font = new Font("Segoe UI", 12f);
            this.btn_start_cancel.ImeMode = ImeMode.NoControl;
            point2 = new Point(0, 0x7a);
            this.btn_start_cancel.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_start_cancel.Margin = padding2;
            this.btn_start_cancel.Name = "btn_start_cancel";
            size2 = new Size(0x6d, 0x23);
            this.btn_start_cancel.Size = size2;
            this.btn_start_cancel.TabIndex = 6;
            this.btn_start_cancel.Text = "取消";
            this.btn_start_cancel.UseVisualStyleBackColor = true;
            this.btn_start_ok.BackColor = Color.LightSeaGreen;
            this.btn_start_ok.FlatAppearance.BorderSize = 0;
            this.btn_start_ok.FlatStyle = FlatStyle.Flat;
            this.btn_start_ok.Font = new Font("Segoe UI", 12f);
            this.btn_start_ok.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x6b, 0x7a);
            this.btn_start_ok.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_start_ok.Margin = padding2;
            this.btn_start_ok.Name = "btn_start_ok";
            size2 = new Size(0x6d, 0x23);
            this.btn_start_ok.Size = size2;
            this.btn_start_ok.TabIndex = 7;
            this.btn_start_ok.Text = "确定";
            this.btn_start_ok.UseVisualStyleBackColor = false;
            this.btn_roll_finish.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.btn_roll_finish.BackColor = Color.LightSeaGreen;
            this.btn_roll_finish.FlatAppearance.BorderSize = 0;
            this.btn_roll_finish.FlatStyle = FlatStyle.Flat;
            this.btn_roll_finish.Font = new Font("Segoe UI", 12f);
            this.btn_roll_finish.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x6a, 0x1b4);
            this.btn_roll_finish.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_roll_finish.Margin = padding2;
            this.btn_roll_finish.Name = "btn_roll_finish";
            size2 = new Size(0x6d, 0x23);
            this.btn_roll_finish.Size = size2;
            this.btn_roll_finish.TabIndex = 14;
            this.btn_roll_finish.Text = "完成";
            this.btn_roll_finish.UseVisualStyleBackColor = false;
            this.btn_roll_finish.Visible = false;
            this.btn_roll_cancle.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.btn_roll_cancle.FlatAppearance.BorderSize = 0;
            this.btn_roll_cancle.FlatStyle = FlatStyle.Flat;
            this.btn_roll_cancle.Font = new Font("Segoe UI", 12f);
            this.btn_roll_cancle.ImeMode = ImeMode.NoControl;
            point2 = new Point(0, 0x1b4);
            this.btn_roll_cancle.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_roll_cancle.Margin = padding2;
            this.btn_roll_cancle.Name = "btn_roll_cancle";
            size2 = new Size(0x6d, 0x23);
            this.btn_roll_cancle.Size = size2;
            this.btn_roll_cancle.TabIndex = 13;
            this.btn_roll_cancle.Text = "取消";
            this.btn_roll_cancle.UseVisualStyleBackColor = true;
            this.btn_roll_cancle.Visible = false;
            this.Label17.AutoSize = true;
            this.Label17.ImeMode = ImeMode.NoControl;
            point2 = new Point(13, 0x9c);
            this.Label17.Location = point2;
            this.Label17.Name = "Label17";
            size2 = new Size(0xbb, 13);
            this.Label17.Size = size2;
            this.Label17.TabIndex = 9;
            this.Label17.Text = "会议开始后在这里显示国家列表。";
            this.Label17.Visible = false;
            this.Label16.AutoSize = true;
            this.Label16.Font = new Font("Segoe UI", 12f);
            this.Label16.ImeMode = ImeMode.NoControl;
            point2 = new Point(7, 0x7a);
            this.Label16.Location = point2;
            this.Label16.Name = "Label16";
            size2 = new Size(0x2c, 0x15);
            this.Label16.Size = size2;
            this.Label16.TabIndex = 8;
            this.Label16.Text = "点名";
            this.txtsession.BackColor = SystemColors.ControlLightLight;
            this.txtsession.BorderStyle = BorderStyle.FixedSingle;
            this.txtsession.ForeColor = SystemColors.WindowText;
            point2 = new Point(0x5c, 0x27);
            this.txtsession.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.txtsession.Margin = padding2;
            this.txtsession.Name = "txtsession";
            size2 = new Size(40, 20);
            this.txtsession.Size = size2;
            this.txtsession.TabIndex = 2;
            this.Label14.AutoSize = true;
            this.Label14.ImeMode = ImeMode.NoControl;
            point2 = new Point(13, 0x2b);
            this.Label14.Location = point2;
            this.Label14.Name = "Label14";
            size2 = new Size(0x97, 13);
            this.Label14.Size = size2;
            this.Label14.TabIndex = 1;
            this.Label14.Text = "本次会议的第　　　　会期";
            this.Label13.AutoSize = true;
            this.Label13.Font = new Font("Segoe UI", 12f);
            this.Label13.ImeMode = ImeMode.NoControl;
            point2 = new Point(7, 11);
            this.Label13.Location = point2;
            this.Label13.Name = "Label13";
            size2 = new Size(0x4e, 0x15);
            this.Label13.Size = size2;
            this.Label13.TabIndex = 0;
            this.Label13.Text = "会议开始";
            this.clb_nation_main.Anchor = AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.clb_nation_main.CheckOnClick = true;
            this.clb_nation_main.FormattingEnabled = true;
            point2 = new Point(15, 0x9c);
            this.clb_nation_main.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.clb_nation_main.Margin = padding2;
            this.clb_nation_main.Name = "clb_nation_main";
            size2 = new Size(0xb9, 0xe5);
            this.clb_nation_main.Size = size2;
            this.clb_nation_main.TabIndex = 12;
            this.clb_nation_main.Visible = false;
            this.panel_spakers_list.Controls.Add(this.panel_csl);
            this.panel_spakers_list.Controls.Add(this.txt_spl_yieldto);
            this.panel_spakers_list.Controls.Add(this.btn_spl_exit);
            this.panel_spakers_list.Controls.Add(this.btn_spl_yieldend);
            this.panel_spakers_list.Controls.Add(this.btn_spl_yieldgo);
            this.panel_spakers_list.Controls.Add(this.Label28);
            this.panel_spakers_list.Controls.Add(this.cbx_spl_yield);
            this.panel_spakers_list.Controls.Add(this.btn_spl_start);
            this.panel_spakers_list.Controls.Add(this.btn_spl_add);
            this.panel_spakers_list.Controls.Add(this.txt_spl_current);
            this.panel_spakers_list.Controls.Add(this.txt_spl_currentnunber);
            this.panel_spakers_list.Controls.Add(this.txt_spl_add);
            this.panel_spakers_list.Controls.Add(this.txt_spl_totalnumber);
            this.panel_spakers_list.Controls.Add(this.Label23);
            this.panel_spakers_list.Controls.Add(this.Label22);
            this.panel_spakers_list.Controls.Add(this.llb_spl_entercustom);
            this.panel_spakers_list.Controls.Add(this.Label20);
            point2 = new Point(170, 0xfb);
            this.panel_spakers_list.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_spakers_list.Margin = padding2;
            this.panel_spakers_list.Name = "panel_spakers_list";
            size2 = new Size(0xd8, 0x167);
            this.panel_spakers_list.Size = size2;
            this.panel_spakers_list.TabIndex = 4;
            this.panel_spakers_list.Visible = false;
            this.panel_csl.Controls.Add(this.btn_spl_loadcustom);
            this.panel_csl.Controls.Add(this.btn_spl_savecustom);
            this.panel_csl.Controls.Add(this.Label21);
            this.panel_csl.Controls.Add(this.txt_spl_customtitle);
            this.panel_csl.Controls.Add(this.chk_spl_allowyield);
            this.panel_csl.Controls.Add(this.num_spl_timem);
            this.panel_csl.Controls.Add(this.num_spl_times);
            this.panel_csl.Controls.Add(this.Label29);
            point2 = new Point(0, 0xc0);
            this.panel_csl.Location = point2;
            this.panel_csl.Name = "panel_csl";
            size2 = new Size(0xd8, 0x6d);
            this.panel_csl.Size = size2;
            this.panel_csl.TabIndex = 9;
            this.panel_csl.Visible = false;
            this.btn_spl_loadcustom.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.btn_spl_loadcustom.FlatAppearance.BorderSize = 0;
            this.btn_spl_loadcustom.FlatStyle = FlatStyle.Flat;
            this.btn_spl_loadcustom.ImeMode = ImeMode.NoControl;
            point2 = new Point(15, 0x55);
            this.btn_spl_loadcustom.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_spl_loadcustom.Margin = padding2;
            this.btn_spl_loadcustom.Name = "btn_spl_loadcustom";
            size2 = new Size(0x5c, 0x19);
            this.btn_spl_loadcustom.Size = size2;
            this.btn_spl_loadcustom.TabIndex = 0x16;
            this.btn_spl_loadcustom.Text = "读取名单";
            this.btn_spl_loadcustom.UseVisualStyleBackColor = true;
            this.btn_spl_savecustom.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.btn_spl_savecustom.FlatAppearance.BorderSize = 0;
            this.btn_spl_savecustom.FlatStyle = FlatStyle.Flat;
            this.btn_spl_savecustom.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x71, 0x55);
            this.btn_spl_savecustom.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_spl_savecustom.Margin = padding2;
            this.btn_spl_savecustom.Name = "btn_spl_savecustom";
            size2 = new Size(0x5c, 0x19);
            this.btn_spl_savecustom.Size = size2;
            this.btn_spl_savecustom.TabIndex = 0x17;
            this.btn_spl_savecustom.Text = "保存名单";
            this.btn_spl_savecustom.UseVisualStyleBackColor = true;
            this.Label21.AutoSize = true;
            this.Label21.ImeMode = ImeMode.NoControl;
            point2 = new Point(12, 4);
            this.Label21.Location = point2;
            this.Label21.Name = "Label21";
            size2 = new Size(0x1f, 13);
            this.Label21.Size = size2;
            this.Label21.TabIndex = 2;
            this.Label21.Text = "标题";
            this.txt_spl_customtitle.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.txt_spl_customtitle.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.txt_spl_customtitle.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(0x35, 0);
            this.txt_spl_customtitle.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.txt_spl_customtitle.Margin = padding2;
            this.txt_spl_customtitle.Name = "txt_spl_customtitle";
            size2 = new Size(150, 20);
            this.txt_spl_customtitle.Size = size2;
            this.txt_spl_customtitle.TabIndex = 5;
            this.chk_spl_allowyield.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.chk_spl_allowyield.AutoSize = true;
            this.chk_spl_allowyield.FlatAppearance.BorderSize = 0;
            this.chk_spl_allowyield.FlatAppearance.CheckedBackColor = Color.PaleTurquoise;
            this.chk_spl_allowyield.ImeMode = ImeMode.NoControl;
            point2 = new Point(15, 60);
            this.chk_spl_allowyield.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.chk_spl_allowyield.Margin = padding2;
            this.chk_spl_allowyield.Name = "chk_spl_allowyield";
            size2 = new Size(0x7a, 0x11);
            this.chk_spl_allowyield.Size = size2;
            this.chk_spl_allowyield.TabIndex = 20;
            this.chk_spl_allowyield.Text = "允许剩余时间让渡";
            this.chk_spl_allowyield.UseVisualStyleBackColor = true;
            this.num_spl_timem.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            point2 = new Point(0x4c, 0x1d);
            this.num_spl_timem.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.num_spl_timem.Margin = padding2;
            this.num_spl_timem.Name = "num_spl_timem";
            size2 = new Size(0x26, 20);
            this.num_spl_timem.Size = size2;
            this.num_spl_timem.TabIndex = 0x12;
            num = new decimal(new int[] { 1, 0, 0, 0 });
            this.num_spl_timem.Value = num;
            this.num_spl_times.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            num = new decimal(new int[] { 5, 0, 0, 0 });
            this.num_spl_times.Increment = num;
            point2 = new Point(0x88, 0x1d);
            this.num_spl_times.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.num_spl_times.Margin = padding2;
            num = new decimal(new int[] { 0x37, 0, 0, 0 });
            this.num_spl_times.Maximum = num;
            this.num_spl_times.Name = "num_spl_times";
            size2 = new Size(0x26, 20);
            this.num_spl_times.Size = size2;
            this.num_spl_times.TabIndex = 0x13;
            num = new decimal(new int[] { 30, 0, 0, 0 });
            this.num_spl_times.Value = num;
            this.Label29.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.Label29.AutoSize = true;
            this.Label29.ImeMode = ImeMode.NoControl;
            point2 = new Point(13, 0x21);
            this.Label29.Location = point2;
            this.Label29.Name = "Label29";
            size2 = new Size(0xb5, 13);
            this.Label29.Size = size2;
            this.Label29.TabIndex = 0x11;
            this.Label29.Text = "发言时间: 　　　　分　　　　秒";
            this.txt_spl_yieldto.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(0x54, 0x81);
            this.txt_spl_yieldto.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.txt_spl_yieldto.Margin = padding2;
            this.txt_spl_yieldto.Name = "txt_spl_yieldto";
            size2 = new Size(0x72, 20);
            this.txt_spl_yieldto.Size = size2;
            this.txt_spl_yieldto.TabIndex = 14;
            this.txt_spl_yieldto.Visible = false;
            this.btn_spl_exit.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.btn_spl_exit.BackColor = Color.LightSeaGreen;
            this.btn_spl_exit.FlatAppearance.BorderSize = 0;
            this.btn_spl_exit.FlatStyle = FlatStyle.Flat;
            this.btn_spl_exit.Font = new Font("Segoe UI", 12f);
            this.btn_spl_exit.ImeMode = ImeMode.NoControl;
            point2 = new Point(0, 0x134);
            this.btn_spl_exit.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_spl_exit.Margin = padding2;
            this.btn_spl_exit.Name = "btn_spl_exit";
            size2 = new Size(0xd8, 0x23);
            this.btn_spl_exit.Size = size2;
            this.btn_spl_exit.TabIndex = 0x15;
            this.btn_spl_exit.Text = "退出发言名单";
            this.btn_spl_exit.UseVisualStyleBackColor = false;
            this.btn_spl_yieldend.FlatAppearance.BorderSize = 0;
            this.btn_spl_yieldend.FlatStyle = FlatStyle.Flat;
            this.btn_spl_yieldend.ImeMode = ImeMode.NoControl;
            point2 = new Point(140, 0x9e);
            this.btn_spl_yieldend.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_spl_yieldend.Margin = padding2;
            this.btn_spl_yieldend.Name = "btn_spl_yieldend";
            size2 = new Size(0x41, 0x19);
            this.btn_spl_yieldend.Size = size2;
            this.btn_spl_yieldend.TabIndex = 0x10;
            this.btn_spl_yieldend.Text = "结束发言";
            this.btn_spl_yieldend.UseVisualStyleBackColor = true;
            this.btn_spl_yieldend.Visible = false;
            this.btn_spl_yieldgo.FlatAppearance.BorderSize = 0;
            this.btn_spl_yieldgo.FlatStyle = FlatStyle.Flat;
            this.btn_spl_yieldgo.ImeMode = ImeMode.NoControl;
            point2 = new Point(12, 0x9e);
            this.btn_spl_yieldgo.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_spl_yieldgo.Margin = padding2;
            this.btn_spl_yieldgo.Name = "btn_spl_yieldgo";
            size2 = new Size(0x7a, 0x19);
            this.btn_spl_yieldgo.Size = size2;
            this.btn_spl_yieldgo.TabIndex = 15;
            this.btn_spl_yieldgo.Text = "开始";
            this.btn_spl_yieldgo.UseVisualStyleBackColor = true;
            this.btn_spl_yieldgo.Visible = false;
            this.Label28.AutoSize = true;
            this.Label28.BackColor = Color.Transparent;
            this.Label28.ImeMode = ImeMode.NoControl;
            point2 = new Point(13, 0x86);
            this.Label28.Location = point2;
            this.Label28.Name = "Label28";
            size2 = new Size(0x9a, 13);
            this.Label28.Size = size2;
            this.Label28.TabIndex = 13;
            this.Label28.Text = "让渡给问题                     代表";
            this.Label28.Visible = false;
            this.cbx_spl_yield.BackColor = Color.Teal;
            this.cbx_spl_yield.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbx_spl_yield.Enabled = false;
            this.cbx_spl_yield.FlatStyle = FlatStyle.Flat;
            this.cbx_spl_yield.ForeColor = SystemColors.ControlLightLight;
            this.cbx_spl_yield.FormattingEnabled = true;
            this.cbx_spl_yield.Items.AddRange(new object[] { "请选择让渡方式", "让渡给他国代表", "让渡给问题", "让渡给评论", "让渡给主席" });
            point2 = new Point(15, 100);
            this.cbx_spl_yield.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.cbx_spl_yield.Margin = padding2;
            this.cbx_spl_yield.Name = "cbx_spl_yield";
            size2 = new Size(0xbb, 0x15);
            this.cbx_spl_yield.Size = size2;
            this.cbx_spl_yield.TabIndex = 12;
            this.btn_spl_start.FlatAppearance.BorderSize = 0;
            this.btn_spl_start.FlatStyle = FlatStyle.Flat;
            this.btn_spl_start.ImeMode = ImeMode.NoControl;
            point2 = new Point(160, 0x48);
            this.btn_spl_start.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_spl_start.Margin = padding2;
            this.btn_spl_start.Name = "btn_spl_start";
            size2 = new Size(0x2a, 0x19);
            this.btn_spl_start.Size = size2;
            this.btn_spl_start.TabIndex = 11;
            this.btn_spl_start.Text = "开始";
            this.btn_spl_start.UseVisualStyleBackColor = true;
            this.btn_spl_add.FlatAppearance.BorderSize = 0;
            this.btn_spl_add.FlatStyle = FlatStyle.Flat;
            this.btn_spl_add.ImeMode = ImeMode.NoControl;
            point2 = new Point(160, 0x29);
            this.btn_spl_add.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_spl_add.Margin = padding2;
            this.btn_spl_add.Name = "btn_spl_add";
            size2 = new Size(0x2a, 0x19);
            this.btn_spl_add.Size = size2;
            this.btn_spl_add.TabIndex = 10;
            this.btn_spl_add.Text = "确认";
            this.btn_spl_add.UseVisualStyleBackColor = true;
            this.txt_spl_current.BackColor = Color.PaleTurquoise;
            this.txt_spl_current.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(80, 0x48);
            this.txt_spl_current.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.txt_spl_current.Margin = padding2;
            this.txt_spl_current.Name = "txt_spl_current";
            this.txt_spl_current.ReadOnly = true;
            size2 = new Size(0x4a, 20);
            this.txt_spl_current.Size = size2;
            this.txt_spl_current.TabIndex = 9;
            this.txt_spl_currentnunber.BackColor = Color.PaleTurquoise;
            this.txt_spl_currentnunber.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(0x34, 0x48);
            this.txt_spl_currentnunber.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.txt_spl_currentnunber.Margin = padding2;
            this.txt_spl_currentnunber.Name = "txt_spl_currentnunber";
            this.txt_spl_currentnunber.ReadOnly = true;
            size2 = new Size(0x16, 20);
            this.txt_spl_currentnunber.Size = size2;
            this.txt_spl_currentnunber.TabIndex = 8;
            this.txt_spl_currentnunber.Text = "0";
            this.txt_spl_add.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.txt_spl_add.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.txt_spl_add.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(80, 0x2b);
            this.txt_spl_add.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.txt_spl_add.Margin = padding2;
            this.txt_spl_add.Name = "txt_spl_add";
            size2 = new Size(0x4a, 20);
            this.txt_spl_add.Size = size2;
            this.txt_spl_add.TabIndex = 7;
            this.txt_spl_totalnumber.BackColor = Color.PaleTurquoise;
            this.txt_spl_totalnumber.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(0x34, 0x2b);
            this.txt_spl_totalnumber.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.txt_spl_totalnumber.Margin = padding2;
            this.txt_spl_totalnumber.Name = "txt_spl_totalnumber";
            this.txt_spl_totalnumber.ReadOnly = true;
            size2 = new Size(0x16, 20);
            this.txt_spl_totalnumber.Size = size2;
            this.txt_spl_totalnumber.TabIndex = 6;
            this.txt_spl_totalnumber.Text = "1";
            this.Label23.AutoSize = true;
            this.Label23.ImeMode = ImeMode.NoControl;
            point2 = new Point(13, 0x4c);
            this.Label23.Location = point2;
            this.Label23.Name = "Label23";
            size2 = new Size(0x22, 13);
            this.Label23.Size = size2;
            this.Label23.TabIndex = 4;
            this.Label23.Text = "当前:";
            this.Label22.AutoSize = true;
            this.Label22.ImeMode = ImeMode.NoControl;
            point2 = new Point(13, 0x2e);
            this.Label22.Location = point2;
            this.Label22.Name = "Label22";
            size2 = new Size(0x22, 13);
            this.Label22.Size = size2;
            this.Label22.TabIndex = 3;
            this.Label22.Text = "新增:";
            this.llb_spl_entercustom.ActiveLinkColor = Color.LightSeaGreen;
            this.llb_spl_entercustom.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.llb_spl_entercustom.AutoSize = true;
            this.llb_spl_entercustom.ImeMode = ImeMode.NoControl;
            this.llb_spl_entercustom.LinkColor = Color.PaleTurquoise;
            point2 = new Point(0x84, 0x11);
            this.llb_spl_entercustom.Location = point2;
            this.llb_spl_entercustom.Name = "llb_spl_entercustom";
            size2 = new Size(0x4f, 13);
            this.llb_spl_entercustom.Size = size2;
            this.llb_spl_entercustom.TabIndex = 1;
            this.llb_spl_entercustom.TabStop = true;
            this.llb_spl_entercustom.Text = "进入自定名单";
            this.llb_spl_entercustom.VisitedLinkColor = Color.PaleTurquoise;
            this.Label20.AutoSize = true;
            this.Label20.Font = new Font("Segoe UI", 12f);
            this.Label20.ImeMode = ImeMode.NoControl;
            point2 = new Point(7, 11);
            this.Label20.Location = point2;
            this.Label20.Name = "Label20";
            size2 = new Size(0x5f, 0x15);
            this.Label20.Size = size2;
            this.Label20.TabIndex = 0;
            this.Label20.Text = "主发言名单";
            this.panel_system.Controls.Add(this.Label61);
            this.panel_system.Controls.Add(this.btn_system_calcel);
            this.panel_system.Controls.Add(this.btnexit);
            this.panel_system.Controls.Add(this.Button12);
            this.panel_system.Controls.Add(this.Button11);
            this.panel_system.Controls.Add(this.btn_system_1);
            point2 = new Point(0x2b, 0x188);
            this.panel_system.Location = point2;
            padding2 = new Padding(3, 0, 3, 0);
            this.panel_system.Margin = padding2;
            this.panel_system.Name = "panel_system";
            size2 = new Size(0xd8, 0x100);
            this.panel_system.Size = size2;
            this.panel_system.TabIndex = 11;
            this.panel_system.Visible = false;
            this.Label61.AutoSize = true;
            this.Label61.Font = new Font("Segoe UI", 12f);
            this.Label61.ImeMode = ImeMode.NoControl;
            point2 = new Point(7, 11);
            this.Label61.Location = point2;
            this.Label61.Name = "Label61";
            size2 = new Size(0x4e, 0x15);
            this.Label61.Size = size2;
            this.Label61.TabIndex = 6;
            this.Label61.Text = "系统菜单";
            this.btn_system_calcel.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.btn_system_calcel.BackColor = Color.LightSeaGreen;
            this.btn_system_calcel.FlatAppearance.BorderSize = 0;
            this.btn_system_calcel.FlatStyle = FlatStyle.Flat;
            this.btn_system_calcel.Font = new Font("Segoe UI", 12f);
            this.btn_system_calcel.ImeMode = ImeMode.NoControl;
            point2 = new Point(0, 0xcc);
            this.btn_system_calcel.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_system_calcel.Margin = padding2;
            this.btn_system_calcel.Name = "btn_system_calcel";
            size2 = new Size(0xd8, 0x23);
            this.btn_system_calcel.Size = size2;
            this.btn_system_calcel.TabIndex = 5;
            this.btn_system_calcel.Text = "取消";
            this.btn_system_calcel.UseVisualStyleBackColor = false;
            this.btnexit.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.btnexit.BackColor = Color.Firebrick;
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = FlatStyle.Flat;
            this.btnexit.Font = new Font("Segoe UI", 12f);
            this.btnexit.ImeMode = ImeMode.NoControl;
            point2 = new Point(0, 0x9a);
            this.btnexit.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btnexit.Margin = padding2;
            this.btnexit.Name = "btnexit";
            size2 = new Size(0xd8, 0x23);
            this.btnexit.Size = size2;
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "退出 Console";
            this.btnexit.UseVisualStyleBackColor = false;
            this.Button12.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.Button12.FlatAppearance.BorderSize = 0;
            this.Button12.FlatStyle = FlatStyle.Flat;
            this.Button12.Font = new Font("Segoe UI", 9f);
            this.Button12.ImeMode = ImeMode.NoControl;
            point2 = new Point(0, 0x57);
            this.Button12.Location = point2;
            padding2 = new Padding(3, 0, 3, 0);
            this.Button12.Margin = padding2;
            this.Button12.Name = "Button12";
            size2 = new Size(0xd8, 0x16);
            this.Button12.Size = size2;
            this.Button12.TabIndex = 3;
            this.Button12.Text = "关于";
            this.Button12.UseVisualStyleBackColor = true;
            this.Button11.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.Button11.FlatAppearance.BorderSize = 0;
            this.Button11.FlatStyle = FlatStyle.Flat;
            this.Button11.Font = new Font("Segoe UI", 9f);
            this.Button11.ImeMode = ImeMode.NoControl;
            point2 = new Point(0, 0x40);
            this.Button11.Location = point2;
            padding2 = new Padding(3, 0, 3, 0);
            this.Button11.Margin = padding2;
            this.Button11.Name = "Button11";
            size2 = new Size(0xd8, 0x16);
            this.Button11.Size = size2;
            this.Button11.TabIndex = 2;
            this.Button11.Text = "会议管理";
            this.Button11.UseVisualStyleBackColor = true;
            this.btn_system_1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.btn_system_1.FlatAppearance.BorderSize = 0;
            this.btn_system_1.FlatStyle = FlatStyle.Flat;
            this.btn_system_1.Font = new Font("Segoe UI", 9f);
            this.btn_system_1.ImeMode = ImeMode.NoControl;
            point2 = new Point(0, 0x29);
            this.btn_system_1.Location = point2;
            padding2 = new Padding(3, 0, 3, 0);
            this.btn_system_1.Margin = padding2;
            this.btn_system_1.Name = "btn_system_1";
            size2 = new Size(0xd8, 0x16);
            this.btn_system_1.Size = size2;
            this.btn_system_1.TabIndex = 1;
            this.btn_system_1.Text = "系统设置";
            this.btn_system_1.UseVisualStyleBackColor = true;
            this.panel_editnationlist.Anchor = AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.panel_editnationlist.Controls.Add(this.btn_enl_save);
            this.panel_editnationlist.Controls.Add(this.btn_enl_cancel);
            this.panel_editnationlist.Controls.Add(this.txtnationlist);
            this.panel_editnationlist.Controls.Add(this.Label19);
            this.panel_editnationlist.Controls.Add(this.Label18);
            point2 = new Point(0xc0, 0xe5);
            this.panel_editnationlist.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_editnationlist.Margin = padding2;
            this.panel_editnationlist.Name = "panel_editnationlist";
            size2 = new Size(0xd8, 0x1e5);
            this.panel_editnationlist.Size = size2;
            this.panel_editnationlist.TabIndex = 3;
            this.panel_editnationlist.Visible = false;
            this.btn_enl_save.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.btn_enl_save.BackColor = Color.LightSeaGreen;
            this.btn_enl_save.FlatAppearance.BorderSize = 0;
            this.btn_enl_save.FlatStyle = FlatStyle.Flat;
            this.btn_enl_save.Font = new Font("Segoe UI", 12f);
            this.btn_enl_save.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x6b, 0x1b9);
            this.btn_enl_save.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_enl_save.Margin = padding2;
            this.btn_enl_save.Name = "btn_enl_save";
            size2 = new Size(0x6d, 0x23);
            this.btn_enl_save.Size = size2;
            this.btn_enl_save.TabIndex = 6;
            this.btn_enl_save.Text = "保存";
            this.btn_enl_save.UseVisualStyleBackColor = false;
            this.btn_enl_cancel.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.btn_enl_cancel.BackColor = Color.Teal;
            this.btn_enl_cancel.FlatAppearance.BorderSize = 0;
            this.btn_enl_cancel.FlatStyle = FlatStyle.Flat;
            this.btn_enl_cancel.Font = new Font("Segoe UI", 12f);
            this.btn_enl_cancel.ImeMode = ImeMode.NoControl;
            point2 = new Point(0, 0x1b9);
            this.btn_enl_cancel.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_enl_cancel.Margin = padding2;
            this.btn_enl_cancel.Name = "btn_enl_cancel";
            size2 = new Size(0x6d, 0x23);
            this.btn_enl_cancel.Size = size2;
            this.btn_enl_cancel.TabIndex = 5;
            this.btn_enl_cancel.Text = "取消";
            this.btn_enl_cancel.UseVisualStyleBackColor = false;
            this.txtnationlist.Anchor = AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.txtnationlist.BorderStyle = BorderStyle.None;
            point2 = new Point(15, 0x79);
            this.txtnationlist.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.txtnationlist.Margin = padding2;
            this.txtnationlist.Multiline = true;
            this.txtnationlist.Name = "txtnationlist";
            this.txtnationlist.ScrollBars = ScrollBars.Vertical;
            size2 = new Size(0xbd, 0x139);
            this.txtnationlist.Size = size2;
            this.txtnationlist.TabIndex = 4;
            this.Label19.ImeMode = ImeMode.NoControl;
            point2 = new Point(13, 0x2b);
            this.Label19.Location = point2;
            this.Label19.Name = "Label19";
            size2 = new Size(0xbf, 0x4c);
            this.Label19.Size = size2;
            this.Label19.TabIndex = 3;
            this.Label19.Text = "注意:\r\n国家列表保存后,出席情况将清空!\r\n如需添加少量国家,请选择\"快速添加\"!\r\n在文本框中输入国家,每行一个:";
            this.Label18.AutoSize = true;
            this.Label18.Font = new Font("Segoe UI", 12f);
            this.Label18.ImeMode = ImeMode.NoControl;
            point2 = new Point(7, 11);
            this.Label18.Location = point2;
            this.Label18.Name = "Label18";
            size2 = new Size(0x70, 0x15);
            this.Label18.Size = size2;
            this.Label18.TabIndex = 0;
            this.Label18.Text = "编辑国家列表";
            this.panel_mc.Controls.Add(this.btn_mc_next);
            this.panel_mc.Controls.Add(this.Label33);
            this.panel_mc.Controls.Add(this.btn_mc_end);
            this.panel_mc.Controls.Add(this.Label30);
            this.panel_mc.Controls.Add(this.Label102);
            this.panel_mc.Controls.Add(this.lbl_mc_total_time);
            this.panel_mc.Controls.Add(this.btn_mc_start);
            this.panel_mc.Controls.Add(this.Label31);
            this.panel_mc.Controls.Add(this.Label32);
            this.panel_mc.Controls.Add(this.txt_mc_totalnumber);
            this.panel_mc.Controls.Add(this.txt_mc_add);
            this.panel_mc.Controls.Add(this.txt_mc_currentnumber);
            this.panel_mc.Controls.Add(this.txt_mc_current);
            this.panel_mc.Controls.Add(this.btn_mc_add);
            point2 = new Point(200, 0xdb);
            this.panel_mc.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_mc.Margin = padding2;
            this.panel_mc.Name = "panel_mc";
            size2 = new Size(0xd8, 0xfe);
            this.panel_mc.Size = size2;
            this.panel_mc.TabIndex = 7;
            this.panel_mc.Visible = false;
            this.btn_mc_next.FlatAppearance.BorderSize = 0;
            this.btn_mc_next.FlatStyle = FlatStyle.Flat;
            this.btn_mc_next.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x97, 0xad);
            this.btn_mc_next.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_mc_next.Margin = padding2;
            this.btn_mc_next.Name = "btn_mc_next";
            size2 = new Size(0x37, 0x19);
            this.btn_mc_next.Size = size2;
            this.btn_mc_next.TabIndex = 11;
            this.btn_mc_next.Text = "下一个";
            this.btn_mc_next.UseVisualStyleBackColor = true;
            this.btn_mc_next.Visible = false;
            this.Label33.AutoSize = true;
            this.Label33.BackColor = Color.Transparent;
            this.Label33.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x11, 0xb2);
            this.Label33.Location = point2;
            this.Label33.Name = "Label33";
            size2 = new Size(0x2d, 13);
            this.Label33.Size = size2;
            this.Label33.TabIndex = 13;
            this.Label33.Text = "Label33";
            this.btn_mc_end.FlatAppearance.BorderSize = 0;
            this.btn_mc_end.FlatStyle = FlatStyle.Flat;
            this.btn_mc_end.Font = new Font("Segoe UI", 12f);
            this.btn_mc_end.ImeMode = ImeMode.NoControl;
            point2 = new Point(0, 0xce);
            this.btn_mc_end.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_mc_end.Margin = padding2;
            this.btn_mc_end.Name = "btn_mc_end";
            size2 = new Size(0xd8, 0x23);
            this.btn_mc_end.Size = size2;
            this.btn_mc_end.TabIndex = 12;
            this.btn_mc_end.Text = "结束";
            this.btn_mc_end.UseVisualStyleBackColor = true;
            this.Label30.AutoSize = true;
            this.Label30.Font = new Font("Segoe UI", 12f);
            this.Label30.ImeMode = ImeMode.NoControl;
            point2 = new Point(12, 0x52);
            this.Label30.Location = point2;
            this.Label30.Name = "Label30";
            size2 = new Size(0x81, 0x15);
            this.Label30.Size = size2;
            this.Label30.TabIndex = 2;
            this.Label30.Text = "有主持核心磋商";
            this.Label102.AutoSize = true;
            this.Label102.Font = new Font("Segoe UI", 14.25f);
            this.Label102.ImeMode = ImeMode.NoControl;
            point2 = new Point(7, 12);
            this.Label102.Location = point2;
            this.Label102.Name = "Label102";
            size2 = new Size(0x43, 50);
            this.Label102.Size = size2;
            this.Label102.TabIndex = 0;
            this.Label102.Text = "TOTAL\r\nTIME";
            this.lbl_mc_total_time.Font = new Font("Segoe UI", 39.75f);
            this.lbl_mc_total_time.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x40, -1);
            this.lbl_mc_total_time.Location = point2;
            this.lbl_mc_total_time.Name = "lbl_mc_total_time";
            size2 = new Size(160, 0x4d);
            this.lbl_mc_total_time.Size = size2;
            this.lbl_mc_total_time.TabIndex = 1;
            this.lbl_mc_total_time.Text = "00:00";
            this.lbl_mc_total_time.TextAlign = ContentAlignment.TopRight;
            this.btn_mc_start.FlatAppearance.BorderSize = 0;
            this.btn_mc_start.FlatStyle = FlatStyle.Flat;
            this.btn_mc_start.ImeMode = ImeMode.NoControl;
            point2 = new Point(0xa4, 0x8f);
            this.btn_mc_start.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_mc_start.Margin = padding2;
            this.btn_mc_start.Name = "btn_mc_start";
            size2 = new Size(0x2a, 0x19);
            this.btn_mc_start.Size = size2;
            this.btn_mc_start.TabIndex = 11;
            this.btn_mc_start.Text = "开始";
            this.btn_mc_start.UseVisualStyleBackColor = true;
            this.Label31.AutoSize = true;
            this.Label31.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x11, 0x77);
            this.Label31.Location = point2;
            this.Label31.Name = "Label31";
            size2 = new Size(0x22, 13);
            this.Label31.Size = size2;
            this.Label31.TabIndex = 3;
            this.Label31.Text = "新增:";
            this.Label32.AutoSize = true;
            this.Label32.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x11, 0x94);
            this.Label32.Location = point2;
            this.Label32.Name = "Label32";
            size2 = new Size(0x22, 13);
            this.Label32.Size = size2;
            this.Label32.TabIndex = 4;
            this.Label32.Text = "当前:";
            this.txt_mc_totalnumber.BackColor = Color.PaleTurquoise;
            this.txt_mc_totalnumber.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(0x38, 0x71);
            this.txt_mc_totalnumber.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.txt_mc_totalnumber.Margin = padding2;
            this.txt_mc_totalnumber.Name = "txt_mc_totalnumber";
            this.txt_mc_totalnumber.ReadOnly = true;
            size2 = new Size(0x16, 20);
            this.txt_mc_totalnumber.Size = size2;
            this.txt_mc_totalnumber.TabIndex = 6;
            this.txt_mc_totalnumber.Text = "1";
            this.txt_mc_add.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.txt_mc_add.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.txt_mc_add.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(0x54, 0x71);
            this.txt_mc_add.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.txt_mc_add.Margin = padding2;
            this.txt_mc_add.Name = "txt_mc_add";
            size2 = new Size(0x4a, 20);
            this.txt_mc_add.Size = size2;
            this.txt_mc_add.TabIndex = 7;
            this.txt_mc_currentnumber.BackColor = Color.PaleTurquoise;
            this.txt_mc_currentnumber.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(0x38, 0x8f);
            this.txt_mc_currentnumber.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.txt_mc_currentnumber.Margin = padding2;
            this.txt_mc_currentnumber.Name = "txt_mc_currentnumber";
            this.txt_mc_currentnumber.ReadOnly = true;
            size2 = new Size(0x16, 20);
            this.txt_mc_currentnumber.Size = size2;
            this.txt_mc_currentnumber.TabIndex = 8;
            this.txt_mc_currentnumber.Text = "0";
            this.txt_mc_current.BackColor = Color.PaleTurquoise;
            this.txt_mc_current.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(0x54, 0x8f);
            this.txt_mc_current.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.txt_mc_current.Margin = padding2;
            this.txt_mc_current.Name = "txt_mc_current";
            this.txt_mc_current.ReadOnly = true;
            size2 = new Size(0x4a, 20);
            this.txt_mc_current.Size = size2;
            this.txt_mc_current.TabIndex = 9;
            this.btn_mc_add.FlatAppearance.BorderSize = 0;
            this.btn_mc_add.FlatStyle = FlatStyle.Flat;
            this.btn_mc_add.ImeMode = ImeMode.NoControl;
            point2 = new Point(0xa4, 0x71);
            this.btn_mc_add.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_mc_add.Margin = padding2;
            this.btn_mc_add.Name = "btn_mc_add";
            size2 = new Size(0x2a, 0x19);
            this.btn_mc_add.Size = size2;
            this.btn_mc_add.TabIndex = 10;
            this.btn_mc_add.Text = "确认";
            this.btn_mc_add.UseVisualStyleBackColor = true;
            this.panel_umc.Controls.Add(this.btn_umc_send);
            this.panel_umc.Controls.Add(this.btn_umc_reset);
            this.panel_umc.Controls.Add(this.txt_umccustom);
            this.panel_umc.Controls.Add(this.Label182);
            this.panel_umc.Controls.Add(this.Label101);
            this.panel_umc.Controls.Add(this.btn_umc_close);
            this.panel_umc.Controls.Add(this.Label181);
            this.panel_umc.Controls.Add(this.Label100);
            point2 = new Point(0xcc, 0xd0);
            this.panel_umc.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_umc.Margin = padding2;
            this.panel_umc.Name = "panel_umc";
            size2 = new Size(0xd8, 0x138);
            this.panel_umc.Size = size2;
            this.panel_umc.TabIndex = 6;
            this.panel_umc.Visible = false;
            this.btn_umc_send.BackColor = Color.LightSeaGreen;
            this.btn_umc_send.FlatAppearance.BorderSize = 0;
            this.btn_umc_send.FlatStyle = FlatStyle.Flat;
            this.btn_umc_send.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x75, 230);
            this.btn_umc_send.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_umc_send.Margin = padding2;
            this.btn_umc_send.Name = "btn_umc_send";
            size2 = new Size(0x55, 0x16);
            this.btn_umc_send.Size = size2;
            this.btn_umc_send.TabIndex = 5;
            this.btn_umc_send.Text = "发送";
            this.btn_umc_send.UseVisualStyleBackColor = false;
            this.btn_umc_reset.FlatAppearance.BorderSize = 0;
            this.btn_umc_reset.FlatStyle = FlatStyle.Flat;
            this.btn_umc_reset.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x10, 0xe5);
            this.btn_umc_reset.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_umc_reset.Margin = padding2;
            this.btn_umc_reset.Name = "btn_umc_reset";
            size2 = new Size(0x55, 0x16);
            this.btn_umc_reset.Size = size2;
            this.btn_umc_reset.TabIndex = 4;
            this.btn_umc_reset.Text = "重填";
            this.btn_umc_reset.UseVisualStyleBackColor = true;
            this.txt_umccustom.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(0x10, 0x81);
            this.txt_umccustom.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.txt_umccustom.Margin = padding2;
            this.txt_umccustom.Multiline = true;
            this.txt_umccustom.Name = "txt_umccustom";
            size2 = new Size(0xbb, 0x5e);
            this.txt_umccustom.Size = size2;
            this.txt_umccustom.TabIndex = 3;
            this.Label182.AutoSize = true;
            this.Label182.ImeMode = ImeMode.NoControl;
            point2 = new Point(13, 0x6f);
            this.Label182.Location = point2;
            this.Label182.Name = "Label182";
            size2 = new Size(0xa3, 13);
            this.Label182.Size = size2;
            this.Label182.TabIndex = 2;
            this.Label182.Text = "在计时中发送来自主席的消息";
            this.Label101.AutoSize = true;
            this.Label101.ImeMode = ImeMode.NoControl;
            point2 = new Point(13, 0x29);
            this.Label101.Location = point2;
            this.Label101.Name = "Label101";
            size2 = new Size(0x58, 13);
            this.Label101.Size = size2;
            this.Label101.TabIndex = 2;
            this.Label101.Text = "预计结束时间:  ";
            this.btn_umc_close.FlatAppearance.BorderSize = 0;
            this.btn_umc_close.FlatStyle = FlatStyle.Flat;
            this.btn_umc_close.Font = new Font("Segoe UI", 12f);
            this.btn_umc_close.ImeMode = ImeMode.NoControl;
            point2 = new Point(0, 0x10b);
            this.btn_umc_close.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_umc_close.Margin = padding2;
            this.btn_umc_close.Name = "btn_umc_close";
            size2 = new Size(0xd8, 0x23);
            this.btn_umc_close.Size = size2;
            this.btn_umc_close.TabIndex = 1;
            this.btn_umc_close.Text = "关闭面板";
            this.btn_umc_close.UseVisualStyleBackColor = true;
            this.Label181.AutoSize = true;
            this.Label181.Font = new Font("Segoe UI", 12f);
            this.Label181.ImeMode = ImeMode.NoControl;
            point2 = new Point(7, 0x52);
            this.Label181.Location = point2;
            this.Label181.Name = "Label181";
            size2 = new Size(0x4e, 0x15);
            this.Label181.Size = size2;
            this.Label181.TabIndex = 0;
            this.Label181.Text = "发送信息";
            this.Label100.AutoSize = true;
            this.Label100.Font = new Font("Segoe UI", 12f);
            this.Label100.ImeMode = ImeMode.NoControl;
            point2 = new Point(7, 11);
            this.Label100.Location = point2;
            this.Label100.Name = "Label100";
            size2 = new Size(0x81, 0x15);
            this.Label100.Size = size2;
            this.Label100.TabIndex = 0;
            this.Label100.Text = "自由磋商进行中";
            this.panel_presents.Controls.Add(this.lbl20maj1);
            this.panel_presents.Controls.Add(this.lbl67maj1);
            this.panel_presents.Controls.Add(this.lbl50maj1);
            this.panel_presents.Controls.Add(this.lbl20maj);
            this.panel_presents.Controls.Add(this.lbl67maj);
            this.panel_presents.Controls.Add(this.lbl50maj);
            this.panel_presents.Controls.Add(this.lblpresent);
            this.panel_presents.Controls.Add(this.lblpresent1);
            this.panel_presents.Dock = DockStyle.Bottom;
            this.panel_presents.ForeColor = SystemColors.ControlLightLight;
            point2 = new Point(0, 0x221);
            this.panel_presents.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_presents.Margin = padding2;
            this.panel_presents.Name = "panel_presents";
            size2 = new Size(0xd8, 0xd5);
            this.panel_presents.Size = size2;
            this.panel_presents.TabIndex = 2;
            this.lbl20maj1.AutoSize = true;
            this.lbl20maj1.Font = new Font("Segoe UI", 12f);
            point2 = new Point(7, 0x9c);
            this.lbl20maj1.Location = point2;
            this.lbl20maj1.Name = "lbl20maj1";
            size2 = new Size(0x2c, 0x15);
            this.lbl20maj1.Size = size2;
            this.lbl20maj1.TabIndex = 13;
            this.lbl20maj1.Text = "20%:";
            this.lbl67maj1.AutoSize = true;
            this.lbl67maj1.Font = new Font("Segoe UI", 12f);
            point2 = new Point(7, 0x71);
            this.lbl67maj1.Location = point2;
            this.lbl67maj1.Name = "lbl67maj1";
            size2 = new Size(0x63, 0x15);
            this.lbl67maj1.Size = size2;
            this.lbl67maj1.TabIndex = 12;
            this.lbl67maj1.Text = "2/3 Majority:";
            this.lbl50maj1.AutoSize = true;
            this.lbl50maj1.Font = new Font("Segoe UI", 12f);
            point2 = new Point(7, 0x45);
            this.lbl50maj1.Location = point2;
            this.lbl50maj1.Name = "lbl50maj1";
            size2 = new Size(0x7b, 0x15);
            this.lbl50maj1.Size = size2;
            this.lbl50maj1.TabIndex = 11;
            this.lbl50maj1.Text = "Simple Majority:";
            this.lbl20maj.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.lbl20maj.Font = new Font("Segoe UI", 20f);
            this.lbl20maj.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x7f, 0x93);
            this.lbl20maj.Location = point2;
            this.lbl20maj.Name = "lbl20maj";
            size2 = new Size(0x52, 0x21);
            this.lbl20maj.Size = size2;
            this.lbl20maj.TabIndex = 10;
            this.lbl20maj.Text = "0";
            this.lbl20maj.TextAlign = ContentAlignment.TopRight;
            this.lbl67maj.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.lbl67maj.Font = new Font("Segoe UI", 20f);
            this.lbl67maj.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x7f, 0x68);
            this.lbl67maj.Location = point2;
            this.lbl67maj.Name = "lbl67maj";
            size2 = new Size(0x52, 0x21);
            this.lbl67maj.Size = size2;
            this.lbl67maj.TabIndex = 9;
            this.lbl67maj.Text = "0";
            this.lbl67maj.TextAlign = ContentAlignment.TopRight;
            this.lbl50maj.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.lbl50maj.Font = new Font("Segoe UI", 20f);
            this.lbl50maj.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x7f, 60);
            this.lbl50maj.Location = point2;
            this.lbl50maj.Name = "lbl50maj";
            size2 = new Size(0x52, 0x21);
            this.lbl50maj.Size = size2;
            this.lbl50maj.TabIndex = 8;
            this.lbl50maj.Text = "0";
            this.lbl50maj.TextAlign = ContentAlignment.TopRight;
            this.lblpresent.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.lblpresent.Font = new Font("Segoe UI", 20f);
            this.lblpresent.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x7f, 14);
            this.lblpresent.Location = point2;
            this.lblpresent.Name = "lblpresent";
            size2 = new Size(0x52, 0x21);
            this.lblpresent.Size = size2;
            this.lblpresent.TabIndex = 7;
            this.lblpresent.Text = "0";
            this.lblpresent.TextAlign = ContentAlignment.TopRight;
            this.lblpresent1.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.lblpresent1.AutoSize = true;
            this.lblpresent1.Font = new Font("Segoe UI", 12f);
            this.lblpresent1.ImeMode = ImeMode.NoControl;
            point2 = new Point(7, 0x17);
            this.lblpresent1.Location = point2;
            this.lblpresent1.Name = "lblpresent1";
            size2 = new Size(0x48, 0x15);
            this.lblpresent1.Size = size2;
            this.lblpresent1.TabIndex = 6;
            this.lblpresent1.Text = "Presents:";
            this.panel_sidebar_timer.Controls.Add(this.lblmaohao);
            this.panel_sidebar_timer.Controls.Add(this.numtime);
            this.panel_sidebar_timer.Controls.Add(this.Panel1);
            this.panel_sidebar_timer.Controls.Add(this.Button4);
            this.panel_sidebar_timer.Controls.Add(this.Button3);
            this.panel_sidebar_timer.Controls.Add(this.Label12);
            this.panel_sidebar_timer.Controls.Add(this.lblcount);
            this.panel_sidebar_timer.Dock = DockStyle.Top;
            point2 = new Point(0, 60);
            this.panel_sidebar_timer.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_sidebar_timer.Margin = padding2;
            this.panel_sidebar_timer.Name = "panel_sidebar_timer";
            size2 = new Size(0xd8, 0x7e);
            this.panel_sidebar_timer.Size = size2;
            this.panel_sidebar_timer.TabIndex = 0;
            this.panel_sidebar_timer.Visible = false;
            this.lblmaohao.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x65, 14);
            this.lblmaohao.Location = point2;
            this.lblmaohao.Name = "lblmaohao";
            size2 = new Size(14, 0x41);
            this.lblmaohao.Size = size2;
            this.lblmaohao.TabIndex = 5;
            this.lblmaohao.Visible = false;
            this.numtime.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(0x2b, 0x5f);
            this.numtime.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.numtime.Margin = padding2;
            num = new decimal(new int[] { 0x2580, 0, 0, 0 });
            this.numtime.Maximum = num;
            this.numtime.Name = "numtime";
            size2 = new Size(0x2c, 20);
            this.numtime.Size = size2;
            this.numtime.TabIndex = 4;
            num = new decimal(new int[] { 60, 0, 0, 0 });
            this.numtime.Value = num;
            this.Panel1.Anchor = AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.Panel1.Controls.Add(this.Button1);
            this.Panel1.Controls.Add(this.Button5);
            this.Panel1.Controls.Add(this.TextBox11);
            this.Panel1.Controls.Add(this.TextBox12);
            this.Panel1.Controls.Add(this.TextBox13);
            this.Panel1.Controls.Add(this.TextBox14);
            this.Panel1.Controls.Add(this.TextBox15);
            this.Panel1.Controls.Add(this.Label24);
            this.Panel1.Controls.Add(this.Label25);
            this.Panel1.Controls.Add(this.Label26);
            this.Panel1.Controls.Add(this.LinkLabel2);
            this.Panel1.Controls.Add(this.Label27);
            point2 = new Point(0, 0x7e);
            this.Panel1.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.Panel1.Margin = padding2;
            this.Panel1.Name = "Panel1";
            size2 = new Size(0xd8, 0x167);
            this.Panel1.Size = size2;
            this.Panel1.TabIndex = 4;
            this.Button1.FlatAppearance.BorderSize = 0;
            this.Button1.FlatStyle = FlatStyle.Flat;
            this.Button1.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x9f, 100);
            this.Button1.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.Button1.Margin = padding2;
            this.Button1.Name = "Button1";
            size2 = new Size(0x2a, 0x19);
            this.Button1.Size = size2;
            this.Button1.TabIndex = 11;
            this.Button1.Text = "开始";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button5.FlatAppearance.BorderSize = 0;
            this.Button5.FlatStyle = FlatStyle.Flat;
            this.Button5.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x9f, 0x48);
            this.Button5.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.Button5.Margin = padding2;
            this.Button5.Name = "Button5";
            size2 = new Size(0x2a, 0x19);
            this.Button5.Size = size2;
            this.Button5.TabIndex = 10;
            this.Button5.Text = "确认";
            this.Button5.UseVisualStyleBackColor = true;
            this.TextBox11.BackColor = Color.PaleTurquoise;
            this.TextBox11.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(0x4f, 100);
            this.TextBox11.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.TextBox11.Margin = padding2;
            this.TextBox11.Name = "TextBox11";
            this.TextBox11.ReadOnly = true;
            size2 = new Size(0x4a, 20);
            this.TextBox11.Size = size2;
            this.TextBox11.TabIndex = 9;
            this.TextBox12.BackColor = Color.PaleTurquoise;
            this.TextBox12.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(0x33, 100);
            this.TextBox12.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.TextBox12.Margin = padding2;
            this.TextBox12.Name = "TextBox12";
            this.TextBox12.ReadOnly = true;
            size2 = new Size(0x16, 20);
            this.TextBox12.Size = size2;
            this.TextBox12.TabIndex = 8;
            this.TextBox13.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(0x4f, 0x48);
            this.TextBox13.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.TextBox13.Margin = padding2;
            this.TextBox13.Name = "TextBox13";
            size2 = new Size(0x4a, 20);
            this.TextBox13.Size = size2;
            this.TextBox13.TabIndex = 7;
            this.TextBox14.BackColor = Color.PaleTurquoise;
            this.TextBox14.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(0x33, 0x48);
            this.TextBox14.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.TextBox14.Margin = padding2;
            this.TextBox14.Name = "TextBox14";
            this.TextBox14.ReadOnly = true;
            size2 = new Size(0x16, 20);
            this.TextBox14.Size = size2;
            this.TextBox14.TabIndex = 6;
            this.TextBox15.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(0x33, 0x2b);
            this.TextBox15.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.TextBox15.Margin = padding2;
            this.TextBox15.Name = "TextBox15";
            size2 = new Size(150, 20);
            this.TextBox15.Size = size2;
            this.TextBox15.TabIndex = 5;
            this.Label24.AutoSize = true;
            this.Label24.ImeMode = ImeMode.NoControl;
            point2 = new Point(12, 0x68);
            this.Label24.Location = point2;
            this.Label24.Name = "Label24";
            size2 = new Size(0x22, 13);
            this.Label24.Size = size2;
            this.Label24.TabIndex = 4;
            this.Label24.Text = "当前:";
            this.Label25.AutoSize = true;
            this.Label25.ImeMode = ImeMode.NoControl;
            point2 = new Point(12, 0x4a);
            this.Label25.Location = point2;
            this.Label25.Name = "Label25";
            size2 = new Size(0x22, 13);
            this.Label25.Size = size2;
            this.Label25.TabIndex = 3;
            this.Label25.Text = "新增:";
            this.Label26.AutoSize = true;
            this.Label26.ImeMode = ImeMode.NoControl;
            point2 = new Point(12, 0x2e);
            this.Label26.Location = point2;
            this.Label26.Name = "Label26";
            size2 = new Size(0x1f, 13);
            this.Label26.Size = size2;
            this.Label26.TabIndex = 2;
            this.Label26.Text = "标题";
            this.LinkLabel2.ActiveLinkColor = Color.Turquoise;
            this.LinkLabel2.AutoSize = true;
            this.LinkLabel2.ImeMode = ImeMode.NoControl;
            this.LinkLabel2.LinkColor = Color.PaleTurquoise;
            point2 = new Point(0x84, 0x11);
            this.LinkLabel2.Location = point2;
            this.LinkLabel2.Name = "LinkLabel2";
            size2 = new Size(0x4f, 13);
            this.LinkLabel2.Size = size2;
            this.LinkLabel2.TabIndex = 1;
            this.LinkLabel2.TabStop = true;
            this.LinkLabel2.Text = "进入自定名单";
            this.LinkLabel2.VisitedLinkColor = Color.PaleTurquoise;
            this.Label27.AutoSize = true;
            this.Label27.Font = new Font("Segoe UI", 12f);
            this.Label27.ImeMode = ImeMode.NoControl;
            point2 = new Point(7, 11);
            this.Label27.Location = point2;
            this.Label27.Name = "Label27";
            size2 = new Size(0x5f, 0x15);
            this.Label27.Size = size2;
            this.Label27.TabIndex = 0;
            this.Label27.Text = "主发言名单";
            this.Button4.FlatAppearance.BorderSize = 0;
            this.Button4.FlatStyle = FlatStyle.Flat;
            this.Button4.ForeColor = SystemColors.ControlLightLight;
            this.Button4.ImeMode = ImeMode.NoControl;
            point2 = new Point(170, 90);
            this.Button4.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.Button4.Margin = padding2;
            this.Button4.Name = "Button4";
            size2 = new Size(0x2a, 0x19);
            this.Button4.Size = size2;
            this.Button4.TabIndex = 3;
            this.Button4.Text = "清除";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button3.FlatAppearance.BorderSize = 0;
            this.Button3.FlatStyle = FlatStyle.Flat;
            this.Button3.ForeColor = SystemColors.ControlLightLight;
            this.Button3.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x7a, 90);
            this.Button3.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.Button3.Margin = padding2;
            this.Button3.Name = "Button3";
            size2 = new Size(0x2a, 0x19);
            this.Button3.Size = size2;
            this.Button3.TabIndex = 2;
            this.Button3.Text = "开始";
            this.Button3.UseVisualStyleBackColor = true;
            this.Label12.AutoSize = true;
            this.Label12.ForeColor = SystemColors.ControlLightLight;
            this.Label12.ImeMode = ImeMode.NoControl;
            point2 = new Point(9, 0x60);
            this.Label12.Location = point2;
            this.Label12.Name = "Label12";
            size2 = new Size(0x61, 13);
            this.Label12.Size = size2;
            this.Label12.TabIndex = 1;
            this.Label12.Text = "时间: 　　　　秒";
            this.lblcount.AutoSize = true;
            this.lblcount.Font = new Font("Segoe UI", 60f);
            this.lblcount.ForeColor = SystemColors.ControlLightLight;
            this.lblcount.ImeMode = ImeMode.NoControl;
            point2 = new Point(-5, -17);
            this.lblcount.Location = point2;
            this.lblcount.Name = "lblcount";
            size2 = new Size(0xea, 0x6a);
            this.lblcount.Size = size2;
            this.lblcount.TabIndex = 0;
            this.lblcount.Text = "00:00";
            this.panel_sidebar_idle.Dock = DockStyle.Top;
            point2 = new Point(0, 0);
            this.panel_sidebar_idle.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_sidebar_idle.Margin = padding2;
            this.panel_sidebar_idle.Name = "panel_sidebar_idle";
            size2 = new Size(0xd8, 60);
            this.panel_sidebar_idle.Size = size2;
            this.panel_sidebar_idle.TabIndex = 10;
            this.tlp_taskbar.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.tlp_taskbar.ColumnCount = 6;
            this.tlp_taskbar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66867f));
            this.tlp_taskbar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66867f));
            this.tlp_taskbar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66867f));
            this.tlp_taskbar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66867f));
            this.tlp_taskbar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66266f));
            this.tlp_taskbar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66266f));
            this.tlp_taskbar.Controls.Add(this.btn_sessionstart, 0, 0);
            this.tlp_taskbar.Controls.Add(this.btn_speakerslist, 1, 0);
            this.tlp_taskbar.Controls.Add(this.btn_motions, 2, 0);
            this.tlp_taskbar.Controls.Add(this.btn_file, 3, 0);
            this.tlp_taskbar.Controls.Add(this.btn_misc, 4, 0);
            this.tlp_taskbar.Controls.Add(this.btn_system, 5, 0);
            point2 = new Point(0, 0x2a2);
            this.tlp_taskbar.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.tlp_taskbar.Margin = padding2;
            this.tlp_taskbar.Name = "tlp_taskbar";
            this.tlp_taskbar.RowCount = 1;
            this.tlp_taskbar.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            size2 = new Size(0x303, 0x2b);
            this.tlp_taskbar.Size = size2;
            this.tlp_taskbar.TabIndex = 5;
            this.btn_sessionstart.Dock = DockStyle.Fill;
            this.btn_sessionstart.FlatAppearance.BorderSize = 0;
            this.btn_sessionstart.FlatAppearance.MouseDownBackColor = Color.Teal;
            this.btn_sessionstart.FlatAppearance.MouseOverBackColor = Color.PaleTurquoise;
            this.btn_sessionstart.FlatStyle = FlatStyle.Flat;
            this.btn_sessionstart.Font = new Font("Segoe UI", 12f);
            this.btn_sessionstart.ImeMode = ImeMode.NoControl;
            point2 = new Point(3, 4);
            this.btn_sessionstart.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_sessionstart.Margin = padding2;
            this.btn_sessionstart.Name = "btn_sessionstart";
            size2 = new Size(0x7a, 0x23);
            this.btn_sessionstart.Size = size2;
            this.btn_sessionstart.TabIndex = 0;
            this.btn_sessionstart.Text = "会议开始";
            this.btn_sessionstart.UseVisualStyleBackColor = true;
            this.btn_speakerslist.Dock = DockStyle.Fill;
            this.btn_speakerslist.FlatAppearance.BorderSize = 0;
            this.btn_speakerslist.FlatAppearance.MouseDownBackColor = Color.Teal;
            this.btn_speakerslist.FlatAppearance.MouseOverBackColor = Color.PaleTurquoise;
            this.btn_speakerslist.FlatStyle = FlatStyle.Flat;
            this.btn_speakerslist.Font = new Font("Segoe UI", 12f);
            this.btn_speakerslist.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x83, 4);
            this.btn_speakerslist.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_speakerslist.Margin = padding2;
            this.btn_speakerslist.Name = "btn_speakerslist";
            size2 = new Size(0x7a, 0x23);
            this.btn_speakerslist.Size = size2;
            this.btn_speakerslist.TabIndex = 1;
            this.btn_speakerslist.Text = "主发言名单";
            this.btn_speakerslist.UseVisualStyleBackColor = true;
            this.btn_motions.Dock = DockStyle.Fill;
            this.btn_motions.FlatAppearance.BorderSize = 0;
            this.btn_motions.FlatAppearance.MouseDownBackColor = Color.Teal;
            this.btn_motions.FlatAppearance.MouseOverBackColor = Color.PaleTurquoise;
            this.btn_motions.FlatStyle = FlatStyle.Flat;
            this.btn_motions.Font = new Font("Segoe UI", 12f);
            this.btn_motions.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x103, 4);
            this.btn_motions.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_motions.Margin = padding2;
            this.btn_motions.Name = "btn_motions";
            size2 = new Size(0x7a, 0x23);
            this.btn_motions.Size = size2;
            this.btn_motions.TabIndex = 2;
            this.btn_motions.Text = "动议";
            this.btn_motions.UseVisualStyleBackColor = true;
            this.btn_file.Dock = DockStyle.Fill;
            this.btn_file.FlatAppearance.BorderSize = 0;
            this.btn_file.FlatAppearance.MouseDownBackColor = Color.Teal;
            this.btn_file.FlatAppearance.MouseOverBackColor = Color.PaleTurquoise;
            this.btn_file.FlatStyle = FlatStyle.Flat;
            this.btn_file.Font = new Font("Segoe UI", 12f);
            this.btn_file.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x183, 4);
            this.btn_file.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_file.Margin = padding2;
            this.btn_file.Name = "btn_file";
            size2 = new Size(0x7a, 0x23);
            this.btn_file.Size = size2;
            this.btn_file.TabIndex = 3;
            this.btn_file.Text = "文件";
            this.btn_file.UseVisualStyleBackColor = true;
            this.btn_misc.Dock = DockStyle.Fill;
            this.btn_misc.FlatAppearance.BorderSize = 0;
            this.btn_misc.FlatAppearance.MouseDownBackColor = Color.Teal;
            this.btn_misc.FlatAppearance.MouseOverBackColor = Color.PaleTurquoise;
            this.btn_misc.FlatStyle = FlatStyle.Flat;
            this.btn_misc.Font = new Font("Segoe UI", 12f);
            this.btn_misc.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x203, 4);
            this.btn_misc.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_misc.Margin = padding2;
            this.btn_misc.Name = "btn_misc";
            size2 = new Size(0x7a, 0x23);
            this.btn_misc.Size = size2;
            this.btn_misc.TabIndex = 4;
            this.btn_misc.Text = "杂项";
            this.btn_misc.UseVisualStyleBackColor = true;
            this.btn_system.Dock = DockStyle.Fill;
            this.btn_system.FlatAppearance.BorderSize = 0;
            this.btn_system.FlatAppearance.MouseDownBackColor = Color.Teal;
            this.btn_system.FlatAppearance.MouseOverBackColor = Color.PaleTurquoise;
            this.btn_system.FlatStyle = FlatStyle.Flat;
            this.btn_system.Font = new Font("Segoe UI", 12f);
            this.btn_system.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x283, 4);
            this.btn_system.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_system.Margin = padding2;
            this.btn_system.Name = "btn_system";
            size2 = new Size(0x7d, 0x23);
            this.btn_system.Size = size2;
            this.btn_system.TabIndex = 5;
            this.btn_system.Text = "系统";
            this.btn_system.UseVisualStyleBackColor = true;
            this.cbx_fmode.BackColor = Color.Teal;
            this.cbx_fmode.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbx_fmode.FlatStyle = FlatStyle.Flat;
            this.cbx_fmode.ForeColor = SystemColors.Window;
            this.cbx_fmode.FormattingEnabled = true;
            this.cbx_fmode.Items.AddRange(new object[] { "请选择功能项", "发布新文件", "介绍文件", "对文件投票", "发布危机" });
            point2 = new Point(0xa89, 0x1b);
            this.cbx_fmode.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.cbx_fmode.Margin = padding2;
            this.cbx_fmode.Name = "cbx_fmode";
            size2 = new Size(0xb8, 0x15);
            this.cbx_fmode.Size = size2;
            this.cbx_fmode.TabIndex = 3;
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 50;
            this.panel_manage.Controls.Add(this.chk_rule_1);
            this.panel_manage.Controls.Add(this.Label203);
            this.panel_manage.Controls.Add(this.btn_fontchange);
            this.panel_manage.Controls.Add(this.Label169);
            this.panel_manage.Controls.Add(this.GroupBox1);
            this.panel_manage.Controls.Add(this.btn_sfx4);
            this.panel_manage.Controls.Add(this.btn_sfx3);
            this.panel_manage.Controls.Add(this.btn_sfx2);
            this.panel_manage.Controls.Add(this.btn_sfx1);
            this.panel_manage.Controls.Add(this.num_timeleft);
            this.panel_manage.Controls.Add(this.txt_sfx4);
            this.panel_manage.Controls.Add(this.txt_sfx3);
            this.panel_manage.Controls.Add(this.txt_sfx2);
            this.panel_manage.Controls.Add(this.txt_sfx1);
            this.panel_manage.Controls.Add(this.chk_sfx_start);
            this.panel_manage.Controls.Add(this.chk_sfx_time60);
            this.panel_manage.Controls.Add(this.chk_sfx_time20);
            this.panel_manage.Controls.Add(this.chk_sfx_timeout);
            this.panel_manage.Controls.Add(this.chk_is_mainimg);
            this.panel_manage.Controls.Add(this.Panel4);
            this.panel_manage.Controls.Add(this.btn_backbrowse);
            this.panel_manage.Controls.Add(this.btn_bannerbrowse);
            this.panel_manage.Controls.Add(this.txt_mainimg);
            this.panel_manage.Controls.Add(this.txt_startimg);
            this.panel_manage.Controls.Add(this.Label172);
            this.panel_manage.Controls.Add(this.Label170);
            this.panel_manage.Controls.Add(this.Label9);
            this.panel_manage.Controls.Add(this.Label6);
            this.panel_manage.Controls.Add(this.tlp_manage_top);
            this.panel_manage.Controls.Add(this.rad_pink);
            this.panel_manage.Controls.Add(this.rad_purple);
            this.panel_manage.Controls.Add(this.rad_blue);
            this.panel_manage.Controls.Add(this.rad_teal);
            this.panel_manage.Controls.Add(this.rad_green);
            this.panel_manage.Controls.Add(this.rad_orange);
            this.panel_manage.Controls.Add(this.rad_darkred);
            this.panel_manage.Controls.Add(this.Label171);
            point2 = new Point(0x237, 0x288);
            this.panel_manage.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_manage.Margin = padding2;
            this.panel_manage.Name = "panel_manage";
            size2 = new Size(0x3f2, 0x2f6);
            this.panel_manage.Size = size2;
            this.panel_manage.TabIndex = 4;
            this.panel_manage.Visible = false;
            this.chk_rule_1.AutoSize = true;
            point2 = new Point(0x170, 470);
            this.chk_rule_1.Location = point2;
            this.chk_rule_1.Name = "chk_rule_1";
            size2 = new Size(0xe2, 0x11);
            this.chk_rule_1.Size = size2;
            this.chk_rule_1.TabIndex = 0x27;
            this.chk_rule_1.Text = "当出席国家少于点名时80%时中断会议";
            this.chk_rule_1.UseVisualStyleBackColor = true;
            this.Label203.AutoSize = true;
            this.Label203.Font = new Font("Segoe UI", 12f);
            point2 = new Point(0x161, 0x1b9);
            this.Label203.Location = point2;
            this.Label203.Name = "Label203";
            size2 = new Size(0x4e, 0x15);
            this.Label203.Size = size2;
            this.Label203.TabIndex = 0x26;
            this.Label203.Text = "规则流程";
            this.btn_fontchange.BackColor = Color.PaleTurquoise;
            this.btn_fontchange.FlatAppearance.BorderSize = 0;
            this.btn_fontchange.FlatStyle = FlatStyle.Flat;
            point2 = new Point(0x42, 0x169);
            this.btn_fontchange.Location = point2;
            this.btn_fontchange.Name = "btn_fontchange";
            size2 = new Size(0xf9, 30);
            this.btn_fontchange.Size = size2;
            this.btn_fontchange.TabIndex = 0x25;
            this.btn_fontchange.Text = "点击这里更改";
            this.btn_fontchange.UseVisualStyleBackColor = false;
            this.Label169.AutoSize = true;
            point2 = new Point(0x40, 0x152);
            this.Label169.Location = point2;
            this.Label169.Name = "Label169";
            size2 = new Size(0x61, 13);
            this.Label169.Size = size2;
            this.Label169.TabIndex = 0x24;
            this.Label169.Text = "更改主界面字体: ";
            this.GroupBox1.Controls.Add(this.txt_fontpreview);
            point2 = new Point(0x43, 0x18f);
            this.GroupBox1.Location = point2;
            this.GroupBox1.Name = "GroupBox1";
            size2 = new Size(0xf8, 0xad);
            this.GroupBox1.Size = size2;
            this.GroupBox1.TabIndex = 0x23;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "预览";
            this.txt_fontpreview.BorderStyle = BorderStyle.None;
            this.txt_fontpreview.Dock = DockStyle.Fill;
            this.txt_fontpreview.Font = new Font("Segoe UI", 20.25f);
            point2 = new Point(3, 0x10);
            this.txt_fontpreview.Location = point2;
            this.txt_fontpreview.Multiline = true;
            this.txt_fontpreview.Name = "txt_fontpreview";
            size2 = new Size(0xf2, 0x9a);
            this.txt_fontpreview.Size = size2;
            this.txt_fontpreview.TabIndex = 0;
            this.txt_fontpreview.Text = "对决议草案0.1进行投票 Vote for Draft Resolution 0.1";
            this.btn_sfx4.BackColor = Color.PaleTurquoise;
            this.btn_sfx4.FlatAppearance.BorderSize = 0;
            this.btn_sfx4.FlatStyle = FlatStyle.Flat;
            this.btn_sfx4.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x231, 0x18f);
            this.btn_sfx4.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_sfx4.Margin = padding2;
            this.btn_sfx4.Name = "btn_sfx4";
            size2 = new Size(0x38, 0x15);
            this.btn_sfx4.Size = size2;
            this.btn_sfx4.TabIndex = 0x22;
            this.btn_sfx4.Text = "浏览...";
            this.btn_sfx4.UseVisualStyleBackColor = false;
            this.btn_sfx3.BackColor = Color.PaleTurquoise;
            this.btn_sfx3.FlatAppearance.BorderSize = 0;
            this.btn_sfx3.FlatStyle = FlatStyle.Flat;
            this.btn_sfx3.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x231, 330);
            this.btn_sfx3.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_sfx3.Margin = padding2;
            this.btn_sfx3.Name = "btn_sfx3";
            size2 = new Size(0x38, 0x15);
            this.btn_sfx3.Size = size2;
            this.btn_sfx3.TabIndex = 0x21;
            this.btn_sfx3.Text = "浏览...";
            this.btn_sfx3.UseVisualStyleBackColor = false;
            this.btn_sfx2.BackColor = Color.PaleTurquoise;
            this.btn_sfx2.FlatAppearance.BorderSize = 0;
            this.btn_sfx2.FlatStyle = FlatStyle.Flat;
            this.btn_sfx2.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x231, 0xef);
            this.btn_sfx2.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_sfx2.Margin = padding2;
            this.btn_sfx2.Name = "btn_sfx2";
            size2 = new Size(0x38, 0x15);
            this.btn_sfx2.Size = size2;
            this.btn_sfx2.TabIndex = 0x20;
            this.btn_sfx2.Text = "浏览...";
            this.btn_sfx2.UseVisualStyleBackColor = false;
            this.btn_sfx1.BackColor = Color.PaleTurquoise;
            this.btn_sfx1.FlatAppearance.BorderSize = 0;
            this.btn_sfx1.FlatStyle = FlatStyle.Flat;
            this.btn_sfx1.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x231, 0xbb);
            this.btn_sfx1.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_sfx1.Margin = padding2;
            this.btn_sfx1.Name = "btn_sfx1";
            size2 = new Size(0x38, 0x15);
            this.btn_sfx1.Size = size2;
            this.btn_sfx1.TabIndex = 0x1f;
            this.btn_sfx1.Text = "浏览...";
            this.btn_sfx1.UseVisualStyleBackColor = false;
            this.num_timeleft.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(0x1a1, 0x10d);
            this.num_timeleft.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.num_timeleft.Margin = padding2;
            num = new decimal(new int[] { 60, 0, 0, 0 });
            this.num_timeleft.Maximum = num;
            num = new decimal(new int[] { 5, 0, 0, 0 });
            this.num_timeleft.Minimum = num;
            this.num_timeleft.Name = "num_timeleft";
            size2 = new Size(0x27, 20);
            this.num_timeleft.Size = size2;
            this.num_timeleft.TabIndex = 0x1c;
            num = new decimal(new int[] { 20, 0, 0, 0 });
            this.num_timeleft.Value = num;
            this.txt_sfx4.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(0x173, 0x18f);
            this.txt_sfx4.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.txt_sfx4.Margin = padding2;
            this.txt_sfx4.Name = "txt_sfx4";
            size2 = new Size(0xb8, 20);
            this.txt_sfx4.Size = size2;
            this.txt_sfx4.TabIndex = 0x1b;
            this.txt_sfx4.Text = @"sounds\oosaka_loop.wav";
            this.txt_sfx3.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(0x173, 0x14c);
            this.txt_sfx3.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.txt_sfx3.Margin = padding2;
            this.txt_sfx3.Name = "txt_sfx3";
            size2 = new Size(0xb8, 20);
            this.txt_sfx3.Size = size2;
            this.txt_sfx3.TabIndex = 0x1a;
            this.txt_sfx3.Text = @"sounds\twilight.wav";
            this.txt_sfx2.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(0x173, 0xef);
            this.txt_sfx2.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.txt_sfx2.Margin = padding2;
            this.txt_sfx2.Name = "txt_sfx2";
            size2 = new Size(0xb8, 20);
            this.txt_sfx2.Size = size2;
            this.txt_sfx2.TabIndex = 0x19;
            this.txt_sfx2.Text = @"sounds\buzzer.wav";
            this.txt_sfx1.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(0x173, 0xbb);
            this.txt_sfx1.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.txt_sfx1.Margin = padding2;
            this.txt_sfx1.Name = "txt_sfx1";
            size2 = new Size(0xb8, 20);
            this.txt_sfx1.Size = size2;
            this.txt_sfx1.TabIndex = 0x18;
            this.txt_sfx1.Text = @"sounds\E233-231-531.wav";
            this.chk_sfx_start.AutoSize = true;
            this.chk_sfx_start.CheckAlign = ContentAlignment.TopLeft;
            this.chk_sfx_start.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x170, 0x169);
            this.chk_sfx_start.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.chk_sfx_start.Margin = padding2;
            this.chk_sfx_start.Name = "chk_sfx_start";
            size2 = new Size(0xc0, 30);
            this.chk_sfx_start.Size = size2;
            this.chk_sfx_start.TabIndex = 0x17;
            this.chk_sfx_start.Text = "播放会议开始提示音\r\n（仅在选择\"定时开始\"时有效）";
            this.chk_sfx_start.UseVisualStyleBackColor = true;
            this.chk_sfx_time60.AutoSize = true;
            this.chk_sfx_time60.CheckAlign = ContentAlignment.TopLeft;
            this.chk_sfx_time60.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x170, 0x12a);
            this.chk_sfx_time60.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.chk_sfx_time60.Margin = padding2;
            this.chk_sfx_time60.Name = "chk_sfx_time60";
            size2 = new Size(0x116, 30);
            this.chk_sfx_time60.Size = size2;
            this.chk_sfx_time60.TabIndex = 0x16;
            this.chk_sfx_time60.Text = "播放自由磋商铃音\r\n(选中后，将在自由磋商剩余1分钟时播放提示音)";
            this.chk_sfx_time60.UseVisualStyleBackColor = true;
            this.chk_sfx_time20.AutoSize = true;
            this.chk_sfx_time20.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x170, 0xd8);
            this.chk_sfx_time20.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.chk_sfx_time20.Margin = padding2;
            this.chk_sfx_time20.Name = "chk_sfx_time20";
            size2 = new Size(0x86, 0x11);
            this.chk_sfx_time20.Size = size2;
            this.chk_sfx_time20.TabIndex = 0x15;
            this.chk_sfx_time20.Text = "播放剩余时间确认音";
            this.chk_sfx_time20.UseVisualStyleBackColor = true;
            this.chk_sfx_timeout.AutoSize = true;
            this.chk_sfx_timeout.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x170, 0xa3);
            this.chk_sfx_timeout.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.chk_sfx_timeout.Margin = padding2;
            this.chk_sfx_timeout.Name = "chk_sfx_timeout";
            size2 = new Size(0x92, 0x11);
            this.chk_sfx_timeout.Size = size2;
            this.chk_sfx_timeout.TabIndex = 20;
            this.chk_sfx_timeout.Text = "播放计时器到时提示音";
            this.chk_sfx_timeout.UseVisualStyleBackColor = true;
            this.chk_is_mainimg.AutoSize = true;
            this.chk_is_mainimg.Checked = true;
            this.chk_is_mainimg.CheckState = CheckState.Checked;
            this.chk_is_mainimg.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x42, 0xd4);
            this.chk_is_mainimg.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.chk_is_mainimg.Margin = padding2;
            this.chk_is_mainimg.Name = "chk_is_mainimg";
            size2 = new Size(0x71, 0x11);
            this.chk_is_mainimg.Size = size2;
            this.chk_is_mainimg.TabIndex = 0x13;
            this.chk_is_mainimg.Text = "使用主界面底图:";
            this.chk_is_mainimg.UseVisualStyleBackColor = true;
            this.chk_is_mainimg.Visible = false;
            this.Panel4.Controls.Add(this.btn_manage_exit);
            this.Panel4.Controls.Add(this.btn_manage_save);
            this.Panel4.Dock = DockStyle.Bottom;
            this.Panel4.Font = new Font("Segoe UI", 12f);
            point2 = new Point(0, 0x2ae);
            this.Panel4.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.Panel4.Margin = padding2;
            this.Panel4.Name = "Panel4";
            size2 = new Size(0x3f2, 0x48);
            this.Panel4.Size = size2;
            this.Panel4.TabIndex = 0x12;
            this.btn_manage_exit.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            this.btn_manage_exit.FlatAppearance.BorderSize = 0;
            this.btn_manage_exit.FlatAppearance.MouseDownBackColor = Color.PaleTurquoise;
            this.btn_manage_exit.FlatStyle = FlatStyle.Flat;
            this.btn_manage_exit.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x378, 0x16);
            this.btn_manage_exit.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_manage_exit.Margin = padding2;
            this.btn_manage_exit.Name = "btn_manage_exit";
            size2 = new Size(0x63, 0x1f);
            this.btn_manage_exit.Size = size2;
            this.btn_manage_exit.TabIndex = 1;
            this.btn_manage_exit.Text = "返回";
            this.btn_manage_exit.UseVisualStyleBackColor = true;
            this.btn_manage_save.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            this.btn_manage_save.BackColor = Color.Teal;
            this.btn_manage_save.FlatAppearance.BorderSize = 0;
            this.btn_manage_save.FlatStyle = FlatStyle.Flat;
            this.btn_manage_save.ForeColor = SystemColors.ControlLightLight;
            this.btn_manage_save.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x2ff, 0x16);
            this.btn_manage_save.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_manage_save.Margin = padding2;
            this.btn_manage_save.Name = "btn_manage_save";
            size2 = new Size(0x63, 0x1f);
            this.btn_manage_save.Size = size2;
            this.btn_manage_save.TabIndex = 0;
            this.btn_manage_save.Text = "保存设置";
            this.btn_manage_save.UseVisualStyleBackColor = false;
            this.btn_backbrowse.BackColor = Color.PaleTurquoise;
            this.btn_backbrowse.FlatAppearance.BorderSize = 0;
            this.btn_backbrowse.FlatStyle = FlatStyle.Flat;
            this.btn_backbrowse.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x103, 0xe8);
            this.btn_backbrowse.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_backbrowse.Margin = padding2;
            this.btn_backbrowse.Name = "btn_backbrowse";
            size2 = new Size(0x38, 0x15);
            this.btn_backbrowse.Size = size2;
            this.btn_backbrowse.TabIndex = 0x11;
            this.btn_backbrowse.Text = "浏览...";
            this.btn_backbrowse.UseVisualStyleBackColor = false;
            this.btn_backbrowse.Visible = false;
            this.btn_bannerbrowse.BackColor = Color.PaleTurquoise;
            this.btn_bannerbrowse.FlatAppearance.BorderSize = 0;
            this.btn_bannerbrowse.FlatStyle = FlatStyle.Flat;
            this.btn_bannerbrowse.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x103, 0xb5);
            this.btn_bannerbrowse.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.btn_bannerbrowse.Margin = padding2;
            this.btn_bannerbrowse.Name = "btn_bannerbrowse";
            size2 = new Size(0x38, 0x15);
            this.btn_bannerbrowse.Size = size2;
            this.btn_bannerbrowse.TabIndex = 0x10;
            this.btn_bannerbrowse.Text = "浏览...";
            this.btn_bannerbrowse.UseVisualStyleBackColor = false;
            this.txt_mainimg.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(0x42, 0xe8);
            this.txt_mainimg.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.txt_mainimg.Margin = padding2;
            this.txt_mainimg.Name = "txt_mainimg";
            size2 = new Size(0xbb, 20);
            this.txt_mainimg.Size = size2;
            this.txt_mainimg.TabIndex = 15;
            this.txt_mainimg.Visible = false;
            this.txt_startimg.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(0x42, 0xb5);
            this.txt_startimg.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.txt_startimg.Margin = padding2;
            this.txt_startimg.Name = "txt_startimg";
            size2 = new Size(0xbb, 20);
            this.txt_startimg.Size = size2;
            this.txt_startimg.TabIndex = 14;
            this.txt_startimg.Text = @"ui\banner.jpg";
            this.Label172.AutoSize = true;
            this.Label172.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x40, 0x109);
            this.Label172.Location = point2;
            this.Label172.Name = "Label172";
            size2 = new Size(0x3a, 13);
            this.Label172.Size = size2;
            this.Label172.TabIndex = 13;
            this.Label172.Text = "界面颜色:";
            this.Label170.AutoSize = true;
            this.Label170.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x40, 0xa3);
            this.Label170.Location = point2;
            this.Label170.Name = "Label170";
            size2 = new Size(70, 13);
            this.Label170.Size = size2;
            this.Label170.TabIndex = 11;
            this.Label170.Text = "起始页图片:";
            this.Label9.AutoSize = true;
            this.Label9.Font = new Font("Segoe UI", 12f);
            this.Label9.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x161, 130);
            this.Label9.Location = point2;
            this.Label9.Name = "Label9";
            size2 = new Size(0x2c, 0x15);
            this.Label9.Size = size2;
            this.Label9.TabIndex = 2;
            this.Label9.Text = "音效";
            this.Label6.AutoSize = true;
            this.Label6.Font = new Font("Segoe UI", 12f);
            this.Label6.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x33, 130);
            this.Label6.Location = point2;
            this.Label6.Name = "Label6";
            size2 = new Size(0x2c, 0x15);
            this.Label6.Size = size2;
            this.Label6.TabIndex = 1;
            this.Label6.Text = "外观";
            this.tlp_manage_top.BackColor = Color.Teal;
            this.tlp_manage_top.ColumnCount = 9;
            this.tlp_manage_top.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20f));
            this.tlp_manage_top.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170f));
            this.tlp_manage_top.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10f));
            this.tlp_manage_top.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170f));
            this.tlp_manage_top.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10f));
            this.tlp_manage_top.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100f));
            this.tlp_manage_top.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            this.tlp_manage_top.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220f));
            this.tlp_manage_top.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20f));
            this.tlp_manage_top.Controls.Add(this.lbl_manage_setting, 1, 1);
            this.tlp_manage_top.Controls.Add(this.lblinfo, 7, 1);
            this.tlp_manage_top.Controls.Add(this.lbl_manage_conferences, 3, 1);
            this.tlp_manage_top.Controls.Add(this.lbl_manage_about, 5, 1);
            this.tlp_manage_top.Dock = DockStyle.Top;
            this.tlp_manage_top.Font = new Font("Segoe UI", 9f);
            this.tlp_manage_top.ForeColor = SystemColors.ControlLightLight;
            point2 = new Point(0, 0);
            this.tlp_manage_top.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.tlp_manage_top.Margin = padding2;
            this.tlp_manage_top.Name = "tlp_manage_top";
            this.tlp_manage_top.RowCount = 3;
            this.tlp_manage_top.RowStyles.Add(new RowStyle(SizeType.Percent, 40f));
            this.tlp_manage_top.RowStyles.Add(new RowStyle(SizeType.Percent, 60f));
            this.tlp_manage_top.RowStyles.Add(new RowStyle(SizeType.Absolute, 11f));
            size2 = new Size(0x3f2, 0x60);
            this.tlp_manage_top.Size = size2;
            this.tlp_manage_top.TabIndex = 0;
            this.lbl_manage_setting.AutoSize = true;
            this.lbl_manage_setting.Font = new Font("Segoe UI", 24f);
            this.lbl_manage_setting.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x17, 0x22);
            this.lbl_manage_setting.Location = point2;
            this.lbl_manage_setting.Name = "lbl_manage_setting";
            size2 = new Size(0x98, 0x2d);
            this.lbl_manage_setting.Size = size2;
            this.lbl_manage_setting.TabIndex = 0;
            this.lbl_manage_setting.Text = "系统设置";
            this.lblinfo.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            this.lblinfo.AutoSize = true;
            this.lblinfo.Font = new Font("Segoe UI", 12f);
            this.lblinfo.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x306, 0x2b);
            this.lblinfo.Location = point2;
            this.lblinfo.Name = "lblinfo";
            size2 = new Size(0xd5, 0x2a);
            this.lblinfo.Size = size2;
            this.lblinfo.TabIndex = 1;
            this.lblinfo.Text = "inQubator Ver 2.01 build 331\r\n2014-12-19 12:08:10";
            this.lblinfo.TextAlign = ContentAlignment.TopRight;
            this.lbl_manage_conferences.AutoSize = true;
            this.lbl_manage_conferences.Font = new Font("Segoe UI", 24f);
            this.lbl_manage_conferences.ForeColor = Color.PaleTurquoise;
            this.lbl_manage_conferences.ImeMode = ImeMode.NoControl;
            point2 = new Point(0xcb, 0x22);
            this.lbl_manage_conferences.Location = point2;
            this.lbl_manage_conferences.Name = "lbl_manage_conferences";
            size2 = new Size(0x98, 0x2d);
            this.lbl_manage_conferences.Size = size2;
            this.lbl_manage_conferences.TabIndex = 2;
            this.lbl_manage_conferences.Text = "会议管理";
            this.lbl_manage_conferences.Visible = false;
            this.lbl_manage_about.AutoSize = true;
            this.lbl_manage_about.Font = new Font("Segoe UI", 24f);
            this.lbl_manage_about.ForeColor = Color.PaleTurquoise;
            this.lbl_manage_about.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x17f, 0x22);
            this.lbl_manage_about.Location = point2;
            this.lbl_manage_about.Name = "lbl_manage_about";
            size2 = new Size(0x56, 0x2d);
            this.lbl_manage_about.Size = size2;
            this.lbl_manage_about.TabIndex = 3;
            this.lbl_manage_about.Text = "关于";
            this.lbl_manage_about.Visible = false;
            this.rad_pink.Appearance = Appearance.Button;
            this.rad_pink.BackColor = Color.White;
            this.rad_pink.BackgroundImage = (Image) manager.GetObject("rad_pink.BackgroundImage");
            this.rad_pink.BackgroundImageLayout = ImageLayout.Center;
            this.rad_pink.FlatAppearance.BorderSize = 0;
            this.rad_pink.FlatStyle = FlatStyle.Flat;
            this.rad_pink.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x11a, 0x11a);
            this.rad_pink.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.rad_pink.Margin = padding2;
            this.rad_pink.Name = "rad_pink";
            size2 = new Size(0x24, 0x27);
            this.rad_pink.Size = size2;
            this.rad_pink.TabIndex = 10;
            this.rad_pink.UseVisualStyleBackColor = false;
            this.rad_purple.Appearance = Appearance.Button;
            this.rad_purple.BackColor = Color.White;
            this.rad_purple.BackgroundImage = (Image) manager.GetObject("rad_purple.BackgroundImage");
            this.rad_purple.BackgroundImageLayout = ImageLayout.Center;
            this.rad_purple.FlatAppearance.BorderSize = 0;
            this.rad_purple.FlatStyle = FlatStyle.Flat;
            this.rad_purple.ImeMode = ImeMode.NoControl;
            point2 = new Point(0xf6, 0x11a);
            this.rad_purple.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.rad_purple.Margin = padding2;
            this.rad_purple.Name = "rad_purple";
            size2 = new Size(0x24, 0x27);
            this.rad_purple.Size = size2;
            this.rad_purple.TabIndex = 9;
            this.rad_purple.UseVisualStyleBackColor = false;
            this.rad_blue.Appearance = Appearance.Button;
            this.rad_blue.BackColor = Color.White;
            this.rad_blue.BackgroundImage = (Image) manager.GetObject("rad_blue.BackgroundImage");
            this.rad_blue.BackgroundImageLayout = ImageLayout.Center;
            this.rad_blue.FlatAppearance.BorderSize = 0;
            this.rad_blue.FlatStyle = FlatStyle.Flat;
            this.rad_blue.ImeMode = ImeMode.NoControl;
            point2 = new Point(210, 0x11a);
            this.rad_blue.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.rad_blue.Margin = padding2;
            this.rad_blue.Name = "rad_blue";
            size2 = new Size(0x24, 0x27);
            this.rad_blue.Size = size2;
            this.rad_blue.TabIndex = 8;
            this.rad_blue.UseVisualStyleBackColor = false;
            this.rad_teal.Appearance = Appearance.Button;
            this.rad_teal.BackColor = Color.White;
            this.rad_teal.BackgroundImage = (Image) manager.GetObject("rad_teal.BackgroundImage");
            this.rad_teal.BackgroundImageLayout = ImageLayout.Center;
            this.rad_teal.Checked = true;
            this.rad_teal.FlatAppearance.BorderSize = 0;
            this.rad_teal.FlatStyle = FlatStyle.Flat;
            this.rad_teal.ImeMode = ImeMode.NoControl;
            point2 = new Point(0xae, 0x11a);
            this.rad_teal.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.rad_teal.Margin = padding2;
            this.rad_teal.Name = "rad_teal";
            size2 = new Size(0x24, 0x27);
            this.rad_teal.Size = size2;
            this.rad_teal.TabIndex = 7;
            this.rad_teal.TabStop = true;
            this.rad_teal.UseVisualStyleBackColor = false;
            this.rad_green.Appearance = Appearance.Button;
            this.rad_green.BackColor = Color.White;
            this.rad_green.BackgroundImage = (Image) manager.GetObject("rad_green.BackgroundImage");
            this.rad_green.BackgroundImageLayout = ImageLayout.Center;
            this.rad_green.FlatAppearance.BorderSize = 0;
            this.rad_green.FlatStyle = FlatStyle.Flat;
            this.rad_green.ForeColor = Color.DarkGreen;
            this.rad_green.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x8a, 0x11a);
            this.rad_green.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.rad_green.Margin = padding2;
            this.rad_green.Name = "rad_green";
            size2 = new Size(0x24, 0x27);
            this.rad_green.Size = size2;
            this.rad_green.TabIndex = 6;
            this.rad_green.UseVisualStyleBackColor = false;
            this.rad_orange.Appearance = Appearance.Button;
            this.rad_orange.BackColor = Color.White;
            this.rad_orange.BackgroundImage = (Image) manager.GetObject("rad_orange.BackgroundImage");
            this.rad_orange.BackgroundImageLayout = ImageLayout.Center;
            this.rad_orange.FlatAppearance.BorderSize = 0;
            this.rad_orange.FlatStyle = FlatStyle.Flat;
            this.rad_orange.ForeColor = Color.SaddleBrown;
            this.rad_orange.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x66, 0x11a);
            this.rad_orange.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.rad_orange.Margin = padding2;
            this.rad_orange.Name = "rad_orange";
            size2 = new Size(0x24, 0x27);
            this.rad_orange.Size = size2;
            this.rad_orange.TabIndex = 5;
            this.rad_orange.UseVisualStyleBackColor = false;
            this.rad_darkred.Appearance = Appearance.Button;
            this.rad_darkred.BackColor = SystemColors.ControlLightLight;
            this.rad_darkred.BackgroundImage = (Image) manager.GetObject("rad_darkred.BackgroundImage");
            this.rad_darkred.BackgroundImageLayout = ImageLayout.Center;
            this.rad_darkred.FlatAppearance.BorderSize = 0;
            this.rad_darkred.FlatStyle = FlatStyle.Flat;
            this.rad_darkred.ForeColor = Color.DarkRed;
            this.rad_darkred.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x42, 0x11a);
            this.rad_darkred.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.rad_darkred.Margin = padding2;
            this.rad_darkred.Name = "rad_darkred";
            size2 = new Size(0x24, 0x27);
            this.rad_darkred.Size = size2;
            this.rad_darkred.TabIndex = 4;
            this.rad_darkred.UseVisualStyleBackColor = false;
            this.Label171.AutoSize = true;
            this.Label171.ImeMode = ImeMode.NoControl;
            point2 = new Point(0x181, 0x110);
            this.Label171.Location = point2;
            this.Label171.Name = "Label171";
            size2 = new Size(0x8b, 13);
            this.Label171.Size = size2;
            this.Label171.TabIndex = 0x1d;
            this.Label171.Text = "剩余　　　　秒时提示。";
            this.ofd_banner.Filter = "图像文件 (*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png)|*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png|所有文件 (*.*)|*.* ";
            this.ofd_banner.InitialDirectory = @"ui\";
            this.ofd_banner.Title = "选择起始页图片";
            this.ofd_sfx.Filter = "波形声音 (*.wav)|*.wav";
            this.ofd_sfx.InitialDirectory = @"sounds\";
            point2 = new Point(0x870, 0x36);
            this.panel_m_5.Location = point2;
            padding2 = new Padding(3, 4, 3, 4);
            this.panel_m_5.Margin = padding2;
            this.panel_m_5.Name = "panel_m_5";
            size2 = new Size(0xd8, 0);
            this.panel_m_5.Size = size2;
            this.panel_m_5.TabIndex = 8;
            this.panel_m_5.Visible = false;
            this.ofd_doc.Filter = "Microsoft Word Document (*.doc;*.docx)|*.doc;*.docx";
            this.ofd_csl.Filter = "自定发言名单列表 (*.csl.txt)|*.csl.txt";
            this.sfd_csl.Filter = "自定发言名单列表 (*.csl.txt)|*.csl.txt";
            this.NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            this.NotifyIcon1.Icon = (Icon) manager.GetObject("NotifyIcon1.Icon");
            this.NotifyIcon1.Text = "Console";
            this.NotifyIcon1.Visible = true;
            this.btn_votectrl.Enabled = false;
            point2 = new Point(-64, -36);
            this.btn_votectrl.Location = point2;
            this.btn_votectrl.Name = "btn_votectrl";
            size2 = new Size(0x4b, 0x19);
            this.btn_votectrl.Size = size2;
            this.btn_votectrl.TabIndex = 9;
            this.btn_votectrl.Text = "Button6";
            this.btn_votectrl.UseVisualStyleBackColor = true;
            SizeF ef2 = new SizeF(6f, 13f);
            this.AutoScaleDimensions = ef2;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.BackColor = Color.White;
            size2 = new Size(0x3f2, 0x2ed);
            this.ClientSize = size2;
            this.Controls.Add(this.btn_votectrl);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_welcome);
            this.Controls.Add(this.panel_manage);
            this.Controls.Add(this.panel_m_5);
            this.Controls.Add(this.cbx_fmode);
            padding2 = new Padding(3, 4, 3, 4);
            this.Margin = padding2;
            size2 = new Size(0x402, 0x2d6);
            this.MinimumSize = size2;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Console";
            this.WindowState = FormWindowState.Maximized;
            this.panel_welcome.ResumeLayout(false);
            this.panel_velcome_new.ResumeLayout(false);
            this.panel_velcome_new.PerformLayout();
            this.panel_modesel.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.Panel2.ResumeLayout(false);
            ((ISupportInitialize) this.PictureBox1).EndInit();
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.tlp_taskbar2.ResumeLayout(false);
            this.panel_main_screen.ResumeLayout(false);
            this.panel_main_screen.PerformLayout();
            this.tlp_screenlist.ResumeLayout(false);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.panel_main_title.ResumeLayout(false);
            this.TableLayoutPanel2.ResumeLayout(false);
            this.panel_main_sidebar.ResumeLayout(false);
            this.panel_dbq.ResumeLayout(false);
            this.panel_dbq.PerformLayout();
            this.num_dbqtime.EndInit();
            this.panel_readfile.ResumeLayout(false);
            this.panel_readfile.PerformLayout();
            this.panel_introtask.ResumeLayout(false);
            this.panel_introtask.PerformLayout();
            this.panel_mcedit.ResumeLayout(false);
            this.panel_mcedit.PerformLayout();
            this.num_mcnumber.EndInit();
            this.panel_files.ResumeLayout(false);
            this.panel_file_bottom.ResumeLayout(false);
            this.panel_files_5.ResumeLayout(false);
            this.panel_f_5.ResumeLayout(false);
            this.panel_f_5.PerformLayout();
            this.num_fdl_ddm.EndInit();
            this.num_fdl_ddh.EndInit();
            this.num_fdl_amm.EndInit();
            this.num_fdl_amh.EndInit();
            this.num_fdl_drm.EndInit();
            this.num_fdl_drh.EndInit();
            this.panel_files_4.ResumeLayout(false);
            this.panel_f_4.ResumeLayout(false);
            this.panel_f_4.PerformLayout();
            this.num_crisis.EndInit();
            this.panel_files_3.ResumeLayout(false);
            this.panel_f_3.ResumeLayout(false);
            this.panel_f_3.PerformLayout();
            this.panel_file_2.ResumeLayout(false);
            this.panel_f_2.ResumeLayout(false);
            this.panel_f_2.PerformLayout();
            this.num_intro.EndInit();
            this.panel_file_1.ResumeLayout(false);
            this.panel_selfile.ResumeLayout(false);
            this.panel_selfile.PerformLayout();
            this.panel_signatories.ResumeLayout(false);
            this.panel_signatories.PerformLayout();
            this.panel_sponsors.ResumeLayout(false);
            this.panel_sponsors.PerformLayout();
            this.panel_f_1.ResumeLayout(false);
            this.panel_f_1.PerformLayout();
            this.num_file.EndInit();
            this.panel_file_top.ResumeLayout(false);
            this.panel_file_top.PerformLayout();
            this.panel_misc.ResumeLayout(false);
            this.panel_misc_bottom.ResumeLayout(false);
            this.panel_misc_5.ResumeLayout(false);
            this.panel_ms_5.ResumeLayout(false);
            this.panel_ms_5.PerformLayout();
            this.panel_misc_3.ResumeLayout(false);
            this.panel_ms_3.ResumeLayout(false);
            this.panel_ms_3.PerformLayout();
            this.panel_misc_2.ResumeLayout(false);
            this.panel_ms_2.ResumeLayout(false);
            this.panel_ms_2.PerformLayout();
            this.panel_clock.ResumeLayout(false);
            this.panel_clock.PerformLayout();
            this.TrackBar1.EndInit();
            this.numhh.EndInit();
            this.nummm.EndInit();
            this.panel_misc_1.ResumeLayout(false);
            this.panel_ms_1.ResumeLayout(false);
            this.panel_ms_1.PerformLayout();
            this.num_tbtime.EndInit();
            this.panel_misc_top.ResumeLayout(false);
            this.panel_misc_top.PerformLayout();
            this.panel_vote.ResumeLayout(false);
            this.panel_vote_config.ResumeLayout(false);
            this.panel_vote_config.PerformLayout();
            this.panel_vote_ctrl.ResumeLayout(false);
            this.panel_vote_ctrl.PerformLayout();
            this.panel_vote_roll.ResumeLayout(false);
            this.panel_vote_roll.PerformLayout();
            this.panel_vote_top.ResumeLayout(false);
            this.panel_vote_top.PerformLayout();
            this.panel_vote_bottom.ResumeLayout(false);
            this.panel_vote_bottom.PerformLayout();
            this.panel_motion.ResumeLayout(false);
            this.Panel5.ResumeLayout(false);
            this.panel_motion_6.ResumeLayout(false);
            this.panel_m_6.ResumeLayout(false);
            this.panel_m_6.PerformLayout();
            this.num_m_custom.EndInit();
            this.panel_motion_5.ResumeLayout(false);
            this.panel_motion_4.ResumeLayout(false);
            this.panel_m_4.ResumeLayout(false);
            this.panel_m_4.PerformLayout();
            this.panel_motions_3.ResumeLayout(false);
            this.panel_m_3.ResumeLayout(false);
            this.panel_m_3.PerformLayout();
            this.num_m_spl_1.EndInit();
            this.num_m_spl_2.EndInit();
            this.panel_motions_2.ResumeLayout(false);
            this.panel_m_2.ResumeLayout(false);
            this.panel_m_2.PerformLayout();
            this.num_m_umc.EndInit();
            this.panel_singledel.ResumeLayout(false);
            this.panel_singledel.PerformLayout();
            this.panel_motions_1.ResumeLayout(false);
            this.panel_m_1.ResumeLayout(false);
            this.panel_m_1.PerformLayout();
            this.num_m_mc_1.EndInit();
            this.num_m_mc_2.EndInit();
            this.panel_motions_top.ResumeLayout(false);
            this.panel_motions_top.PerformLayout();
            this.panel_sidebar_starting.ResumeLayout(false);
            this.panel_sidebar_starting.PerformLayout();
            this.panel_startmethod.ResumeLayout(false);
            this.panel_startmethod.PerformLayout();
            this.numstartm.EndInit();
            this.numstarth.EndInit();
            this.panel_spakers_list.ResumeLayout(false);
            this.panel_spakers_list.PerformLayout();
            this.panel_csl.ResumeLayout(false);
            this.panel_csl.PerformLayout();
            this.num_spl_timem.EndInit();
            this.num_spl_times.EndInit();
            this.panel_system.ResumeLayout(false);
            this.panel_system.PerformLayout();
            this.panel_editnationlist.ResumeLayout(false);
            this.panel_editnationlist.PerformLayout();
            this.panel_mc.ResumeLayout(false);
            this.panel_mc.PerformLayout();
            this.panel_umc.ResumeLayout(false);
            this.panel_umc.PerformLayout();
            this.panel_presents.ResumeLayout(false);
            this.panel_presents.PerformLayout();
            this.panel_sidebar_timer.ResumeLayout(false);
            this.panel_sidebar_timer.PerformLayout();
            this.numtime.EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.tlp_taskbar.ResumeLayout(false);
            this.panel_manage.ResumeLayout(false);
            this.panel_manage.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.num_timeleft.EndInit();
            this.Panel4.ResumeLayout(false);
            this.tlp_manage_top.ResumeLayout(false);
            this.tlp_manage_top.PerformLayout();
            this.ResumeLayout(false);
        }

        public string languageDetect(object lang)
        {
            object left = lang;
            if (Operators.ConditionalCompareObjectEqual(left, 1, false))
            {
                return "简体中文";
            }
            return "English";
        }

        private void lbl_slist_1_Click(object sender, EventArgs e)
        {
            if (this.timingStatus == "MC")
            {
                int num2;
                Label[] labelArray = new Label[] { 
                    this.lbl_slist_1, this.Label36, this.Label39, this.Label40, this.Label41, this.Label42, this.Label43, this.Label44, this.Label45, this.Label46, this.Label37, this.Label52, this.Label53, this.Label54, this.Label56, this.Label55, 
                    this.Label57, this.Label58, this.Label59, this.Label60, this.Label38, this.Label66, this.Label67, this.Label68, this.Label69, this.Label70, this.Label71, this.Label72, this.Label73, this.Label74, this.Label80, this.Label81, 
                    this.Label82, this.Label83, this.Label84, this.Label85, this.Label86, this.Label87, this.Label88, this.Label89
                 };
                int index = 0;
                do
                {
                    if (sender.Equals(labelArray[index]))
                    {
                        break;
                    }
                    index++;
                    num2 = 0x27;
                }
                while (index <= num2);
                if (labelArray[index].Text != "")
                {
                    this.panel_mcedit.Visible = true;
                    this.num_mcnumber.Value = new decimal(index + 1);
                }
            }
        }

        private void lbl_startmode_Click(object sender, EventArgs e)
        {
            this.Panel3.Visible = false;
            this.Panel2.Visible = false;
            this.lbl_startmode.BackColor = this.darkcolor;
            this.lbl_startmode.ForeColor = Color.White;
            this.panel_modesel.Height = this.lbl_startmode.Height + (this.rad_continue.Height * 6);
            this.lbl_startmode.Text = "请选择功能项";
            this.lbl_startmode.Image = Image.FromFile(@"ui\start_taskbar_light.png");
            this.btnstart.Visible = false;
        }

        private void lbl_teabreak_Click(object sender, EventArgs e)
        {
            int num2;
            Button[] buttonArray = new Button[] { this.btn_misc_1, this.btn_misc_2, this.btn_misc_3, this.btn_misc_5 };
            int index = 0;
            do
            {
                if (sender.Equals(buttonArray[index]))
                {
                    break;
                }
                index++;
                num2 = 3;
            }
            while (index <= num2);
            if (buttonArray[index].BackColor == this.midcolor)
            {
                index = 0;
            }
            else
            {
                this.mcTitle = buttonArray[index].Text;
                index++;
            }
            PanelsExpanding.miscCollapse(index);
            this.miscIndex = index;
        }

        private void lblconf_Click(object sender, EventArgs e)
        {
        }

        private void lbltime_Click(object sender, EventArgs e)
        {
            MyProject.Forms.cabinet.Show();
        }

        public void line1add()
        {
            if (this.timingStatus == "FI")
            {
                if (this.language == 1)
                {
                    this.line1 = "请" + this.txthcmotion.Text;
                }
                else
                {
                    this.line1 = "Please " + this.txthcmotion.Text;
                }
            }
            else
            {
                this.line1 = this.txthcmotion.Text;
            }
        }

        public void listAction(string command, int number, string neirong)
        {
            Label[] labelArray = new Label[] { 
                this.lbl_slist_1, this.Label36, this.Label39, this.Label40, this.Label41, this.Label42, this.Label43, this.Label44, this.Label45, this.Label46, this.Label37, this.Label52, this.Label53, this.Label54, this.Label56, this.Label55, 
                this.Label57, this.Label58, this.Label59, this.Label60, this.Label38, this.Label66, this.Label67, this.Label68, this.Label69, this.Label70, this.Label71, this.Label72, this.Label73, this.Label74, this.Label80, this.Label81, 
                this.Label82, this.Label83, this.Label84, this.Label85, this.Label86, this.Label87, this.Label88, this.Label89
             };
            switch (command)
            {
                case "add":
                    labelArray[number].Text = neirong;
                    break;

                case "modify":
                    labelArray[number].Font = this.lbl_sldeldte.Font;
                    break;

                case "clear":
                {
                    int num2;
                    int index = 0;
                    do
                    {
                        labelArray[index].Text = "";
                        labelArray[index].Font = this.lbl_slorig.Font;
                        index++;
                        num2 = 0x27;
                    }
                    while (index <= num2);
                    break;
                }
            }
        }

        private void llb_spl_entercustom_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.isCslMode)
            {
                this.panel_csl.Visible = false;
                this.isCslMode = false;
                this.loadSlist();
                this.cbx_spl_yield.Visible = true;
                this.llb_spl_entercustom.Text = "进入自定名单";
                this.btn_spl_yieldend.Visible = false;
                this.btn_spl_yieldend.Top = this.btn_spl_yieldgo.Top;
            }
            else
            {
                this.panel_csl.Visible = true;
                this.isCslMode = true;
                this.loadCSL();
                this.llb_spl_entercustom.Text = "返回主发言名单";
            }
        }

        public void loadAutoComplete()
        {
            StreamReader reader = new StreamReader(@"saved\" + this.lastPath + @"\nationlist.txt");
            try
            {
                while (reader.ReadLine() != null)
                {
                    string str = reader.ReadLine();
                }
                reader.Close();
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                reader.Close();
                ProjectData.ClearProjectError();
            }
        }

        public void loadClock()
        {
            StreamReader reader = new StreamReader(@"saved\" + this.lastPath + @"\clock.txt");
            this.isCabinet = Conversions.ToBoolean(reader.ReadLine());
            this.cabinTime = Conversions.ToDate(reader.ReadLine());
            this.rawrate = Conversions.ToInteger(reader.ReadLine());
            this.rate = this.cabinRate[this.rawrate];
            reader.Close();
            if (this.isCabinet)
            {
                this.rad_clockyes.Checked = true;
            }
            this.TrackBar1.Value = this.rawrate;
            this.TextBox10.Text = Conversions.ToString(this.cabinRate[this.TrackBar1.Value]);
            if (DateTime.Compare(this.cabinTime, this.DateTimePicker1.MinDate) > 0)
            {
                this.DateTimePicker1.Value = this.cabinTime;
            }
            this.numhh.Value = new decimal(DateAndTime.Hour(this.cabinTime));
            this.nummm.Value = new decimal(DateAndTime.Minute(this.cabinTime));
        }

        public void loadColor()
        {
        }

        public void loadCSL()
        {
            if (this.cslPath != "")
            {
                try
                {
                    StreamReader reader = new StreamReader(this.cslPath);
                    this.cslTitle = reader.ReadLine();
                    this.cslAllowYield = Conversions.ToBoolean(reader.ReadLine());
                    this.cslTotal = Conversions.ToInteger(reader.ReadLine());
                    this.cslCurrent = Conversions.ToInteger(reader.ReadLine());
                    this.cslTime[1] = Conversions.ToInteger(reader.ReadLine());
                    this.cslTime[0] = Conversions.ToInteger(reader.ReadLine());
                    int cslTotal = this.cslTotal;
                    for (int i = 1; i <= cslTotal; i++)
                    {
                        this.cslNations[i] = reader.ReadLine();
                        this.cslIsSpoken[i] = Conversions.ToBoolean(reader.ReadLine());
                    }
                    reader.Close();
                }
                catch (Exception exception1)
                {
                    ProjectData.SetProjectError(exception1);
                    Exception exception = exception1;
                    ProjectData.ClearProjectError();
                }
            }
            this.renderSlist();
            this.txt_spl_customtitle.Text = this.cslTitle;
            this.txt_spl_totalnumber.Text = Conversions.ToString((int) (this.cslTotal + 1));
            this.chk_spl_allowyield.Checked = this.cslAllowYield;
            if (this.cslTotal > 0)
            {
                this.txt_spl_currentnunber.Text = Conversions.ToString((int) (this.cslCurrent + 1));
                this.txt_spl_current.Text = this.cslNations[this.cslCurrent + 1];
            }
            else
            {
                this.txt_spl_currentnunber.Text = Conversions.ToString(0);
                this.txt_spl_current.Text = "";
            }
            if (!-(this.cslAllowYield > false))
            {
                this.btn_spl_yieldend.Visible = true;
                this.cbx_spl_yield.Visible = false;
                this.btn_spl_yieldend.Top = this.cbx_spl_yield.Top;
            }
            this.numtime.Value = new decimal((this.cslTime[0] * 60) + this.cslTime[1]);
        }

        public void loadENL(bool isNew)
        {
            this.panel_editnationlist.Visible = true;
            if (isNew)
            {
                this.btn_enl_cancel.Visible = false;
                this.btn_enl_save.Left = 0;
                this.btn_enl_save.Width = 0xd8;
            }
        }

        public void loadLanguageScript()
        {
            int num9;
            string[] strArray = new string[7];
            if (this.language == 1)
            {
                strArray[0] = @"lang\timer1.edl";
                strArray[1] = @"lang\yield1.edl";
                strArray[2] = @"lang\motion1.edl";
                strArray[3] = @"lang\file1.edl";
                strArray[4] = @"lang\vote1.edl";
                strArray[5] = @"lang\info1.edl";
                strArray[6] = @"lang\present1.edl";
            }
            else
            {
                strArray[0] = @"lang\timer2.edl";
                strArray[1] = @"lang\yield2.edl";
                strArray[2] = @"lang\motion2.edl";
                strArray[3] = @"lang\file2.edl";
                strArray[4] = @"lang\vote2.edl";
                strArray[5] = @"lang\info2.edl";
                strArray[6] = @"lang\present2.edl";
            }
            StreamReader reader5 = new StreamReader(strArray[0]);
            int index = 0;
            do
            {
                this.timer[index] = reader5.ReadLine();
                index++;
                num9 = 9;
            }
            while (index <= num9);
            reader5.Close();
            StreamReader reader7 = new StreamReader(strArray[1]);
            int num2 = 0;
            do
            {
                this.yieldString[num2] = reader7.ReadLine();
                num2++;
                num9 = 5;
            }
            while (num2 <= num9);
            reader7.Close();
            StreamReader reader3 = new StreamReader(strArray[2]);
            int num3 = 0;
            do
            {
                this.motionString[num3] = reader3.ReadLine();
                num3++;
                num9 = 0x1a;
            }
            while (num3 <= num9);
            reader3.Close();
            StreamReader reader = new StreamReader(strArray[3]);
            this.cbx_ftpye.Items.Clear();
            int num4 = 0;
            do
            {
                this.cbx_ftpye.Items.Add(reader.ReadLine());
                num4++;
                num9 = 3;
            }
            while (num4 <= num9);
            reader.Close();
            StreamReader reader6 = new StreamReader(strArray[4]);
            int num5 = 0;
            do
            {
                this.voteString[num5] = reader6.ReadLine();
                num5++;
                num9 = 8;
            }
            while (num5 <= num9);
            reader6.Close();
            StreamReader reader2 = new StreamReader(strArray[5]);
            int num6 = 0;
            do
            {
                this.infoString[num6] = reader2.ReadLine();
                num6++;
                num9 = 12;
            }
            while (num6 <= num9);
            reader2.Close();
            StreamReader reader4 = new StreamReader(strArray[6]);
            int num7 = 0;
            do
            {
                this.presentString[num7] = reader4.ReadLine();
                num7++;
                num9 = 11;
            }
            while (num7 <= num9);
            reader4.Close();
            this.lblpresent1.Text = this.presentString[0];
            this.lbl50maj1.Text = this.presentString[1];
            this.lbl67maj1.Text = this.presentString[2];
            this.lbl20maj1.Text = this.presentString[3];
            this.lblyes1.Text = this.presentString[4];
            this.lblno1.Text = this.presentString[5];
            this.lblabst1.Text = this.presentString[6];
            this.CheckBox2.Text = this.presentString[7];
            this.CheckBox3.Text = this.presentString[8];
            this.CheckBox4.Text = this.presentString[9];
            this.CheckBox5.Text = this.presentString[10];
            this.CheckBox6.Text = this.presentString[11];
        }

        public void loadRollcall()
        {
            int num;
            int num2;
            this.clb_nation_main.Items.Clear();
            StreamReader reader = new StreamReader(@"saved\" + this.lastPath + @"\nationlist.txt");
            try
            {
                while (reader != null)
                {
                    string item = reader.ReadLine();
                    this.clb_nation_main.Items.Add(item);
                    this.cbx_singledel.Items.Add(item);
                }
                reader.Close();
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                reader.Close();
                ProjectData.ClearProjectError();
            }
            StreamReader reader2 = new StreamReader(@"saved\" + this.lastPath + @"\nationlist_p.txt");
            while (num < this.clb_nation_main.Items.Count)
            {
                if (reader2.ReadLine() == "True")
                {
                    this.clb_nation_main.SetItemCheckState(num, CheckState.Checked);
                    num2++;
                }
                else
                {
                    this.clb_nation_main.SetItemCheckState(num, CheckState.Unchecked);
                }
                num++;
            }
            reader2.Close();
            this.pcalc(num2);
        }

        public bool loadSelection(string path)
        {
            bool flag;
            try
            {
                StreamReader reader = new StreamReader(@"saved\" + path + @"\info.txt");
                this.language = Conversions.ToInteger(reader.ReadLine());
                this.topicSelection = Conversions.ToInteger(reader.ReadLine());
                this.conference = reader.ReadLine();
                this.committee = reader.ReadLine();
                this.topic[0] = reader.ReadLine();
                this.topic[1] = reader.ReadLine();
                this.myrule = Conversions.ToInteger(reader.ReadLine());
                reader.Close();
                loadword.loadCcong(path);
                FileInfo info = new FileInfo(@"saved\" + path + @"\config.txt");
                this.Label5.Text = "档案名称: " + path + "\r\n大会: " + this.conference + "\r\n委员会: " + this.committee + "\r\n议题: " + this.topic[this.topicSelection] + "\r\n工作语言: " + this.languageDetect(this.language) + "\r\n创建时间: " + info.CreationTime.ToString();
                if (path == this.lastPath)
                {
                    this.rad_continue.Checked = true;
                }
                if (this.isSingelDel)
                {
                    this.panel_singledel.Visible = true;
                }
                else
                {
                    this.panel_singledel.Visible = false;
                }
                flag = false;
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                if (path == this.lastPath)
                {
                    this.rad_continue.Enabled = false;
                    this.Label5.Text = "没有可用的会议档案";
                    this.Label5.TextAlign = ContentAlignment.MiddleCenter;
                }
                flag = true;
                ProjectData.ClearProjectError();
                return flag;
                ProjectData.ClearProjectError();
            }
            return flag;
        }

        public void loadSlist()
        {
            try
            {
                StreamReader reader = new StreamReader(@"saved\" + this.lastPath + @"\speakers.txt");
                this.slTotal = Conversions.ToInteger(reader.ReadLine());
                this.slCurrent = Conversions.ToInteger(reader.ReadLine());
                this.slTime[1] = Conversions.ToInteger(reader.ReadLine());
                this.slTime[0] = Conversions.ToInteger(reader.ReadLine());
                int slTotal = this.slTotal;
                for (int i = 1; i <= slTotal; i++)
                {
                    this.slNations[i] = reader.ReadLine();
                    this.slIsSpoken[i] = Conversions.ToBoolean(reader.ReadLine());
                }
                reader.Close();
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                ProjectData.ClearProjectError();
            }
            this.renderSlist();
            this.txt_spl_totalnumber.Text = Conversions.ToString((int) (this.slTotal + 1));
            if (this.slTotal > 0)
            {
                this.txt_spl_currentnunber.Text = Conversions.ToString((int) (this.slCurrent + 1));
                this.txt_spl_current.Text = this.slNations[this.slCurrent + 1];
            }
            this.numtime.Value = new decimal((this.slTime[1] * 60) + this.slTime[0]);
        }

        public void manageExit()
        {
            this.panel_manage.Visible = false;
            if (this.isInMeeting)
            {
                this.panel_main.Visible = true;
            }
            else
            {
                this.panel_welcome.Visible = true;
            }
        }

        public void maxPages()
        {
            if (this.panel_spakers_list.Visible)
            {
                if (this.isCslMode)
                {
                    this.maxPage = (this.cslTotal / this.listCapacity) + 1;
                }
                else
                {
                    this.maxPage = (this.slTotal / this.listCapacity) + 1;
                }
            }
            else if (this.panel_mc.Visible)
            {
                this.maxPage = (this.mcTotal / this.listCapacity) + 1;
            }
            else if (this.panel_vote.Visible)
            {
                this.maxPage = (this.vtTotal / this.listCapacity) + 1;
            }
            this.Label47.Text = Conversions.ToString(this.maxPage);
            if (this.language == 1)
            {
                this.Label47.Text = "页数" + Conversion.Str(this.page + 1) + "/" + this.Label47.Text;
            }
            else
            {
                this.Label47.Text = "Page" + Conversion.Str(this.page + 1) + " of " + this.Label47.Text;
            }
            if (this.page == 0)
            {
                this.btn_prev.Visible = false;
            }
            else
            {
                this.btn_prev.Visible = true;
            }
            if (this.page == (this.maxPage - 1))
            {
                this.btn_next.Visible = false;
            }
            else
            {
                this.btn_next.Visible = true;
            }
        }

        public void mcEnd()
        {
            string str;
            int num4;
            string str2 = "";
            if (this.btn_mc_end.Text == "结束")
            {
                if (this.language == 1)
                {
                    this.lblmain.Text = this.txthcmotion.Text + "\r\n本轮动议结束";
                    str = "本轮动议提前结束, 参加发言的国家有: \r\n";
                }
                else
                {
                    this.lblmain.Text = this.txthcmotion.Text + "\r\nMotion Ended";
                    str = "Motion expired, nations came up speech: \r\n";
                }
            }
            else if (this.language == 1)
            {
                this.lblmain.Text = this.txthcmotion.Text + "\r\n本轮动议提前结束";
                str = "本轮动议提前结束, 参加发言的国家有: \r\n";
            }
            else
            {
                this.lblmain.Text = this.txthcmotion.Text + "\r\nMotion Expired";
                str = "Motion expired, nations came up speech: \r\n";
            }
            this.numtime.Value = 60M;
            this.numtime.Enabled = true;
            this.panel_sidebar_timer.Visible = false;
            this.panel_mc.Visible = false;
            this.k = 0;
            this.i = 0;
            this.num_mcnumber.Maximum = decimal.One;
            this.txt_mc_totalnumber.Text = Conversions.ToString(1);
            this.txt_mc_currentnumber.Text = Conversions.ToString(0);
            this.txt_mc_current.Text = "";
            this.txt_mc_add.ReadOnly = false;
            this.btn_mc_add.Enabled = true;
            int mcTotal = this.mcTotal;
            for (int i = 1; i <= mcTotal; i++)
            {
                str2 = str2 + this.mcNations[i] + "\r\n";
                this.mcNations[i] = "";
                this.mcIsSpoken[i] = false;
            }
            this.mcCurrent = 0;
            this.mcTotal = 0;
            int index = 1;
            do
            {
                this.mcNations[index] = "";
                this.mcIsSpoken[index] = false;
                index++;
                num4 = 0x2d;
            }
            while (index <= num4);
            str = str + str2;
            this.txthcmotion.Text = str;
            this.timingStatus = "MC";
            this.Button3.Enabled = true;
            this.Button4.Enabled = true;
            this.tlp_screenlist.Visible = false;
            this.listAction("clear", 0, "");
            this.motionClose();
        }

        public void mcNationAdd()
        {
            int num = this.mcTotal + 1;
            if (this.txt_mc_add.Text != "")
            {
                this.mcTotal = num;
                this.num_mcnumber.Maximum = new decimal(this.mcTotal);
                this.txt_mc_totalnumber.Text = Conversions.ToString((int) (num + 1));
                this.mcNations[this.mcTotal] = this.txt_mc_add.Text;
                this.listAction("add", this.mcTotal - 1, this.txt_mc_add.Text);
                this.txt_mc_add.Focus();
                if (this.isZhuijia)
                {
                    this.btn_mc_start.Enabled = true;
                    this.mcCurrent++;
                    this.txt_mc_currentnumber.Text = Conversions.ToString(this.mcCurrent);
                    this.txt_mc_current.Text = this.mcNations[this.mcCurrent];
                    this.isZhuijia = false;
                }
                if (this.mcTotal >= this.mcAll)
                {
                    this.txt_mc_add.Text = "";
                    this.Label33.Text = "请开始发言";
                    this.txt_mc_add.Enabled = false;
                    this.btn_mc_add.Enabled = false;
                    this.btn_mc_start.Enabled = true;
                    this.btn_mc_start.Focus();
                    this.txt_mc_currentnumber.Text = Conversions.ToString(this.mcCurrent);
                    this.txt_mc_current.Text = this.mcNations[this.mcCurrent];
                }
                else
                {
                    if (this.mcTotal == 1)
                    {
                        this.btn_mc_start.Enabled = true;
                        this.txt_mc_currentnumber.Text = Conversions.ToString(this.mcTotal);
                        this.txt_mc_current.Text = this.mcNations[1];
                        this.mcCurrent = 1;
                        this.num_mcnumber.Maximum = decimal.One;
                    }
                    this.txt_mc_add.Text = "";
                    int num2 = this.mcAll - this.mcTotal;
                    this.Label33.Text = Conversions.ToString(num2);
                    this.Label33.Text = "还可继续添加" + this.Label33.Text + "个国家";
                    this.txt_mc_add.Select();
                }
            }
        }

        public void mcnext()
        {
            this.mcIsSpoken[this.mcCurrent] = true;
            this.listAction("modify", this.mcCurrent - 1, "");
            this.btn_mc_next.Visible = false;
            this.isTiming = false;
            this.Button3.Text = "开始";
            if (this.mcCurrent >= this.mcTotal)
            {
                if (decimal.Compare(new decimal(this.k), this.numtime.Value) >= 0)
                {
                    this.txt_mc_add.Text = "点这里追加";
                    this.txt_mc_add.Enabled = true;
                    this.txt_mc_add.ReadOnly = true;
                    this.btn_mc_end.Visible = true;
                    this.btn_mc_end.Text = "提前结束";
                    this.isZhuijia = true;
                    this.mcAdd = (int) (((long) this.k) / Convert.ToInt64(this.numtime.Value));
                    this.Label33.Text = Conversions.ToString(this.mcAdd);
                    this.Label33.Text = "可向列表追加" + this.Label33.Text + "个国家";
                }
                else
                {
                    this.btn_mc_end.Visible = true;
                    this.btn_mc_end.Text = "结束";
                    this.btn_mc_end.Focus();
                    this.btn_mc_end.BackColor = this.midcolor;
                    this.Label33.Text = "点击\"结束\"以完成本轮发言";
                }
                if (this.k >= 60)
                {
                }
            }
            else
            {
                this.mcCurrent++;
                this.txt_mc_currentnumber.Text = Conversions.ToString(this.mcCurrent);
                this.txt_mc_current.Text = this.mcNations[this.mcCurrent];
                this.btn_mc_start.Enabled = true;
                this.btn_mc_start.Focus();
            }
        }

        public void mcReady()
        {
            this.txt_mc_add.Enabled = true;
            this.btn_mc_end.Visible = false;
            this.btn_mc_start.Enabled = false;
            this.tlp_screenlist.Visible = true;
            this.tlp_screenlist.Top = this.panel_main_screen.Height - this.tlp_screenlist.Height;
            this.listAction("clear", 0, "");
            this.line1add();
            this.mcAll = (int) Math.Round((double) (((double) this.k) / ((double) this.i)));
            this.Label33.Text = Conversions.ToString(this.mcAll);
            this.Label33.Text = "最多有" + this.Label33.Text + "个国家可加入发言列表";
            this.txt_mc_add.Focus();
            this.mcCurrent = 0;
            this.mcTotal = 0;
            this.num_mcnumber.Maximum = decimal.One;
            this.tlp_taskbar2.Visible = true;
        }

        public void mcTimeDisp(int m, int s)
        {
            string str3 = "";
            string str = Conversions.ToString(m);
            string str2 = Conversions.ToString(s);
            if (m < 10)
            {
                str3 = "0";
            }
            else
            {
                str3 = "";
            }
            str3 = str3 + str + ":";
            if (s < 10)
            {
                str3 = str3 + "0";
            }
            str3 = str3 + str2;
            this.lbl_mc_total_time.Text = str3;
        }

        private void modifychuxi(object sender, EventArgs e)
        {
        }

        public void motionClose()
        {
            this.txt_mnation.Text = "";
            this.txt_mtopic.Text = "";
            this.txt_mneirong.Text = "";
            this.panel_motion.Visible = false;
            if (this.isSingelDel)
            {
                this.panel_singledel.Visible = true;
            }
            PanelsExpanding.unlockTaskbar();
            PanelsExpanding.mcExpand(0);
        }

        public void newMsg()
        {
            SoundPlayer player = new SoundPlayer(@"sounds\glass.wav");
            player.Play();
            player.Dispose();
            this.NotifyIcon1.BalloonTipTitle = "新消息";
            this.NotifyIcon1.BalloonTipText = "The name for the document. The default is the current folder and file name. If the document has never been saved, the default name is used (for example, Doc1.doc). If a document with the specified file name already exists, the document is overwritten without prompting the user.";
            this.NotifyIcon1.ShowBalloonTip(0x3a98);
        }

        private void num_mcnumber_ValueChanged(object sender, EventArgs e)
        {
            this.txt_mceditnation.Text = this.mcNations[Convert.ToInt32(this.num_mcnumber.Value)];
        }

        private void num_spl_timem_ValueChanged(object sender, EventArgs e)
        {
            this.cslTime[0] = Convert.ToInt32(this.num_spl_timem.Value);
            this.cslTime[1] = Convert.ToInt32(this.num_spl_times.Value);
            this.numtime.Value = new decimal((this.cslTime[0] * 60) + this.cslTime[1]);
            this.cslEdited = true;
        }

        private void num_timer_s_ValueChanged(object sender, EventArgs e)
        {
            this.num_m_mc_2.Maximum = decimal.Multiply(this.num_m_mc_1.Value, 60M);
        }

        private void NumericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (decimal.Compare(this.numstarth.Value, 24M) == 0)
            {
                this.numstarth.Value = decimal.Zero;
            }
            if (decimal.Compare(this.numstartm.Value, 60M) == 0)
            {
                this.numstartm.Value = decimal.Zero;
            }
        }

        public int opinion1(string op)
        {
            string str = op;
            if (str == this.voteString[3])
            {
                return 1;
            }
            if (str == this.voteString[4])
            {
                return 2;
            }
            if (str == this.voteString[5])
            {
                return 3;
            }
            return 4;
        }

        public void pageAction(bool prev)
        {
            if (prev)
            {
                this.page--;
            }
            else
            {
                this.page++;
            }
            this.autoPage(this.page);
            this.maxPages();
        }

        public void pcalc(int p)
        {
            if (p == 0)
            {
                this.lblpresent.Text = Conversions.ToString(0);
                this.lbl20maj.Text = Conversions.ToString(0);
                this.lbl50maj.Text = Conversions.ToString(0);
                this.lbl67maj.Text = Conversions.ToString(0);
            }
            else
            {
                this.lblpresent.Text = Conversions.ToString(p);
                this.lbl20maj.Text = Conversions.ToString((int) (p / 5));
                this.lbl50maj.Text = Conversions.ToString((int) ((p / 2) + 1));
                this.lbl67maj.Text = Conversions.ToString((int) ((p * 2) / 3));
            }
        }

        public void playTone()
        {
            SoundPlayer player = new SoundPlayer(@"sounds\alarm.wav");
            player.Play();
            player.Dispose();
        }

        private void rad_50maj_CheckedChanged(object sender, EventArgs e)
        {
            this.voteDisp();
        }

        private void rad_clockno_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rad_clockyes.Checked)
            {
                this.panel_clock.Enabled = true;
            }
            else
            {
                this.panel_clock.Enabled = false;
            }
        }

        private void rad_create_CheckedChanged(object sender, EventArgs e)
        {
            this.btnstart.Visible = true;
            if (this.rad_continue.Checked)
            {
                this.lbl_startmode.Text = this.rad_continue.Text;
            }
            if (this.rad_select.Checked)
            {
                this.lbl_startmode.Text = this.rad_select.Text;
                this.ComboBox1.Visible = true;
            }
            else
            {
                this.ComboBox1.Visible = false;
            }
            if (this.rad_load.Checked)
            {
                this.lbl_startmode.Text = this.rad_load.Text;
                this.lbl_loaded.Visible = true;
            }
            else
            {
                this.lbl_loaded.Visible = false;
            }
            if (this.rad_create.Checked)
            {
                this.lbl_startmode.Text = this.rad_create.Text;
                this.Panel3.Visible = true;
                this.Panel2.Visible = false;
            }
            else
            {
                this.Panel3.Visible = false;
                this.Panel2.Visible = true;
            }
            this.lbl_startmode.Image = Image.FromFile(@"ui\start_taskbar.png");
            this.lbl_startmode.BackColor = this.lightcolor;
            this.lbl_startmode.ForeColor = Color.Black;
            this.panel_modesel.Height = this.lbl_startmode.Height;
        }

        private void rad_darkred_CheckedChanged(object sender, EventArgs e)
        {
            int num2;
            RadioButton[] buttonArray = new RadioButton[] { this.rad_darkred, this.rad_orange, this.rad_green, this.rad_teal, this.rad_blue, this.rad_purple, this.rad_pink };
            int index = 0;
            do
            {
                if (buttonArray[index].Checked)
                {
                    buttonArray[index].Image = Image.FromFile(@"ui\colorsel_selected.png");
                    this.myColor = index + 1;
                }
                else
                {
                    buttonArray[index].Image = null;
                }
                index++;
                num2 = 6;
            }
            while (index <= num2);
        }

        private void rad_immediatestart_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rad_timedstart.Checked)
            {
                this.numstarth.Enabled = true;
                this.numstartm.Enabled = true;
                this.numstartm.Value = new decimal(DateAndTime.TimeOfDay.Minute + (5 - (DateAndTime.TimeOfDay.Minute % 5)));
                this.numstarth.Value = new decimal(DateAndTime.TimeOfDay.Hour);
                if (decimal.Compare(this.numstartm.Value, decimal.Zero) == 0)
                {
                    this.numstarth.Value = decimal.Add(this.numstarth.Value, decimal.One);
                }
            }
            else
            {
                this.numstarth.Enabled = false;
                this.numstartm.Enabled = false;
            }
        }

        private void rad_paper_CheckedChanged(object sender, EventArgs e)
        {
            this.signatories();
        }

        public void record(bool passed)
        {
            string str;
            if (this.language == 1)
            {
                str = this.a2 + "\r\n出席的国家数: " + this.lblpresent.Text + "\r\n赞成的国家数:" + this.lblyes.Text + "\r\n反对的国家数: " + this.lblno.Text + "\r\n弃权的国家数: " + this.lblabst.Text;
                if (this.CheckBox6.Checked)
                {
                    str = str + "\r\n" + this.vetoPower();
                }
                str = str + "\r\n具体投票情况如下:";
                int vtTotal = this.vtTotal;
                for (int i = 1; i <= vtTotal; i++)
                {
                    str = str + "\r\n" + this.nations[i] + "——" + this.opini[i];
                }
            }
            else
            {
                str = this.a2 + "\r\nPresent: " + this.lblpresent.Text + "\r\nYes:" + this.lblyes.Text + "\r\nNo: " + this.lblno.Text + "\r\nAbstain: " + this.lblabst.Text;
                if (this.CheckBox6.Checked)
                {
                    str = str + "\r\n" + this.vetoPower();
                }
                str = str + "\r\nThe specific votes as follows:";
                int num4 = this.vtTotal;
                for (int j = 1; j <= num4; j++)
                {
                    str = str + "\r\n" + this.nations[j] + " - " + this.opini[j];
                }
            }
            str = str + "\r\n" + this.vetoPower();
            this.txthcmotion.Text = str;
        }

        public void renderSlist()
        {
            int num;
            this.listAction("clear", 0, "");
            if (this.isCslMode)
            {
                int cslTotal = this.cslTotal;
                for (int i = (this.page * this.listCapacity) + 1; i <= cslTotal; i++)
                {
                    if (i <= ((this.page * this.listCapacity) + 40))
                    {
                        this.listAction("add", (i - (this.page * this.listCapacity)) - 1, this.cslNations[i]);
                    }
                }
                int cslCurrent = this.cslCurrent;
                for (int j = (this.page * this.listCapacity) + 1; j <= cslCurrent; j++)
                {
                    if (j <= ((this.page * this.listCapacity) + 40))
                    {
                        this.listAction("modify", (j - (this.page * this.listCapacity)) - 1, "");
                    }
                }
                num = this.cslCurrent / this.listCapacity;
            }
            else
            {
                int slTotal = this.slTotal;
                for (int k = (this.page * this.listCapacity) + 1; k <= slTotal; k++)
                {
                    if (k <= ((this.page * this.listCapacity) + 40))
                    {
                        this.listAction("add", (k - (this.page * this.listCapacity)) - 1, this.slNations[k]);
                    }
                }
                int slCurrent = this.slCurrent;
                for (int m = (this.page * this.listCapacity) + 1; m <= slCurrent; m++)
                {
                    if (m <= ((this.page * this.listCapacity) + 40))
                    {
                        this.listAction("modify", (m - (this.page * this.listCapacity)) - 1, "");
                    }
                }
                num = this.slCurrent / this.listCapacity;
            }
            this.maxPages();
        }

        public void saveConfig()
        {
            StreamWriter writer2 = new StreamWriter(@"saved\" + this.lastPath + @"\info.txt");
            writer2.WriteLine(this.language);
            writer2.WriteLine(this.topicSelection);
            writer2.WriteLine(this.conference);
            writer2.WriteLine(this.committee);
            writer2.WriteLine(this.topic[0]);
            writer2.WriteLine(this.topic[1]);
            writer2.WriteLine(this.myrule);
            writer2.Close();
            StreamWriter writer = new StreamWriter(@"saved\" + this.lastPath + @"\config.txt");
            writer.WriteLine(this.myVersion);
            writer.WriteLine(this.isStarted);
            writer.WriteLine(this.isSingelDel);
            writer.WriteLine(this.session);
            writer.WriteLine(this.presentWhenRoll);
            writer.Close();
        }

        public void saveCSL()
        {
            try
            {
                StreamWriter writer = new StreamWriter(this.cslPath);
                writer.WriteLine(this.cslTitle);
                writer.WriteLine(this.cslAllowYield);
                writer.WriteLine(this.cslTotal);
                writer.WriteLine(this.cslCurrent);
                writer.WriteLine(this.cslTime[1]);
                writer.WriteLine(this.cslTime[0]);
                int cslTotal = this.cslTotal;
                for (int i = 1; i <= cslTotal; i++)
                {
                    writer.WriteLine(this.cslNations[i]);
                    writer.WriteLine(this.cslIsSpoken[i]);
                }
                writer.Close();
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                ProjectData.ClearProjectError();
            }
        }

        public void saveSlist()
        {
            try
            {
                StreamWriter writer = new StreamWriter(@"saved\" + this.lastPath + @"\speakers.txt");
                writer.WriteLine(this.slTotal);
                writer.WriteLine(this.slCurrent);
                writer.WriteLine(this.slTime[1]);
                writer.WriteLine(this.slTime[0]);
                int slTotal = this.slTotal;
                for (int i = 1; i <= slTotal; i++)
                {
                    writer.WriteLine(this.slNations[i]);
                    writer.WriteLine(this.slIsSpoken[i]);
                }
                writer.Close();
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                ProjectData.ClearProjectError();
            }
        }

        public void setsave1()
        {
            StreamWriter writer = new StreamWriter(@"config\setting.txt");
            writer.WriteLine(this.myColor);
            writer.WriteLine(this.myBanner);
            writer.WriteLine(this.isMainImg);
            writer.WriteLine(this.myMainImg);
            writer.WriteLine(this.isPlaysound);
            writer.WriteLine(this.myPlaysound);
            writer.WriteLine(this.isPlay20);
            writer.WriteLine(this.myPlay20);
            writer.WriteLine(this.valuePlay20);
            writer.WriteLine(this.isPlayUMC);
            writer.WriteLine(this.myPlayUMC);
            writer.WriteLine(this.isPlayStart);
            writer.WriteLine(this.myPlayStart);
            writer.WriteLine(this.myFont.Name);
            writer.WriteLine(this.myFont.Size);
            writer.WriteLine((int) this.myFont.Style);
            writer.Close();
            this.btn_sizequick.Text = "字号:" + Conversion.Str(this.myFont.Size);
        }

        public void signatories()
        {
            if (this.cbx_ftpye.SelectedIndex == 2)
            {
                this.txt_filenumber_3.Visible = true;
                this.Label103.Text = "编号　　　　.　　.";
            }
            else
            {
                this.txt_filenumber_3.Visible = false;
                this.Label103.Text = "编号　　　　.";
            }
            if (!this.rad_paper.Checked)
            {
                this.panel_sponsors.Visible = false;
                this.panel_signatories.Visible = false;
                this.panel_selfile.Visible = true;
                this.panel_file_1.Height = (this.btn_file_1.Height + this.panel_f_1.Height) + this.panel_selfile.Height;
            }
            else
            {
                this.panel_selfile.Visible = false;
                this.panel_sponsors.Visible = true;
                switch (this.cbx_ftpye.SelectedIndex)
                {
                    case 0:
                    case 2:
                        this.panel_signatories.Visible = false;
                        this.panel_file_1.Height = (this.btn_file_1.Height + this.panel_f_1.Height) + this.panel_sponsors.Height;
                        return;
                }
                this.panel_signatories.Visible = true;
                this.panel_file_1.Height = ((this.btn_file_1.Height + this.panel_f_1.Height) + this.panel_sponsors.Height) + this.panel_signatories.Height;
            }
        }

        public void slNationAdd()
        {
            if (this.txt_spl_add.Text != "")
            {
                if (this.isCslMode)
                {
                    this.cslTotal = (int) Math.Round(Conversion.Val(this.txt_spl_totalnumber.Text));
                    this.cslNations[this.cslTotal] = this.txt_spl_add.Text;
                    this.txt_spl_totalnumber.Text = Conversions.ToString((int) (this.cslTotal + 1));
                    this.txt_spl_add.Text = "";
                    this.txt_spl_add.Select();
                    if (this.cslTotal == 1)
                    {
                        this.txt_spl_currentnunber.Text = Conversions.ToString((int) (this.cslCurrent + 1));
                        this.txt_spl_current.Text = this.cslNations[this.cslCurrent + 1];
                    }
                    if (this.cslTotal <= (this.listCapacity * (this.page + 1)))
                    {
                        this.listAction("add", (this.cslTotal - 1) - (this.listCapacity * this.page), this.cslNations[this.cslTotal]);
                    }
                    else
                    {
                        this.autoPage(this.page + 1);
                    }
                    this.cslEdited = true;
                }
                else
                {
                    this.slTotal = (int) Math.Round(Conversion.Val(this.txt_spl_totalnumber.Text));
                    this.slNations[this.slTotal] = this.txt_spl_add.Text;
                    this.txt_spl_totalnumber.Text = Conversions.ToString((int) (this.slTotal + 1));
                    this.txt_spl_add.Text = "";
                    this.txt_spl_add.Select();
                    if (this.slTotal == 1)
                    {
                        this.txt_spl_currentnunber.Text = Conversions.ToString((int) (this.slCurrent + 1));
                        this.txt_spl_current.Text = this.slNations[this.slCurrent + 1];
                    }
                    if (this.slTotal <= (this.listCapacity * (this.page + 1)))
                    {
                        this.listAction("add", (this.slTotal - 1) - (this.listCapacity * this.page), this.slNations[this.slTotal]);
                    }
                    else
                    {
                        this.autoPage(this.page + 1);
                    }
                    this.saveSlist();
                }
            }
        }

        public void slSpeakNext()
        {
            this.cbx_spl_yield.SelectedIndex = 0;
            if (this.isCslMode)
            {
                this.listAction("modify", this.cslCurrent - (this.listCapacity * this.page), "");
                this.cslCurrent++;
                this.cslIsSpoken[this.cslCurrent] = true;
                if (this.cslCurrent != this.slTotal)
                {
                    this.txt_spl_currentnunber.Text = Conversions.ToString((int) (this.cslCurrent + 1));
                    this.txt_spl_current.Text = this.cslNations[this.cslCurrent + 1];
                }
                if (this.cslCurrent >= ((this.page + 1) * this.listCapacity))
                {
                    this.autoPage(this.page + 1);
                }
                this.cslEdited = true;
            }
            else
            {
                this.listAction("modify", this.slCurrent - (this.listCapacity * this.page), "");
                this.slCurrent++;
                this.slIsSpoken[this.slCurrent] = true;
                if (this.slCurrent != this.slTotal)
                {
                    this.txt_spl_currentnunber.Text = Conversions.ToString((int) (this.slCurrent + 1));
                    this.txt_spl_current.Text = this.slNations[this.slCurrent + 1];
                }
                if (this.slCurrent >= ((this.page + 1) * this.listCapacity))
                {
                    this.autoPage(this.page + 1);
                }
                this.saveSlist();
            }
            this.btn_spl_add.Enabled = true;
            this.cbx_spl_yield.Enabled = false;
            this.btn_spl_exit.Enabled = true;
            this.llb_spl_entercustom.Enabled = true;
            this.numtime.Enabled = false;
        }

        public void slStringGenerake()
        {
            string str;
            this.mm = Conversions.ToString(this.slTime[1]);
            this.ss = Conversions.ToString(this.slTime[0]);
            if (this.language == 1)
            {
                str = "主发言名单 (" + this.mm;
                if (this.slTime[0] == 0)
                {
                    str = str + "分钟)";
                }
                else
                {
                    str = str + "分" + this.ss + "秒)";
                }
                str = str + "\r\n当前发言: " + this.slNations[this.slCurrent + 1];
            }
            else
            {
                str = "Speakers' List (" + this.mm;
                if (this.slTime[0] == 0)
                {
                    str = str + " minutes)";
                }
                else
                {
                    str = str + "m " + this.ss + "s)";
                }
                str = str + "\r\nCurrent: " + this.slNations[this.slCurrent + 1];
            }
            this.txthcmotion.Text = str;
        }

        public void speakerend(bool timeout)
        {
            this.isTiming = false;
            this.iTick = 0;
            this.Button3.Enabled = true;
            this.Button4.Enabled = true;
            this.numtime.Enabled = true;
            this.Button3.Text = "开始";
            this.btn_spl_add.Enabled = true;
            this.btn_spl_start.Enabled = true;
            this.txt_spl_add.Enabled = true;
            this.btn_spl_start.Text = "开始";
            if (!timeout)
            {
                if (this.language == 1)
                {
                    this.lblmain.Text = this.txthcmotion.Text + "\r\n发言结束";
                }
                else
                {
                    this.lblmain.Text = this.txthcmotion.Text + "\r\nSpeech Finished";
                }
                this.lblcount.Text = "00:00";
                this.lblcount.ForeColor = Color.White;
                this.lblmaohao.Visible = false;
            }
            else if (!this.isInDbq)
            {
                this.slSpeakNext();
            }
        }

        private void TextBox1_GotFocus(object sender, EventArgs e)
        {
            this.TextBox1.BackColor = Color.White;
            this.TextBox2.BackColor = Color.White;
            this.TextBox3.BackColor = Color.White;
            this.TextBox4.BackColor = Color.White;
            this.TextBox5.BackColor = Color.White;
            this.ComboBox1.BackColor = Color.White;
        }

        private void TextBox5_KeyDown(object sender, KeyEventArgs e)
        {
            Keys keyCode = e.KeyCode;
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
            if (this.TextBox5.Text == "")
            {
                this.Button2.Enabled = true;
            }
            else
            {
                this.Button2.Enabled = false;
            }
        }

        public void timeDisp()
        {
            this.kminute = this.k / 60;
            this.ksecond = this.k % 60;
            this.iminute = this.i / 60;
            this.isecond = this.i % 60;
            string str3 = "";
            string str = Conversions.ToString(this.iminute);
            string str2 = Conversions.ToString(this.isecond);
            if (this.iminute < 10)
            {
                str3 = "0";
            }
            else
            {
                str3 = "";
            }
            str3 = str3 + str + ":";
            if (this.isecond < 10)
            {
                str3 = str3 + "0";
            }
            str3 = str3 + str2;
            this.lblcount.Text = str3;
            if (this.timingStatus == "MC")
            {
                this.mcTimeDisp(this.kminute, this.ksecond);
            }
        }

        [MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (this.isCabinet)
            {
                this.cabinTime = this.cabinTime.AddMilliseconds((double) (this.rate * 0x3e));
                this.lbltime.Text = Conversions.ToString(this.cabinTime);
            }
            else
            {
                this.lbltime.Text = Conversions.ToString(DateTime.Today) + " " + Conversions.ToString(DateAndTime.TimeOfDay);
            }
            this.lblinfo.Text = MyProject.Application.Info.Title + " v" + MyProject.Application.Info.Version.ToString() + "\r\n" + Conversions.ToString(DateTime.Today) + " " + Conversions.ToString(DateAndTime.TimeOfDay);
            if (this.isWaiting && (DateTime.Compare(this.timeStart, DateTime.Now) <= 0))
            {
                this.isWaiting = false;
                if (this.isPlayStart)
                {
                    try
                    {
                        SoundPlayer player = new SoundPlayer(this.myPlayStart);
                        player.Play();
                        player.Dispose();
                    }
                    catch (Exception exception1)
                    {
                        ProjectData.SetProjectError(exception1);
                        Exception exception = exception1;
                        this.isPlayStart = false;
                        ProjectData.ClearProjectError();
                    }
                }
                StreamWriter writer = new StreamWriter(@"saved\" + this.lastPath + @"\record.txt", true);
                writer.Write(Conversions.ToString(DateTime.Today) + " " + Conversions.ToString(DateAndTime.TimeOfDay) + "\r\n" + this.conference + "\r\n" + this.committee + "\r\n" + this.topic[this.topicSelection] + "\r\n" + this.infoString[2] + this.txtsession.Text + this.infoString[3] + this.infoString[4] + "\r\n\r\n");
                writer.Close();
                writer.Dispose();
                this.clb_nation_main.Visible = true;
                this.btn_roll_finish.Visible = true;
                this.Label17.Visible = false;
            }
            if (this.panel_sidebar_starting.Visible | this.panel_singledel.Visible)
            {
                int index = 0;
                int p = 0;
                while (index < this.clb_nation_main.Items.Count)
                {
                    if (this.clb_nation_main.GetItemChecked(index))
                    {
                        p++;
                    }
                    index++;
                }
                this.pcalc(p);
            }
            if (this.isTiming)
            {
                this.iTick++;
                switch (this.iTick)
                {
                    case 8:
                        if (this.i >= 50)
                        {
                            this.lblcount.ForeColor = Color.White;
                        }
                        this.lblmaohao.Visible = true;
                        break;

                    case 0x10:
                    {
                        bool flag;
                        this.lblmaohao.Visible = false;
                        string timingStatus = this.timingStatus;
                        if (timingStatus == "CR")
                        {
                            this.iLimit = 30;
                        }
                        else if (timingStatus == "FI")
                        {
                            this.iLimit = 30;
                        }
                        else if (timingStatus == "FS")
                        {
                            this.iLimit = 30;
                        }
                        else if (timingStatus == "TB")
                        {
                            this.iLimit = 60;
                            flag = true;
                        }
                        else if (timingStatus == "UMC")
                        {
                            this.iLimit = 60;
                            flag = true;
                        }
                        else
                        {
                            this.iLimit = this.valuePlay20;
                        }
                        if (!((this.k == 0) | (this.i == 0)))
                        {
                            this.isTiming = true;
                            this.Button3.Text = "暂停";
                            this.k--;
                            this.i--;
                        }
                        if (this.i <= this.iLimit)
                        {
                            this.lblcount.ForeColor = Color.Gold;
                        }
                        else
                        {
                            this.lblcount.ForeColor = Color.White;
                        }
                        int i = this.i;
                        if (i == 0)
                        {
                            flag = false;
                            if (this.isPlaysound)
                            {
                                try
                                {
                                    SoundPlayer player2 = new SoundPlayer(this.myPlaysound);
                                    player2.Play();
                                    player2.Dispose();
                                }
                                catch (Exception exception5)
                                {
                                    ProjectData.SetProjectError(exception5);
                                    Exception exception2 = exception5;
                                    this.isPlaysound = false;
                                    ProjectData.ClearProjectError();
                                }
                            }
                            this.isTiming = false;
                            if (this.timingStatus != "MC")
                            {
                                this.numtime.Enabled = true;
                                if (!this.isInDbq && (this.timingStatus == "SL"))
                                {
                                    this.tlp_taskbar.Enabled = true;
                                }
                            }
                            else if (!this.isInDbq)
                            {
                                this.mcnext();
                            }
                            this.btn_umc_close.Visible = true;
                            this.Button3.Text = "开始";
                        }
                        else if (i == this.iLimit)
                        {
                            if (flag)
                            {
                                try
                                {
                                    SoundPlayer player3 = new SoundPlayer(this.myPlayUMC);
                                    player3.Play();
                                    player3.Dispose();
                                }
                                catch (Exception exception6)
                                {
                                    ProjectData.SetProjectError(exception6);
                                    Exception exception3 = exception6;
                                    this.isPlayUMC = false;
                                    ProjectData.ClearProjectError();
                                }
                            }
                            else
                            {
                                try
                                {
                                    SoundPlayer player4 = new SoundPlayer(this.myPlay20);
                                    player4.Play();
                                    player4.Dispose();
                                }
                                catch (Exception exception7)
                                {
                                    ProjectData.SetProjectError(exception7);
                                    Exception exception4 = exception7;
                                    this.isPlay20 = false;
                                    ProjectData.ClearProjectError();
                                }
                            }
                        }
                        this.iTick = 0;
                        break;
                    }
                }
                this.timeract();
            }
        }

        public void timeract()
        {
            this.line1add();
            string str = "";
            this.kminute = this.k / 60;
            this.ksecond = this.k % 60;
            this.iminute = this.i / 60;
            this.isecond = this.i % 60;
            this.timeDisp();
            if (this.k == 0)
            {
                switch (this.timingStatus)
                {
                    case "TP":
                        str = this.timer[0];
                        break;

                    case "MC":
                        str = this.timer[1];
                        break;

                    case "CR":
                        str = this.timer[2];
                        break;

                    case "FI":
                        str = this.timer[2];
                        break;

                    case "FS":
                        str = this.timer[3];
                        break;

                    case "SL":
                        str = this.timer[4];
                        this.speakerend(true);
                        break;

                    case "TB":
                        str = this.timer[5];
                        break;

                    case "UMC":
                        str = this.timer[5];
                        break;
                }
                if (!this.isInDbq)
                {
                    this.timingStatus = "";
                }
            }
            else if (this.k < 60)
            {
                str = this.timer[6] + Conversion.Str(this.ksecond) + this.timer[8];
            }
            else
            {
                str = this.timer[6] + Conversion.Str(this.kminute) + this.timer[7] + Conversion.Str(this.ksecond) + this.timer[8];
            }
            if (this.isInDbq)
            {
                this.lblmain.Text = this.dbqText + "\r\n" + str;
            }
            else
            {
                this.lblmain.Text = this.line1 + "\r\n" + str;
            }
        }

        public void timerControl(int command)
        {
            switch (command)
            {
                case 0:
                    this.isTiming = false;
                    this.iTick = 0;
                    this.lblcount.ForeColor = this.lightcolor;
                    this.lblmaohao.Visible = false;
                    break;

                case 1:
                    this.isTiming = true;
                    this.lblcount.ForeColor = Color.White;
                    break;
            }
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            this.TextBox10.Text = Conversions.ToString(this.cabinRate[this.TrackBar1.Value]);
        }

        private void txt_mainimg_TextChanged(object sender, EventArgs e)
        {
            if (this.chk_is_mainimg.Checked)
            {
                this.txt_mainimg.Enabled = true;
                this.btn_backbrowse.Enabled = true;
                this.isMainImg = true;
            }
            else
            {
                this.txt_mainimg.Enabled = false;
                this.btn_backbrowse.Enabled = false;
                this.isMainImg = false;
            }
        }

        private void txt_mc_add_click(object sender, EventArgs e)
        {
            if (this.txt_mc_add.Text == "点这里追加")
            {
                this.txt_mc_add.ReadOnly = false;
                this.txt_mc_add.Text = "";
                this.txt_mc_add.Focus();
                this.mcAll = this.mcCurrent + this.mcAdd;
                this.btn_mc_end.Visible = false;
                this.btn_mc_add.Enabled = true;
                this.txt_mc_totalnumber.Text = Conversions.ToString((int) (this.mcTotal + 1));
            }
        }

        private void txt_mc_add_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.mcNationAdd();
            }
        }

        private void txt_spl_add_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.slNationAdd();
            }
        }

        private void txt_spl_customtitle_TextChanged(object sender, EventArgs e)
        {
            this.cslTitle = this.txt_spl_customtitle.Text;
            if (this.txt_spl_customtitle.Text != this.cslTitle)
            {
                this.cslEdited = true;
            }
        }

        private void txthcmotion_TextChanged(object sender, EventArgs e)
        {
            this.txthcmotion.Text = Conversions.ToString(DateAndTime.Today.AddDays(220.0));
        }

        private void txthcmotion_TextChanged_1(object sender, EventArgs e)
        {
            this.writeRecord(this.txthcmotion.Text);
        }

        private void txtsession_gotfocus(object sender, EventArgs e)
        {
            this.txtsession.BackColor = Color.White;
        }

        public string vetoPower()
        {
            int num;
            int num3;
            string str2 = "";
            CheckBox[] boxArray = new CheckBox[] { this.CheckBox2, this.CheckBox3, this.CheckBox4, this.CheckBox5, this.CheckBox6 };
            int index = 0;
            do
            {
                if (boxArray[index].Checked)
                {
                    num++;
                    if (num > 1)
                    {
                        str2 = str2 + ", ";
                    }
                    str2 = str2 + boxArray[index].Text;
                }
                index++;
                num3 = 4;
            }
            while (index <= num3);
            if (num > 0)
            {
                return (str2 + this.voteString[7]);
            }
            return this.voteString[6];
        }

        public void vote(int op, bool r2)
        {
            switch (op)
            {
                case 1:
                    if (!r2)
                    {
                        this.opini[this.vtCurrent] = this.voteString[3];
                        break;
                    }
                    this.opini[this.pnat[this.q]] = this.voteString[3];
                    break;

                case 2:
                    if (!r2)
                    {
                        this.opini[this.vtCurrent] = this.voteString[4];
                    }
                    else
                    {
                        this.opini[this.pnat[this.q]] = this.voteString[4];
                    }
                    this.no++;
                    if (this.chk_vote_foujue.Checked)
                    {
                        string str;
                        if (r2)
                        {
                            str = this.nations[this.pnat[this.q]];
                        }
                        else
                        {
                            str = this.nations[this.vtCurrent];
                        }
                        switch (str)
                        {
                            case "中国":
                            case "中华人民共和国":
                            case "天朝":
                            case "China":
                            case "PRC":
                            case "PR of China":
                            case "People Republic of China":
                                this.CheckBox2.Checked = true;
                                break;

                            case "美国":
                            case "美利坚合众国":
                            case "美帝":
                            case "US":
                            case "USA":
                            case "U.S.":
                            case "U.S.A.":
                            case "United States":
                            case "United States of America":
                                this.CheckBox3.Checked = true;
                                break;

                            case "英国":
                            case "大不列颠及北爱尔兰联合王国":
                            case "UK":
                            case "U.K.":
                            case "Britain":
                            case "Great Britain":
                            case "United Kingdom":
                            case "United Kingdom of Great Britain and North Ireland":
                                this.CheckBox4.Checked = true;
                                break;

                            case "法国":
                            case "法兰西共和国":
                            case "法兰西第五共和国":
                            case "France":
                            case "Republic of France":
                                this.CheckBox5.Checked = true;
                                break;

                            case "俄罗斯":
                            case "俄罗斯联邦":
                            case "Russia":
                            case "Russian Federation":
                            case "Russian Fed":
                                this.CheckBox6.Checked = true;
                                break;
                        }
                    }
                    goto Label_040E;

                case 3:
                    this.opini[this.vtCurrent] = this.voteString[5];
                    this.abst++;
                    goto Label_040E;

                case 4:
                    this.p++;
                    this.pnat[this.p] = this.vtCurrent;
                    goto Label_040E;

                default:
                    goto Label_040E;
            }
            this.yes++;
        Label_040E:
            this.voteDisp();
            if (!r2)
            {
                if (this.nations[this.vtCurrent + 1] == "")
                {
                    if (this.p == 0)
                    {
                        this.Label108.Text = "请在右侧选择行使否决权的国家\r\n或直接结束投票";
                        this.lbl_vote_nation.Text = "";
                        this.chk_vote_foujue.Enabled = true;
                        this.btn_votectrl.Enabled = false;
                        this.btn_vote_next.Enabled = true;
                        this.btn_vote_next.Focus();
                    }
                    else
                    {
                        this.Label108.Text = "请开启下一轮投票";
                        this.lbl_vote_nation.Text = "---";
                        this.btn_votectrl.Enabled = false;
                        this.btn_vote_next.Enabled = true;
                        this.btn_vote_next.Focus();
                    }
                    this.voteAction(op, (this.vtCurrent - (this.page * this.listCapacity)) - 1);
                    this.btnyes.Enabled = false;
                    this.btnno.Enabled = false;
                    this.btnabst.Enabled = false;
                    this.btnpass.Enabled = false;
                }
                else
                {
                    this.voteAction(op, (this.vtCurrent - (this.page * this.listCapacity)) - 1);
                    this.current = this.vtCurrent / 30;
                    this.vtCurrent++;
                    this.lbl_vote_nation.Text = this.nations[this.vtCurrent];
                    if (((this.vtTotal % this.listCapacity) != 0) && (this.vtCurrent > ((this.page + 1) * this.listCapacity)))
                    {
                        this.autoPage(this.page + 1);
                        this.maxPages();
                    }
                }
            }
            else if (this.nations[this.pnat[this.q + 1]] == "")
            {
                this.Label108.Text = "请在右侧选择行使否决权的国家\r\n或直接结束投票";
                this.lbl_vote_nation.Text = "";
                this.voteAction(op, (this.pnat[this.q] - (this.page * this.listCapacity)) - 1);
                this.chk_vote_foujue.Enabled = true;
                this.btn_votectrl.Enabled = false;
                this.btn_vote_next.Enabled = true;
                this.btnyes.Enabled = false;
                this.btnno.Enabled = false;
                this.Button4.Enabled = true;
                this.btn_vote_next.Focus();
            }
            else
            {
                this.voteAction(op, (this.pnat[this.q] - (this.page * this.listCapacity)) - 1);
                this.current = this.pnat[this.q] / 30;
                this.q++;
                this.lbl_vote_nation.Text = this.nations[this.pnat[this.q]];
                if (((this.vtTotal % this.listCapacity) != 0) && (this.pnat[this.q] > ((this.page + 1) * this.listCapacity)))
                {
                    this.autoPage(this.page + 1);
                    this.maxPages();
                }
            }
        }

        public void voteAction(int command, int number)
        {
            Label[] labelArray = new Label[] { 
                this.lbl_slist_status_01, this.Label109, this.Label110, this.Label112, this.Label113, this.Label114, this.Label115, this.Label116, this.Label117, this.Label118, this.Label124, this.Label125, this.Label126, this.Label127, this.Label128, this.Label129, 
                this.Label130, this.Label131, this.Label132, this.Label133, this.Label139, this.Label140, this.Label141, this.Label142, this.Label143, this.Label144, this.Label145, this.Label146, this.Label147, this.Label148, this.Label154, this.Label155, 
                this.Label156, this.Label157, this.Label158, this.Label159, this.Label160, this.Label161, this.Label162, this.Label163
             };
            if (number < 40)
            {
                switch (command)
                {
                    case 0:
                    {
                        int num3;
                        int index = 0;
                        do
                        {
                            labelArray[index].Text = "";
                            labelArray[index].BackColor = Color.Transparent;
                            labelArray[index].ForeColor = Color.Black;
                            index++;
                            num3 = 0x27;
                        }
                        while (index <= num3);
                        break;
                    }
                    case 1:
                        labelArray[number].Text = this.voteString[3];
                        labelArray[number].BackColor = Color.MistyRose;
                        labelArray[number].ForeColor = Color.Firebrick;
                        break;

                    case 2:
                        labelArray[number].Text = this.voteString[4];
                        labelArray[number].BackColor = Color.PowderBlue;
                        labelArray[number].ForeColor = Color.RoyalBlue;
                        break;

                    case 3:
                        labelArray[number].Text = this.voteString[5];
                        labelArray[number].BackColor = Color.Yellow;
                        labelArray[number].ForeColor = Color.DarkGoldenrod;
                        break;
                }
            }
        }

        public void voteClear()
        {
            int num2;
            int index = 1;
            do
            {
                this.nations[index] = "";
                this.opini[index] = "";
                this.pnat[index - 1] = 0;
                this.yes = 0;
                this.no = 0;
                this.abst = 0;
                this.vtTotal = 0;
                this.vtCurrent = 0;
                this.p = 0;
                this.q = 0;
                this.voteStep = 0;
                this.r2 = false;
                this.current = 0;
                this.voteDisp();
                index++;
                num2 = 100;
            }
            while (index <= num2);
        }

        public void voteDisp()
        {
            this.lblyes.Text = Conversions.ToString(this.votePass());
            this.lblyes.Text = Conversion.Str(this.yes) + "/" + this.lblyes.Text;
            this.lblno.Text = Conversions.ToString(this.no);
            this.lblabst.Text = Conversions.ToString(this.abst);
        }

        public int votePass()
        {
            int num;
            if (this.chk_noabst.Checked)
            {
                num = this.maj67vote - this.abst;
            }
            else
            {
                num = this.maj67vote;
            }
            if (this.rad_50maj.Checked)
            {
                return ((num / 2) + 1);
            }
            if (this.rad_67maj.Checked)
            {
                return (((num * 2) / 3) + 1);
            }
            if (this.rad_80maj.Checked)
            {
                num = (num * 4) / 5;
            }
            return num;
        }

        public void Votestart(bool isMotion)
        {
            if (isMotion)
            {
                if (this.language == 1)
                {
                    this.lblmain.Text = this.lblmain.Text + "\r\n获得通过，投票开始";
                }
                else
                {
                    this.lblmain.Text = this.lblmain.Text + "\r\nMotion passes, vote starts";
                }
                this.cbx_fselect.Text = this.cbx_mfileselect.Text;
                this.motionClose();
            }
            else
            {
                string str;
                if (this.language == 1)
                {
                    str = "对" + this.cbx_fselect.Text + "进行投票";
                    this.lblmain.Text = "正在" + str;
                }
                else
                {
                    str = "Vote for " + this.cbx_fselect.Text + "";
                    this.lblmain.Text = "Voting for " + this.cbx_fselect.Text + "";
                }
                this.txthcmotion.Text = str;
                this.panel_files.Visible = false;
            }
            this.tlp_taskbar.Enabled = false;
            this.panel_vote.Visible = true;
            this.panel_vote_roll.Visible = true;
            if (this.votePresentSaved)
            {
                if (Interaction.MsgBox("您保存了上次投票的出席情况。\r\n是否直接使用它？", MsgBoxStyle.Question | MsgBoxStyle.YesNo, "投票") == MsgBoxResult.Yes)
                {
                    int num;
                    StreamReader reader = new StreamReader(@"saved\" + this.lastPath + @"\nationlist_p.txt");
                    while (num < this.clb_nation_vote.Items.Count)
                    {
                        if (reader.ReadLine() == "True")
                        {
                            if (num < 40)
                            {
                                this.listAction("add", this.vtTotal, Conversions.ToString(this.clb_nation_vote.Items[num]));
                            }
                            this.vtTotal++;
                            this.nations[this.vtTotal] = Conversions.ToString(this.clb_nation_vote.Items[num]);
                        }
                        num++;
                    }
                    reader.Close();
                    this.tlp_screenlist.Visible = true;
                    this.maxPages();
                    this.autoPage(0);
                    this.lblpresent.Text = Conversions.ToString(this.vtTotal);
                    this.lbl50maj.Text = Conversions.ToString((int) ((this.vtTotal / 2) + 1));
                    this.lbl67maj.Text = Conversions.ToString((int) (((this.vtTotal * 2) / 3) + 1));
                    this.maj67vote = this.vtTotal;
                    this.lbl_vote_step.Text = "第2步: 进行第1轮投票";
                    this.lbl_vote_nation.Text = this.nations[1];
                    this.panel_vote_config.Visible = true;
                    this.panel_vote_ctrl.Visible = true;
                    this.vtCurrent = 1;
                    this.voteDisp();
                    this.btnyes.Enabled = true;
                    this.btnno.Enabled = true;
                    this.btnabst.Enabled = true;
                    this.btnpass.Enabled = true;
                    this.panel_vote_roll.Visible = false;
                    this.btn_vote_next.Enabled = false;
                    this.btn_votectrl.Enabled = true;
                    this.btn_votectrl.Focus();
                    this.voteStep = 2;
                }
                else
                {
                    this.VotestartStep1();
                }
            }
            else
            {
                this.VotestartStep1();
            }
            if (this.language == 1)
            {
                this.CheckBox2.Text = "中国";
                this.CheckBox3.Text = "美国";
                this.CheckBox4.Text = "英国";
                this.CheckBox5.Text = "法国";
                this.CheckBox6.Text = "俄罗斯";
                this.lblyes1.Text = "赞成:";
                this.lblno1.Text = "反对:";
                this.lblabst1.Text = "弃权:";
            }
        }

        public void VotestartStep1()
        {
            this.listAction("clear", 0, "");
            this.clb_nation_vote.Items.Clear();
            StreamReader reader = new StreamReader(@"saved\" + this.lastPath + @"\nationlist.txt");
            try
            {
                while (reader != null)
                {
                    this.clb_nation_vote.Items.Add(reader.ReadLine());
                }
                reader.Close();
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                reader.Close();
                ProjectData.ClearProjectError();
            }
            this.voteStep = 1;
            this.chk_vote_saveplist.Checked = false;
        }

        public void writeRecord(string neiRong)
        {
            StreamWriter writer = new StreamWriter(@"saved\" + this.lastPath + @"\record.txt", true);
            writer.Write(Conversions.ToString(DateAndTime.TimeOfDay) + "\r\n" + neiRong + "\r\n\r\n");
            writer.Close();
            writer.Dispose();
        }

        public void writeStat()
        {
            StreamWriter writer = new StreamWriter(@"DATA\STATUS.edb");
            writer.WriteLine(this.language);
            writer.WriteLine(this.topicSelection);
            writer.WriteLine(this.conference);
            writer.WriteLine(this.committee);
            writer.WriteLine(this.topic[0]);
            writer.WriteLine(this.topic[1]);
            writer.WriteLine(this.isStarted);
            writer.WriteLine(this.isSingelDel);
            writer.WriteLine(this.session);
            writer.Close();
        }

        public void yieldAct(int type, bool start, bool isContinue)
        {
            this.isYield = true;
            if (!start)
            {
                this.speakerend(false);
                this.slSpeakNext();
                if (type == 4)
                {
                    this.lblmain.Text = this.txthcmotion.Text + "\r\n" + this.yieldString[5];
                }
                else if (this.language == 1)
                {
                    this.lblmain.Text = this.txthcmotion.Text + "\r\n让渡发言结束";
                }
                else
                {
                    this.lblmain.Text = this.txthcmotion.Text + "\r\nYield-time Speech Finished";
                }
                this.isYield = false;
                this.tlp_taskbar.Enabled = true;
            }
            else
            {
                string str;
                if (!isContinue)
                {
                    switch (type)
                    {
                        case 1:
                            str = this.yieldString[0] + this.txt_spl_yieldto.Text;
                            if (this.language == 1)
                            {
                                str = str + "代表";
                            }
                            this.txthcmotion.Text = str;
                            break;

                        case 2:
                            str = this.yieldString[1] + "\r\n" + this.yieldString[2] + this.txt_spl_yieldto.Text;
                            this.txthcmotion.Text = str;
                            break;

                        case 3:
                            str = this.yieldString[3] + "\r\n" + this.yieldString[4] + this.txt_spl_yieldto.Text;
                            this.txthcmotion.Text = str;
                            break;
                    }
                }
                else
                {
                    str = ", " + this.txt_spl_yieldto.Text;
                    this.txthcmotion.Text = this.txthcmotion.Text + str;
                }
                this.timerControl(1);
                this.btn_spl_start.Text = "暂停";
                this.cbx_spl_yield.Enabled = false;
            }
        }

        public void yieldAction(int type)
        {
            switch (type)
            {
                case 1:
                    this.Label28.Text = "让渡给　　　　　　　　　　 代表";
                    this.txt_spl_yieldto.Left = 0x39;
                    this.btn_spl_yieldgo.Text = "开始";
                    this.yieldType = 1;
                    break;

                case 2:
                    this.Label28.Text = "提问的国家";
                    this.btn_spl_yieldgo.Text = "回答开始";
                    this.txt_spl_yieldto.Left = 0x53;
                    this.yieldType = 2;
                    break;

                case 3:
                    this.Label28.Text = "评论的国家";
                    this.btn_spl_yieldgo.Text = "开始";
                    this.txt_spl_yieldto.Left = 0x53;
                    this.yieldType = 3;
                    break;
            }
        }

        internal virtual Button btn_backbrowse
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_backbrowse;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._btn_backbrowse = value;
            }
        }

        internal virtual Button btn_bannerbrowse
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_bannerbrowse;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_bannerbrowse_Click);
                if (this._btn_bannerbrowse != null)
                {
                    this._btn_bannerbrowse.Click -= handler;
                }
                this._btn_bannerbrowse = value;
                if (this._btn_bannerbrowse != null)
                {
                    this._btn_bannerbrowse.Click += handler;
                }
            }
        }

        internal virtual Button btn_create_back
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_create_back;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_create_back_Click);
                if (this._btn_create_back != null)
                {
                    this._btn_create_back.Click -= handler;
                }
                this._btn_create_back = value;
                if (this._btn_create_back != null)
                {
                    this._btn_create_back.Click += handler;
                }
            }
        }

        internal virtual Button btn_create_next
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_create_next;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_create_next_Click);
                if (this._btn_create_next != null)
                {
                    this._btn_create_next.Click -= handler;
                }
                this._btn_create_next = value;
                if (this._btn_create_next != null)
                {
                    this._btn_create_next.Click += handler;
                }
            }
        }

        internal virtual Button btn_dabianquan
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_dabianquan;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_dabianquan_Click);
                if (this._btn_dabianquan != null)
                {
                    this._btn_dabianquan.Click -= handler;
                }
                this._btn_dabianquan = value;
                if (this._btn_dabianquan != null)
                {
                    this._btn_dabianquan.Click += handler;
                }
            }
        }

        internal virtual Button btn_dbqcancel
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_dbqcancel;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_dbqcancel_Click);
                if (this._btn_dbqcancel != null)
                {
                    this._btn_dbqcancel.Click -= handler;
                }
                this._btn_dbqcancel = value;
                if (this._btn_dbqcancel != null)
                {
                    this._btn_dbqcancel.Click += handler;
                }
            }
        }

        internal virtual Button btn_dbqok
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_dbqok;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_dbqok_Click);
                if (this._btn_dbqok != null)
                {
                    this._btn_dbqok.Click -= handler;
                }
                this._btn_dbqok = value;
                if (this._btn_dbqok != null)
                {
                    this._btn_dbqok.Click += handler;
                }
            }
        }

        internal virtual Button btn_dbqstop
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_dbqstop;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_dbqstop_Click);
                if (this._btn_dbqstop != null)
                {
                    this._btn_dbqstop.Click -= handler;
                }
                this._btn_dbqstop = value;
                if (this._btn_dbqstop != null)
                {
                    this._btn_dbqstop.Click += handler;
                }
            }
        }

        internal virtual Button btn_enl_cancel
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_enl_cancel;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_enl_cancel_Click);
                if (this._btn_enl_cancel != null)
                {
                    this._btn_enl_cancel.Click -= handler;
                }
                this._btn_enl_cancel = value;
                if (this._btn_enl_cancel != null)
                {
                    this._btn_enl_cancel.Click += handler;
                }
            }
        }

        internal virtual Button btn_enl_save
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_enl_save;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_enl_save_Click);
                if (this._btn_enl_save != null)
                {
                    this._btn_enl_save.Click -= handler;
                }
                this._btn_enl_save = value;
                if (this._btn_enl_save != null)
                {
                    this._btn_enl_save.Click += handler;
                }
            }
        }

        internal virtual Button btn_entermanage
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_entermanage;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_entermanage_Click);
                MouseEventHandler handler2 = new MouseEventHandler(this.rad_create_CheckedChanged);
                if (this._btn_entermanage != null)
                {
                    this._btn_entermanage.Click -= handler;
                    this._btn_entermanage.MouseUp -= handler2;
                }
                this._btn_entermanage = value;
                if (this._btn_entermanage != null)
                {
                    this._btn_entermanage.Click += handler;
                    this._btn_entermanage.MouseUp += handler2;
                }
            }
        }

        internal virtual Button btn_file
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_file;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_file_Click);
                if (this._btn_file != null)
                {
                    this._btn_file.Click -= handler;
                }
                this._btn_file = value;
                if (this._btn_file != null)
                {
                    this._btn_file.Click += handler;
                }
            }
        }

        internal virtual Button btn_file_1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_file_1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_file_1_Click);
                if (this._btn_file_1 != null)
                {
                    this._btn_file_1.Click -= handler;
                }
                this._btn_file_1 = value;
                if (this._btn_file_1 != null)
                {
                    this._btn_file_1.Click += handler;
                }
            }
        }

        internal virtual Button btn_file_2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_file_2;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_file_1_Click);
                if (this._btn_file_2 != null)
                {
                    this._btn_file_2.Click -= handler;
                }
                this._btn_file_2 = value;
                if (this._btn_file_2 != null)
                {
                    this._btn_file_2.Click += handler;
                }
            }
        }

        internal virtual Button btn_file_browse
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_file_browse;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_file_browse_Click);
                if (this._btn_file_browse != null)
                {
                    this._btn_file_browse.Click -= handler;
                }
                this._btn_file_browse = value;
                if (this._btn_file_browse != null)
                {
                    this._btn_file_browse.Click += handler;
                }
            }
        }

        internal virtual Button btn_file_cancel
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_file_cancel;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_file_cancel_Click);
                if (this._btn_file_cancel != null)
                {
                    this._btn_file_cancel.Click -= handler;
                }
                this._btn_file_cancel = value;
                if (this._btn_file_cancel != null)
                {
                    this._btn_file_cancel.Click += handler;
                }
            }
        }

        internal virtual Button btn_file_modify
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_file_modify;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_file_modify_Click);
                if (this._btn_file_modify != null)
                {
                    this._btn_file_modify.Click -= handler;
                }
                this._btn_file_modify = value;
                if (this._btn_file_modify != null)
                {
                    this._btn_file_modify.Click += handler;
                }
            }
        }

        internal virtual Button btn_file_ok
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_file_ok;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_file_ok_Click);
                if (this._btn_file_ok != null)
                {
                    this._btn_file_ok.Click -= handler;
                }
                this._btn_file_ok = value;
                if (this._btn_file_ok != null)
                {
                    this._btn_file_ok.Click += handler;
                }
            }
        }

        internal virtual Button btn_fileplayback
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_fileplayback;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._btn_fileplayback = value;
            }
        }

        internal virtual Button btn_files_3
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_files_3;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_file_1_Click);
                if (this._btn_files_3 != null)
                {
                    this._btn_files_3.Click -= handler;
                }
                this._btn_files_3 = value;
                if (this._btn_files_3 != null)
                {
                    this._btn_files_3.Click += handler;
                }
            }
        }

        internal virtual Button btn_files_4
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_files_4;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_file_1_Click);
                if (this._btn_files_4 != null)
                {
                    this._btn_files_4.Click -= handler;
                }
                this._btn_files_4 = value;
                if (this._btn_files_4 != null)
                {
                    this._btn_files_4.Click += handler;
                }
            }
        }

        internal virtual Button btn_files_5
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_files_5;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_file_1_Click);
                if (this._btn_files_5 != null)
                {
                    this._btn_files_5.Click -= handler;
                }
                this._btn_files_5 = value;
                if (this._btn_files_5 != null)
                {
                    this._btn_files_5.Click += handler;
                }
            }
        }

        internal virtual Button btn_fontchange
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_fontchange;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_fontchange_Click);
                if (this._btn_fontchange != null)
                {
                    this._btn_fontchange.Click -= handler;
                }
                this._btn_fontchange = value;
                if (this._btn_fontchange != null)
                {
                    this._btn_fontchange.Click += handler;
                }
            }
        }

        internal virtual Button btn_ispresent
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_ispresent;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_ispresent_Click);
                if (this._btn_ispresent != null)
                {
                    this._btn_ispresent.Click -= handler;
                }
                this._btn_ispresent = value;
                if (this._btn_ispresent != null)
                {
                    this._btn_ispresent.Click += handler;
                }
            }
        }

        internal virtual Button btn_manage_exit
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_manage_exit;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_manage_exit_Click);
                if (this._btn_manage_exit != null)
                {
                    this._btn_manage_exit.Click -= handler;
                }
                this._btn_manage_exit = value;
                if (this._btn_manage_exit != null)
                {
                    this._btn_manage_exit.Click += handler;
                }
            }
        }

        internal virtual Button btn_manage_save
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_manage_save;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_manage_save_Click);
                if (this._btn_manage_save != null)
                {
                    this._btn_manage_save.Click -= handler;
                }
                this._btn_manage_save = value;
                if (this._btn_manage_save != null)
                {
                    this._btn_manage_save.Click += handler;
                }
            }
        }

        internal virtual Button btn_mc_add
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_mc_add;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_mc_add_Click);
                if (this._btn_mc_add != null)
                {
                    this._btn_mc_add.Click -= handler;
                }
                this._btn_mc_add = value;
                if (this._btn_mc_add != null)
                {
                    this._btn_mc_add.Click += handler;
                }
            }
        }

        internal virtual Button btn_mc_end
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_mc_end;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_mc_end_Click);
                if (this._btn_mc_end != null)
                {
                    this._btn_mc_end.Click -= handler;
                }
                this._btn_mc_end = value;
                if (this._btn_mc_end != null)
                {
                    this._btn_mc_end.Click += handler;
                }
            }
        }

        internal virtual Button btn_mc_next
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_mc_next;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_mc_next_Click);
                if (this._btn_mc_next != null)
                {
                    this._btn_mc_next.Click -= handler;
                }
                this._btn_mc_next = value;
                if (this._btn_mc_next != null)
                {
                    this._btn_mc_next.Click += handler;
                }
            }
        }

        internal virtual Button btn_mc_start
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_mc_start;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_mc_start_Click);
                if (this._btn_mc_start != null)
                {
                    this._btn_mc_start.Click -= handler;
                }
                this._btn_mc_start = value;
                if (this._btn_mc_start != null)
                {
                    this._btn_mc_start.Click += handler;
                }
            }
        }

        internal virtual Button btn_mcedit_cancle
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_mcedit_cancle;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_mcedit_cancle_Click);
                if (this._btn_mcedit_cancle != null)
                {
                    this._btn_mcedit_cancle.Click -= handler;
                }
                this._btn_mcedit_cancle = value;
                if (this._btn_mcedit_cancle != null)
                {
                    this._btn_mcedit_cancle.Click += handler;
                }
            }
        }

        internal virtual Button btn_mcedit_save
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_mcedit_save;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_mcedit_save_Click);
                if (this._btn_mcedit_save != null)
                {
                    this._btn_mcedit_save.Click -= handler;
                }
                this._btn_mcedit_save = value;
                if (this._btn_mcedit_save != null)
                {
                    this._btn_mcedit_save.Click += handler;
                }
            }
        }

        internal virtual Button btn_misc
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_misc;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_misc_Click);
                if (this._btn_misc != null)
                {
                    this._btn_misc.Click -= handler;
                }
                this._btn_misc = value;
                if (this._btn_misc != null)
                {
                    this._btn_misc.Click += handler;
                }
            }
        }

        internal virtual Button btn_misc_1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_misc_1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lbl_teabreak_Click);
                if (this._btn_misc_1 != null)
                {
                    this._btn_misc_1.Click -= handler;
                }
                this._btn_misc_1 = value;
                if (this._btn_misc_1 != null)
                {
                    this._btn_misc_1.Click += handler;
                }
            }
        }

        internal virtual Button btn_misc_2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_misc_2;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lbl_teabreak_Click);
                if (this._btn_misc_2 != null)
                {
                    this._btn_misc_2.Click -= handler;
                }
                this._btn_misc_2 = value;
                if (this._btn_misc_2 != null)
                {
                    this._btn_misc_2.Click += handler;
                }
            }
        }

        internal virtual Button btn_misc_3
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_misc_3;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lbl_teabreak_Click);
                if (this._btn_misc_3 != null)
                {
                    this._btn_misc_3.Click -= handler;
                }
                this._btn_misc_3 = value;
                if (this._btn_misc_3 != null)
                {
                    this._btn_misc_3.Click += handler;
                }
            }
        }

        internal virtual Button btn_misc_4
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_misc_4;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_misc_4_Click);
                if (this._btn_misc_4 != null)
                {
                    this._btn_misc_4.Click -= handler;
                }
                this._btn_misc_4 = value;
                if (this._btn_misc_4 != null)
                {
                    this._btn_misc_4.Click += handler;
                }
            }
        }

        internal virtual Button btn_misc_5
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_misc_5;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lbl_teabreak_Click);
                if (this._btn_misc_5 != null)
                {
                    this._btn_misc_5.Click -= handler;
                }
                this._btn_misc_5 = value;
                if (this._btn_misc_5 != null)
                {
                    this._btn_misc_5.Click += handler;
                }
            }
        }

        internal virtual Button btn_misc_cancel
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_misc_cancel;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_system_calcel_Ck);
                if (this._btn_misc_cancel != null)
                {
                    this._btn_misc_cancel.Click -= handler;
                }
                this._btn_misc_cancel = value;
                if (this._btn_misc_cancel != null)
                {
                    this._btn_misc_cancel.Click += handler;
                }
            }
        }

        internal virtual Button btn_misc_ok
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_misc_ok;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_teabreak_ok_Click);
                if (this._btn_misc_ok != null)
                {
                    this._btn_misc_ok.Click -= handler;
                }
                this._btn_misc_ok = value;
                if (this._btn_misc_ok != null)
                {
                    this._btn_misc_ok.Click += handler;
                }
            }
        }

        internal virtual Button btn_modecancel
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_modecancel;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.rad_create_CheckedChanged);
                if (this._btn_modecancel != null)
                {
                    this._btn_modecancel.Click -= handler;
                }
                this._btn_modecancel = value;
                if (this._btn_modecancel != null)
                {
                    this._btn_modecancel.Click += handler;
                }
            }
        }

        internal virtual Button btn_modify_presents
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_modify_presents;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_sessionstart_Click);
                if (this._btn_modify_presents != null)
                {
                    this._btn_modify_presents.Click -= handler;
                }
                this._btn_modify_presents = value;
                if (this._btn_modify_presents != null)
                {
                    this._btn_modify_presents.Click += handler;
                }
            }
        }

        internal virtual Button btn_motion_1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_motion_1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_motion_1_Click);
                if (this._btn_motion_1 != null)
                {
                    this._btn_motion_1.Click -= handler;
                }
                this._btn_motion_1 = value;
                if (this._btn_motion_1 != null)
                {
                    this._btn_motion_1.Click += handler;
                }
            }
        }

        internal virtual Button btn_motion_2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_motion_2;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_motion_1_Click);
                if (this._btn_motion_2 != null)
                {
                    this._btn_motion_2.Click -= handler;
                }
                this._btn_motion_2 = value;
                if (this._btn_motion_2 != null)
                {
                    this._btn_motion_2.Click += handler;
                }
            }
        }

        internal virtual Button btn_motion_3
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_motion_3;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_motion_1_Click);
                if (this._btn_motion_3 != null)
                {
                    this._btn_motion_3.Click -= handler;
                }
                this._btn_motion_3 = value;
                if (this._btn_motion_3 != null)
                {
                    this._btn_motion_3.Click += handler;
                }
            }
        }

        internal virtual Button btn_motion_4
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_motion_4;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_motion_1_Click);
                if (this._btn_motion_4 != null)
                {
                    this._btn_motion_4.Click -= handler;
                }
                this._btn_motion_4 = value;
                if (this._btn_motion_4 != null)
                {
                    this._btn_motion_4.Click += handler;
                }
            }
        }

        internal virtual Button btn_motion_5
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_motion_5;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_motion_1_Click);
                if (this._btn_motion_5 != null)
                {
                    this._btn_motion_5.Click -= handler;
                }
                this._btn_motion_5 = value;
                if (this._btn_motion_5 != null)
                {
                    this._btn_motion_5.Click += handler;
                }
            }
        }

        internal virtual Button btn_motion_6
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_motion_6;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_motion_1_Click);
                if (this._btn_motion_6 != null)
                {
                    this._btn_motion_6.Click -= handler;
                }
                this._btn_motion_6 = value;
                if (this._btn_motion_6 != null)
                {
                    this._btn_motion_6.Click += handler;
                }
            }
        }

        internal virtual Button btn_motion_7
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_motion_7;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_motion_1_Click);
                if (this._btn_motion_7 != null)
                {
                    this._btn_motion_7.Click -= handler;
                }
                this._btn_motion_7 = value;
                if (this._btn_motion_7 != null)
                {
                    this._btn_motion_7.Click += handler;
                }
            }
        }

        internal virtual Button btn_motion_8
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_motion_8;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_motion_1_Click);
                if (this._btn_motion_8 != null)
                {
                    this._btn_motion_8.Click -= handler;
                }
                this._btn_motion_8 = value;
                if (this._btn_motion_8 != null)
                {
                    this._btn_motion_8.Click += handler;
                }
            }
        }

        internal virtual Button btn_motion_9
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_motion_9;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_motion_1_Click);
                if (this._btn_motion_9 != null)
                {
                    this._btn_motion_9.Click -= handler;
                }
                this._btn_motion_9 = value;
                if (this._btn_motion_9 != null)
                {
                    this._btn_motion_9.Click += handler;
                }
            }
        }

        internal virtual Button btn_motion_cancel
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_motion_cancel;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_motion_cancel_Click);
                if (this._btn_motion_cancel != null)
                {
                    this._btn_motion_cancel.Click -= handler;
                }
                this._btn_motion_cancel = value;
                if (this._btn_motion_cancel != null)
                {
                    this._btn_motion_cancel.Click += handler;
                }
            }
        }

        internal virtual Button btn_motion_finish
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_motion_finish;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_motion_finish_Click);
                if (this._btn_motion_finish != null)
                {
                    this._btn_motion_finish.Click -= handler;
                }
                this._btn_motion_finish = value;
                if (this._btn_motion_finish != null)
                {
                    this._btn_motion_finish.Click += handler;
                }
            }
        }

        internal virtual Button btn_motions
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_motions;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_motions_Click);
                if (this._btn_motions != null)
                {
                    this._btn_motions.Click -= handler;
                }
                this._btn_motions = value;
                if (this._btn_motions != null)
                {
                    this._btn_motions.Click += handler;
                }
            }
        }

        internal virtual Button btn_motionstop
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_motionstop;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Button13_Click);
                if (this._btn_motionstop != null)
                {
                    this._btn_motionstop.Click -= handler;
                }
                this._btn_motionstop = value;
                if (this._btn_motionstop != null)
                {
                    this._btn_motionstop.Click += handler;
                }
            }
        }

        internal virtual Button btn_next
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_next;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Button11_Click);
                if (this._btn_next != null)
                {
                    this._btn_next.Click -= handler;
                }
                this._btn_next = value;
                if (this._btn_next != null)
                {
                    this._btn_next.Click += handler;
                }
            }
        }

        internal virtual Button btn_prev
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_prev;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_prev_Click);
                if (this._btn_prev != null)
                {
                    this._btn_prev.Click -= handler;
                }
                this._btn_prev = value;
                if (this._btn_prev != null)
                {
                    this._btn_prev.Click += handler;
                }
            }
        }

        internal virtual Button btn_read_close
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_read_close;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Button6_Click);
                if (this._btn_read_close != null)
                {
                    this._btn_read_close.Click -= handler;
                }
                this._btn_read_close = value;
                if (this._btn_read_close != null)
                {
                    this._btn_read_close.Click += handler;
                }
            }
        }

        internal virtual Button btn_roll_cancle
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_roll_cancle;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Button1_Click_1);
                if (this._btn_roll_cancle != null)
                {
                    this._btn_roll_cancle.Click -= handler;
                }
                this._btn_roll_cancle = value;
                if (this._btn_roll_cancle != null)
                {
                    this._btn_roll_cancle.Click += handler;
                }
            }
        }

        internal virtual Button btn_roll_finish
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_roll_finish;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_roll_finish_Click);
                if (this._btn_roll_finish != null)
                {
                    this._btn_roll_finish.Click -= handler;
                }
                this._btn_roll_finish = value;
                if (this._btn_roll_finish != null)
                {
                    this._btn_roll_finish.Click += handler;
                }
            }
        }

        internal virtual Button btn_sessionstart
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_sessionstart;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_sessionstart_Click);
                if (this._btn_sessionstart != null)
                {
                    this._btn_sessionstart.Click -= handler;
                }
                this._btn_sessionstart = value;
                if (this._btn_sessionstart != null)
                {
                    this._btn_sessionstart.Click += handler;
                }
            }
        }

        internal virtual Button btn_sfx1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_sfx1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_sfx1_Click);
                if (this._btn_sfx1 != null)
                {
                    this._btn_sfx1.Click -= handler;
                }
                this._btn_sfx1 = value;
                if (this._btn_sfx1 != null)
                {
                    this._btn_sfx1.Click += handler;
                }
            }
        }

        internal virtual Button btn_sfx2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_sfx2;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_sfx1_Click);
                if (this._btn_sfx2 != null)
                {
                    this._btn_sfx2.Click -= handler;
                }
                this._btn_sfx2 = value;
                if (this._btn_sfx2 != null)
                {
                    this._btn_sfx2.Click += handler;
                }
            }
        }

        internal virtual Button btn_sfx3
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_sfx3;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_sfx1_Click);
                if (this._btn_sfx3 != null)
                {
                    this._btn_sfx3.Click -= handler;
                }
                this._btn_sfx3 = value;
                if (this._btn_sfx3 != null)
                {
                    this._btn_sfx3.Click += handler;
                }
            }
        }

        internal virtual Button btn_sfx4
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_sfx4;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_sfx1_Click);
                if (this._btn_sfx4 != null)
                {
                    this._btn_sfx4.Click -= handler;
                }
                this._btn_sfx4 = value;
                if (this._btn_sfx4 != null)
                {
                    this._btn_sfx4.Click += handler;
                }
            }
        }

        internal virtual Button btn_sfxquick
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_sfxquick;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_sfxquick_Click);
                if (this._btn_sfxquick != null)
                {
                    this._btn_sfxquick.Click -= handler;
                }
                this._btn_sfxquick = value;
                if (this._btn_sfxquick != null)
                {
                    this._btn_sfxquick.Click += handler;
                }
            }
        }

        internal virtual Button btn_sizequick
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_sizequick;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_sizequick_Click);
                if (this._btn_sizequick != null)
                {
                    this._btn_sizequick.Click -= handler;
                }
                this._btn_sizequick = value;
                if (this._btn_sizequick != null)
                {
                    this._btn_sizequick.Click += handler;
                }
            }
        }

        internal virtual Button btn_speakerslist
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_speakerslist;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_speakerslist_Click);
                if (this._btn_speakerslist != null)
                {
                    this._btn_speakerslist.Click -= handler;
                }
                this._btn_speakerslist = value;
                if (this._btn_speakerslist != null)
                {
                    this._btn_speakerslist.Click += handler;
                }
            }
        }

        internal virtual Button btn_spl_add
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_spl_add;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_spl_add_Click);
                if (this._btn_spl_add != null)
                {
                    this._btn_spl_add.Click -= handler;
                }
                this._btn_spl_add = value;
                if (this._btn_spl_add != null)
                {
                    this._btn_spl_add.Click += handler;
                }
            }
        }

        internal virtual Button btn_spl_exit
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_spl_exit;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_spl_exit_Click);
                if (this._btn_spl_exit != null)
                {
                    this._btn_spl_exit.Click -= handler;
                }
                this._btn_spl_exit = value;
                if (this._btn_spl_exit != null)
                {
                    this._btn_spl_exit.Click += handler;
                }
            }
        }

        internal virtual Button btn_spl_loadcustom
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_spl_loadcustom;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_spl_loadcustom_Click);
                if (this._btn_spl_loadcustom != null)
                {
                    this._btn_spl_loadcustom.Click -= handler;
                }
                this._btn_spl_loadcustom = value;
                if (this._btn_spl_loadcustom != null)
                {
                    this._btn_spl_loadcustom.Click += handler;
                }
            }
        }

        internal virtual Button btn_spl_savecustom
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_spl_savecustom;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_spl_savecustom_Click);
                if (this._btn_spl_savecustom != null)
                {
                    this._btn_spl_savecustom.Click -= handler;
                }
                this._btn_spl_savecustom = value;
                if (this._btn_spl_savecustom != null)
                {
                    this._btn_spl_savecustom.Click += handler;
                }
            }
        }

        internal virtual Button btn_spl_start
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_spl_start;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_spl_start_Click);
                if (this._btn_spl_start != null)
                {
                    this._btn_spl_start.Click -= handler;
                }
                this._btn_spl_start = value;
                if (this._btn_spl_start != null)
                {
                    this._btn_spl_start.Click += handler;
                }
            }
        }

        internal virtual Button btn_spl_yieldend
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_spl_yieldend;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_spl_yieldend_Click);
                if (this._btn_spl_yieldend != null)
                {
                    this._btn_spl_yieldend.Click -= handler;
                }
                this._btn_spl_yieldend = value;
                if (this._btn_spl_yieldend != null)
                {
                    this._btn_spl_yieldend.Click += handler;
                }
            }
        }

        internal virtual Button btn_spl_yieldgo
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_spl_yieldgo;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_spl_yieldgo_Click);
                if (this._btn_spl_yieldgo != null)
                {
                    this._btn_spl_yieldgo.Click -= handler;
                }
                this._btn_spl_yieldgo = value;
                if (this._btn_spl_yieldgo != null)
                {
                    this._btn_spl_yieldgo.Click += handler;
                }
            }
        }

        internal virtual Button btn_start_cancel
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_start_cancel;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Button1_Click_1);
                if (this._btn_start_cancel != null)
                {
                    this._btn_start_cancel.Click -= handler;
                }
                this._btn_start_cancel = value;
                if (this._btn_start_cancel != null)
                {
                    this._btn_start_cancel.Click += handler;
                }
            }
        }

        internal virtual Button btn_start_ok
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_start_ok;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_start_ok_Click);
                if (this._btn_start_ok != null)
                {
                    this._btn_start_ok.Click -= handler;
                }
                this._btn_start_ok = value;
                if (this._btn_start_ok != null)
                {
                    this._btn_start_ok.Click += handler;
                }
            }
        }

        internal virtual Button btn_system
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_system;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_system_Click);
                if (this._btn_system != null)
                {
                    this._btn_system.Click -= handler;
                }
                this._btn_system = value;
                if (this._btn_system != null)
                {
                    this._btn_system.Click += handler;
                }
            }
        }

        internal virtual Button btn_system_1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_system_1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_entermanage_Click);
                if (this._btn_system_1 != null)
                {
                    this._btn_system_1.Click -= handler;
                }
                this._btn_system_1 = value;
                if (this._btn_system_1 != null)
                {
                    this._btn_system_1.Click += handler;
                }
            }
        }

        internal virtual Button btn_system_calcel
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_system_calcel;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_system_calcel_Click);
                if (this._btn_system_calcel != null)
                {
                    this._btn_system_calcel.Click -= handler;
                }
                this._btn_system_calcel = value;
                if (this._btn_system_calcel != null)
                {
                    this._btn_system_calcel.Click += handler;
                }
            }
        }

        internal virtual Button btn_umc_close
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_umc_close;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Button6_Click);
                if (this._btn_umc_close != null)
                {
                    this._btn_umc_close.Click -= handler;
                }
                this._btn_umc_close = value;
                if (this._btn_umc_close != null)
                {
                    this._btn_umc_close.Click += handler;
                }
            }
        }

        internal virtual Button btn_umc_reset
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_umc_reset;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_umc_reset_Click);
                if (this._btn_umc_reset != null)
                {
                    this._btn_umc_reset.Click -= handler;
                }
                this._btn_umc_reset = value;
                if (this._btn_umc_reset != null)
                {
                    this._btn_umc_reset.Click += handler;
                }
            }
        }

        internal virtual Button btn_umc_send
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_umc_send;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_umc_send_Click);
                if (this._btn_umc_send != null)
                {
                    this._btn_umc_send.Click -= handler;
                }
                this._btn_umc_send = value;
                if (this._btn_umc_send != null)
                {
                    this._btn_umc_send.Click += handler;
                }
            }
        }

        internal virtual Button btn_vote_cancel
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_vote_cancel;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cancelvote);
                if (this._btn_vote_cancel != null)
                {
                    this._btn_vote_cancel.Click -= handler;
                }
                this._btn_vote_cancel = value;
                if (this._btn_vote_cancel != null)
                {
                    this._btn_vote_cancel.Click += handler;
                }
            }
        }

        internal virtual Button btn_vote_next
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_vote_next;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btn_vote_next_Click);
                if (this._btn_vote_next != null)
                {
                    this._btn_vote_next.Click -= handler;
                }
                this._btn_vote_next = value;
                if (this._btn_vote_next != null)
                {
                    this._btn_vote_next.Click += handler;
                }
            }
        }

        internal virtual Button btn_votectrl
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btn_votectrl;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.Form1_KeyPress);
                if (this._btn_votectrl != null)
                {
                    this._btn_votectrl.KeyPress -= handler;
                }
                this._btn_votectrl = value;
                if (this._btn_votectrl != null)
                {
                    this._btn_votectrl.KeyPress += handler;
                }
            }
        }

        internal virtual Button btnabst
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btnabst;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btnabst_Click);
                if (this._btnabst != null)
                {
                    this._btnabst.Click -= handler;
                }
                this._btnabst = value;
                if (this._btnabst != null)
                {
                    this._btnabst.Click += handler;
                }
            }
        }

        internal virtual Button btnexit
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btnexit;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btnexit_Click);
                if (this._btnexit != null)
                {
                    this._btnexit.Click -= handler;
                }
                this._btnexit = value;
                if (this._btnexit != null)
                {
                    this._btnexit.Click += handler;
                }
            }
        }

        internal virtual Button btnno
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btnno;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btnno_Click);
                if (this._btnno != null)
                {
                    this._btnno.Click -= handler;
                }
                this._btnno = value;
                if (this._btnno != null)
                {
                    this._btnno.Click += handler;
                }
            }
        }

        internal virtual Button btnpass
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btnpass;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btnpass_Click);
                if (this._btnpass != null)
                {
                    this._btnpass.Click -= handler;
                }
                this._btnpass = value;
                if (this._btnpass != null)
                {
                    this._btnpass.Click += handler;
                }
            }
        }

        internal virtual Button btnstart
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btnstart;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Button1_Click);
                if (this._btnstart != null)
                {
                    this._btnstart.Click -= handler;
                }
                this._btnstart = value;
                if (this._btnstart != null)
                {
                    this._btnstart.Click += handler;
                }
            }
        }

        internal virtual Button btnyes
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btnyes;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btnyes_Click);
                if (this._btnyes != null)
                {
                    this._btnyes.Click -= handler;
                }
                this._btnyes = value;
                if (this._btnyes != null)
                {
                    this._btnyes.Click += handler;
                }
            }
        }

        internal virtual Button Button1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Button1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Button1 = value;
            }
        }

        internal virtual Button Button11
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Button11;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Button11 = value;
            }
        }

        internal virtual Button Button12
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Button12;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Button12 = value;
            }
        }

        internal virtual Button Button2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Button2;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Button2_Click);
                if (this._Button2 != null)
                {
                    this._Button2.Click -= handler;
                }
                this._Button2 = value;
                if (this._Button2 != null)
                {
                    this._Button2.Click += handler;
                }
            }
        }

        internal virtual Button Button3
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Button3;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Button3_Click);
                if (this._Button3 != null)
                {
                    this._Button3.Click -= handler;
                }
                this._Button3 = value;
                if (this._Button3 != null)
                {
                    this._Button3.Click += handler;
                }
            }
        }

        internal virtual Button Button4
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Button4;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Button4_Click);
                if (this._Button4 != null)
                {
                    this._Button4.Click -= handler;
                }
                this._Button4 = value;
                if (this._Button4 != null)
                {
                    this._Button4.Click += handler;
                }
            }
        }

        internal virtual Button Button5
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Button5;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Button5 = value;
            }
        }

        internal virtual ComboBox cbx_awards
        {
            [DebuggerNonUserCode]
            get
            {
                return this._cbx_awards;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._cbx_awards = value;
            }
        }

        internal virtual ComboBox cbx_fmode
        {
            [DebuggerNonUserCode]
            get
            {
                return this._cbx_fmode;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cbx_fmode_SelectedIndexChanged);
                if (this._cbx_fmode != null)
                {
                    this._cbx_fmode.SelectedIndexChanged -= handler;
                }
                this._cbx_fmode = value;
                if (this._cbx_fmode != null)
                {
                    this._cbx_fmode.SelectedIndexChanged += handler;
                }
            }
        }

        internal virtual ComboBox cbx_fselcet_2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._cbx_fselcet_2;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._cbx_fselcet_2 = value;
            }
        }

        internal virtual ComboBox cbx_fselect
        {
            [DebuggerNonUserCode]
            get
            {
                return this._cbx_fselect;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._cbx_fselect = value;
            }
        }

        internal virtual ComboBox cbx_ftpye
        {
            [DebuggerNonUserCode]
            get
            {
                return this._cbx_ftpye;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cbx_ftpye_SelectedIndexChanged);
                if (this._cbx_ftpye != null)
                {
                    this._cbx_ftpye.SelectedIndexChanged -= handler;
                }
                this._cbx_ftpye = value;
                if (this._cbx_ftpye != null)
                {
                    this._cbx_ftpye.SelectedIndexChanged += handler;
                }
            }
        }

        internal virtual ComboBox cbx_mfileselect
        {
            [DebuggerNonUserCode]
            get
            {
                return this._cbx_mfileselect;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._cbx_mfileselect = value;
            }
        }

        internal virtual ComboBox cbx_singledel
        {
            [DebuggerNonUserCode]
            get
            {
                return this._cbx_singledel;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cbx_singledel_SelectedIndexChanged);
                if (this._cbx_singledel != null)
                {
                    this._cbx_singledel.SelectedIndexChanged -= handler;
                }
                this._cbx_singledel = value;
                if (this._cbx_singledel != null)
                {
                    this._cbx_singledel.SelectedIndexChanged += handler;
                }
            }
        }

        internal virtual ComboBox cbx_spl_yield
        {
            [DebuggerNonUserCode]
            get
            {
                return this._cbx_spl_yield;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cbx_spl_yield_SelectedIndexChanged);
                if (this._cbx_spl_yield != null)
                {
                    this._cbx_spl_yield.SelectedIndexChanged -= handler;
                }
                this._cbx_spl_yield = value;
                if (this._cbx_spl_yield != null)
                {
                    this._cbx_spl_yield.SelectedIndexChanged += handler;
                }
            }
        }

        internal virtual CheckBox CheckBox1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._CheckBox1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.CheckBox1_CheckedChanged);
                if (this._CheckBox1 != null)
                {
                    this._CheckBox1.CheckedChanged -= handler;
                }
                this._CheckBox1 = value;
                if (this._CheckBox1 != null)
                {
                    this._CheckBox1.CheckedChanged += handler;
                }
            }
        }

        internal virtual CheckBox CheckBox2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._CheckBox2;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._CheckBox2 = value;
            }
        }

        internal virtual CheckBox CheckBox3
        {
            [DebuggerNonUserCode]
            get
            {
                return this._CheckBox3;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._CheckBox3 = value;
            }
        }

        internal virtual CheckBox CheckBox4
        {
            [DebuggerNonUserCode]
            get
            {
                return this._CheckBox4;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._CheckBox4 = value;
            }
        }

        internal virtual CheckBox CheckBox5
        {
            [DebuggerNonUserCode]
            get
            {
                return this._CheckBox5;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._CheckBox5 = value;
            }
        }

        internal virtual CheckBox CheckBox6
        {
            [DebuggerNonUserCode]
            get
            {
                return this._CheckBox6;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._CheckBox6 = value;
            }
        }

        internal virtual CheckBox chk_filedl_am
        {
            [DebuggerNonUserCode]
            get
            {
                return this._chk_filedl_am;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._chk_filedl_am = value;
            }
        }

        internal virtual CheckBox chk_filedl_dd
        {
            [DebuggerNonUserCode]
            get
            {
                return this._chk_filedl_dd;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._chk_filedl_dd = value;
            }
        }

        internal virtual CheckBox chk_filedl_dr
        {
            [DebuggerNonUserCode]
            get
            {
                return this._chk_filedl_dr;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._chk_filedl_dr = value;
            }
        }

        internal virtual CheckBox chk_is_mainimg
        {
            [DebuggerNonUserCode]
            get
            {
                return this._chk_is_mainimg;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.txt_mainimg_TextChanged);
                if (this._chk_is_mainimg != null)
                {
                    this._chk_is_mainimg.CheckedChanged -= handler;
                }
                this._chk_is_mainimg = value;
                if (this._chk_is_mainimg != null)
                {
                    this._chk_is_mainimg.CheckedChanged += handler;
                }
            }
        }

        internal virtual CheckBox chk_issingle
        {
            [DebuggerNonUserCode]
            get
            {
                return this._chk_issingle;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._chk_issingle = value;
            }
        }

        internal virtual CheckBox chk_istimeruse
        {
            [DebuggerNonUserCode]
            get
            {
                return this._chk_istimeruse;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._chk_istimeruse = value;
            }
        }

        internal virtual CheckBox chk_noabst
        {
            [DebuggerNonUserCode]
            get
            {
                return this._chk_noabst;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.rad_50maj_CheckedChanged);
                if (this._chk_noabst != null)
                {
                    this._chk_noabst.CheckedChanged -= handler;
                }
                this._chk_noabst = value;
                if (this._chk_noabst != null)
                {
                    this._chk_noabst.CheckedChanged += handler;
                }
            }
        }

        internal virtual CheckBox chk_playback
        {
            [DebuggerNonUserCode]
            get
            {
                return this._chk_playback;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.chk_playback_CheckedChanged);
                if (this._chk_playback != null)
                {
                    this._chk_playback.CheckedChanged -= handler;
                }
                this._chk_playback = value;
                if (this._chk_playback != null)
                {
                    this._chk_playback.CheckedChanged += handler;
                }
            }
        }

        internal virtual CheckBox chk_rule_1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._chk_rule_1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._chk_rule_1 = value;
            }
        }

        internal virtual CheckBox chk_sfx_start
        {
            [DebuggerNonUserCode]
            get
            {
                return this._chk_sfx_start;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.chk_sfx_start_CheckedChanged);
                if (this._chk_sfx_start != null)
                {
                    this._chk_sfx_start.CheckedChanged -= handler;
                }
                this._chk_sfx_start = value;
                if (this._chk_sfx_start != null)
                {
                    this._chk_sfx_start.CheckedChanged += handler;
                }
            }
        }

        internal virtual CheckBox chk_sfx_time20
        {
            [DebuggerNonUserCode]
            get
            {
                return this._chk_sfx_time20;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.chk_sfx_time20_CheckedChanged);
                if (this._chk_sfx_time20 != null)
                {
                    this._chk_sfx_time20.CheckedChanged -= handler;
                }
                this._chk_sfx_time20 = value;
                if (this._chk_sfx_time20 != null)
                {
                    this._chk_sfx_time20.CheckedChanged += handler;
                }
            }
        }

        internal virtual CheckBox chk_sfx_time60
        {
            [DebuggerNonUserCode]
            get
            {
                return this._chk_sfx_time60;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.chk_sfx_time60_CheckedChanged);
                if (this._chk_sfx_time60 != null)
                {
                    this._chk_sfx_time60.CheckedChanged -= handler;
                }
                this._chk_sfx_time60 = value;
                if (this._chk_sfx_time60 != null)
                {
                    this._chk_sfx_time60.CheckedChanged += handler;
                }
            }
        }

        internal virtual CheckBox chk_sfx_timeout
        {
            [DebuggerNonUserCode]
            get
            {
                return this._chk_sfx_timeout;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.chk_is_mainimg_CheckedChanged);
                if (this._chk_sfx_timeout != null)
                {
                    this._chk_sfx_timeout.CheckedChanged -= handler;
                }
                this._chk_sfx_timeout = value;
                if (this._chk_sfx_timeout != null)
                {
                    this._chk_sfx_timeout.CheckedChanged += handler;
                }
            }
        }

        internal virtual CheckBox chk_spl_allowyield
        {
            [DebuggerNonUserCode]
            get
            {
                return this._chk_spl_allowyield;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.chk_spl_allowyield_CheckedChanged);
                if (this._chk_spl_allowyield != null)
                {
                    this._chk_spl_allowyield.CheckedChanged -= handler;
                }
                this._chk_spl_allowyield = value;
                if (this._chk_spl_allowyield != null)
                {
                    this._chk_spl_allowyield.CheckedChanged += handler;
                }
            }
        }

        internal virtual CheckBox chk_vote_foujue
        {
            [DebuggerNonUserCode]
            get
            {
                return this._chk_vote_foujue;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.chk_vote_foujue_CheckedChanged);
                if (this._chk_vote_foujue != null)
                {
                    this._chk_vote_foujue.CheckedChanged -= handler;
                }
                this._chk_vote_foujue = value;
                if (this._chk_vote_foujue != null)
                {
                    this._chk_vote_foujue.CheckedChanged += handler;
                }
            }
        }

        internal virtual CheckBox chk_vote_saveplist
        {
            [DebuggerNonUserCode]
            get
            {
                return this._chk_vote_saveplist;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._chk_vote_saveplist = value;
            }
        }

        internal virtual CheckedListBox clb_nation_main
        {
            [DebuggerNonUserCode]
            get
            {
                return this._clb_nation_main;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._clb_nation_main = value;
            }
        }

        internal virtual CheckedListBox clb_nation_vote
        {
            [DebuggerNonUserCode]
            get
            {
                return this._clb_nation_vote;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._clb_nation_vote = value;
            }
        }

        internal virtual ComboBox ComboBox1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._ComboBox1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.ComboBox1_TextChanged);
                EventHandler handler2 = new EventHandler(this.TextBox1_GotFocus);
                if (this._ComboBox1 != null)
                {
                    this._ComboBox1.SelectedIndexChanged -= handler;
                    this._ComboBox1.GotFocus -= handler2;
                }
                this._ComboBox1 = value;
                if (this._ComboBox1 != null)
                {
                    this._ComboBox1.SelectedIndexChanged += handler;
                    this._ComboBox1.GotFocus += handler2;
                }
            }
        }

        internal virtual DateTimePicker DateTimePicker1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._DateTimePicker1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._DateTimePicker1 = value;
            }
        }

        internal virtual FontDialog FontDialog1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._FontDialog1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._FontDialog1 = value;
            }
        }

        internal virtual GroupBox GroupBox1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._GroupBox1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._GroupBox1 = value;
            }
        }

        internal virtual Label Label1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label1 = value;
            }
        }

        internal virtual Label Label10
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label10;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label10 = value;
            }
        }

        internal virtual Label Label100
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label100;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label100 = value;
            }
        }

        internal virtual Label Label101
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label101;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label101 = value;
            }
        }

        internal virtual Label Label102
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label102;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label102 = value;
            }
        }

        internal virtual Label Label103
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label103;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label103 = value;
            }
        }

        internal virtual Label Label104
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label104;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label104 = value;
            }
        }

        internal virtual Label Label105
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label105;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label105 = value;
            }
        }

        internal virtual Label Label106
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label106;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label106 = value;
            }
        }

        internal virtual Label Label108
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label108;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label108 = value;
            }
        }

        internal virtual Label Label109
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label109;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label109 = value;
            }
        }

        internal virtual Label Label11
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label11;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label11 = value;
            }
        }

        internal virtual Label Label110
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label110;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label110 = value;
            }
        }

        internal virtual Label Label111
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label111;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label111 = value;
            }
        }

        internal virtual Label Label112
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label112;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label112 = value;
            }
        }

        internal virtual Label Label113
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label113;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label113 = value;
            }
        }

        internal virtual Label Label114
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label114;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label114 = value;
            }
        }

        internal virtual Label Label115
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label115;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label115 = value;
            }
        }

        internal virtual Label Label116
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label116;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label116 = value;
            }
        }

        internal virtual Label Label117
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label117;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label117 = value;
            }
        }

        internal virtual Label Label118
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label118;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label118 = value;
            }
        }

        internal virtual Label Label119
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label119;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label119 = value;
            }
        }

        internal virtual Label Label12
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label12;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label12 = value;
            }
        }

        internal virtual Label Label120
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label120;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label120 = value;
            }
        }

        internal virtual Label Label121
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label121;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label121 = value;
            }
        }

        internal virtual Label Label122
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label122;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label122 = value;
            }
        }

        internal virtual Label Label123
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label123;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label123 = value;
            }
        }

        internal virtual Label Label124
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label124;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label124 = value;
            }
        }

        internal virtual Label Label125
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label125;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label125 = value;
            }
        }

        internal virtual Label Label126
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label126;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label126 = value;
            }
        }

        internal virtual Label Label127
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label127;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label127 = value;
            }
        }

        internal virtual Label Label128
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label128;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label128 = value;
            }
        }

        internal virtual Label Label129
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label129;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label129 = value;
            }
        }

        internal virtual Label Label13
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label13;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label13 = value;
            }
        }

        internal virtual Label Label130
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label130;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label130 = value;
            }
        }

        internal virtual Label Label131
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label131;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label131 = value;
            }
        }

        internal virtual Label Label132
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label132;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label132 = value;
            }
        }

        internal virtual Label Label133
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label133;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label133 = value;
            }
        }

        internal virtual Label Label134
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label134;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label134 = value;
            }
        }

        internal virtual Label Label135
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label135;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label135 = value;
            }
        }

        internal virtual Label Label136
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label136;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label136 = value;
            }
        }

        internal virtual Label Label137
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label137;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label137 = value;
            }
        }

        internal virtual Label Label138
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label138;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label138 = value;
            }
        }

        internal virtual Label Label139
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label139;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label139 = value;
            }
        }

        internal virtual Label Label14
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label14;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label14 = value;
            }
        }

        internal virtual Label Label140
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label140;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label140 = value;
            }
        }

        internal virtual Label Label141
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label141;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label141 = value;
            }
        }

        internal virtual Label Label142
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label142;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label142 = value;
            }
        }

        internal virtual Label Label143
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label143;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label143 = value;
            }
        }

        internal virtual Label Label144
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label144;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label144 = value;
            }
        }

        internal virtual Label Label145
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label145;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label145 = value;
            }
        }

        internal virtual Label Label146
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label146;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label146 = value;
            }
        }

        internal virtual Label Label147
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label147;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label147 = value;
            }
        }

        internal virtual Label Label148
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label148;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label148 = value;
            }
        }

        internal virtual Label Label149
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label149;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label149 = value;
            }
        }

        internal virtual Label Label150
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label150;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label150 = value;
            }
        }

        internal virtual Label Label151
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label151;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label151 = value;
            }
        }

        internal virtual Label Label152
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label152;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label152 = value;
            }
        }

        internal virtual Label Label153
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label153;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label153 = value;
            }
        }

        internal virtual Label Label154
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label154;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label154 = value;
            }
        }

        internal virtual Label Label155
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label155;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label155 = value;
            }
        }

        internal virtual Label Label156
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label156;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label156 = value;
            }
        }

        internal virtual Label Label157
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label157;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label157 = value;
            }
        }

        internal virtual Label Label158
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label158;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label158 = value;
            }
        }

        internal virtual Label Label159
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label159;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label159 = value;
            }
        }

        internal virtual Label Label16
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label16;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label16 = value;
            }
        }

        internal virtual Label Label160
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label160;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label160 = value;
            }
        }

        internal virtual Label Label161
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label161;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label161 = value;
            }
        }

        internal virtual Label Label162
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label162;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label162 = value;
            }
        }

        internal virtual Label Label163
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label163;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label163 = value;
            }
        }

        internal virtual Label Label164
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label164;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label164 = value;
            }
        }

        internal virtual Label Label165
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label165;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label165 = value;
            }
        }

        internal virtual Label Label166
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label166;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label166 = value;
            }
        }

        internal virtual Label Label167
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label167;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label167 = value;
            }
        }

        internal virtual Label Label168
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label168;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label168 = value;
            }
        }

        internal virtual Label Label169
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label169;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label169 = value;
            }
        }

        internal virtual Label Label17
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label17;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label17 = value;
            }
        }

        internal virtual Label Label170
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label170;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label170 = value;
            }
        }

        internal virtual Label Label171
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label171;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label171 = value;
            }
        }

        internal virtual Label Label172
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label172;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label172 = value;
            }
        }

        internal virtual Label Label173
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label173;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label173 = value;
            }
        }

        internal virtual Label Label174
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label174;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label174 = value;
            }
        }

        internal virtual Label Label175
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label175;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label175 = value;
            }
        }

        internal virtual Label Label176
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label176;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label176 = value;
            }
        }

        internal virtual Label Label177
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label177;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label177 = value;
            }
        }

        internal virtual Label Label178
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label178;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label178 = value;
            }
        }

        internal virtual Label Label179
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label179;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label179 = value;
            }
        }

        internal virtual Label Label18
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label18;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label18 = value;
            }
        }

        internal virtual Label Label180
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label180;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label180 = value;
            }
        }

        internal virtual Label Label181
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label181;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label181 = value;
            }
        }

        internal virtual Label Label182
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label182;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label182 = value;
            }
        }

        private Label Label183
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label183;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label183 = value;
            }
        }

        internal virtual Label Label184
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label184;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label184 = value;
            }
        }

        private Label Label185
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label185;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label185 = value;
            }
        }

        private Label Label186
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label186;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label186 = value;
            }
        }

        internal virtual Label Label187
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label187;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label187 = value;
            }
        }

        internal virtual Label Label188
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label188;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label188 = value;
            }
        }

        internal virtual Label Label189
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label189;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label189 = value;
            }
        }

        internal virtual Label Label19
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label19;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label19 = value;
            }
        }

        internal virtual Label Label190
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label190;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label190 = value;
            }
        }

        internal virtual Label Label191
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label191;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label191 = value;
            }
        }

        internal virtual Label Label192
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label192;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label192 = value;
            }
        }

        internal virtual Label Label193
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label193;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label193 = value;
            }
        }

        internal virtual Label Label194
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label194;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label194 = value;
            }
        }

        internal virtual Label Label195
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label195;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label195 = value;
            }
        }

        internal virtual Label Label196
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label196;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label196 = value;
            }
        }

        internal virtual Label Label197
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label197;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label197 = value;
            }
        }

        internal virtual Label Label198
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label198;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label198 = value;
            }
        }

        internal virtual Label Label199
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label199;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label199 = value;
            }
        }

        internal virtual Label Label2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label2;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label2 = value;
            }
        }

        internal virtual Label Label20
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label20;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label20 = value;
            }
        }

        internal virtual Label Label200
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label200;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label200 = value;
            }
        }

        internal virtual Label Label201
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label201;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label201 = value;
            }
        }

        internal virtual Label Label202
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label202;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label202 = value;
            }
        }

        internal virtual Label Label203
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label203;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label203 = value;
            }
        }

        internal virtual Label Label21
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label21;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label21 = value;
            }
        }

        internal virtual Label Label22
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label22;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label22 = value;
            }
        }

        internal virtual Label Label23
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label23;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label23 = value;
            }
        }

        internal virtual Label Label24
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label24;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label24 = value;
            }
        }

        internal virtual Label Label25
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label25;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label25 = value;
            }
        }

        internal virtual Label Label26
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label26;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label26 = value;
            }
        }

        internal virtual Label Label27
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label27;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label27 = value;
            }
        }

        internal virtual Label Label28
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label28;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label28 = value;
            }
        }

        internal virtual Label Label29
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label29;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label29 = value;
            }
        }

        internal virtual Label Label3
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label3;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label3 = value;
            }
        }

        internal virtual Label Label30
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label30;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label30 = value;
            }
        }

        internal virtual Label Label31
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label31;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label31 = value;
            }
        }

        internal virtual Label Label32
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label32;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label32 = value;
            }
        }

        internal virtual Label Label33
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label33;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label33 = value;
            }
        }

        internal virtual Label Label34
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label34;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label34 = value;
            }
        }

        internal virtual Label Label35
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label35;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label35 = value;
            }
        }

        internal virtual Label Label36
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label36;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lbl_slist_1_Click);
                if (this._Label36 != null)
                {
                    this._Label36.Click -= handler;
                }
                this._Label36 = value;
                if (this._Label36 != null)
                {
                    this._Label36.Click += handler;
                }
            }
        }

        internal virtual Label Label37
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label37;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lbl_slist_1_Click);
                if (this._Label37 != null)
                {
                    this._Label37.Click -= handler;
                }
                this._Label37 = value;
                if (this._Label37 != null)
                {
                    this._Label37.Click += handler;
                }
            }
        }

        internal virtual Label Label38
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label38;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lbl_slist_1_Click);
                if (this._Label38 != null)
                {
                    this._Label38.Click -= handler;
                }
                this._Label38 = value;
                if (this._Label38 != null)
                {
                    this._Label38.Click += handler;
                }
            }
        }

        internal virtual Label Label39
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label39;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lbl_slist_1_Click);
                if (this._Label39 != null)
                {
                    this._Label39.Click -= handler;
                }
                this._Label39 = value;
                if (this._Label39 != null)
                {
                    this._Label39.Click += handler;
                }
            }
        }

        internal virtual Label Label4
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label4;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label4 = value;
            }
        }

        internal virtual Label Label40
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label40;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lbl_slist_1_Click);
                if (this._Label40 != null)
                {
                    this._Label40.Click -= handler;
                }
                this._Label40 = value;
                if (this._Label40 != null)
                {
                    this._Label40.Click += handler;
                }
            }
        }

        internal virtual Label Label41
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label41;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lbl_slist_1_Click);
                if (this._Label41 != null)
                {
                    this._Label41.Click -= handler;
                }
                this._Label41 = value;
                if (this._Label41 != null)
                {
                    this._Label41.Click += handler;
                }
            }
        }

        internal virtual Label Label42
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label42;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lbl_slist_1_Click);
                if (this._Label42 != null)
                {
                    this._Label42.Click -= handler;
                }
                this._Label42 = value;
                if (this._Label42 != null)
                {
                    this._Label42.Click += handler;
                }
            }
        }

        internal virtual Label Label43
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label43;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lbl_slist_1_Click);
                if (this._Label43 != null)
                {
                    this._Label43.Click -= handler;
                }
                this._Label43 = value;
                if (this._Label43 != null)
                {
                    this._Label43.Click += handler;
                }
            }
        }

        internal virtual Label Label44
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label44;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lbl_slist_1_Click);
                if (this._Label44 != null)
                {
                    this._Label44.Click -= handler;
                }
                this._Label44 = value;
                if (this._Label44 != null)
                {
                    this._Label44.Click += handler;
                }
            }
        }

        internal virtual Label Label45
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label45;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lbl_slist_1_Click);
                if (this._Label45 != null)
                {
                    this._Label45.Click -= handler;
                }
                this._Label45 = value;
                if (this._Label45 != null)
                {
                    this._Label45.Click += handler;
                }
            }
        }

        internal virtual Label Label46
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label46;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lbl_slist_1_Click);
                if (this._Label46 != null)
                {
                    this._Label46.Click -= handler;
                }
                this._Label46 = value;
                if (this._Label46 != null)
                {
                    this._Label46.Click += handler;
                }
            }
        }

        internal virtual Label Label47
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label47;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label47 = value;
            }
        }

        internal virtual Label Label48
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label48;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label48 = value;
            }
        }

        internal virtual Label Label49
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label49;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label49 = value;
            }
        }

        internal virtual Label Label5
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label5;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label5 = value;
            }
        }

        internal virtual Label Label50
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label50;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label50 = value;
            }
        }

        internal virtual Label Label51
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label51;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label51 = value;
            }
        }

        internal virtual Label Label52
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label52;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lbl_slist_1_Click);
                if (this._Label52 != null)
                {
                    this._Label52.Click -= handler;
                }
                this._Label52 = value;
                if (this._Label52 != null)
                {
                    this._Label52.Click += handler;
                }
            }
        }

        internal virtual Label Label53
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label53;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lbl_slist_1_Click);
                if (this._Label53 != null)
                {
                    this._Label53.Click -= handler;
                }
                this._Label53 = value;
                if (this._Label53 != null)
                {
                    this._Label53.Click += handler;
                }
            }
        }

        internal virtual Label Label54
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label54;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lbl_slist_1_Click);
                if (this._Label54 != null)
                {
                    this._Label54.Click -= handler;
                }
                this._Label54 = value;
                if (this._Label54 != null)
                {
                    this._Label54.Click += handler;
                }
            }
        }

        internal virtual Label Label55
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label55;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lbl_slist_1_Click);
                if (this._Label55 != null)
                {
                    this._Label55.Click -= handler;
                }
                this._Label55 = value;
                if (this._Label55 != null)
                {
                    this._Label55.Click += handler;
                }
            }
        }

        internal virtual Label Label56
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label56;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lbl_slist_1_Click);
                if (this._Label56 != null)
                {
                    this._Label56.Click -= handler;
                }
                this._Label56 = value;
                if (this._Label56 != null)
                {
                    this._Label56.Click += handler;
                }
            }
        }

        internal virtual Label Label57
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label57;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lbl_slist_1_Click);
                if (this._Label57 != null)
                {
                    this._Label57.Click -= handler;
                }
                this._Label57 = value;
                if (this._Label57 != null)
                {
                    this._Label57.Click += handler;
                }
            }
        }

        internal virtual Label Label58
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label58;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lbl_slist_1_Click);
                if (this._Label58 != null)
                {
                    this._Label58.Click -= handler;
                }
                this._Label58 = value;
                if (this._Label58 != null)
                {
                    this._Label58.Click += handler;
                }
            }
        }

        internal virtual Label Label59
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label59;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lbl_slist_1_Click);
                if (this._Label59 != null)
                {
                    this._Label59.Click -= handler;
                }
                this._Label59 = value;
                if (this._Label59 != null)
                {
                    this._Label59.Click += handler;
                }
            }
        }

        internal virtual Label Label6
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label6;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label6 = value;
            }
        }

        internal virtual Label Label60
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label60;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lbl_slist_1_Click);
                if (this._Label60 != null)
                {
                    this._Label60.Click -= handler;
                }
                this._Label60 = value;
                if (this._Label60 != null)
                {
                    this._Label60.Click += handler;
                }
            }
        }

        internal virtual Label Label61
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label61;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label61 = value;
            }
        }

        internal virtual Label Label62
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label62;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label62 = value;
            }
        }

        internal virtual Label Label63
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label63;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label63 = value;
            }
        }

        internal virtual Label Label64
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label64;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label64 = value;
            }
        }

        internal virtual Label Label65
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label65;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label65 = value;
            }
        }

        internal virtual Label Label66
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label66;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lbl_slist_1_Click);
                if (this._Label66 != null)
                {
                    this._Label66.Click -= handler;
                }
                this._Label66 = value;
                if (this._Label66 != null)
                {
                    this._Label66.Click += handler;
                }
            }
        }

        internal virtual Label Label67
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label67;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lbl_slist_1_Click);
                if (this._Label67 != null)
                {
                    this._Label67.Click -= handler;
                }
                this._Label67 = value;
                if (this._Label67 != null)
                {
                    this._Label67.Click += handler;
                }
            }
        }

        internal virtual Label Label68
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label68;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lbl_slist_1_Click);
                if (this._Label68 != null)
                {
                    this._Label68.Click -= handler;
                }
                this._Label68 = value;
                if (this._Label68 != null)
                {
                    this._Label68.Click += handler;
                }
            }
        }

        internal virtual Label Label69
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label69;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lbl_slist_1_Click);
                if (this._Label69 != null)
                {
                    this._Label69.Click -= handler;
                }
                this._Label69 = value;
                if (this._Label69 != null)
                {
                    this._Label69.Click += handler;
                }
            }
        }

        internal virtual Label Label7
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label7;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label7 = value;
            }
        }

        internal virtual Label Label70
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label70;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lbl_slist_1_Click);
                if (this._Label70 != null)
                {
                    this._Label70.Click -= handler;
                }
                this._Label70 = value;
                if (this._Label70 != null)
                {
                    this._Label70.Click += handler;
                }
            }
        }

        internal virtual Label Label71
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label71;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lbl_slist_1_Click);
                if (this._Label71 != null)
                {
                    this._Label71.Click -= handler;
                }
                this._Label71 = value;
                if (this._Label71 != null)
                {
                    this._Label71.Click += handler;
                }
            }
        }

        internal virtual Label Label72
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label72;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lbl_slist_1_Click);
                if (this._Label72 != null)
                {
                    this._Label72.Click -= handler;
                }
                this._Label72 = value;
                if (this._Label72 != null)
                {
                    this._Label72.Click += handler;
                }
            }
        }

        internal virtual Label Label73
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label73;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lbl_slist_1_Click);
                if (this._Label73 != null)
                {
                    this._Label73.Click -= handler;
                }
                this._Label73 = value;
                if (this._Label73 != null)
                {
                    this._Label73.Click += handler;
                }
            }
        }

        internal virtual Label Label74
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label74;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lbl_slist_1_Click);
                if (this._Label74 != null)
                {
                    this._Label74.Click -= handler;
                }
                this._Label74 = value;
                if (this._Label74 != null)
                {
                    this._Label74.Click += handler;
                }
            }
        }

        internal virtual Label Label75
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label75;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label75 = value;
            }
        }

        internal virtual Label Label76
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label76;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label76 = value;
            }
        }

        internal virtual Label Label77
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label77;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label77 = value;
            }
        }

        internal virtual Label Label78
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label78;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label78 = value;
            }
        }

        internal virtual Label Label79
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label79;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label79 = value;
            }
        }

        internal virtual Label Label8
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label8;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label8 = value;
            }
        }

        internal virtual Label Label80
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label80;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lbl_slist_1_Click);
                if (this._Label80 != null)
                {
                    this._Label80.Click -= handler;
                }
                this._Label80 = value;
                if (this._Label80 != null)
                {
                    this._Label80.Click += handler;
                }
            }
        }

        internal virtual Label Label81
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label81;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lbl_slist_1_Click);
                if (this._Label81 != null)
                {
                    this._Label81.Click -= handler;
                }
                this._Label81 = value;
                if (this._Label81 != null)
                {
                    this._Label81.Click += handler;
                }
            }
        }

        internal virtual Label Label82
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label82;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lbl_slist_1_Click);
                if (this._Label82 != null)
                {
                    this._Label82.Click -= handler;
                }
                this._Label82 = value;
                if (this._Label82 != null)
                {
                    this._Label82.Click += handler;
                }
            }
        }

        internal virtual Label Label83
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label83;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lbl_slist_1_Click);
                if (this._Label83 != null)
                {
                    this._Label83.Click -= handler;
                }
                this._Label83 = value;
                if (this._Label83 != null)
                {
                    this._Label83.Click += handler;
                }
            }
        }

        internal virtual Label Label84
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label84;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lbl_slist_1_Click);
                if (this._Label84 != null)
                {
                    this._Label84.Click -= handler;
                }
                this._Label84 = value;
                if (this._Label84 != null)
                {
                    this._Label84.Click += handler;
                }
            }
        }

        internal virtual Label Label85
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label85;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lbl_slist_1_Click);
                if (this._Label85 != null)
                {
                    this._Label85.Click -= handler;
                }
                this._Label85 = value;
                if (this._Label85 != null)
                {
                    this._Label85.Click += handler;
                }
            }
        }

        internal virtual Label Label86
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label86;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lbl_slist_1_Click);
                if (this._Label86 != null)
                {
                    this._Label86.Click -= handler;
                }
                this._Label86 = value;
                if (this._Label86 != null)
                {
                    this._Label86.Click += handler;
                }
            }
        }

        internal virtual Label Label87
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label87;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lbl_slist_1_Click);
                if (this._Label87 != null)
                {
                    this._Label87.Click -= handler;
                }
                this._Label87 = value;
                if (this._Label87 != null)
                {
                    this._Label87.Click += handler;
                }
            }
        }

        internal virtual Label Label88
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label88;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lbl_slist_1_Click);
                if (this._Label88 != null)
                {
                    this._Label88.Click -= handler;
                }
                this._Label88 = value;
                if (this._Label88 != null)
                {
                    this._Label88.Click += handler;
                }
            }
        }

        internal virtual Label Label89
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label89;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lbl_slist_1_Click);
                if (this._Label89 != null)
                {
                    this._Label89.Click -= handler;
                }
                this._Label89 = value;
                if (this._Label89 != null)
                {
                    this._Label89.Click += handler;
                }
            }
        }

        internal virtual Label Label9
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label9;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label9 = value;
            }
        }

        internal virtual Label Label90
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label90;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label90 = value;
            }
        }

        internal virtual Label Label91
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label91;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label91 = value;
            }
        }

        internal virtual Label Label92
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label92;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label92 = value;
            }
        }

        internal virtual Label Label93
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label93;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label93 = value;
            }
        }

        internal virtual Label Label94
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label94;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label94 = value;
            }
        }

        internal virtual Label Label95
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label95;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label95 = value;
            }
        }

        internal virtual Label Label96
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label96;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label96 = value;
            }
        }

        internal virtual Label Label97
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label97;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label97 = value;
            }
        }

        internal virtual Label Label98
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label98;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label98 = value;
            }
        }

        internal virtual Label Label99
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label99;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label99 = value;
            }
        }

        internal virtual Label lbl_dbqstatus
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lbl_dbqstatus;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lbl_dbqstatus = value;
            }
        }

        internal virtual Label lbl_fileinfo
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lbl_fileinfo;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lbl_fileinfo = value;
            }
        }

        internal virtual Label lbl_filepath
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lbl_filepath;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lbl_filepath = value;
            }
        }

        internal virtual Label lbl_loaded
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lbl_loaded;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lbl_loaded = value;
            }
        }

        internal virtual Label lbl_manage_about
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lbl_manage_about;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lbl_manage_about = value;
            }
        }

        internal virtual Label lbl_manage_conferences
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lbl_manage_conferences;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lbl_manage_conferences = value;
            }
        }

        internal virtual Label lbl_manage_setting
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lbl_manage_setting;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lbl_manage_setting = value;
            }
        }

        internal virtual Label lbl_mc_total_time
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lbl_mc_total_time;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lbl_mc_total_time = value;
            }
        }

        internal virtual Label lbl_reading
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lbl_reading;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lbl_reading = value;
            }
        }

        internal virtual Label lbl_sldeldte
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lbl_sldeldte;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lbl_sldeldte = value;
            }
        }

        internal virtual Label lbl_slist_1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lbl_slist_1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lbl_slist_1_Click);
                if (this._lbl_slist_1 != null)
                {
                    this._lbl_slist_1.Click -= handler;
                }
                this._lbl_slist_1 = value;
                if (this._lbl_slist_1 != null)
                {
                    this._lbl_slist_1.Click += handler;
                }
            }
        }

        internal virtual Label lbl_slist_status_01
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lbl_slist_status_01;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lbl_slist_status_01 = value;
            }
        }

        internal virtual Label lbl_slorig
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lbl_slorig;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lbl_slorig = value;
            }
        }

        internal virtual Label lbl_startmode
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lbl_startmode;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lbl_startmode_Click);
                if (this._lbl_startmode != null)
                {
                    this._lbl_startmode.Click -= handler;
                }
                this._lbl_startmode = value;
                if (this._lbl_startmode != null)
                {
                    this._lbl_startmode.Click += handler;
                }
            }
        }

        internal virtual Label lbl_vote_nation
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lbl_vote_nation;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lbl_vote_nation = value;
            }
        }

        internal virtual Label lbl_vote_step
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lbl_vote_step;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lbl_vote_step = value;
            }
        }

        internal virtual Label lbl20maj
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lbl20maj;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lbl20maj = value;
            }
        }

        internal virtual Label lbl20maj1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lbl20maj1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lbl20maj1 = value;
            }
        }

        internal virtual Label lbl50maj
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lbl50maj;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lbl50maj = value;
            }
        }

        internal virtual Label lbl50maj1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lbl50maj1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lbl50maj1 = value;
            }
        }

        internal virtual Label lbl67maj
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lbl67maj;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lbl67maj = value;
            }
        }

        internal virtual Label lbl67maj1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lbl67maj1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lbl67maj1 = value;
            }
        }

        internal virtual Label lblabst
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lblabst;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lblabst = value;
            }
        }

        internal virtual Label lblabst1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lblabst1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lblabst1 = value;
            }
        }

        internal virtual Label lblconf
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lblconf;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lblconf_Click);
                if (this._lblconf != null)
                {
                    this._lblconf.Click -= handler;
                }
                this._lblconf = value;
                if (this._lblconf != null)
                {
                    this._lblconf.Click += handler;
                }
            }
        }

        internal virtual Label lblcount
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lblcount;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lblcount = value;
            }
        }

        internal virtual Label lblinfo
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lblinfo;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lblinfo = value;
            }
        }

        internal virtual Label lblmain
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lblmain;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lblmain = value;
            }
        }

        internal virtual Label lblmaohao
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lblmaohao;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lblmaohao = value;
            }
        }

        internal virtual Label lblno
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lblno;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lblno = value;
            }
        }

        internal virtual Label lblno1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lblno1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lblno1 = value;
            }
        }

        internal virtual Label lblopic
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lblopic;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lblopic = value;
            }
        }

        internal virtual Label lblpresent
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lblpresent;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lblpresent = value;
            }
        }

        internal virtual Label lblpresent1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lblpresent1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lblpresent1 = value;
            }
        }

        internal virtual Label lbltime
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lbltime;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lbltime = value;
            }
        }

        internal virtual Label lblyes
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lblyes;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lblyes = value;
            }
        }

        internal virtual Label lblyes1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lblyes1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._lblyes1 = value;
            }
        }

        internal virtual LinkLabel LinkLabel2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._LinkLabel2;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._LinkLabel2 = value;
            }
        }

        internal virtual LinkLabel llb_spl_entercustom
        {
            [DebuggerNonUserCode]
            get
            {
                return this._llb_spl_entercustom;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                LinkLabelLinkClickedEventHandler handler = new LinkLabelLinkClickedEventHandler(this.llb_spl_entercustom_LinkClicked);
                if (this._llb_spl_entercustom != null)
                {
                    this._llb_spl_entercustom.LinkClicked -= handler;
                }
                this._llb_spl_entercustom = value;
                if (this._llb_spl_entercustom != null)
                {
                    this._llb_spl_entercustom.LinkClicked += handler;
                }
            }
        }

        internal virtual NotifyIcon NotifyIcon1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._NotifyIcon1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._NotifyIcon1 = value;
            }
        }

        internal virtual NumericUpDown num_crisis
        {
            [DebuggerNonUserCode]
            get
            {
                return this._num_crisis;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._num_crisis = value;
            }
        }

        internal virtual NumericUpDown num_dbqtime
        {
            [DebuggerNonUserCode]
            get
            {
                return this._num_dbqtime;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._num_dbqtime = value;
            }
        }

        internal virtual NumericUpDown num_fdl_amh
        {
            [DebuggerNonUserCode]
            get
            {
                return this._num_fdl_amh;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._num_fdl_amh = value;
            }
        }

        internal virtual NumericUpDown num_fdl_amm
        {
            [DebuggerNonUserCode]
            get
            {
                return this._num_fdl_amm;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._num_fdl_amm = value;
            }
        }

        internal virtual NumericUpDown num_fdl_ddh
        {
            [DebuggerNonUserCode]
            get
            {
                return this._num_fdl_ddh;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._num_fdl_ddh = value;
            }
        }

        internal virtual NumericUpDown num_fdl_ddm
        {
            [DebuggerNonUserCode]
            get
            {
                return this._num_fdl_ddm;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._num_fdl_ddm = value;
            }
        }

        internal virtual NumericUpDown num_fdl_drh
        {
            [DebuggerNonUserCode]
            get
            {
                return this._num_fdl_drh;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._num_fdl_drh = value;
            }
        }

        internal virtual NumericUpDown num_fdl_drm
        {
            [DebuggerNonUserCode]
            get
            {
                return this._num_fdl_drm;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._num_fdl_drm = value;
            }
        }

        internal virtual NumericUpDown num_file
        {
            [DebuggerNonUserCode]
            get
            {
                return this._num_file;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._num_file = value;
            }
        }

        internal virtual NumericUpDown num_intro
        {
            [DebuggerNonUserCode]
            get
            {
                return this._num_intro;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._num_intro = value;
            }
        }

        internal virtual NumericUpDown num_m_custom
        {
            [DebuggerNonUserCode]
            get
            {
                return this._num_m_custom;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._num_m_custom = value;
            }
        }

        internal virtual NumericUpDown num_m_mc_1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._num_m_mc_1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._num_m_mc_1 = value;
            }
        }

        internal virtual NumericUpDown num_m_mc_2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._num_m_mc_2;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.num_timer_s_ValueChanged);
                if (this._num_m_mc_2 != null)
                {
                    this._num_m_mc_2.ValueChanged -= handler;
                }
                this._num_m_mc_2 = value;
                if (this._num_m_mc_2 != null)
                {
                    this._num_m_mc_2.ValueChanged += handler;
                }
            }
        }

        internal virtual NumericUpDown num_m_spl_1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._num_m_spl_1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._num_m_spl_1 = value;
            }
        }

        internal virtual NumericUpDown num_m_spl_2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._num_m_spl_2;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._num_m_spl_2 = value;
            }
        }

        internal virtual NumericUpDown num_m_umc
        {
            [DebuggerNonUserCode]
            get
            {
                return this._num_m_umc;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._num_m_umc = value;
            }
        }

        internal virtual NumericUpDown num_mcnumber
        {
            [DebuggerNonUserCode]
            get
            {
                return this._num_mcnumber;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.num_mcnumber_ValueChanged);
                if (this._num_mcnumber != null)
                {
                    this._num_mcnumber.ValueChanged -= handler;
                }
                this._num_mcnumber = value;
                if (this._num_mcnumber != null)
                {
                    this._num_mcnumber.ValueChanged += handler;
                }
            }
        }

        internal virtual NumericUpDown num_spl_timem
        {
            [DebuggerNonUserCode]
            get
            {
                return this._num_spl_timem;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.num_spl_timem_ValueChanged);
                if (this._num_spl_timem != null)
                {
                    this._num_spl_timem.ValueChanged -= handler;
                }
                this._num_spl_timem = value;
                if (this._num_spl_timem != null)
                {
                    this._num_spl_timem.ValueChanged += handler;
                }
            }
        }

        internal virtual NumericUpDown num_spl_times
        {
            [DebuggerNonUserCode]
            get
            {
                return this._num_spl_times;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.num_spl_timem_ValueChanged);
                if (this._num_spl_times != null)
                {
                    this._num_spl_times.ValueChanged -= handler;
                }
                this._num_spl_times = value;
                if (this._num_spl_times != null)
                {
                    this._num_spl_times.ValueChanged += handler;
                }
            }
        }

        internal virtual NumericUpDown num_tbtime
        {
            [DebuggerNonUserCode]
            get
            {
                return this._num_tbtime;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._num_tbtime = value;
            }
        }

        internal virtual NumericUpDown num_timeleft
        {
            [DebuggerNonUserCode]
            get
            {
                return this._num_timeleft;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._num_timeleft = value;
            }
        }

        internal virtual NumericUpDown numhh
        {
            [DebuggerNonUserCode]
            get
            {
                return this._numhh;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._numhh = value;
            }
        }

        internal virtual NumericUpDown nummm
        {
            [DebuggerNonUserCode]
            get
            {
                return this._nummm;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._nummm = value;
            }
        }

        internal virtual NumericUpDown numstarth
        {
            [DebuggerNonUserCode]
            get
            {
                return this._numstarth;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.NumericUpDown3_ValueChanged);
                if (this._numstarth != null)
                {
                    this._numstarth.ValueChanged -= handler;
                }
                this._numstarth = value;
                if (this._numstarth != null)
                {
                    this._numstarth.ValueChanged += handler;
                }
            }
        }

        internal virtual NumericUpDown numstartm
        {
            [DebuggerNonUserCode]
            get
            {
                return this._numstartm;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.NumericUpDown3_ValueChanged);
                if (this._numstartm != null)
                {
                    this._numstartm.ValueChanged -= handler;
                }
                this._numstartm = value;
                if (this._numstartm != null)
                {
                    this._numstartm.ValueChanged += handler;
                }
            }
        }

        internal virtual NumericUpDown numtime
        {
            [DebuggerNonUserCode]
            get
            {
                return this._numtime;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._numtime = value;
            }
        }

        internal virtual OpenFileDialog ofd_banner
        {
            [DebuggerNonUserCode]
            get
            {
                return this._ofd_banner;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._ofd_banner = value;
            }
        }

        internal virtual OpenFileDialog ofd_csl
        {
            [DebuggerNonUserCode]
            get
            {
                return this._ofd_csl;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._ofd_csl = value;
            }
        }

        internal virtual OpenFileDialog ofd_doc
        {
            [DebuggerNonUserCode]
            get
            {
                return this._ofd_doc;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._ofd_doc = value;
            }
        }

        internal virtual OpenFileDialog ofd_sfx
        {
            [DebuggerNonUserCode]
            get
            {
                return this._ofd_sfx;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._ofd_sfx = value;
            }
        }

        internal virtual Panel panel_clock
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_clock;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_clock = value;
            }
        }

        internal virtual Panel panel_csl
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_csl;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_csl = value;
            }
        }

        internal virtual Panel panel_dbq
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_dbq;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_dbq = value;
            }
        }

        internal virtual Panel panel_editnationlist
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_editnationlist;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_editnationlist = value;
            }
        }

        internal virtual Panel panel_f_1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_f_1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_f_1 = value;
            }
        }

        internal virtual Panel panel_f_2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_f_2;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_f_2 = value;
            }
        }

        internal virtual Panel panel_f_3
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_f_3;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_f_3 = value;
            }
        }

        internal virtual Panel panel_f_4
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_f_4;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_f_4 = value;
            }
        }

        internal virtual Panel panel_f_5
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_f_5;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_f_5 = value;
            }
        }

        internal virtual Panel panel_file_1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_file_1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_file_1 = value;
            }
        }

        internal virtual Panel panel_file_2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_file_2;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_file_2 = value;
            }
        }

        internal virtual Panel panel_file_bottom
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_file_bottom;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_file_bottom = value;
            }
        }

        internal virtual Panel panel_file_top
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_file_top;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_file_top = value;
            }
        }

        internal virtual Panel panel_files
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_files;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_files = value;
            }
        }

        public virtual Panel panel_files_3
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_files_3;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_files_3 = value;
            }
        }

        public virtual Panel panel_files_4
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_files_4;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_files_4 = value;
            }
        }

        public virtual Panel panel_files_5
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_files_5;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_files_5 = value;
            }
        }

        internal virtual Panel panel_introtask
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_introtask;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_introtask = value;
            }
        }

        public virtual Panel panel_m_1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_m_1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_m_1 = value;
            }
        }

        internal virtual Panel panel_m_2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_m_2;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_m_2 = value;
            }
        }

        internal virtual Panel panel_m_3
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_m_3;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_m_3 = value;
            }
        }

        internal virtual Panel panel_m_4
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_m_4;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_m_4 = value;
            }
        }

        internal virtual Panel panel_m_5
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_m_5;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_m_5 = value;
            }
        }

        internal virtual Panel panel_m_6
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_m_6;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_m_6 = value;
            }
        }

        internal virtual Panel panel_main
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_main;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_main = value;
            }
        }

        internal virtual Panel panel_main_screen
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_main_screen;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_main_screen = value;
            }
        }

        internal virtual Panel panel_main_sidebar
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_main_sidebar;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_main_sidebar = value;
            }
        }

        internal virtual Panel panel_main_title
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_main_title;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_main_title = value;
            }
        }

        internal virtual Panel panel_manage
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_manage;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_manage = value;
            }
        }

        internal virtual Panel panel_mc
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_mc;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_mc = value;
            }
        }

        internal virtual Panel panel_mcedit
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_mcedit;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_mcedit = value;
            }
        }

        internal virtual Panel panel_misc
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_misc;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_misc = value;
            }
        }

        internal virtual Panel panel_misc_1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_misc_1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_misc_1 = value;
            }
        }

        internal virtual Panel panel_misc_2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_misc_2;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_misc_2 = value;
            }
        }

        internal virtual Panel panel_misc_3
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_misc_3;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_misc_3 = value;
            }
        }

        internal virtual Panel panel_misc_5
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_misc_5;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_misc_5 = value;
            }
        }

        internal virtual Panel panel_misc_bottom
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_misc_bottom;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_misc_bottom = value;
            }
        }

        internal virtual Panel panel_misc_top
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_misc_top;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_misc_top = value;
            }
        }

        internal virtual Panel panel_modesel
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_modesel;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_modesel = value;
            }
        }

        internal virtual Panel panel_motion
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_motion;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_motion = value;
            }
        }

        public virtual Panel panel_motion_4
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_motion_4;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_motion_4 = value;
            }
        }

        public virtual Panel panel_motion_5
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_motion_5;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_motion_5 = value;
            }
        }

        public virtual Panel panel_motion_6
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_motion_6;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_motion_6 = value;
            }
        }

        public virtual Panel panel_motions_1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_motions_1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_motions_1 = value;
            }
        }

        public virtual Panel panel_motions_2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_motions_2;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_motions_2 = value;
            }
        }

        public virtual Panel panel_motions_3
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_motions_3;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_motions_3 = value;
            }
        }

        internal virtual Panel panel_motions_top
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_motions_top;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_motions_top = value;
            }
        }

        internal virtual Panel panel_ms_1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_ms_1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_ms_1 = value;
            }
        }

        internal virtual Panel panel_ms_2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_ms_2;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_ms_2 = value;
            }
        }

        internal virtual Panel panel_ms_3
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_ms_3;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_ms_3 = value;
            }
        }

        internal virtual Panel panel_ms_5
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_ms_5;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_ms_5 = value;
            }
        }

        internal virtual Panel panel_presents
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_presents;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_presents = value;
            }
        }

        internal virtual Panel panel_readfile
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_readfile;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_readfile = value;
            }
        }

        internal virtual Panel panel_selfile
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_selfile;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_selfile = value;
            }
        }

        internal virtual Panel panel_sidebar_idle
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_sidebar_idle;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_sidebar_idle = value;
            }
        }

        internal virtual Panel panel_sidebar_starting
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_sidebar_starting;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_sidebar_starting = value;
            }
        }

        internal virtual Panel panel_sidebar_timer
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_sidebar_timer;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_sidebar_timer = value;
            }
        }

        internal virtual Panel panel_signatories
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_signatories;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_signatories = value;
            }
        }

        internal virtual Panel panel_singledel
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_singledel;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_singledel = value;
            }
        }

        internal virtual Panel panel_spakers_list
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_spakers_list;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_spakers_list = value;
            }
        }

        internal virtual Panel panel_sponsors
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_sponsors;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_sponsors = value;
            }
        }

        internal virtual Panel panel_startmethod
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_startmethod;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_startmethod = value;
            }
        }

        internal virtual Panel panel_system
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_system;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_system = value;
            }
        }

        internal virtual Panel panel_title_idle
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_title_idle;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_title_idle = value;
            }
        }

        internal virtual Panel panel_umc
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_umc;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_umc = value;
            }
        }

        internal virtual Panel panel_velcome_new
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_velcome_new;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_velcome_new = value;
            }
        }

        internal virtual Panel panel_vote
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_vote;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_vote = value;
            }
        }

        internal virtual Panel panel_vote_bottom
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_vote_bottom;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_vote_bottom = value;
            }
        }

        internal virtual Panel panel_vote_config
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_vote_config;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_vote_config = value;
            }
        }

        internal virtual Panel panel_vote_ctrl
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_vote_ctrl;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_vote_ctrl = value;
            }
        }

        internal virtual Panel panel_vote_roll
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_vote_roll;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_vote_roll = value;
            }
        }

        internal virtual Panel panel_vote_top
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_vote_top;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_vote_top = value;
            }
        }

        internal virtual Panel panel_welcome
        {
            [DebuggerNonUserCode]
            get
            {
                return this._panel_welcome;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._panel_welcome = value;
            }
        }

        internal virtual Panel Panel1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Panel1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Panel1 = value;
            }
        }

        internal virtual Panel Panel2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Panel2;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Panel2 = value;
            }
        }

        internal virtual Panel Panel3
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Panel3;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Panel3 = value;
            }
        }

        internal virtual Panel Panel4
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Panel4;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Panel4 = value;
            }
        }

        internal virtual Panel Panel5
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Panel5;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Panel5 = value;
            }
        }

        internal virtual PictureBox PictureBox1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._PictureBox1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._PictureBox1 = value;
            }
        }

        internal virtual RadioButton rad_50maj
        {
            [DebuggerNonUserCode]
            get
            {
                return this._rad_50maj;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.rad_50maj_CheckedChanged);
                if (this._rad_50maj != null)
                {
                    this._rad_50maj.CheckedChanged -= handler;
                }
                this._rad_50maj = value;
                if (this._rad_50maj != null)
                {
                    this._rad_50maj.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton rad_67maj
        {
            [DebuggerNonUserCode]
            get
            {
                return this._rad_67maj;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.rad_50maj_CheckedChanged);
                if (this._rad_67maj != null)
                {
                    this._rad_67maj.CheckedChanged -= handler;
                }
                this._rad_67maj = value;
                if (this._rad_67maj != null)
                {
                    this._rad_67maj.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton rad_80maj
        {
            [DebuggerNonUserCode]
            get
            {
                return this._rad_80maj;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.rad_50maj_CheckedChanged);
                if (this._rad_80maj != null)
                {
                    this._rad_80maj.CheckedChanged -= handler;
                }
                this._rad_80maj = value;
                if (this._rad_80maj != null)
                {
                    this._rad_80maj.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton rad_all
        {
            [DebuggerNonUserCode]
            get
            {
                return this._rad_all;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.rad_50maj_CheckedChanged);
                if (this._rad_all != null)
                {
                    this._rad_all.CheckedChanged -= handler;
                }
                this._rad_all = value;
                if (this._rad_all != null)
                {
                    this._rad_all.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton rad_blue
        {
            [DebuggerNonUserCode]
            get
            {
                return this._rad_blue;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.rad_darkred_CheckedChanged);
                if (this._rad_blue != null)
                {
                    this._rad_blue.CheckedChanged -= handler;
                }
                this._rad_blue = value;
                if (this._rad_blue != null)
                {
                    this._rad_blue.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton rad_clockno
        {
            [DebuggerNonUserCode]
            get
            {
                return this._rad_clockno;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.rad_clockno_CheckedChanged);
                if (this._rad_clockno != null)
                {
                    this._rad_clockno.CheckedChanged -= handler;
                }
                this._rad_clockno = value;
                if (this._rad_clockno != null)
                {
                    this._rad_clockno.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton rad_clockyes
        {
            [DebuggerNonUserCode]
            get
            {
                return this._rad_clockyes;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._rad_clockyes = value;
            }
        }

        internal virtual RadioButton rad_continue
        {
            [DebuggerNonUserCode]
            get
            {
                return this._rad_continue;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.rad_create_CheckedChanged);
                if (this._rad_continue != null)
                {
                    this._rad_continue.CheckedChanged -= handler;
                }
                this._rad_continue = value;
                if (this._rad_continue != null)
                {
                    this._rad_continue.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton rad_create
        {
            [DebuggerNonUserCode]
            get
            {
                return this._rad_create;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.rad_create_CheckedChanged);
                if (this._rad_create != null)
                {
                    this._rad_create.Click -= handler;
                }
                this._rad_create = value;
                if (this._rad_create != null)
                {
                    this._rad_create.Click += handler;
                }
            }
        }

        internal virtual RadioButton rad_darkred
        {
            [DebuggerNonUserCode]
            get
            {
                return this._rad_darkred;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.rad_darkred_CheckedChanged);
                if (this._rad_darkred != null)
                {
                    this._rad_darkred.CheckedChanged -= handler;
                }
                this._rad_darkred = value;
                if (this._rad_darkred != null)
                {
                    this._rad_darkred.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton rad_green
        {
            [DebuggerNonUserCode]
            get
            {
                return this._rad_green;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.rad_darkred_CheckedChanged);
                if (this._rad_green != null)
                {
                    this._rad_green.CheckedChanged -= handler;
                }
                this._rad_green = value;
                if (this._rad_green != null)
                {
                    this._rad_green.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton rad_immediatestart
        {
            [DebuggerNonUserCode]
            get
            {
                return this._rad_immediatestart;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.rad_immediatestart_CheckedChanged);
                if (this._rad_immediatestart != null)
                {
                    this._rad_immediatestart.CheckedChanged -= handler;
                }
                this._rad_immediatestart = value;
                if (this._rad_immediatestart != null)
                {
                    this._rad_immediatestart.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton rad_load
        {
            [DebuggerNonUserCode]
            get
            {
                return this._rad_load;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.rad_create_CheckedChanged);
                if (this._rad_load != null)
                {
                    this._rad_load.CheckedChanged -= handler;
                }
                this._rad_load = value;
                if (this._rad_load != null)
                {
                    this._rad_load.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton rad_orange
        {
            [DebuggerNonUserCode]
            get
            {
                return this._rad_orange;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.rad_darkred_CheckedChanged);
                if (this._rad_orange != null)
                {
                    this._rad_orange.CheckedChanged -= handler;
                }
                this._rad_orange = value;
                if (this._rad_orange != null)
                {
                    this._rad_orange.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton rad_paper
        {
            [DebuggerNonUserCode]
            get
            {
                return this._rad_paper;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.rad_paper_CheckedChanged);
                if (this._rad_paper != null)
                {
                    this._rad_paper.CheckedChanged -= handler;
                }
                this._rad_paper = value;
                if (this._rad_paper != null)
                {
                    this._rad_paper.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton rad_pink
        {
            [DebuggerNonUserCode]
            get
            {
                return this._rad_pink;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.rad_darkred_CheckedChanged);
                if (this._rad_pink != null)
                {
                    this._rad_pink.CheckedChanged -= handler;
                }
                this._rad_pink = value;
                if (this._rad_pink != null)
                {
                    this._rad_pink.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton rad_present
        {
            [DebuggerNonUserCode]
            get
            {
                return this._rad_present;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.rad_paper_CheckedChanged);
                if (this._rad_present != null)
                {
                    this._rad_present.CheckedChanged -= handler;
                }
                this._rad_present = value;
                if (this._rad_present != null)
                {
                    this._rad_present.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton rad_purple
        {
            [DebuggerNonUserCode]
            get
            {
                return this._rad_purple;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.rad_darkred_CheckedChanged);
                if (this._rad_purple != null)
                {
                    this._rad_purple.CheckedChanged -= handler;
                }
                this._rad_purple = value;
                if (this._rad_purple != null)
                {
                    this._rad_purple.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton rad_select
        {
            [DebuggerNonUserCode]
            get
            {
                return this._rad_select;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.rad_create_CheckedChanged);
                if (this._rad_select != null)
                {
                    this._rad_select.CheckedChanged -= handler;
                }
                this._rad_select = value;
                if (this._rad_select != null)
                {
                    this._rad_select.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton rad_teal
        {
            [DebuggerNonUserCode]
            get
            {
                return this._rad_teal;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.rad_darkred_CheckedChanged);
                if (this._rad_teal != null)
                {
                    this._rad_teal.CheckedChanged -= handler;
                }
                this._rad_teal = value;
                if (this._rad_teal != null)
                {
                    this._rad_teal.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton rad_timedstart
        {
            [DebuggerNonUserCode]
            get
            {
                return this._rad_timedstart;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._rad_timedstart = value;
            }
        }

        internal virtual RadioButton RadioButton4
        {
            [DebuggerNonUserCode]
            get
            {
                return this._RadioButton4;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._RadioButton4 = value;
            }
        }

        internal virtual RadioButton RadioButton5
        {
            [DebuggerNonUserCode]
            get
            {
                return this._RadioButton5;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._RadioButton5 = value;
            }
        }

        internal virtual SaveFileDialog sfd_csl
        {
            [DebuggerNonUserCode]
            get
            {
                return this._sfd_csl;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._sfd_csl = value;
            }
        }

        internal virtual TableLayoutPanel TableLayoutPanel1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TableLayoutPanel1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._TableLayoutPanel1 = value;
            }
        }

        internal virtual TableLayoutPanel TableLayoutPanel2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TableLayoutPanel2;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._TableLayoutPanel2 = value;
            }
        }

        internal virtual TextBox TextBox1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TextBox1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.TextBox1_GotFocus);
                if (this._TextBox1 != null)
                {
                    this._TextBox1.GotFocus -= handler;
                }
                this._TextBox1 = value;
                if (this._TextBox1 != null)
                {
                    this._TextBox1.GotFocus += handler;
                }
            }
        }

        internal virtual TextBox TextBox10
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TextBox10;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._TextBox10 = value;
            }
        }

        internal virtual TextBox TextBox11
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TextBox11;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._TextBox11 = value;
            }
        }

        internal virtual TextBox TextBox12
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TextBox12;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._TextBox12 = value;
            }
        }

        internal virtual TextBox TextBox13
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TextBox13;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._TextBox13 = value;
            }
        }

        internal virtual TextBox TextBox14
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TextBox14;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._TextBox14 = value;
            }
        }

        internal virtual TextBox TextBox15
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TextBox15;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._TextBox15 = value;
            }
        }

        internal virtual TextBox TextBox17
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TextBox17;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._TextBox17 = value;
            }
        }

        internal virtual TextBox TextBox2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TextBox2;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.TextBox1_GotFocus);
                if (this._TextBox2 != null)
                {
                    this._TextBox2.GotFocus -= handler;
                }
                this._TextBox2 = value;
                if (this._TextBox2 != null)
                {
                    this._TextBox2.GotFocus += handler;
                }
            }
        }

        internal virtual TextBox TextBox3
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TextBox3;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.TextBox1_GotFocus);
                if (this._TextBox3 != null)
                {
                    this._TextBox3.GotFocus -= handler;
                }
                this._TextBox3 = value;
                if (this._TextBox3 != null)
                {
                    this._TextBox3.GotFocus += handler;
                }
            }
        }

        internal virtual TextBox TextBox4
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TextBox4;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.TextBox1_GotFocus);
                if (this._TextBox4 != null)
                {
                    this._TextBox4.GotFocus -= handler;
                }
                this._TextBox4 = value;
                if (this._TextBox4 != null)
                {
                    this._TextBox4.GotFocus += handler;
                }
            }
        }

        internal virtual TextBox TextBox5
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TextBox5;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.TextBox1_GotFocus);
                EventHandler handler2 = new EventHandler(this.TextBox5_TextChanged);
                KeyEventHandler handler3 = new KeyEventHandler(this.TextBox5_KeyDown);
                if (this._TextBox5 != null)
                {
                    this._TextBox5.GotFocus -= handler;
                    this._TextBox5.TextChanged -= handler2;
                    this._TextBox5.KeyDown -= handler3;
                }
                this._TextBox5 = value;
                if (this._TextBox5 != null)
                {
                    this._TextBox5.GotFocus += handler;
                    this._TextBox5.TextChanged += handler2;
                    this._TextBox5.KeyDown += handler3;
                }
            }
        }

        internal virtual Timer Timer1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Timer1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Timer1_Tick);
                if (this._Timer1 != null)
                {
                    this._Timer1.Tick -= handler;
                }
                this._Timer1 = value;
                if (this._Timer1 != null)
                {
                    this._Timer1.Tick += handler;
                }
            }
        }

        internal virtual TableLayoutPanel tlp_manage_top
        {
            [DebuggerNonUserCode]
            get
            {
                return this._tlp_manage_top;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._tlp_manage_top = value;
            }
        }

        internal virtual TableLayoutPanel tlp_screenlist
        {
            [DebuggerNonUserCode]
            get
            {
                return this._tlp_screenlist;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._tlp_screenlist = value;
            }
        }

        internal virtual TableLayoutPanel tlp_taskbar
        {
            [DebuggerNonUserCode]
            get
            {
                return this._tlp_taskbar;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._tlp_taskbar = value;
            }
        }

        internal virtual TableLayoutPanel tlp_taskbar2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._tlp_taskbar2;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._tlp_taskbar2 = value;
            }
        }

        internal virtual TrackBar TrackBar1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TrackBar1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.TrackBar1_Scroll);
                if (this._TrackBar1 != null)
                {
                    this._TrackBar1.Scroll -= handler;
                }
                this._TrackBar1 = value;
                if (this._TrackBar1 != null)
                {
                    this._TrackBar1.Scroll += handler;
                }
            }
        }

        internal virtual TextBox txt_awardelg
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txt_awardelg;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._txt_awardelg = value;
            }
        }

        internal virtual TextBox txt_awardnat
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txt_awardnat;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._txt_awardnat = value;
            }
        }

        internal virtual TextBox txt_awardsch
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txt_awardsch;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._txt_awardsch = value;
            }
        }

        internal virtual TextBox txt_custom
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txt_custom;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._txt_custom = value;
            }
        }

        internal virtual TextBox txt_dbqnation
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txt_dbqnation;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._txt_dbqnation = value;
            }
        }

        internal virtual TextBox txt_fcrisis
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txt_fcrisis;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._txt_fcrisis = value;
            }
        }

        internal virtual TextBox txt_file_signatories
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txt_file_signatories;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._txt_file_signatories = value;
            }
        }

        internal virtual TextBox txt_file_sponsors
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txt_file_sponsors;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._txt_file_sponsors = value;
            }
        }

        internal virtual TextBox txt_filenumber_1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txt_filenumber_1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._txt_filenumber_1 = value;
            }
        }

        internal virtual TextBox txt_filenumber_2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txt_filenumber_2;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._txt_filenumber_2 = value;
            }
        }

        internal virtual TextBox txt_filenumber_3
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txt_filenumber_3;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._txt_filenumber_3 = value;
            }
        }

        internal virtual TextBox txt_fontpreview
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txt_fontpreview;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._txt_fontpreview = value;
            }
        }

        internal virtual TextBox txt_mainimg
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txt_mainimg;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._txt_mainimg = value;
            }
        }

        internal virtual TextBox txt_mc_add
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txt_mc_add;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                KeyEventHandler handler = new KeyEventHandler(this.txt_mc_add_KeyPress);
                EventHandler handler2 = new EventHandler(this.txt_mc_add_click);
                if (this._txt_mc_add != null)
                {
                    this._txt_mc_add.KeyUp -= handler;
                    this._txt_mc_add.Click -= handler2;
                }
                this._txt_mc_add = value;
                if (this._txt_mc_add != null)
                {
                    this._txt_mc_add.KeyUp += handler;
                    this._txt_mc_add.Click += handler2;
                }
            }
        }

        internal virtual TextBox txt_mc_current
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txt_mc_current;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._txt_mc_current = value;
            }
        }

        internal virtual TextBox txt_mc_currentnumber
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txt_mc_currentnumber;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._txt_mc_currentnumber = value;
            }
        }

        internal virtual TextBox txt_mc_totalnumber
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txt_mc_totalnumber;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._txt_mc_totalnumber = value;
            }
        }

        internal virtual TextBox txt_mceditnation
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txt_mceditnation;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._txt_mceditnation = value;
            }
        }

        internal virtual TextBox txt_mnation
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txt_mnation;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._txt_mnation = value;
            }
        }

        internal virtual TextBox txt_mneirong
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txt_mneirong;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._txt_mneirong = value;
            }
        }

        internal virtual TextBox txt_mtopic
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txt_mtopic;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._txt_mtopic = value;
            }
        }

        internal virtual TextBox txt_sfx1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txt_sfx1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._txt_sfx1 = value;
            }
        }

        internal virtual TextBox txt_sfx2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txt_sfx2;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._txt_sfx2 = value;
            }
        }

        internal virtual TextBox txt_sfx3
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txt_sfx3;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._txt_sfx3 = value;
            }
        }

        internal virtual TextBox txt_sfx4
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txt_sfx4;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._txt_sfx4 = value;
            }
        }

        internal virtual TextBox txt_spl_add
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txt_spl_add;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                KeyEventHandler handler = new KeyEventHandler(this.txt_spl_add_KeyPress);
                if (this._txt_spl_add != null)
                {
                    this._txt_spl_add.KeyUp -= handler;
                }
                this._txt_spl_add = value;
                if (this._txt_spl_add != null)
                {
                    this._txt_spl_add.KeyUp += handler;
                }
            }
        }

        internal virtual TextBox txt_spl_current
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txt_spl_current;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._txt_spl_current = value;
            }
        }

        internal virtual TextBox txt_spl_currentnunber
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txt_spl_currentnunber;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._txt_spl_currentnunber = value;
            }
        }

        internal virtual TextBox txt_spl_customtitle
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txt_spl_customtitle;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.txt_spl_customtitle_TextChanged);
                if (this._txt_spl_customtitle != null)
                {
                    this._txt_spl_customtitle.TextChanged -= handler;
                }
                this._txt_spl_customtitle = value;
                if (this._txt_spl_customtitle != null)
                {
                    this._txt_spl_customtitle.TextChanged += handler;
                }
            }
        }

        internal virtual TextBox txt_spl_totalnumber
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txt_spl_totalnumber;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._txt_spl_totalnumber = value;
            }
        }

        internal virtual TextBox txt_spl_yieldto
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txt_spl_yieldto;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._txt_spl_yieldto = value;
            }
        }

        internal virtual TextBox txt_startimg
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txt_startimg;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._txt_startimg = value;
            }
        }

        internal virtual TextBox txt_umccustom
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txt_umccustom;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._txt_umccustom = value;
            }
        }

        internal virtual TextBox txthcmotion
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txthcmotion;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.txthcmotion_TextChanged_1);
                if (this._txthcmotion != null)
                {
                    this._txthcmotion.TextChanged -= handler;
                }
                this._txthcmotion = value;
                if (this._txthcmotion != null)
                {
                    this._txthcmotion.TextChanged += handler;
                }
            }
        }

        internal virtual TextBox txtnationlist
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtnationlist;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._txtnationlist = value;
            }
        }

        internal virtual TextBox txtsession
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtsession;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.txtsession_gotfocus);
                if (this._txtsession != null)
                {
                    this._txtsession.GotFocus -= handler;
                }
                this._txtsession = value;
                if (this._txtsession != null)
                {
                    this._txtsession.GotFocus += handler;
                }
            }
        }

        internal virtual WebBrowser WebBrowser1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._WebBrowser1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._WebBrowser1 = value;
            }
        }
    }
}

