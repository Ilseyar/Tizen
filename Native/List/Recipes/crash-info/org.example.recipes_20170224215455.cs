S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160504.2021
Build-Date: 2016.05.04 20:21:45

Crash Information
Process Name: recipes
PID: 11063
Date: 2017-02-24 21:54:55+0900
Executable File Path: /opt/usr/apps/org.example.recipes/bin/recipes
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xffffff94

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb91929d0, esi = 0xb907a5b8
ebp = 0xbfddc518, esp = 0xbfddc4dc
eax = 0xffffff94, ebx = 0xb705bb78
ecx = 0xb919bba8, edx = 0xb919bba8
eip = 0xb6d2dc08

Memory Information
MemTotal:      123 KB
MemFree:        29 KB
Buffers:         7 KB
Cached:     174552 KB
VmPeak:      99220 KB
VmSize:      99220 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       21736 KB
VmRSS:       21736 KB
VmData:      33588 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33424 KB
VmPTE:          80 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 11063 TID = 11063
11063 11064 11246 11248 

Maps Information
b2c30000 b2c3a000 r-xp /usr/lib/libfeedback.so.0.1.4
b2c40000 b2c4c000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2c4d000 b2c6e000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2c73000 b2c74000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2c75000 b2c7a000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2c7b000 b2c7d000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2c7e000 b2c80000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2c81000 b2c8d000 r-xp /usr/lib/libdrm.so.2.4.0
b2c8e000 b2c91000 r-xp /usr/lib/libdri2.so.0.0.0
b2c92000 b2c9c000 r-xp /usr/lib/libtbm.so.1.0.0
b2c9d000 b2cb2000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2cb3000 b2cc5000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b34c7000 b34d0000 r-xp /usr/lib/libeventsystem.so.0.0.1
b34d1000 b34e3000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b34ea000 b34eb000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b34ec000 b34ed000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b34ee000 b34f1000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b34f2000 b34f5000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b35fd000 b3603000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3604000 b3748000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3758000 b3759000 r-xp /usr/lib/libxshmfence.so.1.0.0
b375a000 b375b000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b375c000 b3765000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3766000 b3769000 r-xp /opt/usr/apps/org.example.recipes/bin/recipes
b376a000 b37a3000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b41a6000 b41b1000 r-xp /lib/libnss_files-2.20-2014.11.so
b41b3000 b41be000 r-xp /lib/libnss_nis-2.20-2014.11.so
b41c0000 b41d7000 r-xp /lib/libnsl-2.20-2014.11.so
b41db000 b41e3000 r-xp /lib/libnss_compat-2.20-2014.11.so
b41e5000 b4209000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b420a000 b420b000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b420c000 b420f000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4210000 b4217000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4218000 b4222000 r-xp /usr/lib/libsensord-share.so
b4223000 b423f000 r-xp /usr/lib/libsensor.so.1.2.0
b4241000 b424a000 r-xp /usr/lib/libappcore-common.so.1.1
b424d000 b424f000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4264000 b4266000 r-xp /usr/lib/libXau.so.6.0.0
b4267000 b4289000 r-xp /usr/lib/libxcb.so.1.1.0
b428b000 b4294000 r-xp /lib/libcrypt-2.20-2014.11.so
b42bd000 b42bf000 r-xp /usr/lib/libiri.so
b42c0000 b42e6000 r-xp /lib/libexpat.so.1.5.2
b42e8000 b4353000 r-xp /usr/lib/libssl.so.1.0.0
b4359000 b4365000 r-xp /usr/lib/libethumb.so.1.13.0
b4366000 b436a000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b436b000 b45bc000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b37000 b5b47000 r-xp /usr/lib/libXi.so.6.1.0
b5b48000 b5b4a000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b4b000 b5b51000 r-xp /usr/lib/libXtst.so.6.1.0
b5b52000 b5b5c000 r-xp /usr/lib/libXrender.so.1.3.0
b5b5d000 b5b66000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b68000 b5b6a000 r-xp /usr/lib/libXinerama.so.1.0.0
b5b6b000 b5b70000 r-xp /usr/lib/libXfixes.so.3.1.0
b5b71000 b5b83000 r-xp /usr/lib/libXext.so.6.4.0
b5b84000 b5b86000 r-xp /usr/lib/libXdamage.so.1.1.0
b5b87000 b5b89000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5b8b000 b5ccd000 r-xp /usr/lib/libX11.so.6.3.0
b5cd1000 b5cdb000 r-xp /usr/lib/libXcursor.so.1.0.2
b5cdc000 b5cf2000 r-xp /usr/lib/libudev.so.1.6.0
b5cf5000 b5cf9000 r-xp /lib/libattr.so.1.1.0
b5cfa000 b5d29000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d2b000 b5d31000 r-xp /usr/lib/libffi.so.6.0.2
b5d32000 b5d55000 r-xp /lib/libz.so.1.2.8
b5d56000 b5d59000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d5a000 b5eb6000 r-xp /usr/lib/libxml2.so.2.9.2
b5ebc000 b5fa3000 r-xp /usr/lib/libstdc++.so.6.0.20
b5fb0000 b5fb3000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5fb4000 b5fd6000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5fd7000 b5feb000 r-xp /lib/libresolv-2.20-2014.11.so
b5fef000 b6013000 r-xp /usr/lib/liblzma.so.5.0.3
b6014000 b6016000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b6018000 b6022000 r-xp /usr/lib/libembryo.so.1.13.0
b6023000 b604c000 r-xp /usr/lib/libpng12.so.0.50.0
b604d000 b6096000 r-xp /usr/lib/libjpeg.so.8.0.2
b60a7000 b60ae000 r-xp /lib/librt-2.20-2014.11.so
b60b0000 b60cf000 r-xp /usr/lib/libector.so.1.13.0
b60d2000 b60ff000 r-xp /usr/lib/liblua-5.1.so
b6100000 b6190000 r-xp /usr/lib/libfreetype.so.6.11.3
b6194000 b61d2000 r-xp /usr/lib/libfontconfig.so.1.8.0
b61d3000 b61e9000 r-xp /usr/lib/libfribidi.so.0.3.1
b61ea000 b6243000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6246000 b6291000 r-xp /lib/libm-2.20-2014.11.so
b6293000 b62a5000 r-xp /usr/lib/libeio.so.1.13.0
b62a6000 b62a9000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b62aa000 b62b0000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b62b1000 b62d4000 r-xp /usr/lib/libefreet.so.1.13.0
b62d7000 b6302000 r-xp /usr/lib/libeldbus.so.1.13.0
b6303000 b6337000 r-xp /usr/lib/libecore_con.so.1.13.0
b6339000 b6342000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6343000 b634c000 r-xp /usr/lib/libethumb_client.so.1.13.0
b634d000 b6360000 r-xp /usr/lib/libeo.so.1.13.0
b6362000 b6375000 r-xp /usr/lib/libecore_input.so.1.13.0
b6376000 b637d000 r-xp /usr/lib/libecore_file.so.1.13.0
b637e000 b63a1000 r-xp /usr/lib/libecore_evas.so.1.13.0
b63a2000 b63ce000 r-xp /usr/lib/libeet.so.1.13.0
b63d7000 b6442000 r-xp /usr/lib/libeina.so.1.13.0
b6445000 b645c000 r-xp /usr/lib/libefl.so.1.13.0
b645e000 b65c5000 r-xp /usr/lib/libicuuc.so.51.1
b65d3000 b67df000 r-xp /usr/lib/libicui18n.so.51.1
b67e7000 b6836000 r-xp /usr/lib/libecore_x.so.1.13.0
b6838000 b6852000 r-xp /lib/libgcc_s-4.9.so.1
b6854000 b6858000 r-xp /lib/libcap.so.2.21
b6859000 b689f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b68a0000 b68a7000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b68a9000 b68fb000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b68fd000 b6a88000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6a8d000 b6b5b000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b5e000 b6b62000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b63000 b6b72000 r-xp /usr/lib/libvconf.so.0.2.45
b6b73000 b6b76000 r-xp /usr/lib/libvasum.so.0.3.1
b6b77000 b6b7a000 r-xp /usr/lib/libttrace.so.1.1
b6b7c000 b6b80000 r-xp /usr/lib/libiniparser.so.0
b6b81000 b6bb1000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6bb2000 b6bbb000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6bbc000 b6be1000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6be2000 b6bf2000 r-xp /usr/lib/libunwind.so.8.0.1
b6bfc000 b6daa000 r-xp /lib/libc-2.20-2014.11.so
b6db2000 b6ef5000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6ef7000 b6f4f000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f50000 b6f84000 r-xp /usr/lib/libsystemd.so.0.4.0
b6f87000 b705b000 r-xp /usr/lib/libedje.so.1.13.0
b705e000 b708a000 r-xp /usr/lib/libecore.so.1.13.0
b709b000 b72c1000 r-xp /usr/lib/libevas.so.1.13.0
b72e9000 b7301000 r-xp /lib/libpthread-2.20-2014.11.so
b7305000 b767f000 r-xp /usr/lib/libelementary.so.1.13.0
b769f000 b76a3000 r-xp /usr/lib/libsmack.so.1.0.0
b76a4000 b76ad000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76ae000 b76b1000 r-xp /usr/lib/libdlog.so.0.0.0
b76b2000 b76b7000 r-xp /usr/lib/libbundle.so.0.1.22
b76b8000 b76bb000 r-xp /lib/libdl-2.20-2014.11.so
b76bd000 b76e2000 r-xp /usr/lib/libaul.so.0.1.0
b76e5000 b76e7000 r-xp /usr/lib/libappsvc.so.0.1.0
b76e8000 b76ed000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b76ee000 b76f5000 r-xp /usr/lib/libappcore-efl.so.1.1
b76f7000 b76fc000 r-xp /usr/lib/libsys-assert.so
b76ff000 b7700000 r-xp [vdso]
b7700000 b7722000 r-xp /lib/ld-2.20-2014.11.so
b7724000 b772c000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:11063)
Call Stack Count: 35
 0: (0xb6d2dc08) [/lib/libc.so.6] + 0x131c08
 1: (0xb7030f14) [/usr/lib/libedje.so.1] + 0xa9f14
 2: edje_obj_part_text_escaped_set + 0xb3 (0xb7013053) [/usr/lib/libedje.so.1] + 0x8c053
 3: edje_object_part_text_escaped_set + 0x5c (0xb702057c) [/usr/lib/libedje.so.1] + 0x9957c
 4: (0xb74b8ff5) [/usr/lib/libelementary.so.1] + 0x1b3ff5
 5: elm_obj_layout_text_set + 0xb3 (0xb74b0bf3) [/usr/lib/libelementary.so.1] + 0x1abbf3
 6: (0xb74addc0) [/usr/lib/libelementary.so.1] + 0x1a8dc0
 7: elm_obj_layout_text_set + 0xb3 (0xb74b0bf3) [/usr/lib/libelementary.so.1] + 0x1abbf3
 8: elm_layout_text_set + 0x5c (0xb74b9afc) [/usr/lib/libelementary.so.1] + 0x1b4afc
 9: (0xb756c396) [/usr/lib/libelementary.so.1] + 0x267396
10: elm_obj_widget_part_text_set + 0xb9 (0xb75672d9) [/usr/lib/libelementary.so.1] + 0x2622d9
11: elm_widget_part_text_set + 0x60 (0xb7581730) [/usr/lib/libelementary.so.1] + 0x27c730
12: elm_object_part_text_set + 0x2f (0xb74cd7ff) [/usr/lib/libelementary.so.1] + 0x1c87ff
13: create_label_view + 0xcf (0xb3767e5f) [/opt/usr/apps/org.example.recipes/bin/recipes] + 0x1e5f
14: recipes_detail_cb + 0x8b (0xb3767d1b) [/opt/usr/apps/org.example.recipes/bin/recipes] + 0x1d1b
15: (0xb74c46ec) [/usr/lib/libelementary.so.1] + 0x1bf6ec
16: (0xb74c5ede) [/usr/lib/libelementary.so.1] + 0x1c0ede
17: (0xb70cf449) [/usr/lib/libevas.so.1] + 0x34449
18: (0xb635b319) [/usr/lib/libeo.so.1] + 0xe319
19: eo_event_callback_call + 0xb3 (0xb6358d63) [/usr/lib/libeo.so.1] + 0xbd63
20: (0xb70cfa62) [/usr/lib/libevas.so.1] + 0x34a62
21: (0xb70cfad8) [/usr/lib/libevas.so.1] + 0x34ad8
22: (0xb70dee49) [/usr/lib/libevas.so.1] + 0x43e49
23: evas_canvas_event_feed_mouse_up + 0xcf (0xb70e80af) [/usr/lib/libevas.so.1] + 0x4d0af
24: evas_event_feed_mouse_up + 0x6a (0xb70eeb8a) [/usr/lib/libevas.so.1] + 0x53b8a
25: (0xb4368535) [/usr/lib/libecore_input_evas.so.1] + 0x2535
26: (0xb706b055) [/usr/lib/libecore.so.1] + 0xd055
27: (0xb70741b9) [/usr/lib/libecore.so.1] + 0x161b9
28: ecore_main_loop_begin + 0x57 (0xb7074587) [/usr/lib/libecore.so.1] + 0x16587
29: elm_run + 0x2d (0xb74cd22d) [/usr/lib/libelementary.so.1] + 0x1c822d
30: appcore_efl_main + 0x4de (0xb76f1dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
31: ui_app_main + 0x140 (0xb76eac40) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c40
32: main + 0x2a4 (0xb3767364) [/opt/usr/apps/org.example.recipes/bin/recipes] + 0x1364
33: (0xb7726148) [/opt/usr/apps/org.example.recipes/bin/recipes] + 0xb7726148
34: __libc_start_main + 0xde (0xb6c13e4e) [/lib/libc.so.6] + 0x17e4e
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
m-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.recipes, /opt/usr/apps/org.example.recipes/cache, 0, org.example.recipes), result=[0]
02-24 21:54:49.949+0900 D/rpm-installer(11190): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.recipes, /opt/usr/apps/org.example.recipes/tizen-manifest.xml, 0, org.example.recipes), result=[0]
02-24 21:54:49.949+0900 D/rpm-installer(11190): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.recipes, /opt/usr/apps/org.example.recipes/author-signature.xml, 0, org.example.recipes), result=[0]
02-24 21:54:49.949+0900 D/rpm-installer(11190): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.recipes, /opt/usr/apps/org.example.recipes/signature1.xml, 0, org.example.recipes), result=[0]
02-24 21:54:49.949+0900 D/rpm-installer(11190): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.recipes, /opt/share/packages/org.example.recipes.xml, 0, org.example.recipes), result=[0]
02-24 21:54:49.949+0900 D/rpm-installer(11190): rpm-installer-privilege.c: _ri_privilege_set_package_version(75) > [smack] app[org.example.recipes] version set to [2.3] result=[0]
02-24 21:54:49.949+0900 D/rpm-installer(11190): rpm-installer.c: _ri_apply_privilege(1924) > api-version[2.3] fot privilege has done successfully.
02-24 21:54:49.949+0900 D/rpm-installer(11190): rpm-installer.c: __privilege_func(1046) > package_id=[org.example.recipes], privilege=[http://tizen.org/privilege/systemsettings]
02-24 21:54:49.959+0900 D/rpm-installer(11190): rpm-installer-privilege.c: _ri_privilege_enable_permissions(106) > [smack] app_enable_permissions(org.example.recipes, 7), result=[0]
02-24 21:54:49.959+0900 D/rpm-installer(11190): coretpk-installer.c: _coretpk_installer_package_reinstall(5083) > #permission applying success.
02-24 21:54:49.959+0900 D/PKGMGR  (11190): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(11190), zone(host), pkg_typ(tpk), pkg_id(org.example.recipes), key(install_percent), val(100)
02-24 21:54:49.959+0900 D/PKGMGR  (11190): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(11190), pkg_typ(tpk), pkg_id(org.example.recipes), key(install_percent), val(100)
02-24 21:54:49.959+0900 D/PKGMGR  (11190): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr_status), signal_name(status)
02-24 21:54:49.959+0900 D/PKGMGR_INSTALLER(11190): pkgmgr_installer.c: __send_event(112) > option is pkgid[org.example.recipes] key[install_percent] value[100]
02-24 21:54:49.959+0900 D/PKGMGR  (11185): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_1009637463], pkg_type=[tpk], pkgid=[org.example.recipes], key=[install_percent], value=[100]
02-24 21:54:49.959+0900 D/PKGMGR  (11190): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(11190), zone(host), pkg_typ(tpk), pkg_id(org.example.recipes), key(install_percent), val(100)
02-24 21:54:49.959+0900 D/PKGMGR  (11190): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(11190), pkg_typ(tpk), pkg_id(org.example.recipes), key(install_percent), val(100)
02-24 21:54:49.959+0900 D/PKGMGR  (11190): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr.install.progress), signal_name(install_progress)
02-24 21:54:49.959+0900 D/PKGMGR  ( 3184): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_1009637463], pkg_type=[tpk], pkgid=[org.example.recipes], key=[install_percent], value=[100]
02-24 21:54:49.959+0900 D/PKGMGR  ( 3087): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_1009637463], pkg_type=[tpk], pkgid=[org.example.recipes], key=[install_percent], value=[100]
02-24 21:54:49.959+0900 D/rpm-installer(11190): coretpk-installer.c: _coretpk_installer_package_reinstall(5096) > _coretpk_installer_package_reinstall(org.example.recipes) is done.
02-24 21:54:49.959+0900 D/PKGMGR  (11190): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(11190), zone(host), pkg_typ(tpk), pkg_id(org.example.recipes), key(end), val(ok)
02-24 21:54:49.959+0900 D/PKGMGR  (11190): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(11190), pkg_typ(tpk), pkg_id(org.example.recipes), key(end), val(ok)
02-24 21:54:49.959+0900 D/PKGMGR  (11190): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr_status), signal_name(status)
02-24 21:54:49.959+0900 D/PKGMGR  ( 3020): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_1009637463], pkg_type=[tpk], pkgid=[org.example.recipes], key=[install_percent], value=[100]
02-24 21:54:49.959+0900 W/cluster-home( 3020): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[1], package[org.example.recipes]
02-24 21:54:49.959+0900 D/PKGMGR  ( 3020): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_1009637463], pkg_type=[tpk], pkgid=[org.example.recipes], key=[install_percent], value=[100]
02-24 21:54:49.959+0900 D/cluster-home( 3020): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[30200003] pkg_type[tpk] package[org.example.recipes] key[install_percent] val[100] pmsg[(null)]
02-24 21:54:49.959+0900 D/PKGMGR  ( 3068): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_1009637463], pkg_type=[tpk], pkgid=[org.example.recipes], key=[install_percent], value=[100]
02-24 21:54:49.959+0900 D/QUICKPANEL( 3068): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.recipes key:install_percent val:100
02-24 21:54:49.959+0900 D/PKGMGR  ( 3079): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_1009637463], pkg_type=[tpk], pkgid=[org.example.recipes], key=[install_percent], value=[100]
02-24 21:54:49.959+0900 D/PKGMGR  ( 3079): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
02-24 21:54:49.959+0900 D/PKGMGR  ( 3067): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_1009637463], pkg_type=[tpk], pkgid=[org.example.recipes], key=[install_percent], value=[100]
02-24 21:54:49.959+0900 D/DATA_PROVIDER_MASTER( 3067): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.recipes] 100
02-24 21:54:49.959+0900 D/PKGMGR  ( 3064): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_1009637463], pkg_type=[tpk], pkgid=[org.example.recipes], key=[install_percent], value=[100]
02-24 21:54:49.959+0900 D/ESD     ( 3064): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(30640002), pkg_type(tpk), pkgid(org.example.recipes), key(install_percent), val(100)
02-24 21:54:49.959+0900 D/PKGMGR  ( 3064): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_1009637463], pkg_type=[tpk], pkgid=[org.example.recipes], key=[end], value=[ok]
02-24 21:54:49.959+0900 D/ESD     ( 3064): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(30640002), pkg_type(tpk), pkgid(org.example.recipes), key(end), val(ok)
02-24 21:54:49.959+0900 D/ESD     ( 3064): esd_main.c: __esd_pkgmgr_event_callback(1728) > install end (ok)
02-24 21:54:49.959+0900 D/PKGMGR_INSTALLER(11190): pkgmgr_installer.c: __send_event(112) > option is pkgid[org.example.recipes] key[end] value[ok]
02-24 21:54:49.959+0900 D/PKGMGR  (11190): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(11190), zone(host), pkg_typ(tpk), pkg_id(org.example.recipes), key(end), val(ok)
02-24 21:54:49.959+0900 D/PKGMGR  (11190): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(11190), pkg_typ(tpk), pkg_id(org.example.recipes), key(end), val(ok)
02-24 21:54:49.959+0900 D/PKGMGR  (11190): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr.upgrade), signal_name(upgrade)
02-24 21:54:49.959+0900 D/PKGMGR  (11185): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_1009637463], pkg_type=[tpk], pkgid=[org.example.recipes], key=[end], value=[ok]
02-24 21:54:49.959+0900 D/PKGMGR  ( 3020): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_1009637463], pkg_type=[tpk], pkgid=[org.example.recipes], key=[end], value=[ok]
02-24 21:54:49.959+0900 W/cluster-home( 3020): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[2], package[org.example.recipes]
02-24 21:54:49.959+0900 D/cluster-home( 3020): widget-data-provider.cpp: PackageUpdated(2160) >  No boxes that pkgname is[org.example.recipes]
02-24 21:54:49.959+0900 D/PKGMGR  ( 3020): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_1009637463], pkg_type=[tpk], pkgid=[org.example.recipes], key=[end], value=[ok]
02-24 21:54:49.959+0900 D/cluster-home( 3020): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[30200003] pkg_type[tpk] package[org.example.recipes] key[end] val[ok] pmsg[(null)]
02-24 21:54:49.959+0900 E/cluster-home( 3020): mainmenu-package-manager.cpp: OnClientListenCb(463) >  #Step 1
02-24 21:54:49.959+0900 E/cluster-home( 3020): mainmenu-package-manager.cpp: OnClientListenCb(467) >  #Step 2
02-24 21:54:49.959+0900 E/cluster-home( 3020): mainmenu-package-manager.cpp: _GetAppIds(334) >  BEGIN
02-24 21:54:49.959+0900 D/PKGMGR  ( 2767): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[upgrade], req_id=[org.example.recipes_1009637463], pkg_type=[tpk], pkgid=[org.example.recipes], key=[end], value=[ok]
02-24 21:54:49.959+0900 D/AUL_AMD ( 2767): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(638) > [SECURE_LOG] pkgid(org.example.recipes), key(end), value(ok)
02-24 21:54:49.959+0900 W/AUL_AMD ( 2767): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(664) > [SECURE_LOG] op(update), value(ok)
02-24 21:54:49.969+0900 D/cluster-home( 3020): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(220) >  NoDisplay [0]
02-24 21:54:49.969+0900 D/cluster-home( 3020): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(225) >  app Id [org.example.recipes]
02-24 21:54:49.969+0900 E/cluster-home( 3020): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(236) >  ##### [org.example.recipes]
02-24 21:54:49.969+0900 E/cluster-home( 3020): mainmenu-package-manager.cpp: _GetAppIds(355) >  ##### [org.example.recipes]
02-24 21:54:49.969+0900 E/cluster-home( 3020): mainmenu-package-manager.cpp: _GetAppIds(359) >  END
02-24 21:54:49.969+0900 E/cluster-home( 3020): mainmenu-package-manager.cpp: _DoPkgJob(387) >  #Step 3 size[1]
02-24 21:54:49.969+0900 E/cluster-home( 3020): mainmenu-package-manager.cpp: _DoPkgJob(391) >  appId[org.example.recipes]
02-24 21:54:49.969+0900 D/AUL_AMD ( 2767): amd_appinfo.c: __app_info_insert_handler(488) > [SECURE_LOG] appinfo file:org.example.recipes, type:rpm
02-24 21:54:49.969+0900 D/PKGMGR  ( 3079): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_1009637463], pkg_type=[tpk], pkgid=[org.example.recipes], key=[end], value=[ok]
02-24 21:54:49.969+0900 D/PKGMGR  ( 3079): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
02-24 21:54:49.969+0900 D/PKGMGR  ( 3184): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_1009637463], pkg_type=[tpk], pkgid=[org.example.recipes], key=[end], value=[ok]
02-24 21:54:49.969+0900 D/PKGMGR  ( 3087): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_1009637463], pkg_type=[tpk], pkgid=[org.example.recipes], key=[end], value=[ok]
02-24 21:54:49.969+0900 D/PKGMGR  ( 3067): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_1009637463], pkg_type=[tpk], pkgid=[org.example.recipes], key=[end], value=[ok]
02-24 21:54:49.969+0900 D/DATA_PROVIDER_MASTER( 3067): pkgmgr.c: end_cb(409) > [SECURE_LOG] [org.example.recipes] ok
02-24 21:54:49.969+0900 D/DATA_PROVIDER_MASTER( 3067): notification_service.c: _invoke_package_change_event(916) > [SECURE_LOG] pkgname[org.example.recipes], event_type[1]
02-24 21:54:49.969+0900 D/DATA_PROVIDER_MASTER( 3067): notification_service.c: _invoke_package_change_event(945) > [SECURE_LOG] _invoke_package_change_event returns [0]
02-24 21:54:49.969+0900 D/DATA_PROVIDER_MASTER( 3067): notification_service.c: service_thread_main(883) > [SECURE_LOG] (nil) PACKET_REQ_NOACK: Command: [package_install]
02-24 21:54:49.969+0900 D/DATA_PROVIDER_MASTER( 3067): notification_service.c: _handler_package_install(579) > [SECURE_LOG] _handler_package_install
02-24 21:54:49.969+0900 D/DATA_PROVIDER_MASTER( 3067): notification_service.c: _handler_package_install(581) > [SECURE_LOG] package_name [org.example.recipes]
02-24 21:54:49.969+0900 E/cluster-home( 3020): mainmenu-package-manager.cpp: _GetAppInfo(848) >  AppId[org.example.recipes] Name[recipes] Icon[/opt/usr/apps/org.example.recipes/shared/res/recipes.png] enable[1] system[0]
02-24 21:54:49.969+0900 D/cluster-home( 3020): mainmenu-presenter.cpp: OnAppUpdated(337) >  pAppId [org.example.recipes]
02-24 21:54:49.969+0900 D/cluster-home( 3020): mainmenu-data-manager.cpp: GetBoxDataByAppId(1832) >  BEGIN, strAppId: org.example.recipes
02-24 21:54:49.969+0900 D/cluster-home( 3020): mainmenu-data-manager.cpp: GetBoxDataByAppId(1874) >  nId[580], isFolder[0], pageId[4], col[4], row[1], appId[org.example.recipes], name[recipes], menuId[1], isPreload[0] isPreload[0]
02-24 21:54:49.969+0900 D/cluster-home( 3020): mainmenu-data-manager.cpp: GetBoxDataByAppId(1881) >  DONE
02-24 21:54:49.969+0900 E/cluster-home( 3020): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.recipes] Name[recipes] Icon[/opt/usr/apps/org.example.recipes/shared/res/recipes.png] enable[1] system[0]
02-24 21:54:49.969+0900 D/cluster-home( 3020): mainmenu-presenter.cpp: OnAppUpdated(364) >  name [recipes]
02-24 21:54:49.969+0900 D/cluster-home( 3020): mainmenu-data-manager.cpp: GetMenuBoxData(1241) >  BEGIN
02-24 21:54:49.969+0900 D/cluster-home( 3020): mainmenu-data-manager.cpp: GetMenuBoxData(1291) >  DONE
02-24 21:54:49.969+0900 D/test-log( 3020): mainmenu-box-impl.cpp: UpdateBoxData(812) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.recipes/shared/res/recipes.png], New icon path[/opt/usr/apps/org.example.recipes/shared/res/recipes.png]!!!!!
02-24 21:54:49.969+0900 D/cluster-home( 3020): mainmenu-data-manager.cpp: UpdateBoxData(853) >  Query [UPDATE boxes set isFolder = 0, pageId = 4, appId = $appId, name = $name, col = 4, row = 1, isPreload = 0, isSystem = 0 WHERE boxId = 580]
02-24 21:54:49.999+0900 D/PKGMGR  ( 3068): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_1009637463], pkg_type=[tpk], pkgid=[org.example.recipes], key=[end], value=[ok]
02-24 21:54:49.999+0900 D/QUICKPANEL( 3068): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.recipes key:end val:ok
02-24 21:54:50.329+0900 D/rpm-installer(11190): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
02-24 21:54:50.329+0900 D/rpm-installer(11190): rpm-appcore-intf.c: main(259) > ------------------------------------------------
02-24 21:54:50.329+0900 D/rpm-installer(11190): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
02-24 21:54:50.329+0900 D/rpm-installer(11190): rpm-appcore-intf.c: main(261) > ------------------------------------------------
02-24 21:54:50.329+0900 D/PKGMGR_SERVER(11187): pkgmgr-server.c: sighandler(387) > child exit [11190]
02-24 21:54:50.329+0900 E/PKGMGR_SERVER(11187): pkgmgr-server.c: sighandler(402) > child NORMAL exit [11190]
02-24 21:54:51.569+0900 D/AUL_AMD ( 2767): amd_request.c: __request_handler(838) > __request_handler: 0
02-24 21:54:51.579+0900 D/AUL_AMD ( 2767): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.recipes
02-24 21:54:51.579+0900 D/PKGMGR_INFO( 2767): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
02-24 21:54:51.579+0900 D/PKGMGR_INFO( 2767): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
02-24 21:54:51.579+0900 I/AUL     ( 2767): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
02-24 21:54:51.579+0900 D/AUL     ( 2767): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 11240, pid = 11242
02-24 21:54:51.579+0900 D/PKGMGR_INFO( 2767): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
02-24 21:54:51.579+0900 D/PKGMGR_INFO( 2767): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
02-24 21:54:51.579+0900 I/AUL     ( 2767): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
02-24 21:54:51.579+0900 E/AUL_AMD ( 2767): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
02-24 21:54:51.579+0900 W/AUL_AMD ( 2767): amd_launch.c: _start_app(2233) > caller pid : 11242
02-24 21:54:51.579+0900 E/AUL_AMD ( 2767): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
02-24 21:54:51.579+0900 W/AUL_AMD ( 2767): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.recipes) pkgid(org.example.recipes) attribute(200)
02-24 21:54:51.579+0900 D/AUL_AMD ( 2767): amd_launch.c: _start_app(2648) > process_pool: false
02-24 21:54:51.579+0900 D/AUL_AMD ( 2767): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
02-24 21:54:51.579+0900 D/AUL_AMD ( 2767): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.recipes
02-24 21:54:51.579+0900 W/AUL_AMD ( 2767): amd_launch.c: _start_app(2665) > pad pid(-5)
02-24 21:54:51.579+0900 D/AUL_AMD ( 2767): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
02-24 21:54:51.579+0900 D/AUL_AMD ( 2767): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
02-24 21:54:51.579+0900 D/AUL     ( 2767): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
02-24 21:54:51.579+0900 D/AUL_PAD ( 3065): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
02-24 21:54:51.579+0900 D/AUL_PAD ( 3065): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
02-24 21:54:51.579+0900 D/AUL_PAD ( 3065): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
02-24 21:54:51.579+0900 D/AUL_PAD ( 3065): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
02-24 21:54:51.579+0900 D/AUL_PAD ( 3065): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
02-24 21:54:51.579+0900 D/AUL_PAD ( 3065): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
02-24 21:54:51.579+0900 D/AUL_PAD ( 3065): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
02-24 21:54:51.579+0900 D/AUL_PAD ( 3065): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
02-24 21:54:51.579+0900 D/AUL_PAD ( 3065): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.recipes
02-24 21:54:51.579+0900 D/AUL_PAD ( 3065): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.recipes/bin/recipes
02-24 21:54:51.579+0900 D/AUL_PAD ( 3065): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
02-24 21:54:51.579+0900 D/AUL_PAD ( 3065): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
02-24 21:54:51.579+0900 D/AUL_PAD ( 3065): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
02-24 21:54:51.579+0900 D/AUL_PAD ( 3065): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
02-24 21:54:51.579+0900 W/AUL_PAD ( 3065): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
02-24 21:54:51.579+0900 D/AUL     ( 3065): process_pool.c: __send_pkt_raw_data(219) > send(11) : 624 / 624
02-24 21:54:51.579+0900 D/AUL_PAD ( 3065): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 11063, bin path: /opt/usr/apps/org.example.recipes/bin/recipes
02-24 21:54:51.579+0900 W/AUL_PAD ( 3065): launchpad.c: __send_result_to_caller(265) > Check app launching
02-24 21:54:51.579+0900 D/AUL_PAD ( 3065): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
02-24 21:54:51.579+0900 D/RESOURCED( 2996): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.recipes, pkgid = org.example.recipes, flags = 512
02-24 21:54:51.579+0900 D/RESOURCED( 2996): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.recipes, pkgname = org.example.recipes, ref = 1
02-24 21:54:51.579+0900 E/RESOURCED( 2996): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
02-24 21:54:51.579+0900 D/AUL_PAD (11063): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
02-24 21:54:51.579+0900 D/AUL_PAD (11063): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 624, pkt->len: 616
02-24 21:54:51.579+0900 D/AUL_PAD (11063): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.recipes, launchpad type: 0
02-24 21:54:51.579+0900 D/AUL_PAD (11063): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
02-24 21:54:51.579+0900 D/AUL_PAD (11063): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.recipes
02-24 21:54:51.579+0900 D/AUL_PAD (11063): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.recipes
02-24 21:54:51.579+0900 D/AUL     (11063): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (11064) is sent.
02-24 21:54:51.579+0900 D/AUL     (11063): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 11064, signo: 10
02-24 21:54:51.579+0900 D/AUL     (11063): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
02-24 21:54:51.579+0900 D/AUL_PAD (11063): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.recipes / pkg_type : rpm / app_path : /opt/usr/apps/org.example.recipes/bin/recipes
02-24 21:54:51.579+0900 D/AUL_PAD (11063): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.recipes/bin/recipes##
02-24 21:54:51.579+0900 D/AUL_PAD (11063): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
02-24 21:54:51.579+0900 D/AUL_PAD (11063): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
02-24 21:54:51.579+0900 D/AUL_PAD (11063): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0ODc5NDA4OTEvNTc5NjUxAA==##
02-24 21:54:51.579+0900 D/AUL_PAD (11063): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
02-24 21:54:51.579+0900 D/AUL_PAD (11063): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KQAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAYAAAAxMTI0MgA=##
02-24 21:54:51.579+0900 D/AUL_PAD (11063): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
02-24 21:54:51.579+0900 D/AUL_PAD (11063): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
02-24 21:54:51.579+0900 D/AUL_PAD (11063): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.recipes/bin/recipes, real app argc: 8
02-24 21:54:51.579+0900 D/AUL_PAD (11063): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
02-24 21:54:51.579+0900 D/AUL_PAD (11063): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.recipes/bin/recipes)
02-24 21:54:51.589+0900 I/CAPI_APPFW_APPLICATION(11063): app_main.c: ui_app_main(788) > app_efl_main
02-24 21:54:51.589+0900 D/LAUNCH  (11063): appcore-efl.c: appcore_efl_main(1692) > [recipes:Application:main:done]
02-24 21:54:51.589+0900 D/APP_CORE(11063): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
02-24 21:54:51.589+0900 D/APP_CORE(11063): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.recipes/res/locale
02-24 21:54:51.589+0900 D/APP_CORE(11063): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
02-24 21:54:51.589+0900 D/APP_CORE(11063): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
02-24 21:54:51.589+0900 D/AUL     (11063): app_sock.c: __create_server_sock(156) > pg path - already exists
02-24 21:54:51.589+0900 D/APP_CORE(11063): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb424a520
02-24 21:54:51.589+0900 D/LAUNCH  (11063): appcore-efl.c: __before_loop(1136) > [recipes:Platform:appcore_init:done]
02-24 21:54:51.589+0900 I/CAPI_APPFW_APPLICATION(11063): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
02-24 21:54:51.679+0900 D/AUL_PAD ( 3065): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
02-24 21:54:51.679+0900 W/AUL     ( 2767): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 11063, appid: org.example.recipes
02-24 21:54:51.679+0900 D/AUL     ( 2767): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
02-24 21:54:51.679+0900 E/AUL     ( 2767): simple_util.c: __trm_app_info_send_socket(330) > access
02-24 21:54:51.679+0900 D/AUL_AMD ( 2767): amd_launch.c: _start_app(2700) > add app group info
02-24 21:54:51.679+0900 E/AUL     ( 2767): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
02-24 21:54:51.679+0900 D/AUL_AMD ( 2767): amd_status.c: _status_add_app_info_list(427) > pid(11063) appid(org.example.recipes) pkgid(org.example.recipes) comp(uiapp)
02-24 21:54:51.679+0900 D/RESOURCED( 2996): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.recipes, 11063
02-24 21:54:51.679+0900 D/RESOURCED( 2996): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.recipes with pkgname
02-24 21:54:51.679+0900 E/RESOURCED( 2996): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.recipes
02-24 21:54:51.679+0900 D/RESOURCED( 2996): proc-main.c: resourced_proc_status_change(888) > available memory = 323
02-24 21:54:51.759+0900 D/AUL_AMD ( 2767): amd_status.c: __app_terminate_timer_cb(442) > pid(10874)
02-24 21:54:51.759+0900 W/AUL_AMD ( 2767): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
02-24 21:54:51.759+0900 D/AUL_AMD ( 2767): amd_status.c: __app_terminate_timer_cb(442) > pid(10874)
02-24 21:54:51.759+0900 W/AUL_AMD ( 2767): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
02-24 21:54:51.999+0900 E/PKGMGR_SERVER(11187): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
02-24 21:54:51.999+0900 E/PKGMGR_SERVER(11187): pkgmgr-server.c: main(2265) > package manager server terminated.
02-24 21:54:52.039+0900 D/LAUNCH  (11063): appcore-efl.c: __before_loop(1154) > [recipes:Application:create:done]
02-24 21:54:52.039+0900 E/E17     ( 2951): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x00e00002)
02-24 21:54:52.039+0900 D/APP_CORE(11063): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
02-24 21:54:52.049+0900 E/E17     ( 2951): e_border.c: e_border_show(2088) > BD_SHOW(0x00e00002)
02-24 21:54:52.059+0900 D/APP_CORE(11063): appcore.c: __aul_handler(587) > [APP 11063]     AUL event: AUL_START
02-24 21:54:52.059+0900 I/APP_CORE(11063): appcore-efl.c: __do_app(496) > [APP 11063] Event: RESET State: CREATED
02-24 21:54:52.059+0900 D/APP_CORE(11063): appcore-efl.c: __do_app(527) > [APP 11063] RESET
02-24 21:54:52.059+0900 D/LAUNCH  (11063): appcore-efl.c: __do_app(529) > [recipes:Application:reset:start]
02-24 21:54:52.059+0900 D/APP_CORE(11063): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
02-24 21:54:52.059+0900 D/APP_CORE(11063): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
02-24 21:54:52.059+0900 I/CAPI_APPFW_APPLICATION(11063): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
02-24 21:54:52.069+0900 D/AUL     (11063): service.c: __set_bundle(186) > __set_bundle
02-24 21:54:52.069+0900 D/LAUNCH  (11063): appcore-efl.c: __do_app(544) > [recipes:Application:reset:done]
02-24 21:54:52.069+0900 D/APP_CORE(11063): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
02-24 21:54:52.069+0900 E/EFL     (11063): edje<11063> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
02-24 21:54:52.069+0900 E/EFL     (11063): By the power of Grayskull, your previous Embryo stack is now broken!
02-24 21:54:52.069+0900 E/EFL     (11063): edje<11063> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
02-24 21:54:52.069+0900 E/EFL     (11063): By the power of Grayskull, your previous Embryo stack is now broken!
02-24 21:54:52.069+0900 E/EFL     (11063): edje<11063> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
02-24 21:54:52.069+0900 E/EFL     (11063): By the power of Grayskull, your previous Embryo stack is now broken!
02-24 21:54:52.069+0900 E/EFL     (11063): edje<11063> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
02-24 21:54:52.069+0900 E/EFL     (11063): By the power of Grayskull, your previous Embryo stack is now broken!
02-24 21:54:52.069+0900 E/EFL     (11063): edje<11063> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
02-24 21:54:52.069+0900 E/EFL     (11063): By the power of Grayskull, your previous Embryo stack is now broken!
02-24 21:54:52.069+0900 W/PROCESSMGR( 2951): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=11063
02-24 21:54:52.069+0900 E/EFL     ( 2951): eo<2951> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
02-24 21:54:52.069+0900 E/EFL     ( 2951): eo<2951> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
02-24 21:54:52.079+0900 W/APP_CORE(11063): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:e00002
02-24 21:54:52.079+0900 D/APP_CORE(11063): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:e00002
02-24 21:54:52.079+0900 D/APP_CORE(11063): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
02-24 21:54:52.079+0900 D/INDICATOR( 3000): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
02-24 21:54:52.079+0900 D/AUL     (11063): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
02-24 21:54:52.079+0900 D/AUL_AMD ( 2767): amd_request.c: __request_handler(838) > __request_handler: 34
02-24 21:54:52.079+0900 D/INDICATOR( 3000): util.c: util_signal_emit_by_win(116) > emission bg.opaque
02-24 21:54:52.079+0900 D/INDICATOR( 3000): main.c: _rotate_window(229) > Indicator angle is 0 degree
02-24 21:54:52.079+0900 D/INDICATOR( 3000): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
02-24 21:54:52.079+0900 D/INDICATOR( 3000): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
02-24 21:54:52.079+0900 D/INDICATOR( 3000): main.c: _rotate_window(252) > port :: hide more icon
02-24 21:54:52.079+0900 D/AUL_AMD ( 2767): amd_request.c: __request_handler(838) > __request_handler: 15
02-24 21:54:52.079+0900 D/PKGMGR_INFO( 2767): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.recipes/bin/recipes' and package_app_info.app_disable IN ('false','False')
02-24 21:54:52.079+0900 D/PKGMGR_INFO( 2767): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.recipes/bin/recipes' and package_app_info.app_disable IN ('false','False')
02-24 21:54:52.079+0900 D/AUL_AMD ( 2767): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 11063 is org.example.recipes
02-24 21:54:52.079+0900 D/AUL_AMD ( 2767): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 11063 : 0
02-24 21:54:52.079+0900 D/AUL     ( 3087): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
02-24 21:54:52.679+0900 D/AUL_PAD ( 3065): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
02-24 21:54:52.679+0900 D/AUL_PAD (11250): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
02-24 21:54:52.679+0900 D/AUL_AMD ( 2767): amd_launch.c: __grab_timeout_handler(1445) > pid(11063) ecore_x_pointer_ungrab
02-24 21:54:52.679+0900 D/AUL_AMD ( 2767): amd_key.c: _key_ungrab(265) > _key_ungrab, win : 600002
02-24 21:54:52.689+0900 D/AUL_PAD ( 3065): sigchild.h: __send_app_launch_signal(131) > send launch signal done
02-24 21:54:52.689+0900 E/RESOURCED( 2996): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.756
02-24 21:54:52.939+0900 W/AUL_AMD ( 2767): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
02-24 21:54:52.939+0900 W/AUL_AMD ( 2767): amd_launch.c: __grab_timeout_handler(1447) > back key ungrab error
02-24 21:54:52.939+0900 D/APP_CORE(11063): appcore.c: __prt_ltime(236) > [APP 11063] first idle after reset: 1369 msec
02-24 21:54:53.179+0900 D/AUL_AMD ( 2767): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.recipes /opt/usr/apps/org.example.recipes/bin/recipes
02-24 21:54:53.179+0900 D/RUA     ( 2767): rua.c: rua_add_history(179) > rua_add_history start
02-24 21:54:53.189+0900 D/RUA     ( 2767): rua.c: rua_add_history(247) > rua_add_history ok
02-24 21:54:53.719+0900 D/AUL_PAD (11250): launchpad_loader.c: main(588) > sleeping 1 sec...
02-24 21:54:53.719+0900 D/AUL_PAD (11250): preload.h: __preload_init(52) > max_cmdline_size = 1053
02-24 21:54:53.719+0900 D/AUL_PAD (11250): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b794c760
02-24 21:54:53.719+0900 D/AUL_PAD (11250): preload.h: __preload_init(69) > get pre-initialization function
02-24 21:54:53.719+0900 D/AUL_PAD (11250): preload.h: __preload_init(73) > get shutdown function
02-24 21:54:53.719+0900 D/AUL_PAD (11250): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b794ca40
02-24 21:54:53.729+0900 D/AUL_PAD (11250): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b794e640
02-24 21:54:53.729+0900 D/AUL_PAD (11250): preload.h: __preload_init(69) > get pre-initialization function
02-24 21:54:53.729+0900 D/AUL_PAD (11250): preload.h: __preload_init(73) > get shutdown function
02-24 21:54:53.729+0900 D/AUL_PAD (11250): preexec.h: __preexec_init(76) > preexec start
02-24 21:54:53.729+0900 D/AUL_PAD (11250): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
02-24 21:54:53.729+0900 D/AUL     (11250): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
02-24 21:54:53.729+0900 D/AUL     (11250): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
02-24 21:54:53.729+0900 D/AUL     (11250): process_pool.c: __connect_to_launchpad(132) > send(11250) : 4
02-24 21:54:53.729+0900 D/AUL     (11250): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
02-24 21:54:53.729+0900 D/AUL_PAD ( 3065): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
02-24 21:54:53.729+0900 D/AUL_PAD ( 3065): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
02-24 21:54:53.729+0900 D/AUL_PAD ( 3065): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
02-24 21:54:53.729+0900 D/AUL_PAD ( 3065): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
02-24 21:54:53.729+0900 D/AUL_PAD ( 3065): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
02-24 21:54:53.729+0900 D/AUL_PAD ( 3065): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
02-24 21:54:53.729+0900 D/AUL_PAD ( 3065): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
02-24 21:54:53.729+0900 D/AUL_PAD ( 3065): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
02-24 21:54:53.729+0900 D/AUL_PAD ( 3065): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 11250
02-24 21:54:53.739+0900 E/E17     ( 2951): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
02-24 21:54:53.739+0900 D/APP_CORE( 3020): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
02-24 21:54:53.739+0900 D/APP_CORE( 3020): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
02-24 21:54:53.739+0900 D/APP_CORE( 3020): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
02-24 21:54:53.739+0900 I/APP_CORE( 3020): appcore-efl.c: __do_app(496) > [APP 3020] Event: PAUSE State: RUNNING
02-24 21:54:53.739+0900 D/APP_CORE( 3020): appcore-efl.c: __do_app(565) > [APP 3020] PAUSE
02-24 21:54:53.739+0900 I/CAPI_APPFW_APPLICATION( 3020): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
02-24 21:54:53.739+0900 E/cluster-home( 3020): homescreen.cpp: OnPause(84) >  app pause
02-24 21:54:53.739+0900 D/cluster-view( 3020): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
02-24 21:54:53.739+0900 D/cluster-view( 3020): homescreen-view-manager.cpp: AppPause(923) >  END
02-24 21:54:53.739+0900 D/APP_CORE( 3020): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
02-24 21:54:53.739+0900 E/APP_CORE( 3020): appcore-efl.c: __trm_app_info_send_socket(242) > access
02-24 21:54:53.749+0900 D/AUL_AMD ( 2767): amd_status.c: _status_update_app_info_list(456) > pid(3020) status(4)
02-24 21:54:53.749+0900 D/AUL_AMD ( 2767): amd_status.c: _status_update_app_info_list(468) > pid(3020) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
02-24 21:54:53.749+0900 D/AUL     ( 2767): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
02-24 21:54:53.749+0900 W/AUL     ( 2767): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3020, appid: org.tizen.homescreen, status: bg
02-24 21:54:53.749+0900 D/AUL_AMD ( 2767): amd_launch.c: __e17_status_handler(2891) > pid(11063) status(3)
02-24 21:54:53.749+0900 D/AUL_AMD ( 2767): amd_key.c: _key_ungrab(265) > _key_ungrab, win : 600002
02-24 21:54:53.749+0900 W/AUL_AMD ( 2767): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
02-24 21:54:53.749+0900 W/AUL_AMD ( 2767): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
02-24 21:54:53.749+0900 D/AUL_AMD ( 2767): amd_status.c: _status_update_app_info_list(456) > pid(11063) status(3)
02-24 21:54:53.749+0900 D/AUL_AMD ( 2767): amd_status.c: _status_update_app_info_list(468) > pid(11063) appid(org.example.recipes) pkgid(org.example.recipes) status(3)
02-24 21:54:53.749+0900 D/AUL     ( 2767): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.recipes
02-24 21:54:53.749+0900 W/AUL     ( 2767): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 11063, appid: org.example.recipes, status: fg
02-24 21:54:53.749+0900 D/APP_CORE(11063): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:e00002 fully_obscured 0
02-24 21:54:53.749+0900 D/APP_CORE(11063): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
02-24 21:54:53.749+0900 D/APP_CORE(11063): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
02-24 21:54:53.749+0900 I/APP_CORE(11063): appcore-efl.c: __do_app(496) > [APP 11063] Event: RESUME State: CREATED
02-24 21:54:53.749+0900 D/LAUNCH  (11063): appcore-efl.c: __do_app(597) > [recipes:Application:resume:start]
02-24 21:54:53.749+0900 D/APP_CORE(11063): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
02-24 21:54:53.749+0900 D/APP_CORE(11063): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
02-24 21:54:53.749+0900 D/APP_CORE(11063): appcore-efl.c: __do_app(607) > [APP 11063] RESUME
02-24 21:54:53.759+0900 D/RESOURCED( 2996): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 11063
02-24 21:54:53.759+0900 D/RESOURCED( 2996): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 11063, proc_name: org.example.recipes, cg_name: foreground, oom_score_adj: 200
02-24 21:54:53.759+0900 D/RESOURCED( 2996): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 11063
02-24 21:54:53.759+0900 D/DATA_PROVIDER_MASTER( 3067): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 3020 is paused
02-24 21:54:53.759+0900 D/DATA_PROVIDER_MASTER( 3067): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
02-24 21:54:53.759+0900 I/APP_CORE(11063): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
02-24 21:54:53.759+0900 I/APP_CORE(11063): appcore-efl.c: __do_app(614) > [APP 11063] Initial Launching, call the resume_cb
02-24 21:54:53.759+0900 I/CAPI_APPFW_APPLICATION(11063): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
02-24 21:54:53.759+0900 D/LAUNCH  (11063): appcore-efl.c: __do_app(636) > [recipes:Application:resume:done]
02-24 21:54:53.759+0900 D/LAUNCH  (11063): appcore-efl.c: __do_app(638) > [recipes:Application:Launching:done]
02-24 21:54:53.759+0900 D/APP_CORE(11063): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
02-24 21:54:53.759+0900 E/APP_CORE(11063): appcore-efl.c: __trm_app_info_send_socket(242) > access
02-24 21:54:53.759+0900 I/CAPI_WIDGET_APPLICATION( 3098): widget_app.c: __provider_pause_cb(294) > widget obj was paused
02-24 21:54:53.759+0900 I/CAPI_WIDGET_APPLICATION( 3098): widget_app.c: __check_status_for_cgroup(142) > enter background group
02-24 21:54:53.759+0900 W/AUL     ( 3098): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3098, appid: org.tizen.calendar.widget, status: bg
02-24 21:54:53.829+0900 D/RESOURCED( 2996): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 11063, appname = org.example.recipes, pkgname = org.example.recipes
02-24 21:54:53.829+0900 D/RESOURCED( 2996): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 11063, appname = org.example.recipes
02-24 21:54:53.829+0900 D/RESOURCED( 2996): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 11063
02-24 21:54:53.829+0900 D/RESOURCED( 2996): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3098, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
02-24 21:54:53.829+0900 D/RESOURCED( 2996): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3098
02-24 21:54:53.829+0900 D/RESOURCED( 2996): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3098, appname = org.tizen.calendar.widget
02-24 21:54:53.829+0900 D/RESOURCED( 2996): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3098
02-24 21:54:53.829+0900 I/RESOURCED( 2996): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
02-24 21:54:53.829+0900 I/RESOURCED( 2996): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
02-24 21:54:54.019+0900 E/CAPI_NETWORK_WIFI( 3000): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
02-24 21:54:54.019+0900 E/INDICATOR( 3000): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
02-24 21:54:54.019+0900 E/INDICATOR( 3000): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
02-24 21:54:54.019+0900 E/INDICATOR( 3000): 
02-24 21:54:54.269+0900 D/AUL_AMD ( 2767): amd_launch.c: __e17_status_handler(2910) > pid(11063) status(0)
02-24 21:54:54.559+0900 D/AUL_PAD (11250): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
02-24 21:54:54.569+0900 D/AUL_PAD (11250): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
02-24 21:54:54.569+0900 D/AUL_PAD (11250): launchpad_loader.c: main(693) > [candidate] ecore handler add
02-24 21:54:54.569+0900 D/AUL_PAD (11250): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
02-24 21:54:55.609+0900 D/PROCESSMGR( 2951): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002f  register trigger_timer!  pointed_win=0x20130a 
02-24 21:54:55.749+0900 W/CRASH_MANAGER(11252): worker.c: worker_job(1204) > 1111063726563148794089
