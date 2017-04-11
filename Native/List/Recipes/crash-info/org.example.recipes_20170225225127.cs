S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160504.2021
Build-Date: 2016.05.04 20:21:45

Crash Information
Process Name: recipes
PID: 17854
Date: 2017-02-25 22:51:27+0900
Executable File Path: /opt/usr/apps/org.example.recipes/bin/recipes
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xff

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xfbad8001, esi = 0xb77c6f84
ebp = 0xbff84ba8, esp = 0xbff84668
eax = 0x000000ff, ebx = 0xb6e4a000
ecx = 0x00002525, edx = 0x25252525
eip = 0xb6d149c7

Memory Information
MemTotal:      123 KB
MemFree:        16 KB
Buffers:        10 KB
Cached:     184496 KB
VmPeak:      99380 KB
VmSize:      99380 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22108 KB
VmRSS:       22108 KB
VmData:      33744 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33428 KB
VmPTE:          80 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 17854 TID = 17854
17854 17855 18078 18079 

Maps Information
b2ccb000 b2cd5000 r-xp /usr/lib/libfeedback.so.0.1.4
b2cdb000 b2ce7000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2ce8000 b2d09000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2d0e000 b2d0f000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2d10000 b2d15000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2d16000 b2d17000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2d18000 b2d1a000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2d1b000 b2d1d000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2d1e000 b2d2a000 r-xp /usr/lib/libdrm.so.2.4.0
b2d2b000 b2d2e000 r-xp /usr/lib/libdri2.so.0.0.0
b2d2f000 b2d39000 r-xp /usr/lib/libtbm.so.1.0.0
b2d3a000 b2d4f000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2d50000 b2d62000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3564000 b356d000 r-xp /usr/lib/libeventsystem.so.0.0.1
b356e000 b3580000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b3587000 b3588000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3589000 b358a000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b358b000 b358e000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b358f000 b3592000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b369a000 b36a0000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b36a1000 b37e5000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37f6000 b37f7000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b37f8000 b3801000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3802000 b3806000 r-xp /opt/usr/apps/org.example.recipes/bin/recipes
b3807000 b3840000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4243000 b424e000 r-xp /lib/libnss_files-2.20-2014.11.so
b4250000 b425b000 r-xp /lib/libnss_nis-2.20-2014.11.so
b425d000 b4274000 r-xp /lib/libnsl-2.20-2014.11.so
b4278000 b4280000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4282000 b42a6000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b42a7000 b42a8000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b42a9000 b42ac000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b42ad000 b42b4000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42b5000 b42bf000 r-xp /usr/lib/libsensord-share.so
b42c0000 b42dc000 r-xp /usr/lib/libsensor.so.1.2.0
b42de000 b42e7000 r-xp /usr/lib/libappcore-common.so.1.1
b42ea000 b42ec000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4301000 b4303000 r-xp /usr/lib/libXau.so.6.0.0
b4304000 b4326000 r-xp /usr/lib/libxcb.so.1.1.0
b4328000 b4331000 r-xp /lib/libcrypt-2.20-2014.11.so
b435a000 b435c000 r-xp /usr/lib/libiri.so
b435d000 b4383000 r-xp /lib/libexpat.so.1.5.2
b4385000 b43f0000 r-xp /usr/lib/libssl.so.1.0.0
b43f6000 b4402000 r-xp /usr/lib/libethumb.so.1.13.0
b4403000 b4407000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4408000 b4659000 r-xp /usr/lib/libcrypto.so.1.0.0
b5bd4000 b5be4000 r-xp /usr/lib/libXi.so.6.1.0
b5be5000 b5be7000 r-xp /usr/lib/libXgesture.so.7.0.0
b5be8000 b5bee000 r-xp /usr/lib/libXtst.so.6.1.0
b5bef000 b5bf9000 r-xp /usr/lib/libXrender.so.1.3.0
b5bfa000 b5c03000 r-xp /usr/lib/libXrandr.so.2.2.0
b5c05000 b5c07000 r-xp /usr/lib/libXinerama.so.1.0.0
b5c08000 b5c0d000 r-xp /usr/lib/libXfixes.so.3.1.0
b5c0e000 b5c20000 r-xp /usr/lib/libXext.so.6.4.0
b5c21000 b5c23000 r-xp /usr/lib/libXdamage.so.1.1.0
b5c24000 b5c26000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5c28000 b5d6a000 r-xp /usr/lib/libX11.so.6.3.0
b5d6e000 b5d78000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d79000 b5d8f000 r-xp /usr/lib/libudev.so.1.6.0
b5d92000 b5d96000 r-xp /lib/libattr.so.1.1.0
b5d97000 b5dc6000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5dc8000 b5dce000 r-xp /usr/lib/libffi.so.6.0.2
b5dcf000 b5df2000 r-xp /lib/libz.so.1.2.8
b5df3000 b5df6000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5df7000 b5f53000 r-xp /usr/lib/libxml2.so.2.9.2
b5f59000 b6040000 r-xp /usr/lib/libstdc++.so.6.0.20
b604d000 b6050000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6051000 b6073000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6074000 b6088000 r-xp /lib/libresolv-2.20-2014.11.so
b608c000 b60b0000 r-xp /usr/lib/liblzma.so.5.0.3
b60b1000 b60b3000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b60b5000 b60bf000 r-xp /usr/lib/libembryo.so.1.13.0
b60c0000 b60e9000 r-xp /usr/lib/libpng12.so.0.50.0
b60ea000 b6133000 r-xp /usr/lib/libjpeg.so.8.0.2
b6144000 b614b000 r-xp /lib/librt-2.20-2014.11.so
b614d000 b616c000 r-xp /usr/lib/libector.so.1.13.0
b616f000 b619c000 r-xp /usr/lib/liblua-5.1.so
b619d000 b622d000 r-xp /usr/lib/libfreetype.so.6.11.3
b6231000 b626f000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6270000 b6286000 r-xp /usr/lib/libfribidi.so.0.3.1
b6287000 b62e0000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b62e3000 b632e000 r-xp /lib/libm-2.20-2014.11.so
b6330000 b6342000 r-xp /usr/lib/libeio.so.1.13.0
b6343000 b6346000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b6347000 b634d000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b634e000 b6371000 r-xp /usr/lib/libefreet.so.1.13.0
b6374000 b639f000 r-xp /usr/lib/libeldbus.so.1.13.0
b63a0000 b63d4000 r-xp /usr/lib/libecore_con.so.1.13.0
b63d6000 b63df000 r-xp /usr/lib/libecore_imf.so.1.13.0
b63e0000 b63e9000 r-xp /usr/lib/libethumb_client.so.1.13.0
b63ea000 b63fd000 r-xp /usr/lib/libeo.so.1.13.0
b63ff000 b6412000 r-xp /usr/lib/libecore_input.so.1.13.0
b6413000 b641a000 r-xp /usr/lib/libecore_file.so.1.13.0
b641b000 b643e000 r-xp /usr/lib/libecore_evas.so.1.13.0
b643f000 b646b000 r-xp /usr/lib/libeet.so.1.13.0
b6474000 b64df000 r-xp /usr/lib/libeina.so.1.13.0
b64e2000 b64f9000 r-xp /usr/lib/libefl.so.1.13.0
b64fb000 b6662000 r-xp /usr/lib/libicuuc.so.51.1
b6670000 b687c000 r-xp /usr/lib/libicui18n.so.51.1
b6884000 b68d3000 r-xp /usr/lib/libecore_x.so.1.13.0
b68d5000 b68ef000 r-xp /lib/libgcc_s-4.9.so.1
b68f1000 b68f5000 r-xp /lib/libcap.so.2.21
b68f6000 b693c000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b693d000 b6944000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6946000 b6998000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b699a000 b6b25000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6b2a000 b6bf8000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6bfb000 b6bff000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6c00000 b6c0f000 r-xp /usr/lib/libvconf.so.0.2.45
b6c10000 b6c13000 r-xp /usr/lib/libvasum.so.0.3.1
b6c14000 b6c17000 r-xp /usr/lib/libttrace.so.1.1
b6c19000 b6c1d000 r-xp /usr/lib/libiniparser.so.0
b6c1e000 b6c4e000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c4f000 b6c58000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c59000 b6c7e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c7f000 b6c8f000 r-xp /usr/lib/libunwind.so.8.0.1
b6c99000 b6e47000 r-xp /lib/libc-2.20-2014.11.so
b6e4f000 b6f92000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f94000 b6fec000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6fed000 b7021000 r-xp /usr/lib/libsystemd.so.0.4.0
b7024000 b70f8000 r-xp /usr/lib/libedje.so.1.13.0
b70fb000 b7127000 r-xp /usr/lib/libecore.so.1.13.0
b7138000 b735e000 r-xp /usr/lib/libevas.so.1.13.0
b7386000 b739e000 r-xp /lib/libpthread-2.20-2014.11.so
b73a2000 b771c000 r-xp /usr/lib/libelementary.so.1.13.0
b773c000 b7740000 r-xp /usr/lib/libsmack.so.1.0.0
b7741000 b774a000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b774b000 b774e000 r-xp /usr/lib/libdlog.so.0.0.0
b774f000 b7754000 r-xp /usr/lib/libbundle.so.0.1.22
b7755000 b7758000 r-xp /lib/libdl-2.20-2014.11.so
b775a000 b777f000 r-xp /usr/lib/libaul.so.0.1.0
b7782000 b7784000 r-xp /usr/lib/libappsvc.so.0.1.0
b7785000 b778a000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b778b000 b7792000 r-xp /usr/lib/libappcore-efl.so.1.1
b7794000 b7799000 r-xp /usr/lib/libsys-assert.so
b779c000 b779d000 r-xp [vdso]
b779d000 b77bf000 r-xp /lib/ld-2.20-2014.11.so
b77c1000 b77c9000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:17854)
Call Stack Count: 23
 0: strchrnul + 0x17 (0xb6d149c7) [/lib/libc.so.6] + 0x7b9c7
 1: vsprintf + 0x69 (0xb6cfc889) [/lib/libc.so.6] + 0x63889
 2: recipes_detail_cb + 0x145 (0xb3805225) [/opt/usr/apps/org.example.recipes/bin/recipes] + 0x3225
 3: (0xb75616ec) [/usr/lib/libelementary.so.1] + 0x1bf6ec
 4: (0xb7562ede) [/usr/lib/libelementary.so.1] + 0x1c0ede
 5: (0xb716c449) [/usr/lib/libevas.so.1] + 0x34449
 6: (0xb63f8319) [/usr/lib/libeo.so.1] + 0xe319
 7: eo_event_callback_call + 0xb3 (0xb63f5d63) [/usr/lib/libeo.so.1] + 0xbd63
 8: (0xb716ca62) [/usr/lib/libevas.so.1] + 0x34a62
 9: (0xb716cad8) [/usr/lib/libevas.so.1] + 0x34ad8
10: (0xb717be49) [/usr/lib/libevas.so.1] + 0x43e49
11: evas_canvas_event_feed_mouse_up + 0xcf (0xb71850af) [/usr/lib/libevas.so.1] + 0x4d0af
12: evas_event_feed_mouse_up + 0x6a (0xb718bb8a) [/usr/lib/libevas.so.1] + 0x53b8a
13: (0xb4405535) [/usr/lib/libecore_input_evas.so.1] + 0x2535
14: (0xb7108055) [/usr/lib/libecore.so.1] + 0xd055
15: (0xb71111b9) [/usr/lib/libecore.so.1] + 0x161b9
16: ecore_main_loop_begin + 0x57 (0xb7111587) [/usr/lib/libecore.so.1] + 0x16587
17: elm_run + 0x2d (0xb756a22d) [/usr/lib/libelementary.so.1] + 0x1c822d
18: appcore_efl_main + 0x4de (0xb778edde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
19: ui_app_main + 0x140 (0xb7787c40) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c40
20: main + 0x2a4 (0xb3804474) [/opt/usr/apps/org.example.recipes/bin/recipes] + 0x2474
21: my_box_pack + 0xd8 (0xb77c3148) [/opt/usr/apps/org.example.recipes/bin/recipes] + 0xb77c3148
22: __libc_start_main + 0xde (0xb6cb0e4e) [/lib/libc.so.6] + 0x17e4e
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
es] key[install_percent] value[100]
02-25 22:51:21.865+0900 D/PKGMGR  (18022): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(18022), zone(host), pkg_typ(tpk), pkg_id(org.example.recipes), key(install_percent), val(100)
02-25 22:51:21.865+0900 D/PKGMGR  (18022): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(18022), pkg_typ(tpk), pkg_id(org.example.recipes), key(install_percent), val(100)
02-25 22:51:21.865+0900 D/PKGMGR  (18022): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr.install.progress), signal_name(install_progress)
02-25 22:51:21.865+0900 D/PKGMGR  ( 2960): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_607255390], pkg_type=[tpk], pkgid=[org.example.recipes], key=[install_percent], value=[100]
02-25 22:51:21.865+0900 D/ESD     ( 2960): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29600002), pkg_type(tpk), pkgid(org.example.recipes), key(install_percent), val(100)
02-25 22:51:21.865+0900 D/rpm-installer(18022): coretpk-installer.c: _coretpk_installer_package_reinstall(5096) > _coretpk_installer_package_reinstall(org.example.recipes) is done.
02-25 22:51:21.865+0900 D/PKGMGR  (18022): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(18022), zone(host), pkg_typ(tpk), pkg_id(org.example.recipes), key(end), val(ok)
02-25 22:51:21.865+0900 D/PKGMGR  (18022): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(18022), pkg_typ(tpk), pkg_id(org.example.recipes), key(end), val(ok)
02-25 22:51:21.865+0900 D/PKGMGR  (18022): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr_status), signal_name(status)
02-25 22:51:21.865+0900 D/PKGMGR_INSTALLER(18022): pkgmgr_installer.c: __send_event(112) > option is pkgid[org.example.recipes] key[end] value[ok]
02-25 22:51:21.865+0900 D/PKGMGR  ( 3129): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_607255390], pkg_type=[tpk], pkgid=[org.example.recipes], key=[install_percent], value=[100]
02-25 22:51:21.865+0900 D/PKGMGR  (18022): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(18022), zone(host), pkg_typ(tpk), pkg_id(org.example.recipes), key(end), val(ok)
02-25 22:51:21.865+0900 D/PKGMGR  (18022): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(18022), pkg_typ(tpk), pkg_id(org.example.recipes), key(end), val(ok)
02-25 22:51:21.865+0900 D/PKGMGR  ( 2984): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_607255390], pkg_type=[tpk], pkgid=[org.example.recipes], key=[install_percent], value=[100]
02-25 22:51:21.865+0900 D/PKGMGR  (18022): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr.upgrade), signal_name(upgrade)
02-25 22:51:21.865+0900 D/PKGMGR  ( 2984): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
02-25 22:51:21.865+0900 D/PKGMGR  ( 2915): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_607255390], pkg_type=[tpk], pkgid=[org.example.recipes], key=[install_percent], value=[100]
02-25 22:51:21.865+0900 W/cluster-home( 2915): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[1], package[org.example.recipes]
02-25 22:51:21.865+0900 D/PKGMGR  ( 2915): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_607255390], pkg_type=[tpk], pkgid=[org.example.recipes], key=[install_percent], value=[100]
02-25 22:51:21.865+0900 D/cluster-home( 2915): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29150003] pkg_type[tpk] package[org.example.recipes] key[install_percent] val[100] pmsg[(null)]
02-25 22:51:21.865+0900 D/PKGMGR  ( 2990): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_607255390], pkg_type=[tpk], pkgid=[org.example.recipes], key=[install_percent], value=[100]
02-25 22:51:21.865+0900 D/PKGMGR  ( 2963): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_607255390], pkg_type=[tpk], pkgid=[org.example.recipes], key=[install_percent], value=[100]
02-25 22:51:21.865+0900 D/DATA_PROVIDER_MASTER( 2963): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.recipes] 100
02-25 22:51:21.865+0900 D/PKGMGR  ( 2964): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_607255390], pkg_type=[tpk], pkgid=[org.example.recipes], key=[end], value=[ok]
02-25 22:51:21.865+0900 D/QUICKPANEL( 2964): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.recipes key:end val:ok
02-25 22:51:21.865+0900 D/PKGMGR  ( 2746): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[upgrade], req_id=[org.example.recipes_607255390], pkg_type=[tpk], pkgid=[org.example.recipes], key=[end], value=[ok]
02-25 22:51:21.865+0900 D/AUL_AMD ( 2746): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(638) > [SECURE_LOG] pkgid(org.example.recipes), key(end), value(ok)
02-25 22:51:21.865+0900 W/AUL_AMD ( 2746): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(664) > [SECURE_LOG] op(update), value(ok)
02-25 22:51:21.865+0900 D/PKGMGR  ( 2990): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_607255390], pkg_type=[tpk], pkgid=[org.example.recipes], key=[end], value=[ok]
02-25 22:51:21.865+0900 D/PKGMGR  ( 2915): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_607255390], pkg_type=[tpk], pkgid=[org.example.recipes], key=[end], value=[ok]
02-25 22:51:21.865+0900 W/cluster-home( 2915): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[2], package[org.example.recipes]
02-25 22:51:21.865+0900 D/cluster-home( 2915): widget-data-provider.cpp: PackageUpdated(2160) >  No boxes that pkgname is[org.example.recipes]
02-25 22:51:21.865+0900 D/PKGMGR  (18017): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_607255390], pkg_type=[tpk], pkgid=[org.example.recipes], key=[end], value=[ok]
02-25 22:51:21.865+0900 D/PKGMGR  ( 2915): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_607255390], pkg_type=[tpk], pkgid=[org.example.recipes], key=[end], value=[ok]
02-25 22:51:21.865+0900 D/cluster-home( 2915): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29150003] pkg_type[tpk] package[org.example.recipes] key[end] val[ok] pmsg[(null)]
02-25 22:51:21.865+0900 E/cluster-home( 2915): mainmenu-package-manager.cpp: OnClientListenCb(463) >  #Step 1
02-25 22:51:21.865+0900 E/cluster-home( 2915): mainmenu-package-manager.cpp: OnClientListenCb(467) >  #Step 2
02-25 22:51:21.865+0900 D/PKGMGR  ( 2960): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_607255390], pkg_type=[tpk], pkgid=[org.example.recipes], key=[end], value=[ok]
02-25 22:51:21.865+0900 E/cluster-home( 2915): mainmenu-package-manager.cpp: _GetAppIds(334) >  BEGIN
02-25 22:51:21.865+0900 D/ESD     ( 2960): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29600002), pkg_type(tpk), pkgid(org.example.recipes), key(end), val(ok)
02-25 22:51:21.865+0900 D/ESD     ( 2960): esd_main.c: __esd_pkgmgr_event_callback(1728) > install end (ok)
02-25 22:51:21.865+0900 D/PKGMGR  ( 2984): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_607255390], pkg_type=[tpk], pkgid=[org.example.recipes], key=[end], value=[ok]
02-25 22:51:21.865+0900 D/PKGMGR  ( 2984): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
02-25 22:51:21.865+0900 D/PKGMGR  ( 2963): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_607255390], pkg_type=[tpk], pkgid=[org.example.recipes], key=[end], value=[ok]
02-25 22:51:21.865+0900 D/DATA_PROVIDER_MASTER( 2963): pkgmgr.c: end_cb(409) > [SECURE_LOG] [org.example.recipes] ok
02-25 22:51:21.865+0900 D/DATA_PROVIDER_MASTER( 2963): notification_service.c: _invoke_package_change_event(916) > [SECURE_LOG] pkgname[org.example.recipes], event_type[1]
02-25 22:51:21.865+0900 D/DATA_PROVIDER_MASTER( 2963): notification_service.c: _invoke_package_change_event(945) > [SECURE_LOG] _invoke_package_change_event returns [0]
02-25 22:51:21.865+0900 D/DATA_PROVIDER_MASTER( 2963): notification_service.c: service_thread_main(883) > [SECURE_LOG] (nil) PACKET_REQ_NOACK: Command: [package_install]
02-25 22:51:21.865+0900 D/DATA_PROVIDER_MASTER( 2963): notification_service.c: _handler_package_install(579) > [SECURE_LOG] _handler_package_install
02-25 22:51:21.865+0900 D/DATA_PROVIDER_MASTER( 2963): notification_service.c: _handler_package_install(581) > [SECURE_LOG] package_name [org.example.recipes]
02-25 22:51:21.865+0900 D/AUL_AMD ( 2746): amd_appinfo.c: __app_info_insert_handler(488) > [SECURE_LOG] appinfo file:org.example.recipes, type:rpm
02-25 22:51:21.865+0900 D/PKGMGR  ( 3082): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_607255390], pkg_type=[tpk], pkgid=[org.example.recipes], key=[end], value=[ok]
02-25 22:51:21.865+0900 D/ISF_PANEL_EFL( 3082): isf_panel_efl.cpp: _package_manager_event_cb(1288) > type=tpk package=org.example.recipes event_type=UPDATE event_state=COMPLETED progress=100 error=0
02-25 22:51:21.865+0900 D/PKGMGR  ( 3129): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_607255390], pkg_type=[tpk], pkgid=[org.example.recipes], key=[end], value=[ok]
02-25 22:51:21.865+0900 D/cluster-home( 2915): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(220) >  NoDisplay [0]
02-25 22:51:21.865+0900 D/cluster-home( 2915): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(225) >  app Id [org.example.recipes]
02-25 22:51:21.865+0900 E/cluster-home( 2915): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(236) >  ##### [org.example.recipes]
02-25 22:51:21.865+0900 E/cluster-home( 2915): mainmenu-package-manager.cpp: _GetAppIds(355) >  ##### [org.example.recipes]
02-25 22:51:21.865+0900 E/cluster-home( 2915): mainmenu-package-manager.cpp: _GetAppIds(359) >  END
02-25 22:51:21.865+0900 E/cluster-home( 2915): mainmenu-package-manager.cpp: _DoPkgJob(387) >  #Step 3 size[1]
02-25 22:51:21.865+0900 E/cluster-home( 2915): mainmenu-package-manager.cpp: _DoPkgJob(391) >  appId[org.example.recipes]
02-25 22:51:21.865+0900 W/ISF_PANEL_EFL( 3082): isf_panel_efl.cpp: _package_manager_event_cb(1380) > isf_db_select_appids_by_pkgid returned 0.
02-25 22:51:21.865+0900 E/cluster-home( 2915): mainmenu-package-manager.cpp: _GetAppInfo(848) >  AppId[org.example.recipes] Name[recipes] Icon[/opt/usr/apps/org.example.recipes/shared/res/recipes.png] enable[1] system[0]
02-25 22:51:21.865+0900 D/cluster-home( 2915): mainmenu-presenter.cpp: OnAppUpdated(337) >  pAppId [org.example.recipes]
02-25 22:51:21.865+0900 D/cluster-home( 2915): mainmenu-data-manager.cpp: GetBoxDataByAppId(1832) >  BEGIN, strAppId: org.example.recipes
02-25 22:51:21.865+0900 D/cluster-home( 2915): mainmenu-data-manager.cpp: GetBoxDataByAppId(1874) >  nId[581], isFolder[0], pageId[4], col[4], row[1], appId[org.example.recipes], name[recipes], menuId[1], isPreload[0] isPreload[0]
02-25 22:51:21.865+0900 D/cluster-home( 2915): mainmenu-data-manager.cpp: GetBoxDataByAppId(1881) >  DONE
02-25 22:51:21.865+0900 E/cluster-home( 2915): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.recipes] Name[recipes] Icon[/opt/usr/apps/org.example.recipes/shared/res/recipes.png] enable[1] system[0]
02-25 22:51:21.865+0900 D/cluster-home( 2915): mainmenu-presenter.cpp: OnAppUpdated(364) >  name [recipes]
02-25 22:51:21.865+0900 D/cluster-home( 2915): mainmenu-data-manager.cpp: GetMenuBoxData(1241) >  BEGIN
02-25 22:51:21.865+0900 D/cluster-home( 2915): mainmenu-data-manager.cpp: GetMenuBoxData(1291) >  DONE
02-25 22:51:21.865+0900 D/test-log( 2915): mainmenu-box-impl.cpp: UpdateBoxData(812) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.recipes/shared/res/recipes.png], New icon path[/opt/usr/apps/org.example.recipes/shared/res/recipes.png]!!!!!
02-25 22:51:21.865+0900 D/cluster-home( 2915): mainmenu-data-manager.cpp: UpdateBoxData(853) >  Query [UPDATE boxes set isFolder = 0, pageId = 4, appId = $appId, name = $name, col = 4, row = 1, isPreload = 0, isSystem = 0 WHERE boxId = 581]
02-25 22:51:22.295+0900 D/rpm-installer(18022): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
02-25 22:51:22.295+0900 D/rpm-installer(18022): rpm-appcore-intf.c: main(259) > ------------------------------------------------
02-25 22:51:22.295+0900 D/rpm-installer(18022): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
02-25 22:51:22.295+0900 D/rpm-installer(18022): rpm-appcore-intf.c: main(261) > ------------------------------------------------
02-25 22:51:22.295+0900 D/PKGMGR_SERVER(18019): pkgmgr-server.c: sighandler(387) > child exit [18022]
02-25 22:51:22.295+0900 E/PKGMGR_SERVER(18019): pkgmgr-server.c: sighandler(402) > child NORMAL exit [18022]
02-25 22:51:23.905+0900 D/AUL_AMD ( 2746): amd_request.c: __request_handler(838) > __request_handler: 0
02-25 22:51:23.905+0900 D/AUL_AMD ( 2746): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.recipes
02-25 22:51:23.905+0900 D/PKGMGR_INFO( 2746): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
02-25 22:51:23.905+0900 D/PKGMGR_INFO( 2746): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
02-25 22:51:23.915+0900 I/AUL     ( 2746): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
02-25 22:51:23.915+0900 D/AUL     ( 2746): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 18072, pid = 18074
02-25 22:51:23.915+0900 D/PKGMGR_INFO( 2746): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
02-25 22:51:23.915+0900 D/PKGMGR_INFO( 2746): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
02-25 22:51:23.915+0900 I/AUL     ( 2746): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
02-25 22:51:23.915+0900 E/AUL_AMD ( 2746): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
02-25 22:51:23.915+0900 W/AUL_AMD ( 2746): amd_launch.c: _start_app(2233) > caller pid : 18074
02-25 22:51:23.915+0900 E/AUL_AMD ( 2746): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
02-25 22:51:23.915+0900 W/AUL_AMD ( 2746): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.recipes) pkgid(org.example.recipes) attribute(200)
02-25 22:51:23.915+0900 D/AUL_AMD ( 2746): amd_launch.c: _start_app(2648) > process_pool: false
02-25 22:51:23.915+0900 D/AUL_AMD ( 2746): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
02-25 22:51:23.915+0900 D/AUL_AMD ( 2746): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.recipes
02-25 22:51:23.915+0900 W/AUL_AMD ( 2746): amd_launch.c: _start_app(2665) > pad pid(-5)
02-25 22:51:23.915+0900 D/AUL_AMD ( 2746): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
02-25 22:51:23.915+0900 D/AUL_AMD ( 2746): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
02-25 22:51:23.915+0900 D/AUL     ( 2746): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
02-25 22:51:23.915+0900 D/AUL_PAD ( 2961): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
02-25 22:51:23.915+0900 D/AUL_PAD ( 2961): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
02-25 22:51:23.915+0900 D/AUL_PAD ( 2961): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
02-25 22:51:23.915+0900 D/AUL_PAD ( 2961): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
02-25 22:51:23.915+0900 D/AUL_PAD ( 2961): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
02-25 22:51:23.915+0900 D/AUL_PAD ( 2961): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
02-25 22:51:23.915+0900 D/AUL_PAD ( 2961): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
02-25 22:51:23.915+0900 D/AUL_PAD ( 2961): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
02-25 22:51:23.915+0900 D/AUL_PAD ( 2961): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.recipes
02-25 22:51:23.915+0900 D/AUL_PAD ( 2961): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.recipes/bin/recipes
02-25 22:51:23.915+0900 D/AUL_PAD ( 2961): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
02-25 22:51:23.915+0900 D/AUL_PAD ( 2961): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
02-25 22:51:23.915+0900 D/AUL_PAD ( 2961): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
02-25 22:51:23.915+0900 D/AUL_PAD ( 2961): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
02-25 22:51:23.915+0900 W/AUL_PAD ( 2961): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
02-25 22:51:23.915+0900 D/AUL     ( 2961): process_pool.c: __send_pkt_raw_data(219) > send(12) : 624 / 624
02-25 22:51:23.915+0900 D/AUL_PAD ( 2961): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 17854, bin path: /opt/usr/apps/org.example.recipes/bin/recipes
02-25 22:51:23.915+0900 W/AUL_PAD ( 2961): launchpad.c: __send_result_to_caller(265) > Check app launching
02-25 22:51:23.915+0900 D/AUL_PAD ( 2961): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
02-25 22:51:23.915+0900 D/RESOURCED( 2892): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.recipes, pkgid = org.example.recipes, flags = 512
02-25 22:51:23.915+0900 D/RESOURCED( 2892): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.recipes, pkgname = org.example.recipes, ref = 1
02-25 22:51:23.915+0900 E/RESOURCED( 2892): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
02-25 22:51:23.915+0900 D/AUL_PAD (17854): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
02-25 22:51:23.915+0900 D/AUL_PAD (17854): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 624, pkt->len: 616
02-25 22:51:23.915+0900 D/AUL_PAD (17854): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.recipes, launchpad type: 0
02-25 22:51:23.915+0900 D/AUL_PAD (17854): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
02-25 22:51:23.915+0900 D/AUL_PAD (17854): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.recipes
02-25 22:51:23.915+0900 D/AUL_PAD (17854): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.recipes
02-25 22:51:23.915+0900 D/AUL     (17854): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (17855) is sent.
02-25 22:51:23.915+0900 D/AUL     (17854): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 17855, signo: 10
02-25 22:51:23.915+0900 D/AUL     (17854): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
02-25 22:51:23.915+0900 D/AUL_PAD (17854): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.recipes / pkg_type : rpm / app_path : /opt/usr/apps/org.example.recipes/bin/recipes
02-25 22:51:23.915+0900 D/AUL_PAD (17854): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.recipes/bin/recipes##
02-25 22:51:23.915+0900 D/AUL_PAD (17854): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
02-25 22:51:23.915+0900 D/AUL_PAD (17854): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
02-25 22:51:23.915+0900 D/AUL_PAD (17854): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0ODgwMzA2ODMvOTE5MzI1AA==##
02-25 22:51:23.915+0900 D/AUL_PAD (17854): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
02-25 22:51:23.915+0900 D/AUL_PAD (17854): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KQAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAYAAAAxODA3NAA=##
02-25 22:51:23.915+0900 D/AUL_PAD (17854): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
02-25 22:51:23.915+0900 D/AUL_PAD (17854): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
02-25 22:51:23.915+0900 D/AUL_PAD (17854): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.recipes/bin/recipes, real app argc: 8
02-25 22:51:23.915+0900 D/AUL_PAD (17854): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
02-25 22:51:23.915+0900 D/AUL_PAD (17854): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.recipes/bin/recipes)
02-25 22:51:23.925+0900 I/CAPI_APPFW_APPLICATION(17854): app_main.c: ui_app_main(788) > app_efl_main
02-25 22:51:23.925+0900 D/LAUNCH  (17854): appcore-efl.c: appcore_efl_main(1692) > [recipes:Application:main:done]
02-25 22:51:23.925+0900 D/APP_CORE(17854): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
02-25 22:51:23.925+0900 D/APP_CORE(17854): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.recipes/res/locale
02-25 22:51:23.925+0900 D/APP_CORE(17854): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
02-25 22:51:23.925+0900 D/APP_CORE(17854): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
02-25 22:51:23.925+0900 D/AUL     (17854): app_sock.c: __create_server_sock(156) > pg path - already exists
02-25 22:51:23.925+0900 D/APP_CORE(17854): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb42e7520
02-25 22:51:23.925+0900 D/LAUNCH  (17854): appcore-efl.c: __before_loop(1136) > [recipes:Platform:appcore_init:done]
02-25 22:51:23.925+0900 I/CAPI_APPFW_APPLICATION(17854): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
02-25 22:51:23.975+0900 I/TAG11_db_read(17854): 1
02-25 22:51:23.975+0900 I/TAG11_db_read(17854): 1
02-25 22:51:23.985+0900 I/TAG11_db_read(17854): 2
02-25 22:51:23.985+0900 I/TAG11_db_read(17854): 2
02-25 22:51:23.985+0900 I/TAG11_db_read(17854): 3
02-25 22:51:23.985+0900 I/TAG11_db_read(17854): 3
02-25 22:51:23.985+0900 D/LAUNCH  (17854): appcore-efl.c: __before_loop(1154) > [recipes:Application:create:done]
02-25 22:51:23.985+0900 D/APP_CORE(17854): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
02-25 22:51:23.985+0900 E/E17     ( 2865): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x00e00002)
02-25 22:51:23.995+0900 E/PKGMGR_SERVER(18019): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
02-25 22:51:23.995+0900 E/PKGMGR_SERVER(18019): pkgmgr-server.c: main(2265) > package manager server terminated.
02-25 22:51:23.995+0900 E/E17     ( 2865): e_border.c: e_border_show(2088) > BD_SHOW(0x00e00002)
02-25 22:51:24.015+0900 D/AUL_PAD ( 2961): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
02-25 22:51:24.015+0900 W/AUL     ( 2746): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 17854, appid: org.example.recipes
02-25 22:51:24.015+0900 D/AUL     ( 2746): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
02-25 22:51:24.015+0900 E/AUL     ( 2746): simple_util.c: __trm_app_info_send_socket(330) > access
02-25 22:51:24.015+0900 D/AUL_AMD ( 2746): amd_launch.c: _start_app(2700) > add app group info
02-25 22:51:24.015+0900 E/AUL     ( 2746): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
02-25 22:51:24.015+0900 D/AUL_AMD ( 2746): amd_status.c: _status_add_app_info_list(427) > pid(17854) appid(org.example.recipes) pkgid(org.example.recipes) comp(uiapp)
02-25 22:51:24.015+0900 D/RESOURCED( 2892): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.recipes, 17854
02-25 22:51:24.015+0900 D/RESOURCED( 2892): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.recipes with pkgname
02-25 22:51:24.015+0900 E/RESOURCED( 2892): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.recipes
02-25 22:51:24.015+0900 D/RESOURCED( 2892): proc-main.c: resourced_proc_status_change(888) > available memory = 294
02-25 22:51:24.025+0900 W/PROCESSMGR( 2865): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=17854
02-25 22:51:24.025+0900 D/APP_CORE(17854): appcore.c: __aul_handler(587) > [APP 17854]     AUL event: AUL_START
02-25 22:51:24.025+0900 I/APP_CORE(17854): appcore-efl.c: __do_app(496) > [APP 17854] Event: RESET State: CREATED
02-25 22:51:24.025+0900 D/APP_CORE(17854): appcore-efl.c: __do_app(527) > [APP 17854] RESET
02-25 22:51:24.025+0900 D/LAUNCH  (17854): appcore-efl.c: __do_app(529) > [recipes:Application:reset:start]
02-25 22:51:24.025+0900 D/APP_CORE(17854): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
02-25 22:51:24.025+0900 D/APP_CORE(17854): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
02-25 22:51:24.025+0900 I/CAPI_APPFW_APPLICATION(17854): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
02-25 22:51:24.025+0900 D/AUL     (17854): service.c: __set_bundle(186) > __set_bundle
02-25 22:51:24.025+0900 D/LAUNCH  (17854): appcore-efl.c: __do_app(544) > [recipes:Application:reset:done]
02-25 22:51:24.025+0900 D/APP_CORE(17854): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
02-25 22:51:24.025+0900 E/EFL     ( 2865): eo<2865> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
02-25 22:51:24.025+0900 E/EFL     ( 2865): eo<2865> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
02-25 22:51:24.025+0900 E/EFL     (17854): edje<17854> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
02-25 22:51:24.025+0900 E/EFL     (17854): By the power of Grayskull, your previous Embryo stack is now broken!
02-25 22:51:24.025+0900 E/EFL     (17854): edje<17854> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
02-25 22:51:24.025+0900 E/EFL     (17854): By the power of Grayskull, your previous Embryo stack is now broken!
02-25 22:51:24.025+0900 E/EFL     (17854): edje<17854> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
02-25 22:51:24.025+0900 E/EFL     (17854): By the power of Grayskull, your previous Embryo stack is now broken!
02-25 22:51:24.025+0900 E/EFL     (17854): edje<17854> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
02-25 22:51:24.025+0900 E/EFL     (17854): By the power of Grayskull, your previous Embryo stack is now broken!
02-25 22:51:24.025+0900 E/EFL     (17854): edje<17854> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
02-25 22:51:24.025+0900 E/EFL     (17854): By the power of Grayskull, your previous Embryo stack is now broken!
02-25 22:51:24.035+0900 D/INDICATOR( 2896): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
02-25 22:51:24.035+0900 D/INDICATOR( 2896): util.c: util_signal_emit_by_win(116) > emission bg.opaque
02-25 22:51:24.035+0900 D/INDICATOR( 2896): main.c: _rotate_window(229) > Indicator angle is 0 degree
02-25 22:51:24.035+0900 D/INDICATOR( 2896): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
02-25 22:51:24.035+0900 D/INDICATOR( 2896): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
02-25 22:51:24.035+0900 D/INDICATOR( 2896): main.c: _rotate_window(252) > port :: hide more icon
02-25 22:51:24.035+0900 D/AUL_AMD ( 2746): amd_request.c: __request_handler(838) > __request_handler: 15
02-25 22:51:24.045+0900 D/PKGMGR_INFO( 2746): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.recipes/bin/recipes' and package_app_info.app_disable IN ('false','False')
02-25 22:51:24.045+0900 D/PKGMGR_INFO( 2746): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.recipes/bin/recipes' and package_app_info.app_disable IN ('false','False')
02-25 22:51:24.045+0900 W/APP_CORE(17854): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:e00002
02-25 22:51:24.045+0900 D/APP_CORE(17854): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:e00002
02-25 22:51:24.045+0900 D/APP_CORE(17854): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
02-25 22:51:24.045+0900 D/AUL     (17854): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
02-25 22:51:24.045+0900 D/AUL_AMD ( 2746): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 17854 is org.example.recipes
02-25 22:51:24.045+0900 D/AUL_AMD ( 2746): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 17854 : 0
02-25 22:51:24.045+0900 D/AUL_AMD ( 2746): amd_request.c: __request_handler(838) > __request_handler: 34
02-25 22:51:24.045+0900 D/AUL     ( 2990): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
02-25 22:51:24.905+0900 D/APP_CORE(17854): appcore.c: __prt_ltime(236) > [APP 17854] first idle after reset: 992 msec
02-25 22:51:25.015+0900 D/AUL_PAD ( 2961): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
02-25 22:51:25.015+0900 D/AUL_PAD ( 2961): sigchild.h: __send_app_launch_signal(131) > send launch signal done
02-25 22:51:25.025+0900 D/AUL_PAD (18082): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
02-25 22:51:25.025+0900 D/AUL_AMD ( 2746): amd_launch.c: __grab_timeout_handler(1445) > pid(17854) ecore_x_pointer_ungrab
02-25 22:51:25.025+0900 D/AUL_AMD ( 2746): amd_key.c: _key_ungrab(265) > _key_ungrab, win : 600002
02-25 22:51:25.045+0900 E/RESOURCED( 2892): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1264
02-25 22:51:25.165+0900 W/AUL_AMD ( 2746): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
02-25 22:51:25.165+0900 W/AUL_AMD ( 2746): amd_launch.c: __grab_timeout_handler(1447) > back key ungrab error
02-25 22:51:25.515+0900 D/AUL_AMD ( 2746): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.recipes /opt/usr/apps/org.example.recipes/bin/recipes
02-25 22:51:25.515+0900 D/RUA     ( 2746): rua.c: rua_add_history(179) > rua_add_history start
02-25 22:51:25.535+0900 D/RUA     ( 2746): rua.c: rua_add_history(247) > rua_add_history ok
02-25 22:51:25.755+0900 E/E17     ( 2865): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
02-25 22:51:25.755+0900 D/APP_CORE(17854): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:e00002 fully_obscured 0
02-25 22:51:25.755+0900 D/APP_CORE(17854): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
02-25 22:51:25.755+0900 D/APP_CORE(17854): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
02-25 22:51:25.755+0900 I/APP_CORE(17854): appcore-efl.c: __do_app(496) > [APP 17854] Event: RESUME State: CREATED
02-25 22:51:25.755+0900 D/LAUNCH  (17854): appcore-efl.c: __do_app(597) > [recipes:Application:resume:start]
02-25 22:51:25.755+0900 D/APP_CORE(17854): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
02-25 22:51:25.755+0900 D/APP_CORE(17854): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
02-25 22:51:25.755+0900 D/APP_CORE(17854): appcore-efl.c: __do_app(607) > [APP 17854] RESUME
02-25 22:51:25.755+0900 D/AUL_AMD ( 2746): amd_status.c: _status_update_app_info_list(456) > pid(2915) status(4)
02-25 22:51:25.755+0900 D/AUL_AMD ( 2746): amd_status.c: _status_update_app_info_list(468) > pid(2915) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
02-25 22:51:25.755+0900 D/AUL     ( 2746): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
02-25 22:51:25.755+0900 W/AUL     ( 2746): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2915, appid: org.tizen.homescreen, status: bg
02-25 22:51:25.765+0900 D/APP_CORE( 2915): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
02-25 22:51:25.765+0900 D/APP_CORE( 2915): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
02-25 22:51:25.765+0900 D/APP_CORE( 2915): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
02-25 22:51:25.765+0900 I/APP_CORE( 2915): appcore-efl.c: __do_app(496) > [APP 2915] Event: PAUSE State: RUNNING
02-25 22:51:25.765+0900 D/APP_CORE( 2915): appcore-efl.c: __do_app(565) > [APP 2915] PAUSE
02-25 22:51:25.765+0900 I/CAPI_APPFW_APPLICATION( 2915): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
02-25 22:51:25.765+0900 E/cluster-home( 2915): homescreen.cpp: OnPause(84) >  app pause
02-25 22:51:25.765+0900 D/cluster-view( 2915): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
02-25 22:51:25.765+0900 D/cluster-view( 2915): homescreen-view-manager.cpp: AppPause(923) >  END
02-25 22:51:25.765+0900 D/APP_CORE( 2915): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
02-25 22:51:25.765+0900 E/APP_CORE( 2915): appcore-efl.c: __trm_app_info_send_socket(242) > access
02-25 22:51:25.765+0900 I/APP_CORE(17854): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
02-25 22:51:25.765+0900 I/APP_CORE(17854): appcore-efl.c: __do_app(614) > [APP 17854] Initial Launching, call the resume_cb
02-25 22:51:25.765+0900 I/CAPI_APPFW_APPLICATION(17854): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
02-25 22:51:25.765+0900 D/LAUNCH  (17854): appcore-efl.c: __do_app(636) > [recipes:Application:resume:done]
02-25 22:51:25.765+0900 D/LAUNCH  (17854): appcore-efl.c: __do_app(638) > [recipes:Application:Launching:done]
02-25 22:51:25.765+0900 D/APP_CORE(17854): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
02-25 22:51:25.765+0900 E/APP_CORE(17854): appcore-efl.c: __trm_app_info_send_socket(242) > access
02-25 22:51:25.765+0900 D/AUL_AMD ( 2746): amd_launch.c: __e17_status_handler(2891) > pid(17854) status(3)
02-25 22:51:25.765+0900 D/AUL_AMD ( 2746): amd_key.c: _key_ungrab(265) > _key_ungrab, win : 600002
02-25 22:51:25.765+0900 W/AUL_AMD ( 2746): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
02-25 22:51:25.765+0900 W/AUL_AMD ( 2746): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
02-25 22:51:25.765+0900 D/AUL_AMD ( 2746): amd_status.c: _status_update_app_info_list(456) > pid(17854) status(3)
02-25 22:51:25.765+0900 D/AUL_AMD ( 2746): amd_status.c: _status_update_app_info_list(468) > pid(17854) appid(org.example.recipes) pkgid(org.example.recipes) status(3)
02-25 22:51:25.765+0900 D/AUL     ( 2746): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.recipes
02-25 22:51:25.765+0900 W/AUL     ( 2746): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 17854, appid: org.example.recipes, status: fg
02-25 22:51:25.765+0900 D/RESOURCED( 2892): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 17854
02-25 22:51:25.765+0900 D/RESOURCED( 2892): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 17854, proc_name: org.example.recipes, cg_name: foreground, oom_score_adj: 200
02-25 22:51:25.765+0900 D/RESOURCED( 2892): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 17854
02-25 22:51:25.775+0900 D/DATA_PROVIDER_MASTER( 2963): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2915 is paused
02-25 22:51:25.775+0900 D/DATA_PROVIDER_MASTER( 2963): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
02-25 22:51:25.775+0900 I/CAPI_WIDGET_APPLICATION( 3064): widget_app.c: __provider_pause_cb(294) > widget obj was paused
02-25 22:51:25.775+0900 I/CAPI_WIDGET_APPLICATION( 3064): widget_app.c: __check_status_for_cgroup(142) > enter background group
02-25 22:51:25.775+0900 W/AUL     ( 3064): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3064, appid: org.tizen.calendar.widget, status: bg
02-25 22:51:25.855+0900 D/RESOURCED( 2892): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 17854, appname = org.example.recipes, pkgname = org.example.recipes
02-25 22:51:25.855+0900 D/RESOURCED( 2892): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 17854, appname = org.example.recipes
02-25 22:51:25.855+0900 D/RESOURCED( 2892): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 17854
02-25 22:51:25.855+0900 D/RESOURCED( 2892): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3064, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
02-25 22:51:25.855+0900 D/RESOURCED( 2892): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3064
02-25 22:51:25.855+0900 D/RESOURCED( 2892): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3064, appname = org.tizen.calendar.widget
02-25 22:51:25.855+0900 D/RESOURCED( 2892): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3064
02-25 22:51:25.855+0900 I/RESOURCED( 2892): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
02-25 22:51:25.855+0900 I/RESOURCED( 2892): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
02-25 22:51:26.045+0900 D/AUL_PAD (18082): launchpad_loader.c: main(588) > sleeping 1 sec...
02-25 22:51:26.045+0900 D/AUL_PAD (18082): preload.h: __preload_init(52) > max_cmdline_size = 1053
02-25 22:51:26.045+0900 D/AUL_PAD (18082): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b8ba9760
02-25 22:51:26.045+0900 D/AUL_PAD (18082): preload.h: __preload_init(69) > get pre-initialization function
02-25 22:51:26.045+0900 D/AUL_PAD (18082): preload.h: __preload_init(73) > get shutdown function
02-25 22:51:26.045+0900 D/AUL_PAD (18082): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b8ba9a40
02-25 22:51:26.045+0900 D/AUL_PAD (18082): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b8bab640
02-25 22:51:26.045+0900 D/AUL_PAD (18082): preload.h: __preload_init(69) > get pre-initialization function
02-25 22:51:26.045+0900 D/AUL_PAD (18082): preload.h: __preload_init(73) > get shutdown function
02-25 22:51:26.045+0900 D/AUL_PAD (18082): preexec.h: __preexec_init(76) > preexec start
02-25 22:51:26.045+0900 D/AUL_PAD (18082): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
02-25 22:51:26.045+0900 D/AUL     (18082): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
02-25 22:51:26.045+0900 D/AUL     (18082): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
02-25 22:51:26.045+0900 D/AUL     (18082): process_pool.c: __connect_to_launchpad(132) > send(18082) : 4
02-25 22:51:26.045+0900 D/AUL     (18082): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
02-25 22:51:26.045+0900 D/AUL_PAD ( 2961): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
02-25 22:51:26.045+0900 D/AUL_PAD ( 2961): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
02-25 22:51:26.045+0900 D/AUL_PAD ( 2961): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
02-25 22:51:26.045+0900 D/AUL_PAD ( 2961): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
02-25 22:51:26.045+0900 D/AUL_PAD ( 2961): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
02-25 22:51:26.045+0900 D/AUL_PAD ( 2961): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
02-25 22:51:26.045+0900 D/AUL_PAD ( 2961): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
02-25 22:51:26.045+0900 D/AUL_PAD ( 2961): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
02-25 22:51:26.045+0900 D/AUL_PAD ( 2961): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 18082
02-25 22:51:26.305+0900 D/AUL_AMD ( 2746): amd_launch.c: __e17_status_handler(2910) > pid(17854) status(0)
02-25 22:51:26.335+0900 D/AUL_PAD (18082): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
02-25 22:51:26.335+0900 D/AUL_PAD (18082): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
02-25 22:51:26.335+0900 D/AUL_PAD (18082): launchpad_loader.c: main(693) > [candidate] ecore handler add
02-25 22:51:26.345+0900 D/AUL_PAD (18082): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
02-25 22:51:27.475+0900 I/TAG11   (17854): ø¿Y
02-25 22:51:27.475+0900 D/PROCESSMGR( 2865): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x202f68 
02-25 22:51:27.515+0900 D/AUL_PAD ( 2961): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
02-25 22:51:27.515+0900 D/AUL_PAD ( 2961): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
02-25 22:51:27.515+0900 D/AUL_PAD ( 2961): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
02-25 22:51:27.515+0900 D/AUL_PAD ( 2961): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
02-25 22:51:27.515+0900 D/AUL_PAD ( 2961): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
02-25 22:51:27.515+0900 D/AUL_PAD ( 2961): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
02-25 22:51:27.515+0900 D/AUL_PAD ( 2961): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
02-25 22:51:27.515+0900 I/AUL_PAD ( 2961): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 17854 pgid = 17854
02-25 22:51:27.515+0900 I/AUL_PAD ( 2961): sigchild.h: __sigchild_action(142) > dead_pid(17854)
02-25 22:51:27.525+0900 E/EFL     ( 2865): eo<2865> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
02-25 22:51:27.525+0900 D/AUL_AMD ( 2746): amd_launch.c: __e17_status_handler(2891) > pid(2915) status(3)
02-25 22:51:27.525+0900 D/AUL_AMD ( 2746): amd_key.c: _key_ungrab(265) > _key_ungrab, win : 600002
02-25 22:51:27.525+0900 W/AUL_AMD ( 2746): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
02-25 22:51:27.525+0900 W/AUL_AMD ( 2746): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
02-25 22:51:27.525+0900 D/AUL_AMD ( 2746): amd_status.c: _status_update_app_info_list(456) > pid(2915) status(3)
02-25 22:51:27.525+0900 D/AUL_AMD ( 2746): amd_status.c: _status_update_app_info_list(468) > pid(2915) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(3)
02-25 22:51:27.525+0900 D/AUL     ( 2746): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.tizen.homescreen
02-25 22:51:27.525+0900 W/AUL     ( 2746): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2915, appid: org.tizen.homescreen, status: fg
02-25 22:51:27.535+0900 D/RESOURCED( 2892): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 2915
02-25 22:51:27.535+0900 D/RESOURCED( 2892): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 2915, appname = org.tizen.homescreen, pkgname = org.tizen.homescreen
02-25 22:51:27.535+0900 D/RESOURCED( 2892): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 2915, appname = org.tizen.homescreen
02-25 22:51:27.535+0900 D/RESOURCED( 2892): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2915
02-25 22:51:27.535+0900 E/E17     ( 2865): e_border.c: e_border_show(2088) > BD_SHOW(0x01600002)
02-25 22:51:27.544+0900 E/E17     ( 2865): e_border.c: e_border_hide(2248) > BD_HIDE(0x00e00002), visible:1
02-25 22:51:27.544+0900 D/AUL_PAD ( 2961): sigchild.h: __send_app_dead_signal(90) > send dead signal done
02-25 22:51:27.544+0900 I/AUL_PAD ( 2961): sigchild.h: __sigchild_action(148) > __send_app_dead_signal(0)
02-25 22:51:27.544+0900 I/AUL_PAD ( 2961): sigchild.h: __launchpad_process_sigchld(169) > after __sigchild_action
02-25 22:51:27.544+0900 E/AUL_PAD ( 2961): launchpad.c: main(688) > error reading sigchld info
02-25 22:51:27.544+0900 W/CRASH_MANAGER(18084): worker.c: worker_job(1204) > 1117854726563148803068
