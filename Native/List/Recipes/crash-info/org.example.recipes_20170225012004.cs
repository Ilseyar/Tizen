S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160504.2021
Build-Date: 2016.05.04 20:21:45

Crash Information
Process Name: recipes
PID: 17078
Date: 2017-02-25 01:20:04+0900
Executable File Path: /opt/usr/apps/org.example.recipes/bin/recipes
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x28

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x00000000, esi = 0xb929cad0
ebp = 0xbf9bda68, esp = 0xbf9bda10
eax = 0xb423f000, ebx = 0xb72b25f0
ecx = 0xb423f040, edx = 0xb423f040
eip = 0xb70becb6

Memory Information
MemTotal:      123 KB
MemFree:        26 KB
Buffers:         8 KB
Cached:     177460 KB
VmPeak:     108648 KB
VmSize:     108648 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22764 KB
VmRSS:       22764 KB
VmData:      43016 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33424 KB
VmPTE:          84 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 17078 TID = 17078
17078 17079 17169 17170 17175 

Maps Information
b2c1f000 b2c29000 r-xp /usr/lib/libfeedback.so.0.1.4
b2c2f000 b2c3b000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2c3c000 b2c5d000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2c62000 b2c63000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2c64000 b2c69000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2c6a000 b2c6c000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2c6d000 b2c6f000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2c70000 b2c7c000 r-xp /usr/lib/libdrm.so.2.4.0
b2c7d000 b2c80000 r-xp /usr/lib/libdri2.so.0.0.0
b2c81000 b2c8b000 r-xp /usr/lib/libtbm.so.1.0.0
b2c8c000 b2ca1000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2ca2000 b2cb4000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b34b6000 b34bf000 r-xp /usr/lib/libeventsystem.so.0.0.1
b34c0000 b34d2000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b34d9000 b34da000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b34db000 b34dc000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b34dd000 b34e0000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b34e1000 b34e4000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b35ec000 b35f2000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b35f3000 b3737000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3747000 b3748000 r-xp /usr/lib/libxshmfence.so.1.0.0
b3749000 b374a000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b374b000 b3754000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3755000 b3758000 r-xp /opt/usr/apps/org.example.recipes/bin/recipes
b3759000 b3792000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4195000 b41a0000 r-xp /lib/libnss_files-2.20-2014.11.so
b41a2000 b41ad000 r-xp /lib/libnss_nis-2.20-2014.11.so
b41af000 b41c6000 r-xp /lib/libnsl-2.20-2014.11.so
b41ca000 b41d2000 r-xp /lib/libnss_compat-2.20-2014.11.so
b41d4000 b41f8000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b41f9000 b41fa000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b41fb000 b41fe000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b41ff000 b4206000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4207000 b4211000 r-xp /usr/lib/libsensord-share.so
b4212000 b422e000 r-xp /usr/lib/libsensor.so.1.2.0
b4230000 b4239000 r-xp /usr/lib/libappcore-common.so.1.1
b423c000 b423e000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4253000 b4255000 r-xp /usr/lib/libXau.so.6.0.0
b4256000 b4278000 r-xp /usr/lib/libxcb.so.1.1.0
b427a000 b4283000 r-xp /lib/libcrypt-2.20-2014.11.so
b42ac000 b42ae000 r-xp /usr/lib/libiri.so
b42af000 b42d5000 r-xp /lib/libexpat.so.1.5.2
b42d7000 b4342000 r-xp /usr/lib/libssl.so.1.0.0
b4348000 b4354000 r-xp /usr/lib/libethumb.so.1.13.0
b4355000 b4359000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b435a000 b45ab000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b26000 b5b36000 r-xp /usr/lib/libXi.so.6.1.0
b5b37000 b5b39000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b3a000 b5b40000 r-xp /usr/lib/libXtst.so.6.1.0
b5b41000 b5b4b000 r-xp /usr/lib/libXrender.so.1.3.0
b5b4c000 b5b55000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b57000 b5b59000 r-xp /usr/lib/libXinerama.so.1.0.0
b5b5a000 b5b5f000 r-xp /usr/lib/libXfixes.so.3.1.0
b5b60000 b5b72000 r-xp /usr/lib/libXext.so.6.4.0
b5b73000 b5b75000 r-xp /usr/lib/libXdamage.so.1.1.0
b5b76000 b5b78000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5b7a000 b5cbc000 r-xp /usr/lib/libX11.so.6.3.0
b5cc0000 b5cca000 r-xp /usr/lib/libXcursor.so.1.0.2
b5ccb000 b5ce1000 r-xp /usr/lib/libudev.so.1.6.0
b5ce4000 b5ce8000 r-xp /lib/libattr.so.1.1.0
b5ce9000 b5d18000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d1a000 b5d20000 r-xp /usr/lib/libffi.so.6.0.2
b5d21000 b5d44000 r-xp /lib/libz.so.1.2.8
b5d45000 b5d48000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d49000 b5ea5000 r-xp /usr/lib/libxml2.so.2.9.2
b5eab000 b5f92000 r-xp /usr/lib/libstdc++.so.6.0.20
b5f9f000 b5fa2000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5fa3000 b5fc5000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5fc6000 b5fda000 r-xp /lib/libresolv-2.20-2014.11.so
b5fde000 b6002000 r-xp /usr/lib/liblzma.so.5.0.3
b6003000 b6005000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b6007000 b6011000 r-xp /usr/lib/libembryo.so.1.13.0
b6012000 b603b000 r-xp /usr/lib/libpng12.so.0.50.0
b603c000 b6085000 r-xp /usr/lib/libjpeg.so.8.0.2
b6096000 b609d000 r-xp /lib/librt-2.20-2014.11.so
b609f000 b60be000 r-xp /usr/lib/libector.so.1.13.0
b60c1000 b60ee000 r-xp /usr/lib/liblua-5.1.so
b60ef000 b617f000 r-xp /usr/lib/libfreetype.so.6.11.3
b6183000 b61c1000 r-xp /usr/lib/libfontconfig.so.1.8.0
b61c2000 b61d8000 r-xp /usr/lib/libfribidi.so.0.3.1
b61d9000 b6232000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6235000 b6280000 r-xp /lib/libm-2.20-2014.11.so
b6282000 b6294000 r-xp /usr/lib/libeio.so.1.13.0
b6295000 b6298000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b6299000 b629f000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b62a0000 b62c3000 r-xp /usr/lib/libefreet.so.1.13.0
b62c6000 b62f1000 r-xp /usr/lib/libeldbus.so.1.13.0
b62f2000 b6326000 r-xp /usr/lib/libecore_con.so.1.13.0
b6328000 b6331000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6332000 b633b000 r-xp /usr/lib/libethumb_client.so.1.13.0
b633c000 b634f000 r-xp /usr/lib/libeo.so.1.13.0
b6351000 b6364000 r-xp /usr/lib/libecore_input.so.1.13.0
b6365000 b636c000 r-xp /usr/lib/libecore_file.so.1.13.0
b636d000 b6390000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6391000 b63bd000 r-xp /usr/lib/libeet.so.1.13.0
b63c6000 b6431000 r-xp /usr/lib/libeina.so.1.13.0
b6434000 b644b000 r-xp /usr/lib/libefl.so.1.13.0
b644d000 b65b4000 r-xp /usr/lib/libicuuc.so.51.1
b65c2000 b67ce000 r-xp /usr/lib/libicui18n.so.51.1
b67d6000 b6825000 r-xp /usr/lib/libecore_x.so.1.13.0
b6827000 b6841000 r-xp /lib/libgcc_s-4.9.so.1
b6843000 b6847000 r-xp /lib/libcap.so.2.21
b6848000 b688e000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b688f000 b6896000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6898000 b68ea000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b68ec000 b6a77000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6a7c000 b6b4a000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b4d000 b6b51000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b52000 b6b61000 r-xp /usr/lib/libvconf.so.0.2.45
b6b62000 b6b65000 r-xp /usr/lib/libvasum.so.0.3.1
b6b66000 b6b69000 r-xp /usr/lib/libttrace.so.1.1
b6b6b000 b6b6f000 r-xp /usr/lib/libiniparser.so.0
b6b70000 b6ba0000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6ba1000 b6baa000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6bab000 b6bd0000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6bd1000 b6be1000 r-xp /usr/lib/libunwind.so.8.0.1
b6beb000 b6d99000 r-xp /lib/libc-2.20-2014.11.so
b6da1000 b6ee4000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6ee6000 b6f3e000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f3f000 b6f73000 r-xp /usr/lib/libsystemd.so.0.4.0
b6f76000 b704a000 r-xp /usr/lib/libedje.so.1.13.0
b704d000 b7079000 r-xp /usr/lib/libecore.so.1.13.0
b708a000 b72b0000 r-xp /usr/lib/libevas.so.1.13.0
b72d8000 b72f0000 r-xp /lib/libpthread-2.20-2014.11.so
b72f4000 b766e000 r-xp /usr/lib/libelementary.so.1.13.0
b768e000 b7692000 r-xp /usr/lib/libsmack.so.1.0.0
b7693000 b769c000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b769d000 b76a0000 r-xp /usr/lib/libdlog.so.0.0.0
b76a1000 b76a6000 r-xp /usr/lib/libbundle.so.0.1.22
b76a7000 b76aa000 r-xp /lib/libdl-2.20-2014.11.so
b76ac000 b76d1000 r-xp /usr/lib/libaul.so.0.1.0
b76d4000 b76d6000 r-xp /usr/lib/libappsvc.so.0.1.0
b76d7000 b76dc000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b76dd000 b76e4000 r-xp /usr/lib/libappcore-efl.so.1.1
b76e6000 b76eb000 r-xp /usr/lib/libsys-assert.so
b76ee000 b76ef000 r-xp [vdso]
b76ef000 b7711000 r-xp /lib/ld-2.20-2014.11.so
b7713000 b771b000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:17078)
Call Stack Count: 31
 0: evas_object_event_callback_priority_add + 0xe6 (0xb70becb6) [/usr/lib/libevas.so.1] + 0x34cb6
 1: evas_object_event_callback_add + 0x38 (0xb70bed48) [/usr/lib/libevas.so.1] + 0x34d48
 2: (0xb74a60b8) [/usr/lib/libelementary.so.1] + 0x1b20b8
 3: elm_obj_widget_sub_object_add + 0xa1 (0xb7557371) [/usr/lib/libelementary.so.1] + 0x263371
 4: elm_widget_sub_object_add + 0x55 (0xb7571085) [/usr/lib/libelementary.so.1] + 0x27d085
 5: (0xb74a2af2) [/usr/lib/libelementary.so.1] + 0x1aeaf2
 6: elm_obj_container_content_set + 0xb3 (0xb73f0393) [/usr/lib/libelementary.so.1] + 0xfc393
 7: elm_widget_content_part_set + 0x71 (0xb7563b41) [/usr/lib/libelementary.so.1] + 0x26fb41
 8: elm_object_part_content_set + 0x2f (0xb74bcb3f) [/usr/lib/libelementary.so.1] + 0x1c8b3f
 9: my_box_pack + 0x134 (0xb3756444) [/opt/usr/apps/org.example.recipes/bin/recipes] + 0x1444
10: add_recipe_cb + 0x118 (0xb37562a8) [/opt/usr/apps/org.example.recipes/bin/recipes] + 0x12a8
11: (0xb7113116) [/usr/lib/libevas.so.1] + 0x89116
12: (0xb634a319) [/usr/lib/libeo.so.1] + 0xe319
13: eo_event_callback_call + 0xb3 (0xb6347d63) [/usr/lib/libeo.so.1] + 0xbd63
14: evas_object_smart_callback_call + 0x75 (0xb71159e5) [/usr/lib/libevas.so.1] + 0x8b9e5
15: (0xb73c6404) [/usr/lib/libelementary.so.1] + 0xd2404
16: (0xb6ff9f39) [/usr/lib/libedje.so.1] + 0x83f39
17: (0xb7000a11) [/usr/lib/libedje.so.1] + 0x8aa11
18: (0xb6ffafdc) [/usr/lib/libedje.so.1] + 0x84fdc
19: (0xb6ffb4cb) [/usr/lib/libedje.so.1] + 0x854cb
20: (0xb6ffb68f) [/usr/lib/libedje.so.1] + 0x8568f
21: (0xb7060702) [/usr/lib/libecore.so.1] + 0x13702
22: (0xb705a055) [/usr/lib/libecore.so.1] + 0xd055
23: (0xb70631b9) [/usr/lib/libecore.so.1] + 0x161b9
24: ecore_main_loop_begin + 0x57 (0xb7063587) [/usr/lib/libecore.so.1] + 0x16587
25: elm_run + 0x2d (0xb74bc22d) [/usr/lib/libelementary.so.1] + 0x1c822d
26: appcore_efl_main + 0x4de (0xb76e0dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
27: ui_app_main + 0x140 (0xb76d9c40) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c40
28: main + 0x2a4 (0xb3756714) [/opt/usr/apps/org.example.recipes/bin/recipes] + 0x1714
29: create_label_view + 0x18 (0xb7715148) [/opt/usr/apps/org.example.recipes/bin/recipes] + 0xb7715148
30: __libc_start_main + 0xde (0xb6c02e4e) [/lib/libc.so.6] + 0x17e4e
End of Call Stack

Package Information
Package Name: org.example.recipes
Package ID : org.example.recipes
Version: 1.0.0
Package Type: tpk
App Name: recipes
App ID: org.example.recipes
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
SOURCED( 2996): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 16886, proc_name: org.example.recipes, cg_name: previous, oom_score_adj: 300
02-25 01:19:55.574+0900 D/RESOURCED( 2996): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 16886
02-25 01:19:55.574+0900 D/DATA_PROVIDER_MASTER( 3067): xmonitor.c: xmonitor_resume(339) > [SECURE_LOG] 3020 is resumed
02-25 01:19:55.574+0900 D/DATA_PROVIDER_MASTER( 3067): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 0
02-25 01:19:55.574+0900 E/DATA_PROVIDER_MASTER( 3067): setting.c: setting_is_lcd_off(95) > [SECURE_LOG] State: 1, (3:lcdoff, 4:sleep)
02-25 01:19:55.594+0900 I/CAPI_WIDGET_APPLICATION( 3098): widget_app.c: __provider_resume_cb(312) > widget obj was resumed
02-25 01:19:55.594+0900 I/CAPI_WIDGET_APPLICATION( 3098): widget_app.c: __check_status_for_cgroup(132) > enter foreground group
02-25 01:19:55.594+0900 W/AUL     ( 3098): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3098, appid: org.tizen.calendar.widget, status: fg
02-25 01:19:55.644+0900 D/RESOURCED( 2996): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 3098
02-25 01:19:55.644+0900 D/RESOURCED( 2996): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3098, proc_name: org.tizen.calendar.widget, cg_name: foreground, oom_score_adj: 200
02-25 01:19:55.644+0900 D/RESOURCED( 2996): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 3098
02-25 01:19:55.684+0900 D/RESOURCED( 2996): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 3098, appname = org.tizen.calendar.widget
02-25 01:19:55.684+0900 D/RESOURCED( 2996): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 3098
02-25 01:19:55.684+0900 I/RESOURCED( 2996): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
02-25 01:19:55.684+0900 I/RESOURCED( 2996): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
02-25 01:19:55.894+0900 D/cluster-view( 3020): custom-cluster-impl.cpp: OnCustomScrollComplete(5141) >  ##################### scroll complete ########################### 
02-25 01:19:55.894+0900 D/cluster-view( 3020): cluster-impl.cpp: OnScrollComplete(639) >  Horizontal Cluster scrollview is stopped normally, pos[0.00, 0.00]
02-25 01:19:55.894+0900 D/cluster-view( 3020): cluster-impl.cpp: OnScrollComplete(653) >  scroll position x : -0.00 (page:0)
02-25 01:19:55.894+0900 D/test-log( 3020): cluster-impl.cpp: SetFocusedPage(791) >  Set mFocusedPage: 1
02-25 01:19:55.894+0900 D/test-log( 3020): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
02-25 01:19:55.894+0900 D/cluster-view( 3020): cluster-view-controller.cpp: OnClusterChangeFocusedPage(1779) >  Cluster[0:] 1 page focused
02-25 01:19:55.894+0900 D/cluster-home( 3020): widget-data-provider.cpp: OnCustomClusterFocusedPageChanged(2934) >  Cluster[0] page[1] focused
02-25 01:19:58.484+0900 D/PROCESSMGR( 2951): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x201e00 bd->visible=0
02-25 01:19:59.474+0900 E/PKGMGR_SERVER(17113): pkgmgr-server.c: main(2209) > package manager server start
02-25 01:19:59.474+0900 D/PKGMGR  (17113): comm_pkg_mgr_server.c: pkg_mgr_server_gdbus_init(405) > initialize_gdbus Enter
02-25 01:19:59.474+0900 D/PKGMGR  (17113): comm_pkg_mgr_server.c: pkg_mgr_server_gdbus_init(423) > initialize_gdbus Exit
02-25 01:19:59.524+0900 D/PKGMGR  (17113): comm_pkg_mgr_server.c: on_bus_acquired(376) > on_bus_acquired
02-25 01:19:59.524+0900 D/PKGMGR  (17113): comm_pkg_mgr_server.c: on_bus_acquired(400) > on_bus_acquired done
02-25 01:19:59.534+0900 D/PKGMGR  (17113): comm_pkg_mgr_server.c: pkgmgr_request(145) > Called
02-25 01:19:59.534+0900 D/PKGMGR  (17113): comm_pkg_mgr_server.c: pkgmgr_request(164) > sender_name: :1.1225
02-25 01:19:59.534+0900 D/PKGMGR  (17113): comm_pkg_mgr_server.c: pkg_mgr_get_sender_pid(79) > zone pid : 17111
02-25 01:19:59.534+0900 D/PKGMGR  (17113): comm_pkg_mgr_server.c: pkgmgr_request(166) > sender_pid: 17111
02-25 01:19:59.534+0900 D/PKGMGR  (17113): comm_pkg_mgr_server.c: pkgmgr_request(175) > [SECURE_LOG] Call request callback(obj, org.example.recipes_434471569, 14, tpk, org.example.recipes, , host)
02-25 01:19:59.534+0900 D/PKGMGR_SERVER(17113): pkgmgr-server.c: req_cb(625) > [SECURE_LOG] >> in callback >> Got request: [org.example.recipes_434471569] [14] [tpk] [org.example.recipes] [] [] [host]
02-25 01:19:59.534+0900 D/PKGMGR_SERVER(17113): pkgmgr-server.c: req_cb(646) > req_type=(14)  backend_flag=(0) zone(host)
02-25 01:19:59.534+0900 D/PKGMGR_SERVER(17113): pkgmgr-server.c: queue_job(1880) > target zone(host, host)
02-25 01:19:59.534+0900 D/PKGMGR_SERVER(17113): pkgmgr-server.c: queue_job(1884) > child forked [17116] for request type [14]
02-25 01:19:59.534+0900 D/PKGMGR_SERVER(17113): pkgmgr-server.c: queue_job(2126) > parent exit
02-25 01:19:59.534+0900 D/PKGMGR_SERVER(17116): pkgmgr-server.c: queue_job(1884) > child forked [0] for request type [14]
02-25 01:19:59.534+0900 D/PKGMGR_SERVER(17116): pkgmgr-server.c: queue_job(2057) > kill/check request
02-25 01:19:59.534+0900 D/PKGMGR  (17111): pkgmgr.c: __check_sync_process(868) > info_file file is generated, result = 0
02-25 01:19:59.534+0900 D/PKGMGR  (17111): . 
02-25 01:19:59.534+0900 E/PKGMGR  (17111): pkgmgr.c: __check_sync_process(884) > file is can not remove[/tmp/org.example.recipes, -1]
02-25 01:19:59.544+0900 D/PKGMGR_SERVER(17116): pkgmgr-server.c: __pkgcmd_app_cb(1458) > sub_cmd(kill), zone_name(host)
02-25 01:19:59.554+0900 D/AUL     (17116): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(14)
02-25 01:19:59.554+0900 D/AUL_AMD ( 2767): amd_request.c: __request_handler(838) > __request_handler: 14
02-25 01:19:59.554+0900 D/AUL_AMD ( 2767): amd_status.c: _status_app_is_running_from_cache(836) > is_running hit cache, return immediately
02-25 01:19:59.554+0900 D/AUL_AMD ( 2767): amd_request.c: __request_handler(1028) > [SECURE_LOG] APP_IS_RUNNING : org.example.recipes : 16886
02-25 01:19:59.554+0900 W/AUL_AMD ( 2767): amd_request.c: __send_result_to_client(150) > __send_result_to_client, pid: 16886
02-25 01:19:59.554+0900 D/AUL_AMD ( 2767): amd_request.c: __request_handler(838) > __request_handler: 12
02-25 01:19:59.554+0900 D/AUL     (17116): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 293
02-25 01:19:59.554+0900 D/AUL     (17116): launch.c: app_request_to_launchpad(396) > [SECURE_LOG] launch request : 16886
02-25 01:19:59.554+0900 D/AUL     (17116): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(5)
02-25 01:19:59.554+0900 D/AUL_AMD ( 2767): amd_request.c: __request_handler(838) > __request_handler: 5
02-25 01:19:59.554+0900 D/AUL_AMD ( 2767): amd_appinfo.c: appinfo_set_value(905) > [SECURE_LOG] org.example.recipes : installed : norestart
02-25 01:19:59.554+0900 D/AUL_AMD ( 2767): amd_request.c: __app_process_by_pid(279) > [SECURE_LOG] __app_process_by_pid, pid: 16886, 
02-25 01:19:59.554+0900 D/AUL     ( 2767): app_sock.c: __app_send_raw_with_delay_reply(455) > pid(16886) : cmd(4)
02-25 01:19:59.554+0900 D/AUL_AMD ( 2767): amd_launch.c: _term_app(1076) > term done
02-25 01:19:59.554+0900 D/AUL_AMD ( 2767): amd_launch.c: __set_reply_handler(1015) > listen fd : 31, send fd : 30
02-25 01:19:59.554+0900 D/APP_CORE(16886): appcore.c: __aul_handler(632) > [APP 16886]     AUL event: AUL_TERMINATE
02-25 01:19:59.554+0900 I/APP_CORE(16886): appcore-efl.c: __do_app(496) > [APP 16886] Event: TERMINATE State: PAUSED
02-25 01:19:59.554+0900 D/APP_CORE(16886): appcore-efl.c: __do_app(517) > [APP 16886] TERMINATE
02-25 01:19:59.554+0900 W/AUL_AMD ( 2767): amd_launch.c: __reply_handler(913) > listen fd(31) , send fd(30), pid(16886), cmd(4)
02-25 01:19:59.554+0900 D/RESOURCED( 2996): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 16886
02-25 01:19:59.554+0900 D/AUL     (16886): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
02-25 01:19:59.554+0900 D/AUL_AMD ( 2767): amd_request.c: __request_handler(838) > __request_handler: 22
02-25 01:19:59.554+0900 D/AUL     (16886): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
02-25 01:19:59.554+0900 W/AUL_AMD ( 2767): amd_request.c: __request_handler(1056) > app status : 5
02-25 01:19:59.554+0900 D/AUL_AMD ( 2767): amd_status.c: _status_update_app_info_list(456) > pid(16886) status(5)
02-25 01:19:59.554+0900 D/AUL_AMD ( 2767): amd_status.c: _status_update_app_info_list(468) > pid(16886) appid(org.example.recipes) pkgid(org.example.recipes) status(5)
02-25 01:19:59.554+0900 D/AUL_AMD ( 2767): amd_request.c: __request_handler(838) > __request_handler: 22
02-25 01:19:59.554+0900 W/AUL_AMD ( 2767): amd_request.c: __request_handler(1056) > app status : 5
02-25 01:19:59.554+0900 D/AUL_AMD ( 2767): amd_status.c: _status_update_app_info_list(456) > pid(16886) status(5)
02-25 01:19:59.554+0900 D/AUL_AMD ( 2767): amd_status.c: _status_update_app_info_list(468) > pid(16886) appid(org.example.recipes) pkgid(org.example.recipes) status(5)
02-25 01:19:59.554+0900 D/AUL     (17116): launch.c: app_request_to_launchpad(425) > launch request result : 0
02-25 01:19:59.564+0900 D/APP_CORE(16886): appcore.c: _appcore_fini_suspend_dbus_handler(944) > [__SUSPEND__] suspend signal finalized
02-25 01:19:59.564+0900 I/CAPI_APPFW_APPLICATION(16886): app_main.c: _ui_app_appcore_terminate(662) > app_appcore_terminate
02-25 01:19:59.564+0900 E/EFL     (16886): eo<16886> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x80036fb8 is not pointing to a valid object. Maybe it has already been freed.
02-25 01:19:59.564+0900 E/EFL     (16886): eo<16886> lib/eo/eo.c:485 _eo_do_internal() Obj (0x80036fb8) is an invalid ref.
02-25 01:19:59.564+0900 D/AUL     (17116): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(14)
02-25 01:19:59.564+0900 D/AUL_AMD ( 2767): amd_request.c: __request_handler(838) > __request_handler: 14
02-25 01:19:59.564+0900 D/AUL_AMD ( 2767): amd_status.c: _status_app_is_running_from_cache(836) > is_running hit cache, return immediately
02-25 01:19:59.564+0900 D/AUL_AMD ( 2767): amd_request.c: __request_handler(1028) > [SECURE_LOG] APP_IS_RUNNING : org.example.recipes : 16886
02-25 01:19:59.564+0900 D/AUL_AMD ( 2767): amd_request.c: __request_handler(1030) > [SECURE_LOG] APP_IS_RUNNING: 16886 is dying
02-25 01:19:59.564+0900 W/AUL_AMD ( 2767): amd_request.c: __send_result_to_client(150) > __send_result_to_client, pid: -1
02-25 01:19:59.564+0900 E/E17     ( 2951): e_border.c: e_border_hide(2248) > BD_HIDE(0x02800002), visible:1
02-25 01:19:59.564+0900 D/PKGMGR_SERVER(17116): pkgmgr-server.c: __make_pid_info_file(1384) > cano_path(tmp/org.example.recipes)
02-25 01:19:59.564+0900 D/PKGMGR_SERVER(17116): pkgmgr-server.c: __make_pid_info_file(1403) > security_server_label_access(tmp/org.example.recipes, *) is ok.
02-25 01:19:59.564+0900 D/PKGMGR_SERVER(17113): pkgmgr-server.c: sighandler(387) > child exit [17116]
02-25 01:19:59.564+0900 E/PKGMGR_SERVER(17113): pkgmgr-server.c: sighandler(402) > child NORMAL exit [17116]
02-25 01:19:59.864+0900 D/AUL_PAD ( 3065): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
02-25 01:19:59.864+0900 D/AUL_PAD ( 3065): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
02-25 01:19:59.864+0900 D/AUL_PAD ( 3065): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
02-25 01:19:59.864+0900 D/AUL_PAD ( 3065): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
02-25 01:19:59.864+0900 D/AUL_PAD ( 3065): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
02-25 01:19:59.864+0900 D/AUL_PAD ( 3065): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
02-25 01:19:59.864+0900 D/AUL_PAD ( 3065): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
02-25 01:19:59.864+0900 I/AUL_PAD ( 3065): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 16886 pgid = 16886
02-25 01:19:59.864+0900 I/AUL_PAD ( 3065): sigchild.h: __sigchild_action(142) > dead_pid(16886)
02-25 01:19:59.874+0900 D/AUL_PAD ( 3065): sigchild.h: __send_app_dead_signal(90) > send dead signal done
02-25 01:19:59.874+0900 I/AUL_PAD ( 3065): sigchild.h: __sigchild_action(148) > __send_app_dead_signal(0)
02-25 01:19:59.874+0900 I/AUL_PAD ( 3065): sigchild.h: __launchpad_process_sigchld(169) > after __sigchild_action
02-25 01:19:59.874+0900 E/AUL_PAD ( 3065): launchpad.c: main(688) > error reading sigchld info
02-25 01:19:59.874+0900 I/ESD     ( 3064): esd_main.c: __esd_app_dead_handler(1771) > pid: 16886
02-25 01:19:59.874+0900 W/AUL_AMD ( 2767): amd_main.c: __app_dead_handler(324) > __app_dead_handler, pid: 16886
02-25 01:19:59.874+0900 D/STARTER ( 2995): starter.c: _check_dead_signal(181) > [_check_dead_signal:181] Process 16886 is termianted
02-25 01:19:59.874+0900 D/STARTER ( 2995): starter.c: _check_dead_signal(202) > [_check_dead_signal:202] Unknown process, ignore it
02-25 01:19:59.874+0900 D/AUL_AMD ( 2767): amd_key.c: _unregister_key_event(179) > ===key stack===
02-25 01:19:59.874+0900 E/AUL_AMD ( 2767): amd_launch.c: _revoke_temporary_permission(2129) > list or callee_label was null
02-25 01:19:59.874+0900 D/AUL_AMD ( 2767): amd_status.c: __remove_pkg_info(266) > ~STATUS_SERVICE : appid(org.example.recipes)
02-25 01:19:59.874+0900 D/AUL     ( 2767): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
02-25 01:19:59.874+0900 E/AUL     ( 2767): simple_util.c: __trm_app_info_send_socket(330) > access
02-25 01:19:59.874+0900 D/RESOURCED( 2996): proc-monitor.c: proc_dbus_aul_terminated(1080) > received terminated process : pid 16886
02-25 01:19:59.874+0900 D/RESOURCED( 2996): appinfo-list.c: resourced_appinfo_put(132) > appid org.example.recipes, pkgname = org.example.recipes, ref = 0
02-25 01:20:00.584+0900 D/INDICATOR( 3000): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
02-25 01:20:00.584+0900 D/INDICATOR( 3000): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
02-25 01:20:00.584+0900 D/INDICATOR( 3000): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
02-25 01:20:00.594+0900 D/INDICATOR( 3000): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 1:20 4 h"
02-25 01:20:00.594+0900 D/INDICATOR( 3000): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 1:20"
02-25 01:20:00.594+0900 D/INDICATOR( 3000): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 1&#x2236;20"
02-25 01:20:00.594+0900 D/INDICATOR( 3000): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2146258082 Time: <font_size=33>1&#x2236;20</font_size> <font_size=32>AM</font_size></font>
02-25 01:20:01.314+0900 D/AUL_AMD ( 2767): amd_request.c: __request_handler(838) > __request_handler: 0
02-25 01:20:01.314+0900 D/AUL_AMD ( 2767): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.recipes
02-25 01:20:01.314+0900 D/PKGMGR_INFO( 2767): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
02-25 01:20:01.314+0900 D/PKGMGR_INFO( 2767): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
02-25 01:20:01.314+0900 I/AUL     ( 2767): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
02-25 01:20:01.324+0900 D/AUL     ( 2767): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 17163, pid = 17165
02-25 01:20:01.324+0900 D/PKGMGR_INFO( 2767): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
02-25 01:20:01.324+0900 D/PKGMGR_INFO( 2767): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
02-25 01:20:01.324+0900 I/AUL     ( 2767): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
02-25 01:20:01.324+0900 E/AUL_AMD ( 2767): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
02-25 01:20:01.324+0900 W/AUL_AMD ( 2767): amd_launch.c: _start_app(2233) > caller pid : 17165
02-25 01:20:01.324+0900 E/AUL_AMD ( 2767): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
02-25 01:20:01.324+0900 W/AUL_AMD ( 2767): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.recipes) pkgid(org.example.recipes) attribute(200)
02-25 01:20:01.324+0900 D/AUL_AMD ( 2767): amd_launch.c: _start_app(2648) > process_pool: false
02-25 01:20:01.324+0900 D/AUL_AMD ( 2767): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
02-25 01:20:01.324+0900 D/AUL_AMD ( 2767): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.recipes
02-25 01:20:01.324+0900 W/AUL_AMD ( 2767): amd_launch.c: _start_app(2665) > pad pid(-5)
02-25 01:20:01.324+0900 D/AUL_AMD ( 2767): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
02-25 01:20:01.324+0900 D/AUL_AMD ( 2767): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
02-25 01:20:01.324+0900 D/AUL     ( 2767): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
02-25 01:20:01.324+0900 D/AUL_PAD ( 3065): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
02-25 01:20:01.324+0900 D/AUL_PAD ( 3065): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
02-25 01:20:01.324+0900 D/AUL_PAD ( 3065): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
02-25 01:20:01.324+0900 D/AUL_PAD ( 3065): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
02-25 01:20:01.324+0900 D/AUL_PAD ( 3065): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
02-25 01:20:01.324+0900 D/AUL_PAD ( 3065): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
02-25 01:20:01.324+0900 D/AUL_PAD ( 3065): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
02-25 01:20:01.324+0900 D/AUL_PAD ( 3065): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
02-25 01:20:01.324+0900 D/AUL_PAD ( 3065): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.recipes
02-25 01:20:01.324+0900 D/AUL_PAD ( 3065): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.recipes/bin/recipes
02-25 01:20:01.324+0900 D/AUL_PAD ( 3065): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
02-25 01:20:01.324+0900 D/AUL_PAD ( 3065): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
02-25 01:20:01.324+0900 D/AUL_PAD ( 3065): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
02-25 01:20:01.324+0900 D/AUL_PAD ( 3065): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
02-25 01:20:01.324+0900 W/AUL_PAD ( 3065): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
02-25 01:20:01.324+0900 D/AUL     ( 3065): process_pool.c: __send_pkt_raw_data(219) > send(11) : 624 / 624
02-25 01:20:01.324+0900 D/AUL_PAD ( 3065): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 17078, bin path: /opt/usr/apps/org.example.recipes/bin/recipes
02-25 01:20:01.324+0900 W/AUL_PAD ( 3065): launchpad.c: __send_result_to_caller(265) > Check app launching
02-25 01:20:01.324+0900 D/AUL_PAD ( 3065): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
02-25 01:20:01.324+0900 D/AUL_PAD (17078): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
02-25 01:20:01.324+0900 D/AUL_PAD (17078): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 624, pkt->len: 616
02-25 01:20:01.324+0900 D/AUL_PAD (17078): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.recipes, launchpad type: 0
02-25 01:20:01.324+0900 D/AUL_PAD (17078): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
02-25 01:20:01.324+0900 D/AUL_PAD (17078): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.recipes
02-25 01:20:01.324+0900 D/AUL_PAD (17078): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.recipes
02-25 01:20:01.324+0900 D/AUL     (17078): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (17079) is sent.
02-25 01:20:01.324+0900 D/AUL     (17078): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 17079, signo: 10
02-25 01:20:01.324+0900 D/RESOURCED( 2996): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.recipes, pkgid = org.example.recipes, flags = 512
02-25 01:20:01.324+0900 D/RESOURCED( 2996): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.recipes, pkgname = org.example.recipes, ref = 1
02-25 01:20:01.324+0900 E/RESOURCED( 2996): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
02-25 01:20:01.324+0900 D/AUL     (17078): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
02-25 01:20:01.324+0900 D/AUL_PAD (17078): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.recipes / pkg_type : rpm / app_path : /opt/usr/apps/org.example.recipes/bin/recipes
02-25 01:20:01.324+0900 D/AUL_PAD (17078): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.recipes/bin/recipes##
02-25 01:20:01.324+0900 D/AUL_PAD (17078): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
02-25 01:20:01.324+0900 D/AUL_PAD (17078): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
02-25 01:20:01.324+0900 D/AUL_PAD (17078): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0ODc5NTMyMDEvMzI3OTc0AA==##
02-25 01:20:01.324+0900 D/AUL_PAD (17078): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
02-25 01:20:01.324+0900 D/AUL_PAD (17078): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KQAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAYAAAAxNzE2NQA=##
02-25 01:20:01.324+0900 D/AUL_PAD (17078): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
02-25 01:20:01.324+0900 D/AUL_PAD (17078): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
02-25 01:20:01.324+0900 D/AUL_PAD (17078): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.recipes/bin/recipes, real app argc: 8
02-25 01:20:01.324+0900 D/AUL_PAD (17078): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
02-25 01:20:01.324+0900 D/AUL_PAD (17078): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.recipes/bin/recipes)
02-25 01:20:01.334+0900 I/CAPI_APPFW_APPLICATION(17078): app_main.c: ui_app_main(788) > app_efl_main
02-25 01:20:01.334+0900 D/LAUNCH  (17078): appcore-efl.c: appcore_efl_main(1692) > [recipes:Application:main:done]
02-25 01:20:01.334+0900 D/APP_CORE(17078): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
02-25 01:20:01.334+0900 D/APP_CORE(17078): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.recipes/res/locale
02-25 01:20:01.334+0900 D/APP_CORE(17078): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
02-25 01:20:01.334+0900 D/APP_CORE(17078): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
02-25 01:20:01.334+0900 D/AUL     (17078): app_sock.c: __create_server_sock(156) > pg path - already exists
02-25 01:20:01.334+0900 D/APP_CORE(17078): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb4239520
02-25 01:20:01.334+0900 D/LAUNCH  (17078): appcore-efl.c: __before_loop(1136) > [recipes:Platform:appcore_init:done]
02-25 01:20:01.334+0900 I/CAPI_APPFW_APPLICATION(17078): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
02-25 01:20:01.424+0900 D/AUL_PAD ( 3065): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
02-25 01:20:01.424+0900 W/AUL     ( 2767): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 17078, appid: org.example.recipes
02-25 01:20:01.424+0900 D/AUL     ( 2767): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
02-25 01:20:01.424+0900 E/AUL     ( 2767): simple_util.c: __trm_app_info_send_socket(330) > access
02-25 01:20:01.424+0900 D/AUL_AMD ( 2767): amd_launch.c: _start_app(2700) > add app group info
02-25 01:20:01.424+0900 E/AUL     ( 2767): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
02-25 01:20:01.424+0900 D/AUL_AMD ( 2767): amd_status.c: _status_add_app_info_list(427) > pid(17078) appid(org.example.recipes) pkgid(org.example.recipes) comp(uiapp)
02-25 01:20:01.424+0900 D/RESOURCED( 2996): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.recipes, 17078
02-25 01:20:01.424+0900 D/RESOURCED( 2996): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.recipes with pkgname
02-25 01:20:01.424+0900 E/RESOURCED( 2996): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.recipes
02-25 01:20:01.424+0900 D/RESOURCED( 2996): proc-main.c: resourced_proc_status_change(888) > available memory = 321
02-25 01:20:01.554+0900 D/LAUNCH  (17078): appcore-efl.c: __before_loop(1154) > [recipes:Application:create:done]
02-25 01:20:01.554+0900 E/E17     ( 2951): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x02600002)
02-25 01:20:01.554+0900 D/APP_CORE(17078): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
02-25 01:20:01.564+0900 E/E17     ( 2951): e_border.c: e_border_show(2088) > BD_SHOW(0x02600002)
02-25 01:20:01.574+0900 D/APP_CORE(17078): appcore.c: __aul_handler(587) > [APP 17078]     AUL event: AUL_START
02-25 01:20:01.574+0900 I/APP_CORE(17078): appcore-efl.c: __do_app(496) > [APP 17078] Event: RESET State: CREATED
02-25 01:20:01.574+0900 D/APP_CORE(17078): appcore-efl.c: __do_app(527) > [APP 17078] RESET
02-25 01:20:01.574+0900 D/LAUNCH  (17078): appcore-efl.c: __do_app(529) > [recipes:Application:reset:start]
02-25 01:20:01.574+0900 D/APP_CORE(17078): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
02-25 01:20:01.574+0900 D/APP_CORE(17078): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
02-25 01:20:01.574+0900 I/CAPI_APPFW_APPLICATION(17078): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
02-25 01:20:01.584+0900 D/AUL     (17078): service.c: __set_bundle(186) > __set_bundle
02-25 01:20:01.584+0900 D/LAUNCH  (17078): appcore-efl.c: __do_app(544) > [recipes:Application:reset:done]
02-25 01:20:01.584+0900 D/APP_CORE(17078): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
02-25 01:20:01.584+0900 E/EFL     (17078): edje<17078> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
02-25 01:20:01.584+0900 E/EFL     (17078): By the power of Grayskull, your previous Embryo stack is now broken!
02-25 01:20:01.584+0900 E/EFL     (17078): edje<17078> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
02-25 01:20:01.584+0900 E/EFL     (17078): By the power of Grayskull, your previous Embryo stack is now broken!
02-25 01:20:01.584+0900 E/EFL     (17078): edje<17078> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
02-25 01:20:01.584+0900 E/EFL     (17078): By the power of Grayskull, your previous Embryo stack is now broken!
02-25 01:20:01.584+0900 E/EFL     (17078): edje<17078> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
02-25 01:20:01.584+0900 E/EFL     (17078): By the power of Grayskull, your previous Embryo stack is now broken!
02-25 01:20:01.584+0900 E/EFL     (17078): edje<17078> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
02-25 01:20:01.584+0900 E/EFL     (17078): By the power of Grayskull, your previous Embryo stack is now broken!
02-25 01:20:01.584+0900 W/PROCESSMGR( 2951): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=17078
02-25 01:20:01.584+0900 W/APP_CORE(17078): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2600002
02-25 01:20:01.584+0900 D/APP_CORE(17078): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2600002
02-25 01:20:01.584+0900 D/APP_CORE(17078): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
02-25 01:20:01.584+0900 D/AUL     (17078): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
02-25 01:20:01.594+0900 D/AUL_AMD ( 2767): amd_request.c: __request_handler(838) > __request_handler: 34
02-25 01:20:01.604+0900 E/EFL     ( 2951): eo<2951> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
02-25 01:20:01.604+0900 E/EFL     ( 2951): eo<2951> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
02-25 01:20:01.604+0900 D/AUL_AMD ( 2767): amd_request.c: __request_handler(838) > __request_handler: 15
02-25 01:20:01.604+0900 D/PKGMGR_INFO( 2767): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.recipes/bin/recipes' and package_app_info.app_disable IN ('false','False')
02-25 01:20:01.604+0900 D/PKGMGR_INFO( 2767): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.recipes/bin/recipes' and package_app_info.app_disable IN ('false','False')
02-25 01:20:01.604+0900 D/INDICATOR( 3000): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
02-25 01:20:01.604+0900 D/INDICATOR( 3000): util.c: util_signal_emit_by_win(116) > emission bg.opaque
02-25 01:20:01.604+0900 D/INDICATOR( 3000): main.c: _rotate_window(229) > Indicator angle is 0 degree
02-25 01:20:01.604+0900 D/INDICATOR( 3000): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
02-25 01:20:01.604+0900 D/INDICATOR( 3000): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
02-25 01:20:01.604+0900 D/INDICATOR( 3000): main.c: _rotate_window(252) > port :: hide more icon
02-25 01:20:01.614+0900 D/AUL_AMD ( 2767): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 17078 is org.example.recipes
02-25 01:20:01.614+0900 D/AUL_AMD ( 2767): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 17078 : 0
02-25 01:20:01.614+0900 D/AUL     ( 3087): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
02-25 01:20:01.994+0900 E/PKGMGR_SERVER(17113): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
02-25 01:20:01.994+0900 E/PKGMGR_SERVER(17113): pkgmgr-server.c: main(2265) > package manager server terminated.
02-25 01:20:02.174+0900 D/APP_CORE(17078): appcore.c: __prt_ltime(236) > [APP 17078] first idle after reset: 856 msec
02-25 01:20:02.424+0900 D/AUL_PAD ( 3065): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
02-25 01:20:02.424+0900 D/AUL_PAD (17173): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
02-25 01:20:02.424+0900 D/AUL_AMD ( 2767): amd_launch.c: __grab_timeout_handler(1445) > pid(17078) ecore_x_pointer_ungrab
02-25 01:20:02.424+0900 D/AUL_AMD ( 2767): amd_key.c: _key_ungrab(265) > _key_ungrab, win : 600002
02-25 01:20:02.434+0900 D/AUL_PAD ( 3065): sigchild.h: __send_app_launch_signal(131) > send launch signal done
02-25 01:20:02.444+0900 W/AUL_AMD ( 2767): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
02-25 01:20:02.444+0900 W/AUL_AMD ( 2767): amd_launch.c: __grab_timeout_handler(1447) > back key ungrab error
02-25 01:20:02.444+0900 E/RESOURCED( 2996): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1230
02-25 01:20:02.924+0900 D/AUL_AMD ( 2767): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.recipes /opt/usr/apps/org.example.recipes/bin/recipes
02-25 01:20:02.924+0900 D/RUA     ( 2767): rua.c: rua_add_history(179) > rua_add_history start
02-25 01:20:02.934+0900 D/RUA     ( 2767): rua.c: rua_add_history(247) > rua_add_history ok
02-25 01:20:02.994+0900 E/E17     ( 2951): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
02-25 01:20:02.994+0900 D/APP_CORE( 3020): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
02-25 01:20:02.994+0900 D/APP_CORE( 3020): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
02-25 01:20:02.994+0900 D/APP_CORE( 3020): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
02-25 01:20:02.994+0900 I/APP_CORE( 3020): appcore-efl.c: __do_app(496) > [APP 3020] Event: PAUSE State: RUNNING
02-25 01:20:02.994+0900 D/APP_CORE( 3020): appcore-efl.c: __do_app(565) > [APP 3020] PAUSE
02-25 01:20:02.994+0900 I/CAPI_APPFW_APPLICATION( 3020): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
02-25 01:20:02.994+0900 E/cluster-home( 3020): homescreen.cpp: OnPause(84) >  app pause
02-25 01:20:02.994+0900 D/cluster-view( 3020): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
02-25 01:20:02.994+0900 D/cluster-view( 3020): homescreen-view-manager.cpp: AppPause(923) >  END
02-25 01:20:02.994+0900 D/APP_CORE( 3020): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
02-25 01:20:02.994+0900 E/APP_CORE( 3020): appcore-efl.c: __trm_app_info_send_socket(242) > access
02-25 01:20:02.994+0900 D/AUL_AMD ( 2767): amd_status.c: _status_update_app_info_list(456) > pid(3020) status(4)
02-25 01:20:02.994+0900 D/AUL_AMD ( 2767): amd_status.c: _status_update_app_info_list(468) > pid(3020) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
02-25 01:20:02.994+0900 D/AUL     ( 2767): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
02-25 01:20:02.994+0900 W/AUL     ( 2767): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3020, appid: org.tizen.homescreen, status: bg
02-25 01:20:03.004+0900 D/AUL_AMD ( 2767): amd_launch.c: __e17_status_handler(2891) > pid(17078) status(3)
02-25 01:20:03.004+0900 D/AUL_AMD ( 2767): amd_key.c: _key_ungrab(265) > _key_ungrab, win : 600002
02-25 01:20:03.004+0900 W/AUL_AMD ( 2767): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
02-25 01:20:03.004+0900 W/AUL_AMD ( 2767): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
02-25 01:20:03.004+0900 D/AUL_AMD ( 2767): amd_status.c: _status_update_app_info_list(456) > pid(17078) status(3)
02-25 01:20:03.004+0900 D/AUL_AMD ( 2767): amd_status.c: _status_update_app_info_list(468) > pid(17078) appid(org.example.recipes) pkgid(org.example.recipes) status(3)
02-25 01:20:03.004+0900 D/AUL     ( 2767): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.recipes
02-25 01:20:03.004+0900 W/AUL     ( 2767): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 17078, appid: org.example.recipes, status: fg
02-25 01:20:03.004+0900 D/RESOURCED( 2996): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 17078
02-25 01:20:03.004+0900 D/RESOURCED( 2996): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 17078, proc_name: org.example.recipes, cg_name: foreground, oom_score_adj: 200
02-25 01:20:03.004+0900 D/RESOURCED( 2996): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 17078
02-25 01:20:03.004+0900 D/DATA_PROVIDER_MASTER( 3067): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 3020 is paused
02-25 01:20:03.004+0900 D/DATA_PROVIDER_MASTER( 3067): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
02-25 01:20:03.004+0900 I/CAPI_WIDGET_APPLICATION( 3098): widget_app.c: __provider_pause_cb(294) > widget obj was paused
02-25 01:20:03.004+0900 I/CAPI_WIDGET_APPLICATION( 3098): widget_app.c: __check_status_for_cgroup(142) > enter background group
02-25 01:20:03.004+0900 W/AUL     ( 3098): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3098, appid: org.tizen.calendar.widget, status: bg
02-25 01:20:03.074+0900 D/RESOURCED( 2996): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 17078, appname = org.example.recipes, pkgname = org.example.recipes
02-25 01:20:03.074+0900 D/RESOURCED( 2996): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 17078, appname = org.example.recipes
02-25 01:20:03.074+0900 D/RESOURCED( 2996): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 17078
02-25 01:20:03.074+0900 D/RESOURCED( 2996): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3098, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
02-25 01:20:03.074+0900 D/RESOURCED( 2996): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3098
02-25 01:20:03.074+0900 D/RESOURCED( 2996): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3098, appname = org.tizen.calendar.widget
02-25 01:20:03.074+0900 D/RESOURCED( 2996): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3098
02-25 01:20:03.074+0900 I/RESOURCED( 2996): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
02-25 01:20:03.074+0900 I/RESOURCED( 2996): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
02-25 01:20:03.274+0900 D/APP_CORE(17078): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2600002 fully_obscured 0
02-25 01:20:03.274+0900 D/APP_CORE(17078): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
02-25 01:20:03.274+0900 D/APP_CORE(17078): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
02-25 01:20:03.274+0900 I/APP_CORE(17078): appcore-efl.c: __do_app(496) > [APP 17078] Event: RESUME State: CREATED
02-25 01:20:03.274+0900 D/LAUNCH  (17078): appcore-efl.c: __do_app(597) > [recipes:Application:resume:start]
02-25 01:20:03.274+0900 D/APP_CORE(17078): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
02-25 01:20:03.274+0900 D/APP_CORE(17078): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
02-25 01:20:03.274+0900 D/APP_CORE(17078): appcore-efl.c: __do_app(607) > [APP 17078] RESUME
02-25 01:20:03.274+0900 I/APP_CORE(17078): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
02-25 01:20:03.274+0900 I/APP_CORE(17078): appcore-efl.c: __do_app(614) > [APP 17078] Initial Launching, call the resume_cb
02-25 01:20:03.274+0900 I/CAPI_APPFW_APPLICATION(17078): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
02-25 01:20:03.274+0900 D/LAUNCH  (17078): appcore-efl.c: __do_app(636) > [recipes:Application:resume:done]
02-25 01:20:03.274+0900 D/LAUNCH  (17078): appcore-efl.c: __do_app(638) > [recipes:Application:Launching:done]
02-25 01:20:03.274+0900 D/APP_CORE(17078): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
02-25 01:20:03.274+0900 E/APP_CORE(17078): appcore-efl.c: __trm_app_info_send_socket(242) > access
02-25 01:20:03.474+0900 D/AUL_PAD (17173): launchpad_loader.c: main(588) > sleeping 1 sec...
02-25 01:20:03.474+0900 D/AUL_PAD (17173): preload.h: __preload_init(52) > max_cmdline_size = 1053
02-25 01:20:03.474+0900 D/AUL_PAD (17173): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b90be760
02-25 01:20:03.474+0900 D/AUL_PAD (17173): preload.h: __preload_init(69) > get pre-initialization function
02-25 01:20:03.474+0900 D/AUL_PAD (17173): preload.h: __preload_init(73) > get shutdown function
02-25 01:20:03.474+0900 D/AUL_PAD (17173): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b90bea40
02-25 01:20:03.484+0900 D/AUL_PAD (17173): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b90c0640
02-25 01:20:03.484+0900 D/AUL_PAD (17173): preload.h: __preload_init(69) > get pre-initialization function
02-25 01:20:03.484+0900 D/AUL_PAD (17173): preload.h: __preload_init(73) > get shutdown function
02-25 01:20:03.484+0900 D/AUL_PAD (17173): preexec.h: __preexec_init(76) > preexec start
02-25 01:20:03.484+0900 D/AUL_PAD (17173): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
02-25 01:20:03.484+0900 D/AUL     (17173): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
02-25 01:20:03.484+0900 D/AUL     (17173): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
02-25 01:20:03.484+0900 D/AUL_PAD ( 3065): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
02-25 01:20:03.484+0900 D/AUL_PAD ( 3065): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
02-25 01:20:03.484+0900 D/AUL_PAD ( 3065): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
02-25 01:20:03.484+0900 D/AUL_PAD ( 3065): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
02-25 01:20:03.484+0900 D/AUL_PAD ( 3065): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
02-25 01:20:03.484+0900 D/AUL_PAD ( 3065): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
02-25 01:20:03.484+0900 D/AUL_PAD ( 3065): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
02-25 01:20:03.484+0900 D/AUL_PAD ( 3065): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
02-25 01:20:03.484+0900 D/AUL_PAD ( 3065): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 17173
02-25 01:20:03.484+0900 D/AUL     (17173): process_pool.c: __connect_to_launchpad(132) > send(17173) : 4
02-25 01:20:03.484+0900 D/AUL     (17173): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
02-25 01:20:03.534+0900 D/AUL_AMD ( 2767): amd_launch.c: __e17_status_handler(2910) > pid(17078) status(0)
02-25 01:20:03.834+0900 D/AUL_PAD (17173): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
02-25 01:20:03.834+0900 D/AUL_PAD (17173): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
02-25 01:20:03.834+0900 D/AUL_PAD (17173): launchpad_loader.c: main(693) > [candidate] ecore handler add
02-25 01:20:03.844+0900 D/AUL_PAD (17173): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
02-25 01:20:04.554+0900 D/AUL_AMD ( 2767): amd_status.c: __app_terminate_timer_cb(442) > pid(16886)
02-25 01:20:04.554+0900 W/AUL_AMD ( 2767): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
02-25 01:20:04.554+0900 D/AUL_AMD ( 2767): amd_status.c: __app_terminate_timer_cb(442) > pid(16886)
02-25 01:20:04.554+0900 W/AUL_AMD ( 2767): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
02-25 01:20:04.724+0900 D/PROCESSMGR( 2951): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002f  register trigger_timer!  pointed_win=0x201e48 
02-25 01:20:04.734+0900 E/EFL     (17078): eo<17078> lib/eo/eo.c:485 _eo_do_internal() Obj (0xa) is an invalid ref.
02-25 01:20:04.734+0900 E/EFL     (17078): eo<17078> lib/eo/eo.c:485 _eo_do_internal() Obj (0xa) is an invalid ref.
02-25 01:20:04.734+0900 E/EFL     (17078): eo<17078> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0xb7712a94 is not pointing to a valid object. Maybe it has already been freed.
02-25 01:20:04.734+0900 E/EFL     (17078): eo<17078> lib/eo/eo.c:485 _eo_do_internal() Obj (0xb7712a94) is an invalid ref.
02-25 01:20:04.734+0900 E/EFL     (17078): eo<17078> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0xb7712a94 is not pointing to a valid object. Maybe it has already been freed.
02-25 01:20:04.734+0900 E/EFL     (17078): eo<17078> lib/eo/eo.c:485 _eo_do_internal() Obj (0xb7712a94) is an invalid ref.
02-25 01:20:04.734+0900 E/EFL     (17078): eo<17078> lib/eo/eo.c:485 _eo_do_internal() Obj (0xa) is an invalid ref.
02-25 01:20:04.734+0900 E/EFL     (17078): eo<17078> lib/eo/eo.c:485 _eo_do_internal() Obj (0xa) is an invalid ref.
02-25 01:20:04.734+0900 E/EFL     (17078): eo<17078> lib/eo/eo.c:485 _eo_do_internal() Obj (0xa) is an invalid ref.
02-25 01:20:04.734+0900 E/EFL     (17078): eo<17078> lib/eo/eo.c:485 _eo_do_internal() Obj (0xa) is an invalid ref.
02-25 01:20:04.734+0900 E/EFL     (17078): eo<17078> lib/eo/eo.c:1471 eo_isa() Obj (0xa) is an invalid ref.
02-25 01:20:04.734+0900 E/EFL     (17078): eo<17078> lib/eo/eo.c:485 _eo_do_internal() Obj (0xa) is an invalid ref.
02-25 01:20:04.734+0900 E/EFL     (17078): eo<17078> lib/eo/eo.c:485 _eo_do_internal() Obj (0xa) is an invalid ref.
02-25 01:20:04.734+0900 E/EFL     (17078): eo<17078> lib/eo/eo.c:1471 eo_isa() Obj (0xa) is an invalid ref.
02-25 01:20:04.734+0900 E/EFL     (17078): eo<17078> lib/eo/eo.c:485 _eo_do_internal() Obj (0xa) is an invalid ref.
02-25 01:20:04.734+0900 E/EFL     (17078): eo<17078> lib/eo/eo.c:1471 eo_isa() Obj (0xa) is an invalid ref.
02-25 01:20:04.734+0900 E/EFL     (17078): eo<17078> lib/eo/eo.c:1699 eo_data_scope_get() Obj (0xa) is an invalid ref.
02-25 01:20:04.734+0900 E/EFL     (17078): eo<17078> lib/eo/eo.c:485 _eo_do_internal() Obj (0xa) is an invalid ref.
02-25 01:20:04.784+0900 W/CRASH_MANAGER(17176): worker.c: worker_job(1204) > 1117078726563148795320
