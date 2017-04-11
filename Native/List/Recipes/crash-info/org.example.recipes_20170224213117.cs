S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160504.2021
Build-Date: 2016.05.04 20:21:45

Crash Information
Process Name: recipes
PID: 8632
Date: 2017-02-24 21:31:17+0900
Executable File Path: /opt/usr/apps/org.example.recipes/bin/recipes
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x00000000, esi = 0x8000a654
ebp = 0xbfa760a8, esp = 0xbfa75fe0
eax = 0x00000000, ebx = 0xb37a23ec
ecx = 0xb37a23ec, edx = 0xb37a0b60
eip = 0xb37a07e3

Memory Information
MemTotal:      123 KB
MemFree:        33 KB
Buffers:         6 KB
Cached:     170244 KB
VmPeak:      80296 KB
VmSize:      80296 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15616 KB
VmRSS:       15616 KB
VmData:      19992 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33424 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 8632 TID = 8632
8632 8653 8748 

Maps Information
b2c69000 b2c73000 r-xp /usr/lib/libfeedback.so.0.1.4
b2c79000 b2c85000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2c86000 b2ca7000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2cac000 b2cad000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2cae000 b2cb3000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2cb4000 b2cb6000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2cb7000 b2cb9000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2cba000 b2cc6000 r-xp /usr/lib/libdrm.so.2.4.0
b2cc7000 b2cca000 r-xp /usr/lib/libdri2.so.0.0.0
b2ccb000 b2cd5000 r-xp /usr/lib/libtbm.so.1.0.0
b2cd6000 b2ceb000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2cec000 b2cfe000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3500000 b3509000 r-xp /usr/lib/libeventsystem.so.0.0.1
b350a000 b351c000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b3523000 b3524000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3525000 b3526000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b3527000 b352a000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b352b000 b352e000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3636000 b363c000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b363d000 b3781000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3791000 b3792000 r-xp /usr/lib/libxshmfence.so.1.0.0
b3793000 b3794000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b3795000 b379e000 r-xp /usr/lib/libefl-extension.so.0.1.0
b379f000 b37a2000 r-xp /opt/usr/apps/org.example.recipes/bin/recipes
b37a3000 b37dc000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b41df000 b41ea000 r-xp /lib/libnss_files-2.20-2014.11.so
b41ec000 b41f7000 r-xp /lib/libnss_nis-2.20-2014.11.so
b41f9000 b4210000 r-xp /lib/libnsl-2.20-2014.11.so
b4214000 b421c000 r-xp /lib/libnss_compat-2.20-2014.11.so
b421e000 b4242000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b4243000 b4244000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b4245000 b4248000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4249000 b4250000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4251000 b425b000 r-xp /usr/lib/libsensord-share.so
b425c000 b4278000 r-xp /usr/lib/libsensor.so.1.2.0
b427a000 b4283000 r-xp /usr/lib/libappcore-common.so.1.1
b4286000 b4288000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b429d000 b429f000 r-xp /usr/lib/libXau.so.6.0.0
b42a0000 b42c2000 r-xp /usr/lib/libxcb.so.1.1.0
b42c4000 b42cd000 r-xp /lib/libcrypt-2.20-2014.11.so
b42f6000 b42f8000 r-xp /usr/lib/libiri.so
b42f9000 b431f000 r-xp /lib/libexpat.so.1.5.2
b4321000 b438c000 r-xp /usr/lib/libssl.so.1.0.0
b4392000 b439e000 r-xp /usr/lib/libethumb.so.1.13.0
b439f000 b43a3000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43a4000 b45f5000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b70000 b5b80000 r-xp /usr/lib/libXi.so.6.1.0
b5b81000 b5b83000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b84000 b5b8a000 r-xp /usr/lib/libXtst.so.6.1.0
b5b8b000 b5b95000 r-xp /usr/lib/libXrender.so.1.3.0
b5b96000 b5b9f000 r-xp /usr/lib/libXrandr.so.2.2.0
b5ba1000 b5ba3000 r-xp /usr/lib/libXinerama.so.1.0.0
b5ba4000 b5ba9000 r-xp /usr/lib/libXfixes.so.3.1.0
b5baa000 b5bbc000 r-xp /usr/lib/libXext.so.6.4.0
b5bbd000 b5bbf000 r-xp /usr/lib/libXdamage.so.1.1.0
b5bc0000 b5bc2000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5bc4000 b5d06000 r-xp /usr/lib/libX11.so.6.3.0
b5d0a000 b5d14000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d15000 b5d2b000 r-xp /usr/lib/libudev.so.1.6.0
b5d2e000 b5d32000 r-xp /lib/libattr.so.1.1.0
b5d33000 b5d62000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d64000 b5d6a000 r-xp /usr/lib/libffi.so.6.0.2
b5d6b000 b5d8e000 r-xp /lib/libz.so.1.2.8
b5d8f000 b5d92000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d93000 b5eef000 r-xp /usr/lib/libxml2.so.2.9.2
b5ef5000 b5fdc000 r-xp /usr/lib/libstdc++.so.6.0.20
b5fe9000 b5fec000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5fed000 b600f000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6010000 b6024000 r-xp /lib/libresolv-2.20-2014.11.so
b6028000 b604c000 r-xp /usr/lib/liblzma.so.5.0.3
b604d000 b604f000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b6051000 b605b000 r-xp /usr/lib/libembryo.so.1.13.0
b605c000 b6085000 r-xp /usr/lib/libpng12.so.0.50.0
b6086000 b60cf000 r-xp /usr/lib/libjpeg.so.8.0.2
b60e0000 b60e7000 r-xp /lib/librt-2.20-2014.11.so
b60e9000 b6108000 r-xp /usr/lib/libector.so.1.13.0
b610b000 b6138000 r-xp /usr/lib/liblua-5.1.so
b6139000 b61c9000 r-xp /usr/lib/libfreetype.so.6.11.3
b61cd000 b620b000 r-xp /usr/lib/libfontconfig.so.1.8.0
b620c000 b6222000 r-xp /usr/lib/libfribidi.so.0.3.1
b6223000 b627c000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b627f000 b62ca000 r-xp /lib/libm-2.20-2014.11.so
b62cc000 b62de000 r-xp /usr/lib/libeio.so.1.13.0
b62df000 b62e2000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b62e3000 b62e9000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b62ea000 b630d000 r-xp /usr/lib/libefreet.so.1.13.0
b6310000 b633b000 r-xp /usr/lib/libeldbus.so.1.13.0
b633c000 b6370000 r-xp /usr/lib/libecore_con.so.1.13.0
b6372000 b637b000 r-xp /usr/lib/libecore_imf.so.1.13.0
b637c000 b6385000 r-xp /usr/lib/libethumb_client.so.1.13.0
b6386000 b6399000 r-xp /usr/lib/libeo.so.1.13.0
b639b000 b63ae000 r-xp /usr/lib/libecore_input.so.1.13.0
b63af000 b63b6000 r-xp /usr/lib/libecore_file.so.1.13.0
b63b7000 b63da000 r-xp /usr/lib/libecore_evas.so.1.13.0
b63db000 b6407000 r-xp /usr/lib/libeet.so.1.13.0
b6410000 b647b000 r-xp /usr/lib/libeina.so.1.13.0
b647e000 b6495000 r-xp /usr/lib/libefl.so.1.13.0
b6497000 b65fe000 r-xp /usr/lib/libicuuc.so.51.1
b660c000 b6818000 r-xp /usr/lib/libicui18n.so.51.1
b6820000 b686f000 r-xp /usr/lib/libecore_x.so.1.13.0
b6871000 b688b000 r-xp /lib/libgcc_s-4.9.so.1
b688d000 b6891000 r-xp /lib/libcap.so.2.21
b6892000 b68d8000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b68d9000 b68e0000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b68e2000 b6934000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6936000 b6ac1000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6ac6000 b6b94000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b97000 b6b9b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b9c000 b6bab000 r-xp /usr/lib/libvconf.so.0.2.45
b6bac000 b6baf000 r-xp /usr/lib/libvasum.so.0.3.1
b6bb0000 b6bb3000 r-xp /usr/lib/libttrace.so.1.1
b6bb5000 b6bb9000 r-xp /usr/lib/libiniparser.so.0
b6bba000 b6bea000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6beb000 b6bf4000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6bf5000 b6c1a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c1b000 b6c2b000 r-xp /usr/lib/libunwind.so.8.0.1
b6c35000 b6de3000 r-xp /lib/libc-2.20-2014.11.so
b6deb000 b6f2e000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f30000 b6f88000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f89000 b6fbd000 r-xp /usr/lib/libsystemd.so.0.4.0
b6fc0000 b7094000 r-xp /usr/lib/libedje.so.1.13.0
b7097000 b70c3000 r-xp /usr/lib/libecore.so.1.13.0
b70d4000 b72fa000 r-xp /usr/lib/libevas.so.1.13.0
b7322000 b733a000 r-xp /lib/libpthread-2.20-2014.11.so
b733e000 b76b8000 r-xp /usr/lib/libelementary.so.1.13.0
b76d8000 b76dc000 r-xp /usr/lib/libsmack.so.1.0.0
b76dd000 b76e6000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76e7000 b76ea000 r-xp /usr/lib/libdlog.so.0.0.0
b76eb000 b76f0000 r-xp /usr/lib/libbundle.so.0.1.22
b76f1000 b76f4000 r-xp /lib/libdl-2.20-2014.11.so
b76f6000 b771b000 r-xp /usr/lib/libaul.so.0.1.0
b771e000 b7720000 r-xp /usr/lib/libappsvc.so.0.1.0
b7721000 b7726000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7727000 b772e000 r-xp /usr/lib/libappcore-efl.so.1.1
b7730000 b7735000 r-xp /usr/lib/libsys-assert.so
b7738000 b7739000 r-xp [vdso]
b7739000 b775b000 r-xp /lib/ld-2.20-2014.11.so
b775d000 b7765000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:8632)
Call Stack Count: 8
 0: create_base_gui + 0x393 (0xb37a07e3) [/opt/usr/apps/org.example.recipes/bin/recipes] + 0x17e3
 1: app_create + 0x2c (0xb37a02fc) [/opt/usr/apps/org.example.recipes/bin/recipes] + 0x12fc
 2: (0xb772361b) [/usr/lib/libcapi-appfw-application.so.0] + 0x261b
 3: appcore_efl_main + 0x327 (0xb772ac27) [/usr/lib/libappcore-efl.so.1] + 0x3c27
 4: ui_app_main + 0x140 (0xb7723c40) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c40
 5: main + 0x2a4 (0xb37a0274) [/opt/usr/apps/org.example.recipes/bin/recipes] + 0x1274
 6: (0xb775f148) [/opt/usr/apps/org.example.recipes/bin/recipes] + 0xb775f148
 7: __libc_start_main + 0xde (0xb6c4ce4e) [/lib/libc.so.6] + 0x17e4e
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
 process
02-24 21:30:48.487+0900 D/AUL_AMD ( 2767): amd_request.c: __request_handler(838) > __request_handler: 0
02-24 21:30:48.487+0900 D/AUL_AMD ( 2767): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.recipes
02-24 21:30:48.487+0900 D/PKGMGR_INFO( 2767): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
02-24 21:30:48.487+0900 D/PKGMGR_INFO( 2767): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
02-24 21:30:48.497+0900 I/AUL     ( 2767): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
02-24 21:30:48.497+0900 D/AUL     ( 2767): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 8610, pid = 8612
02-24 21:30:48.497+0900 D/PKGMGR_INFO( 2767): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
02-24 21:30:48.497+0900 D/PKGMGR_INFO( 2767): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
02-24 21:30:48.497+0900 I/AUL     ( 2767): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
02-24 21:30:48.497+0900 E/AUL_AMD ( 2767): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
02-24 21:30:48.497+0900 W/AUL_AMD ( 2767): amd_launch.c: _start_app(2233) > caller pid : 8612
02-24 21:30:48.497+0900 E/AUL_AMD ( 2767): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
02-24 21:30:48.497+0900 W/AUL_AMD ( 2767): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.recipes) pkgid(org.example.recipes) attribute(200)
02-24 21:30:48.497+0900 D/AUL_AMD ( 2767): amd_launch.c: _start_app(2648) > process_pool: false
02-24 21:30:48.497+0900 D/AUL_AMD ( 2767): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
02-24 21:30:48.497+0900 D/AUL_AMD ( 2767): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.recipes
02-24 21:30:48.497+0900 W/AUL_AMD ( 2767): amd_launch.c: _start_app(2665) > pad pid(-5)
02-24 21:30:48.497+0900 D/AUL_AMD ( 2767): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
02-24 21:30:48.497+0900 D/AUL_AMD ( 2767): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
02-24 21:30:48.497+0900 D/AUL     ( 2767): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
02-24 21:30:48.497+0900 D/RESOURCED( 2996): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.recipes, pkgid = org.example.recipes, flags = 512
02-24 21:30:48.497+0900 D/RESOURCED( 2996): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.recipes, pkgname = org.example.recipes, ref = 1
02-24 21:30:48.497+0900 D/AUL_PAD ( 3065): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
02-24 21:30:48.497+0900 D/AUL_PAD ( 3065): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
02-24 21:30:48.497+0900 D/AUL_PAD ( 3065): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
02-24 21:30:48.497+0900 D/AUL_PAD ( 3065): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
02-24 21:30:48.497+0900 D/AUL_PAD ( 3065): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
02-24 21:30:48.497+0900 D/AUL_PAD ( 3065): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
02-24 21:30:48.497+0900 D/AUL_PAD ( 3065): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
02-24 21:30:48.497+0900 D/AUL_PAD ( 3065): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
02-24 21:30:48.497+0900 D/AUL_PAD ( 3065): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.recipes
02-24 21:30:48.497+0900 D/AUL_PAD ( 3065): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.recipes/bin/recipes
02-24 21:30:48.497+0900 D/AUL_PAD ( 3065): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
02-24 21:30:48.497+0900 D/AUL_PAD ( 3065): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
02-24 21:30:48.497+0900 D/AUL_PAD ( 3065): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
02-24 21:30:48.497+0900 D/AUL_PAD ( 3065): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
02-24 21:30:48.497+0900 W/AUL_PAD ( 3065): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
02-24 21:30:48.497+0900 E/RESOURCED( 2996): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
02-24 21:30:48.497+0900 D/AUL     ( 3065): process_pool.c: __send_pkt_raw_data(219) > send(11) : 620 / 620
02-24 21:30:48.497+0900 D/AUL_PAD ( 3065): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 8430, bin path: /opt/usr/apps/org.example.recipes/bin/recipes
02-24 21:30:48.497+0900 W/AUL_PAD ( 3065): launchpad.c: __send_result_to_caller(265) > Check app launching
02-24 21:30:48.497+0900 D/AUL_PAD ( 3065): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
02-24 21:30:48.497+0900 D/AUL_PAD ( 8430): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
02-24 21:30:48.497+0900 D/AUL_PAD ( 8430): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 620, pkt->len: 612
02-24 21:30:48.497+0900 D/AUL_PAD ( 8430): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.recipes, launchpad type: 0
02-24 21:30:48.497+0900 D/AUL_PAD ( 8430): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
02-24 21:30:48.497+0900 D/AUL_PAD ( 8430): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.recipes
02-24 21:30:48.497+0900 D/AUL_PAD ( 8430): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.recipes
02-24 21:30:48.497+0900 D/AUL     ( 8430): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (8431) is sent.
02-24 21:30:48.497+0900 D/AUL     ( 8430): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 8431, signo: 10
02-24 21:30:48.507+0900 D/AUL     ( 8430): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
02-24 21:30:48.507+0900 D/AUL_PAD ( 8430): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.recipes / pkg_type : rpm / app_path : /opt/usr/apps/org.example.recipes/bin/recipes
02-24 21:30:48.507+0900 D/AUL_PAD ( 8430): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.recipes/bin/recipes##
02-24 21:30:48.507+0900 D/AUL_PAD ( 8430): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
02-24 21:30:48.507+0900 D/AUL_PAD ( 8430): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
02-24 21:30:48.507+0900 D/AUL_PAD ( 8430): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0ODc5Mzk0NDgvNDk4NTY5AA==##
02-24 21:30:48.507+0900 D/AUL_PAD ( 8430): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
02-24 21:30:48.507+0900 D/AUL_PAD ( 8430): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAA4NjEyAA==##
02-24 21:30:48.507+0900 D/AUL_PAD ( 8430): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
02-24 21:30:48.507+0900 D/AUL_PAD ( 8430): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
02-24 21:30:48.507+0900 D/AUL_PAD ( 8430): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.recipes/bin/recipes, real app argc: 8
02-24 21:30:48.507+0900 D/AUL_PAD ( 8430): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
02-24 21:30:48.507+0900 D/AUL_PAD ( 8430): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.recipes/bin/recipes)
02-24 21:30:48.507+0900 I/CAPI_APPFW_APPLICATION( 8430): app_main.c: ui_app_main(788) > app_efl_main
02-24 21:30:48.507+0900 D/LAUNCH  ( 8430): appcore-efl.c: appcore_efl_main(1692) > [recipes:Application:main:done]
02-24 21:30:48.507+0900 D/APP_CORE( 8430): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
02-24 21:30:48.507+0900 D/APP_CORE( 8430): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.recipes/res/locale
02-24 21:30:48.507+0900 D/APP_CORE( 8430): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
02-24 21:30:48.507+0900 D/APP_CORE( 8430): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
02-24 21:30:48.517+0900 D/AUL     ( 8430): app_sock.c: __create_server_sock(156) > pg path - already exists
02-24 21:30:48.517+0900 D/APP_CORE( 8430): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb42b2520
02-24 21:30:48.517+0900 D/LAUNCH  ( 8430): appcore-efl.c: __before_loop(1136) > [recipes:Platform:appcore_init:done]
02-24 21:30:48.517+0900 I/CAPI_APPFW_APPLICATION( 8430): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
02-24 21:30:48.597+0900 W/CRASH_MANAGER( 8617): worker.c: worker_job(1204) > 11084307265631487939448
02-24 21:30:48.597+0900 E/AUL_PAD ( 3065): launchpad.c: __send_result_to_caller(280) > error founded when being launched with 8430
02-24 21:30:48.597+0900 E/AUL_PAD ( 3065): launchpad.c: __send_result_to_caller(282) > The app process might be terminated while we are wating 8430
02-24 21:30:48.597+0900 E/AUL_PAD ( 3065): launchpad.c: __send_result_to_caller(312) > process launched, but cmdline not changed
02-24 21:30:48.597+0900 W/AUL     ( 2767): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 8430, appid: org.example.recipes
02-24 21:30:48.597+0900 D/AUL     ( 2767): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
02-24 21:30:48.597+0900 E/AUL     ( 2767): simple_util.c: __trm_app_info_send_socket(330) > access
02-24 21:30:48.597+0900 D/AUL_AMD ( 2767): amd_launch.c: _start_app(2700) > add app group info
02-24 21:30:48.597+0900 E/AUL     ( 2767): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
02-24 21:30:48.597+0900 D/AUL_AMD ( 2767): amd_status.c: _status_add_app_info_list(427) > pid(8430) appid(org.example.recipes) pkgid(org.example.recipes) comp(uiapp)
02-24 21:30:48.597+0900 D/RESOURCED( 2996): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.recipes, 8430
02-24 21:30:48.597+0900 D/RESOURCED( 2996): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.recipes with pkgname
02-24 21:30:48.597+0900 E/RESOURCED( 2996): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.recipes
02-24 21:30:48.597+0900 D/RESOURCED( 2996): proc-main.c: resourced_proc_status_change(888) > available memory = 325
02-24 21:30:48.997+0900 E/PKGMGR_SERVER( 8557): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
02-24 21:30:48.997+0900 E/PKGMGR_SERVER( 8557): pkgmgr-server.c: main(2265) > package manager server terminated.
02-24 21:30:49.367+0900 E/VCONF   ( 8617): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
02-24 21:30:49.367+0900 E/VCONF   ( 8617): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
02-24 21:30:49.367+0900 E/VCONF   ( 8617): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
02-24 21:30:49.367+0900 E/VCONF   ( 8617): vconf.c: vconf_get_str(2891) > vconf_get_str(8617) : db/menu_widget/language error
02-24 21:30:49.367+0900 E/PKGMGR_INFO( 8617): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
02-24 21:30:49.367+0900 D/PKGMGR_INFO( 8617): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3502) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.recipes/bin/recipes' and package_app_info.app_disable IN ('false','False')
02-24 21:30:49.367+0900 D/PKGMGR_INFO( 8617): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3508) > [SECURE_LOG] query = select DISTINCT package_app_info.app_id, package_app_info.app_component, package_app_info.app_installed_storage from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale='No Locale' LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.recipes/bin/recipes' and package_app_info.app_disable IN ('false','False')
02-24 21:30:49.377+0900 E/VCONF   ( 8617): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
02-24 21:30:49.377+0900 E/VCONF   ( 8617): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
02-24 21:30:49.377+0900 E/VCONF   ( 8617): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
02-24 21:30:49.377+0900 E/VCONF   ( 8617): vconf.c: vconf_get_str(2891) > vconf_get_str(8617) : db/menu_widget/language error
02-24 21:30:49.377+0900 E/PKGMGR_INFO( 8617): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
02-24 21:30:49.377+0900 D/PKGMGR_INFO( 8617): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.recipes/bin/recipes' and package_app_info.app_disable IN ('false','False')
02-24 21:30:49.377+0900 D/PKGMGR_INFO( 8617): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'No Locale') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.recipes/bin/recipes' and package_app_info.app_disable IN ('false','False')
02-24 21:30:49.377+0900 E/VCONF   ( 8617): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
02-24 21:30:49.377+0900 E/VCONF   ( 8617): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
02-24 21:30:49.377+0900 E/VCONF   ( 8617): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
02-24 21:30:49.377+0900 E/VCONF   ( 8617): vconf.c: vconf_get_str(2891) > vconf_get_str(8617) : db/menu_widget/language error
02-24 21:30:49.377+0900 E/PKGMGR_INFO( 8617): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
02-24 21:30:49.377+0900 D/PKGMGR_INFO( 8617): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.recipes/bin/recipes' and package_app_info.app_disable IN ('false','False')
02-24 21:30:49.377+0900 D/PKGMGR_INFO( 8617): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'No Locale') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.recipes/bin/recipes' and package_app_info.app_disable IN ('false','False')
02-24 21:30:49.377+0900 E/VCONF   ( 8617): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
02-24 21:30:49.377+0900 E/VCONF   ( 8617): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
02-24 21:30:49.377+0900 E/VCONF   ( 8617): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
02-24 21:30:49.377+0900 E/VCONF   ( 8617): vconf.c: vconf_get_str(2891) > vconf_get_str(8617) : db/menu_widget/language error
02-24 21:30:49.377+0900 E/PKGMGR_INFO( 8617): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
02-24 21:30:49.527+0900 D/LAUNCH  ( 8629): appcore-efl.c: appcore_efl_main(1692) > [crash-popup:Application:main:done]
02-24 21:30:49.527+0900 D/PKGMGR_INFO( 8629): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/apps/org.tizen.crash-popup/bin/crash-popup' and package_app_info.app_disable IN ('false','False')
02-24 21:30:49.527+0900 D/PKGMGR_INFO( 8629): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/apps/org.tizen.crash-popup/bin/crash-popup' and package_app_info.app_disable IN ('false','False')
02-24 21:30:49.527+0900 D/AUL     ( 8629): pkginfo.c: aul_app_get_appid_bypid(241) > [SECURE_LOG] appid for 8629 is org.tizen.crash-popup
02-24 21:30:49.597+0900 D/AUL_PAD ( 3065): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
02-24 21:30:49.597+0900 D/AUL_PAD ( 8632): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
02-24 21:30:49.607+0900 D/AUL_AMD ( 2767): amd_launch.c: __grab_timeout_handler(1445) > pid(8430) ecore_x_pointer_ungrab
02-24 21:30:49.607+0900 D/APP_CORE( 8629): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
02-24 21:30:49.607+0900 D/AUL_AMD ( 2767): amd_key.c: _key_ungrab(265) > _key_ungrab, win : 600002
02-24 21:30:49.607+0900 D/APP_CORE( 8629): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /usr/apps/org.tizen.crash-popup/res/locale
02-24 21:30:49.607+0900 D/APP_CORE( 8629): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
02-24 21:30:49.607+0900 W/AUL_AMD ( 2767): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
02-24 21:30:49.607+0900 W/AUL_AMD ( 2767): amd_launch.c: __grab_timeout_handler(1447) > back key ungrab error
02-24 21:30:49.607+0900 D/AUL_PAD ( 3065): sigchild.h: __send_app_launch_signal(131) > send launch signal done
02-24 21:30:49.607+0900 D/AUL_PAD ( 3065): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
02-24 21:30:49.607+0900 D/AUL_PAD ( 3065): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
02-24 21:30:49.607+0900 D/AUL_PAD ( 3065): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
02-24 21:30:49.607+0900 D/AUL_PAD ( 3065): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
02-24 21:30:49.607+0900 D/AUL_PAD ( 3065): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
02-24 21:30:49.607+0900 D/AUL_PAD ( 3065): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
02-24 21:30:49.607+0900 D/AUL_PAD ( 3065): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
02-24 21:30:49.607+0900 I/AUL_PAD ( 3065): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 8430 pgid = 8430
02-24 21:30:49.607+0900 I/AUL_PAD ( 3065): sigchild.h: __sigchild_action(142) > dead_pid(8430)
02-24 21:30:49.617+0900 E/RESOURCED( 2996): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.562
02-24 21:30:49.627+0900 D/AUL_PAD ( 3065): sigchild.h: __send_app_dead_signal(90) > send dead signal done
02-24 21:30:49.627+0900 I/AUL_PAD ( 3065): sigchild.h: __sigchild_action(148) > __send_app_dead_signal(0)
02-24 21:30:49.627+0900 I/AUL_PAD ( 3065): sigchild.h: __launchpad_process_sigchld(169) > after __sigchild_action
02-24 21:30:49.627+0900 E/AUL_PAD ( 3065): launchpad.c: main(688) > error reading sigchld info
02-24 21:30:49.637+0900 I/ESD     ( 3064): esd_main.c: __esd_app_dead_handler(1771) > pid: 8430
02-24 21:30:49.637+0900 W/AUL_AMD ( 2767): amd_main.c: __app_dead_handler(324) > __app_dead_handler, pid: 8430
02-24 21:30:49.637+0900 W/AUL_AMD ( 2767): amd_main.c: __app_dead_handler(334) > app_group_leader_app, pid: 8430
02-24 21:30:49.637+0900 D/AUL_AMD ( 2767): amd_key.c: _unregister_key_event(179) > ===key stack===
02-24 21:30:49.637+0900 E/AUL_AMD ( 2767): amd_launch.c: _revoke_temporary_permission(2129) > list or callee_label was null
02-24 21:30:49.637+0900 D/AUL_AMD ( 2767): amd_status.c: __remove_pkg_info(266) > ~STATUS_SERVICE : appid(org.example.recipes)
02-24 21:30:49.637+0900 D/AUL     ( 2767): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
02-24 21:30:49.637+0900 E/AUL     ( 2767): simple_util.c: __trm_app_info_send_socket(330) > access
02-24 21:30:49.637+0900 D/STARTER ( 2995): starter.c: _check_dead_signal(181) > [_check_dead_signal:181] Process 8430 is termianted
02-24 21:30:49.637+0900 D/STARTER ( 2995): starter.c: _check_dead_signal(202) > [_check_dead_signal:202] Unknown process, ignore it
02-24 21:30:49.637+0900 E/RESOURCED( 2996): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.564
02-24 21:30:49.637+0900 D/APP_CORE( 8629): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
02-24 21:30:49.637+0900 D/APP_CORE( 8629): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb7793520
02-24 21:30:49.637+0900 D/LAUNCH  ( 8629): appcore-efl.c: __before_loop(1136) > [crash-popup:Platform:appcore_init:done]
02-24 21:30:49.637+0900 D/RESOURCED( 2996): proc-monitor.c: proc_dbus_aul_terminated(1080) > received terminated process : pid 8430
02-24 21:30:49.637+0900 D/RESOURCED( 2996): appinfo-list.c: resourced_appinfo_put(132) > appid org.example.recipes, pkgname = org.example.recipes, ref = 0
02-24 21:30:49.667+0900 D/APP_CORE( 8629): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
02-24 21:30:49.677+0900 D/LAUNCH  ( 8629): appcore-efl.c: __before_loop(1154) > [crash-popup:Application:create:done]
02-24 21:30:49.677+0900 D/APP_CORE( 8629): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
02-24 21:30:49.967+0900 E/RESOURCED( 2996): heart-abnormal.c: heart_abnormal_process_crashed(77) > Failed: dbus_message_get_args()
02-24 21:30:50.147+0900 D/AUL_AMD ( 2767): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.recipes /opt/usr/apps/org.example.recipes/bin/recipes
02-24 21:30:50.147+0900 D/RUA     ( 2767): rua.c: rua_add_history(179) > rua_add_history start
02-24 21:30:50.157+0900 D/RUA     ( 2767): rua.c: rua_add_history(247) > rua_add_history ok
02-24 21:30:50.647+0900 D/AUL_PAD ( 8632): launchpad_loader.c: main(588) > sleeping 1 sec...
02-24 21:30:50.647+0900 D/AUL_PAD ( 8632): preload.h: __preload_init(52) > max_cmdline_size = 1053
02-24 21:30:50.657+0900 D/AUL_PAD ( 8632): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b8da7760
02-24 21:30:50.657+0900 D/AUL_PAD ( 8632): preload.h: __preload_init(69) > get pre-initialization function
02-24 21:30:50.657+0900 D/AUL_PAD ( 8632): preload.h: __preload_init(73) > get shutdown function
02-24 21:30:50.657+0900 D/AUL_PAD ( 8632): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b8da7a40
02-24 21:30:50.667+0900 D/AUL_PAD ( 8632): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b8da9640
02-24 21:30:50.667+0900 D/AUL_PAD ( 8632): preload.h: __preload_init(69) > get pre-initialization function
02-24 21:30:50.667+0900 D/AUL_PAD ( 8632): preload.h: __preload_init(73) > get shutdown function
02-24 21:30:50.667+0900 D/AUL_PAD ( 8632): preexec.h: __preexec_init(76) > preexec start
02-24 21:30:50.667+0900 D/AUL_PAD ( 8632): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
02-24 21:30:50.667+0900 D/AUL     ( 8632): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
02-24 21:30:50.667+0900 D/AUL     ( 8632): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
02-24 21:30:50.667+0900 D/AUL     ( 8632): process_pool.c: __connect_to_launchpad(132) > send(8632) : 4
02-24 21:30:50.667+0900 D/AUL     ( 8632): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
02-24 21:30:50.667+0900 D/AUL_PAD ( 3065): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
02-24 21:30:50.667+0900 D/AUL_PAD ( 3065): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
02-24 21:30:50.667+0900 D/AUL_PAD ( 3065): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
02-24 21:30:50.667+0900 D/AUL_PAD ( 3065): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
02-24 21:30:50.667+0900 D/AUL_PAD ( 3065): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
02-24 21:30:50.667+0900 D/AUL_PAD ( 3065): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
02-24 21:30:50.667+0900 D/AUL_PAD ( 3065): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
02-24 21:30:50.667+0900 D/AUL_PAD ( 3065): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
02-24 21:30:50.667+0900 D/AUL_PAD ( 3065): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 8632
02-24 21:30:50.737+0900 D/AUL_PAD ( 8632): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
02-24 21:30:50.747+0900 D/AUL_PAD ( 8632): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
02-24 21:30:50.747+0900 D/AUL_PAD ( 8632): launchpad_loader.c: main(693) > [candidate] ecore handler add
02-24 21:30:50.747+0900 D/AUL_PAD ( 8632): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
02-24 21:30:52.687+0900 E/EFL     ( 8629): eldbus<8629> lib/eldbus/eldbus_core.c:1005 _connection_get() Error connecting to bus of type 1. error name: org.freedesktop.DBus.Error.NoServer error message: Failed to connect to socket /tmp/dbus-RHpNxwz5DT: Connection refused
02-24 21:30:52.687+0900 E/EFL     ( 8629): <8629> lib/eldbus/eldbus_core.c:1068 eldbus_connection_get() safety check failed: conn == NULL
02-24 21:30:52.687+0900 E/EFL     ( 8629): elementary<8629> elm_atspi_bridge.c:4750 _elm_atspi_bridge_eo_base_constructor() Unable to connect to Session Bus
02-24 21:30:52.687+0900 D/APP_CORE( 8629): appcore.c: __aul_handler(587) > [APP 8629]     AUL event: AUL_START
02-24 21:30:52.687+0900 I/APP_CORE( 8629): appcore-efl.c: __do_app(496) > [APP 8629] Event: RESET State: CREATED
02-24 21:30:52.687+0900 D/APP_CORE( 8629): appcore-efl.c: __do_app(527) > [APP 8629] RESET
02-24 21:30:52.687+0900 D/LAUNCH  ( 8629): appcore-efl.c: __do_app(529) > [crash-popup:Application:reset:start]
02-24 21:30:52.687+0900 D/APP_CORE( 8629): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
02-24 21:30:52.687+0900 D/APP_CORE( 8629): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
02-24 21:30:52.687+0900 E/SYSPOPUP( 8629): syspopup_core.c: _syspopup_get_name_from_bundle(228) > syspopup permission error
02-24 21:30:52.687+0900 E/SYSPOPUP( 8629): syspopup_core.c: _syspopup_get_name_from_bundle(228) > syspopup permission error
02-24 21:30:52.687+0900 E/SYSPOPUP( 8629): syspopup_efl.c: syspopup_create(95) > popup_name or handler is NULL
02-24 21:30:52.687+0900 D/LAUNCH  ( 8629): appcore-efl.c: __do_app(544) > [crash-popup:Application:reset:done]
02-24 21:30:52.687+0900 D/APP_CORE( 8629): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
02-24 21:30:52.767+0900 E/CAPI_NETWORK_WIFI( 3000): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
02-24 21:30:52.767+0900 E/INDICATOR( 3000): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
02-24 21:30:52.767+0900 E/INDICATOR( 3000): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
02-24 21:30:52.767+0900 E/INDICATOR( 3000): 
02-24 21:30:52.807+0900 D/AUL     ( 8629): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
02-24 21:30:52.807+0900 D/AUL_AMD ( 2767): amd_request.c: __request_handler(838) > __request_handler: 22
02-24 21:30:52.807+0900 W/AUL_AMD ( 2767): amd_request.c: __request_handler(1056) > app status : 5
02-24 21:30:52.807+0900 D/AUL_AMD ( 2767): amd_status.c: _status_update_app_info_list(456) > pid(8629) status(5)
02-24 21:30:52.807+0900 D/APP_CORE( 8629): appcore.c: _appcore_fini_suspend_dbus_handler(944) > [__SUSPEND__] suspend signal finalized
02-24 21:30:52.807+0900 E/EFL     ( 8629): eo<8629> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x8000542b is not pointing to a valid object. Maybe it has already been freed.
02-24 21:30:52.807+0900 E/EFL     ( 8629): eo<8629> lib/eo/eo.c:485 _eo_do_internal() Obj (0x8000542b) is an invalid ref.
02-24 21:30:53.607+0900 D/AUL_AMD ( 2767): amd_status.c: _status_update_app_info_list(456) > pid(8430) status(4)
02-24 21:31:00.377+0900 D/INDICATOR( 3000): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
02-24 21:31:00.377+0900 D/INDICATOR( 3000): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
02-24 21:31:00.377+0900 D/INDICATOR( 3000): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
02-24 21:31:00.377+0900 D/INDICATOR( 3000): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 9:31 4 h"
02-24 21:31:00.377+0900 D/INDICATOR( 3000): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 9:31"
02-24 21:31:00.377+0900 D/INDICATOR( 3000): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 9&#x2236;31"
02-24 21:31:00.377+0900 D/INDICATOR( 3000): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2146818282 Time: <font_size=33>9&#x2236;31</font_size> <font_size=32>PM</font_size></font>
02-24 21:31:12.787+0900 E/CAPI_NETWORK_WIFI( 3000): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
02-24 21:31:12.787+0900 E/INDICATOR( 3000): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
02-24 21:31:12.787+0900 E/INDICATOR( 3000): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
02-24 21:31:12.787+0900 E/INDICATOR( 3000): 
02-24 21:31:15.547+0900 E/PKGMGR_SERVER( 8692): pkgmgr-server.c: main(2209) > package manager server start
02-24 21:31:15.547+0900 D/PKGMGR  ( 8692): comm_pkg_mgr_server.c: pkg_mgr_server_gdbus_init(405) > initialize_gdbus Enter
02-24 21:31:15.547+0900 D/PKGMGR  ( 8692): comm_pkg_mgr_server.c: pkg_mgr_server_gdbus_init(423) > initialize_gdbus Exit
02-24 21:31:15.557+0900 D/PKGMGR  ( 8692): comm_pkg_mgr_server.c: on_bus_acquired(376) > on_bus_acquired
02-24 21:31:15.557+0900 D/PKGMGR  ( 8692): comm_pkg_mgr_server.c: on_bus_acquired(400) > on_bus_acquired done
02-24 21:31:15.557+0900 D/PKGMGR  ( 8692): comm_pkg_mgr_server.c: pkgmgr_request(145) > Called
02-24 21:31:15.557+0900 D/PKGMGR  ( 8692): comm_pkg_mgr_server.c: pkgmgr_request(164) > sender_name: :1.568
02-24 21:31:15.567+0900 D/PKGMGR  ( 8692): comm_pkg_mgr_server.c: pkg_mgr_get_sender_pid(79) > zone pid : 8690
02-24 21:31:15.567+0900 D/PKGMGR  ( 8692): comm_pkg_mgr_server.c: pkgmgr_request(166) > sender_pid: 8690
02-24 21:31:15.567+0900 D/PKGMGR  ( 8692): comm_pkg_mgr_server.c: pkgmgr_request(175) > [SECURE_LOG] Call request callback(obj, org.example.recipes_-404561480, 14, tpk, org.example.recipes, , host)
02-24 21:31:15.567+0900 D/PKGMGR_SERVER( 8692): pkgmgr-server.c: req_cb(625) > [SECURE_LOG] >> in callback >> Got request: [org.example.recipes_-404561480] [14] [tpk] [org.example.recipes] [] [] [host]
02-24 21:31:15.567+0900 D/PKGMGR_SERVER( 8692): pkgmgr-server.c: req_cb(646) > req_type=(14)  backend_flag=(0) zone(host)
02-24 21:31:15.567+0900 D/PKGMGR_SERVER( 8692): pkgmgr-server.c: queue_job(1880) > target zone(host, host)
02-24 21:31:15.567+0900 D/PKGMGR_SERVER( 8695): pkgmgr-server.c: queue_job(1884) > child forked [0] for request type [14]
02-24 21:31:15.567+0900 D/PKGMGR_SERVER( 8695): pkgmgr-server.c: queue_job(2057) > kill/check request
02-24 21:31:15.567+0900 D/PKGMGR_SERVER( 8692): pkgmgr-server.c: queue_job(1884) > child forked [8695] for request type [14]
02-24 21:31:15.567+0900 D/PKGMGR_SERVER( 8692): pkgmgr-server.c: queue_job(2126) > parent exit
02-24 21:31:15.567+0900 D/PKGMGR  ( 8690): pkgmgr.c: __check_sync_process(868) > info_file file is generated, result = 0
02-24 21:31:15.567+0900 D/PKGMGR  ( 8690): . 
02-24 21:31:15.567+0900 E/PKGMGR  ( 8690): pkgmgr.c: __check_sync_process(884) > file is can not remove[/tmp/org.example.recipes, -1]
02-24 21:31:15.577+0900 D/PKGMGR_SERVER( 8695): pkgmgr-server.c: __pkgcmd_app_cb(1458) > sub_cmd(kill), zone_name(host)
02-24 21:31:15.577+0900 D/AUL     ( 8695): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(14)
02-24 21:31:15.577+0900 D/AUL_AMD ( 2767): amd_request.c: __request_handler(838) > __request_handler: 14
02-24 21:31:15.587+0900 D/AUL_AMD ( 2767): amd_request.c: __request_handler(1028) > [SECURE_LOG] APP_IS_RUNNING : org.example.recipes : -1
02-24 21:31:15.587+0900 W/AUL_AMD ( 2767): amd_request.c: __send_result_to_client(150) > __send_result_to_client, pid: -1
02-24 21:31:15.587+0900 D/PKGMGR_SERVER( 8695): pkgmgr-server.c: __make_pid_info_file(1384) > cano_path(tmp/org.example.recipes)
02-24 21:31:15.587+0900 D/PKGMGR_SERVER( 8695): pkgmgr-server.c: __make_pid_info_file(1403) > security_server_label_access(tmp/org.example.recipes, *) is ok.
02-24 21:31:15.587+0900 D/PKGMGR_SERVER( 8692): pkgmgr-server.c: sighandler(387) > child exit [8695]
02-24 21:31:15.587+0900 E/PKGMGR_SERVER( 8692): pkgmgr-server.c: sighandler(402) > child NORMAL exit [8695]
02-24 21:31:17.866+0900 D/AUL_AMD ( 2767): amd_request.c: __request_handler(838) > __request_handler: 0
02-24 21:31:17.866+0900 D/AUL_AMD ( 2767): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.recipes
02-24 21:31:17.866+0900 D/PKGMGR_INFO( 2767): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
02-24 21:31:17.866+0900 D/PKGMGR_INFO( 2767): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
02-24 21:31:17.866+0900 I/AUL     ( 2767): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
02-24 21:31:17.866+0900 D/AUL     ( 2767): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 8742, pid = 8744
02-24 21:31:17.866+0900 D/PKGMGR_INFO( 2767): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
02-24 21:31:17.866+0900 D/PKGMGR_INFO( 2767): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
02-24 21:31:17.866+0900 I/AUL     ( 2767): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
02-24 21:31:17.866+0900 E/AUL_AMD ( 2767): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
02-24 21:31:17.866+0900 W/AUL_AMD ( 2767): amd_launch.c: _start_app(2233) > caller pid : 8744
02-24 21:31:17.866+0900 E/AUL_AMD ( 2767): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
02-24 21:31:17.876+0900 W/AUL_AMD ( 2767): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.recipes) pkgid(org.example.recipes) attribute(200)
02-24 21:31:17.876+0900 D/AUL_AMD ( 2767): amd_launch.c: _start_app(2648) > process_pool: false
02-24 21:31:17.876+0900 D/AUL_AMD ( 2767): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
02-24 21:31:17.876+0900 D/AUL_AMD ( 2767): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.recipes
02-24 21:31:17.876+0900 W/AUL_AMD ( 2767): amd_launch.c: _start_app(2665) > pad pid(-5)
02-24 21:31:17.876+0900 D/AUL_AMD ( 2767): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
02-24 21:31:17.876+0900 D/AUL_AMD ( 2767): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
02-24 21:31:17.876+0900 D/AUL     ( 2767): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
02-24 21:31:17.876+0900 D/AUL_PAD ( 3065): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
02-24 21:31:17.876+0900 D/AUL_PAD ( 3065): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
02-24 21:31:17.876+0900 D/AUL_PAD ( 3065): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
02-24 21:31:17.876+0900 D/AUL_PAD ( 3065): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
02-24 21:31:17.876+0900 D/AUL_PAD ( 3065): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
02-24 21:31:17.876+0900 D/AUL_PAD ( 3065): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
02-24 21:31:17.876+0900 D/AUL_PAD ( 3065): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
02-24 21:31:17.876+0900 D/AUL_PAD ( 3065): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
02-24 21:31:17.876+0900 D/AUL_PAD ( 3065): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.recipes
02-24 21:31:17.876+0900 D/AUL_PAD ( 3065): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.recipes/bin/recipes
02-24 21:31:17.876+0900 D/AUL_PAD ( 3065): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
02-24 21:31:17.876+0900 D/AUL_PAD ( 3065): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
02-24 21:31:17.876+0900 D/AUL_PAD ( 3065): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
02-24 21:31:17.876+0900 D/AUL_PAD ( 3065): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
02-24 21:31:17.876+0900 W/AUL_PAD ( 3065): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
02-24 21:31:17.876+0900 D/AUL     ( 3065): process_pool.c: __send_pkt_raw_data(219) > send(11) : 620 / 620
02-24 21:31:17.876+0900 D/AUL_PAD ( 3065): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 8632, bin path: /opt/usr/apps/org.example.recipes/bin/recipes
02-24 21:31:17.876+0900 W/AUL_PAD ( 3065): launchpad.c: __send_result_to_caller(265) > Check app launching
02-24 21:31:17.876+0900 D/AUL_PAD ( 3065): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
02-24 21:31:17.876+0900 D/RESOURCED( 2996): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.recipes, pkgid = org.example.recipes, flags = 512
02-24 21:31:17.876+0900 D/RESOURCED( 2996): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.recipes, pkgname = org.example.recipes, ref = 1
02-24 21:31:17.876+0900 E/RESOURCED( 2996): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
02-24 21:31:17.876+0900 D/AUL_PAD ( 8632): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
02-24 21:31:17.876+0900 D/AUL_PAD ( 8632): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 620, pkt->len: 612
02-24 21:31:17.876+0900 D/AUL_PAD ( 8632): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.recipes, launchpad type: 0
02-24 21:31:17.876+0900 D/AUL_PAD ( 8632): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
02-24 21:31:17.876+0900 D/AUL_PAD ( 8632): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.recipes
02-24 21:31:17.876+0900 D/AUL_PAD ( 8632): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.recipes
02-24 21:31:17.876+0900 D/AUL     ( 8632): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (8653) is sent.
02-24 21:31:17.876+0900 D/AUL     ( 8632): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 8653, signo: 10
02-24 21:31:17.876+0900 D/AUL     ( 8632): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
02-24 21:31:17.876+0900 D/AUL_PAD ( 8632): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.recipes / pkg_type : rpm / app_path : /opt/usr/apps/org.example.recipes/bin/recipes
02-24 21:31:17.876+0900 D/AUL_PAD ( 8632): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.recipes/bin/recipes##
02-24 21:31:17.876+0900 D/AUL_PAD ( 8632): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
02-24 21:31:17.876+0900 D/AUL_PAD ( 8632): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
02-24 21:31:17.876+0900 D/AUL_PAD ( 8632): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0ODc5Mzk0NzcvODc0NjU4AA==##
02-24 21:31:17.876+0900 D/AUL_PAD ( 8632): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
02-24 21:31:17.876+0900 D/AUL_PAD ( 8632): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAA4NzQ0AA==##
02-24 21:31:17.876+0900 D/AUL_PAD ( 8632): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
02-24 21:31:17.876+0900 D/AUL_PAD ( 8632): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
02-24 21:31:17.876+0900 D/AUL_PAD ( 8632): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.recipes/bin/recipes, real app argc: 8
02-24 21:31:17.876+0900 D/AUL_PAD ( 8632): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
02-24 21:31:17.876+0900 D/AUL_PAD ( 8632): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.recipes/bin/recipes)
02-24 21:31:17.876+0900 I/CAPI_APPFW_APPLICATION( 8632): app_main.c: ui_app_main(788) > app_efl_main
02-24 21:31:17.876+0900 D/LAUNCH  ( 8632): appcore-efl.c: appcore_efl_main(1692) > [recipes:Application:main:done]
02-24 21:31:17.876+0900 D/APP_CORE( 8632): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
02-24 21:31:17.876+0900 D/APP_CORE( 8632): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.recipes/res/locale
02-24 21:31:17.876+0900 D/APP_CORE( 8632): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
02-24 21:31:17.886+0900 D/APP_CORE( 8632): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
02-24 21:31:17.886+0900 D/AUL     ( 8632): app_sock.c: __create_server_sock(156) > pg path - already exists
02-24 21:31:17.886+0900 D/APP_CORE( 8632): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb4283520
02-24 21:31:17.886+0900 D/LAUNCH  ( 8632): appcore-efl.c: __before_loop(1136) > [recipes:Platform:appcore_init:done]
02-24 21:31:17.886+0900 I/CAPI_APPFW_APPLICATION( 8632): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
02-24 21:31:17.926+0900 W/CRASH_MANAGER( 8617): worker.c: worker_job(1204) > 1108632726563148793947
