S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160504.2021
Build-Date: 2016.05.04 20:21:45

Crash Information
Process Name: recipes
PID: 18408
Date: 2017-02-25 22:56:27+0900
Executable File Path: /opt/usr/apps/org.example.recipes/bin/recipes
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xff

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xfbad8001, esi = 0xb7727f84
ebp = 0xbffd75d8, esp = 0xbffd7098
eax = 0x000000ff, ebx = 0xb6dab000
ecx = 0x00002525, edx = 0x25252525
eip = 0xb6c759c7

Memory Information
MemTotal:      123 KB
MemFree:        16 KB
Buffers:        10 KB
Cached:     184636 KB
VmPeak:      99292 KB
VmSize:      99292 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22112 KB
VmRSS:       22112 KB
VmData:      33656 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33428 KB
VmPTE:          80 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 18408 TID = 18408
18408 18409 18633 18634 

Maps Information
b2c2c000 b2c36000 r-xp /usr/lib/libfeedback.so.0.1.4
b2c3c000 b2c48000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2c49000 b2c6a000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2c6f000 b2c70000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2c71000 b2c76000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2c77000 b2c78000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2c79000 b2c7b000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2c7c000 b2c7e000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2c7f000 b2c8b000 r-xp /usr/lib/libdrm.so.2.4.0
b2c8c000 b2c8f000 r-xp /usr/lib/libdri2.so.0.0.0
b2c90000 b2c9a000 r-xp /usr/lib/libtbm.so.1.0.0
b2c9b000 b2cb0000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2cb1000 b2cc3000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b34c5000 b34ce000 r-xp /usr/lib/libeventsystem.so.0.0.1
b34cf000 b34e1000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b34e8000 b34e9000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b34ea000 b34eb000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b34ec000 b34ef000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b34f0000 b34f3000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b35fb000 b3601000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3602000 b3746000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3757000 b3758000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b3759000 b3762000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3763000 b3767000 r-xp /opt/usr/apps/org.example.recipes/bin/recipes
b3768000 b37a1000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b41a4000 b41af000 r-xp /lib/libnss_files-2.20-2014.11.so
b41b1000 b41bc000 r-xp /lib/libnss_nis-2.20-2014.11.so
b41be000 b41d5000 r-xp /lib/libnsl-2.20-2014.11.so
b41d9000 b41e1000 r-xp /lib/libnss_compat-2.20-2014.11.so
b41e3000 b4207000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b4208000 b4209000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b420a000 b420d000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b420e000 b4215000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4216000 b4220000 r-xp /usr/lib/libsensord-share.so
b4221000 b423d000 r-xp /usr/lib/libsensor.so.1.2.0
b423f000 b4248000 r-xp /usr/lib/libappcore-common.so.1.1
b424b000 b424d000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4262000 b4264000 r-xp /usr/lib/libXau.so.6.0.0
b4265000 b4287000 r-xp /usr/lib/libxcb.so.1.1.0
b4289000 b4292000 r-xp /lib/libcrypt-2.20-2014.11.so
b42bb000 b42bd000 r-xp /usr/lib/libiri.so
b42be000 b42e4000 r-xp /lib/libexpat.so.1.5.2
b42e6000 b4351000 r-xp /usr/lib/libssl.so.1.0.0
b4357000 b4363000 r-xp /usr/lib/libethumb.so.1.13.0
b4364000 b4368000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4369000 b45ba000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b35000 b5b45000 r-xp /usr/lib/libXi.so.6.1.0
b5b46000 b5b48000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b49000 b5b4f000 r-xp /usr/lib/libXtst.so.6.1.0
b5b50000 b5b5a000 r-xp /usr/lib/libXrender.so.1.3.0
b5b5b000 b5b64000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b66000 b5b68000 r-xp /usr/lib/libXinerama.so.1.0.0
b5b69000 b5b6e000 r-xp /usr/lib/libXfixes.so.3.1.0
b5b6f000 b5b81000 r-xp /usr/lib/libXext.so.6.4.0
b5b82000 b5b84000 r-xp /usr/lib/libXdamage.so.1.1.0
b5b85000 b5b87000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5b89000 b5ccb000 r-xp /usr/lib/libX11.so.6.3.0
b5ccf000 b5cd9000 r-xp /usr/lib/libXcursor.so.1.0.2
b5cda000 b5cf0000 r-xp /usr/lib/libudev.so.1.6.0
b5cf3000 b5cf7000 r-xp /lib/libattr.so.1.1.0
b5cf8000 b5d27000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d29000 b5d2f000 r-xp /usr/lib/libffi.so.6.0.2
b5d30000 b5d53000 r-xp /lib/libz.so.1.2.8
b5d54000 b5d57000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d58000 b5eb4000 r-xp /usr/lib/libxml2.so.2.9.2
b5eba000 b5fa1000 r-xp /usr/lib/libstdc++.so.6.0.20
b5fae000 b5fb1000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5fb2000 b5fd4000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5fd5000 b5fe9000 r-xp /lib/libresolv-2.20-2014.11.so
b5fed000 b6011000 r-xp /usr/lib/liblzma.so.5.0.3
b6012000 b6014000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b6016000 b6020000 r-xp /usr/lib/libembryo.so.1.13.0
b6021000 b604a000 r-xp /usr/lib/libpng12.so.0.50.0
b604b000 b6094000 r-xp /usr/lib/libjpeg.so.8.0.2
b60a5000 b60ac000 r-xp /lib/librt-2.20-2014.11.so
b60ae000 b60cd000 r-xp /usr/lib/libector.so.1.13.0
b60d0000 b60fd000 r-xp /usr/lib/liblua-5.1.so
b60fe000 b618e000 r-xp /usr/lib/libfreetype.so.6.11.3
b6192000 b61d0000 r-xp /usr/lib/libfontconfig.so.1.8.0
b61d1000 b61e7000 r-xp /usr/lib/libfribidi.so.0.3.1
b61e8000 b6241000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6244000 b628f000 r-xp /lib/libm-2.20-2014.11.so
b6291000 b62a3000 r-xp /usr/lib/libeio.so.1.13.0
b62a4000 b62a7000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b62a8000 b62ae000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b62af000 b62d2000 r-xp /usr/lib/libefreet.so.1.13.0
b62d5000 b6300000 r-xp /usr/lib/libeldbus.so.1.13.0
b6301000 b6335000 r-xp /usr/lib/libecore_con.so.1.13.0
b6337000 b6340000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6341000 b634a000 r-xp /usr/lib/libethumb_client.so.1.13.0
b634b000 b635e000 r-xp /usr/lib/libeo.so.1.13.0
b6360000 b6373000 r-xp /usr/lib/libecore_input.so.1.13.0
b6374000 b637b000 r-xp /usr/lib/libecore_file.so.1.13.0
b637c000 b639f000 r-xp /usr/lib/libecore_evas.so.1.13.0
b63a0000 b63cc000 r-xp /usr/lib/libeet.so.1.13.0
b63d5000 b6440000 r-xp /usr/lib/libeina.so.1.13.0
b6443000 b645a000 r-xp /usr/lib/libefl.so.1.13.0
b645c000 b65c3000 r-xp /usr/lib/libicuuc.so.51.1
b65d1000 b67dd000 r-xp /usr/lib/libicui18n.so.51.1
b67e5000 b6834000 r-xp /usr/lib/libecore_x.so.1.13.0
b6836000 b6850000 r-xp /lib/libgcc_s-4.9.so.1
b6852000 b6856000 r-xp /lib/libcap.so.2.21
b6857000 b689d000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b689e000 b68a5000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b68a7000 b68f9000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b68fb000 b6a86000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6a8b000 b6b59000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b5c000 b6b60000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b61000 b6b70000 r-xp /usr/lib/libvconf.so.0.2.45
b6b71000 b6b74000 r-xp /usr/lib/libvasum.so.0.3.1
b6b75000 b6b78000 r-xp /usr/lib/libttrace.so.1.1
b6b7a000 b6b7e000 r-xp /usr/lib/libiniparser.so.0
b6b7f000 b6baf000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6bb0000 b6bb9000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6bba000 b6bdf000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6be0000 b6bf0000 r-xp /usr/lib/libunwind.so.8.0.1
b6bfa000 b6da8000 r-xp /lib/libc-2.20-2014.11.so
b6db0000 b6ef3000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6ef5000 b6f4d000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f4e000 b6f82000 r-xp /usr/lib/libsystemd.so.0.4.0
b6f85000 b7059000 r-xp /usr/lib/libedje.so.1.13.0
b705c000 b7088000 r-xp /usr/lib/libecore.so.1.13.0
b7099000 b72bf000 r-xp /usr/lib/libevas.so.1.13.0
b72e7000 b72ff000 r-xp /lib/libpthread-2.20-2014.11.so
b7303000 b767d000 r-xp /usr/lib/libelementary.so.1.13.0
b769d000 b76a1000 r-xp /usr/lib/libsmack.so.1.0.0
b76a2000 b76ab000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76ac000 b76af000 r-xp /usr/lib/libdlog.so.0.0.0
b76b0000 b76b5000 r-xp /usr/lib/libbundle.so.0.1.22
b76b6000 b76b9000 r-xp /lib/libdl-2.20-2014.11.so
b76bb000 b76e0000 r-xp /usr/lib/libaul.so.0.1.0
b76e3000 b76e5000 r-xp /usr/lib/libappsvc.so.0.1.0
b76e6000 b76eb000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b76ec000 b76f3000 r-xp /usr/lib/libappcore-efl.so.1.1
b76f5000 b76fa000 r-xp /usr/lib/libsys-assert.so
b76fd000 b76fe000 r-xp [vdso]
b76fe000 b7720000 r-xp /lib/ld-2.20-2014.11.so
b7722000 b772a000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:18408)
Call Stack Count: 23
 0: strchrnul + 0x17 (0xb6c759c7) [/lib/libc.so.6] + 0x7b9c7
 1: vsprintf + 0x69 (0xb6c5d889) [/lib/libc.so.6] + 0x63889
 2: recipes_detail_cb + 0x145 (0xb3766245) [/opt/usr/apps/org.example.recipes/bin/recipes] + 0x3245
 3: (0xb74c26ec) [/usr/lib/libelementary.so.1] + 0x1bf6ec
 4: (0xb74c3ede) [/usr/lib/libelementary.so.1] + 0x1c0ede
 5: (0xb70cd449) [/usr/lib/libevas.so.1] + 0x34449
 6: (0xb6359319) [/usr/lib/libeo.so.1] + 0xe319
 7: eo_event_callback_call + 0xb3 (0xb6356d63) [/usr/lib/libeo.so.1] + 0xbd63
 8: (0xb70cda62) [/usr/lib/libevas.so.1] + 0x34a62
 9: (0xb70cdad8) [/usr/lib/libevas.so.1] + 0x34ad8
10: (0xb70dce49) [/usr/lib/libevas.so.1] + 0x43e49
11: evas_canvas_event_feed_mouse_up + 0xcf (0xb70e60af) [/usr/lib/libevas.so.1] + 0x4d0af
12: evas_event_feed_mouse_up + 0x6a (0xb70ecb8a) [/usr/lib/libevas.so.1] + 0x53b8a
13: (0xb4366535) [/usr/lib/libecore_input_evas.so.1] + 0x2535
14: (0xb7069055) [/usr/lib/libecore.so.1] + 0xd055
15: (0xb70721b9) [/usr/lib/libecore.so.1] + 0x161b9
16: ecore_main_loop_begin + 0x57 (0xb7072587) [/usr/lib/libecore.so.1] + 0x16587
17: elm_run + 0x2d (0xb74cb22d) [/usr/lib/libelementary.so.1] + 0x1c822d
18: appcore_efl_main + 0x4de (0xb76efdde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
19: ui_app_main + 0x140 (0xb76e8c40) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c40
20: main + 0x2a4 (0xb3765474) [/opt/usr/apps/org.example.recipes/bin/recipes] + 0x2474
21: my_box_pack + 0xd8 (0xb7724148) [/opt/usr/apps/org.example.recipes/bin/recipes] + 0xb7724148
22: __libc_start_main + 0xde (0xb6c11e4e) [/lib/libc.so.6] + 0x17e4e
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
10.751+0900 D/PKGMGR  (18576): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr_status), signal_name(status)
02-25 22:56:10.751+0900 D/PKGMGR_INSTALLER(18576): pkgmgr_installer.c: __send_event(112) > option is pkgid[org.example.recipes] key[install_percent] value[100]
02-25 22:56:10.751+0900 D/PKGMGR  (18576): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(18576), zone(host), pkg_typ(tpk), pkg_id(org.example.recipes), key(install_percent), val(100)
02-25 22:56:10.751+0900 D/PKGMGR  (18576): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(18576), pkg_typ(tpk), pkg_id(org.example.recipes), key(install_percent), val(100)
02-25 22:56:10.751+0900 D/PKGMGR  (18576): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr.install.progress), signal_name(install_progress)
02-25 22:56:10.751+0900 D/rpm-installer(18576): coretpk-installer.c: _coretpk_installer_package_reinstall(5096) > _coretpk_installer_package_reinstall(org.example.recipes) is done.
02-25 22:56:10.751+0900 D/PKGMGR  (18576): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(18576), zone(host), pkg_typ(tpk), pkg_id(org.example.recipes), key(end), val(ok)
02-25 22:56:10.751+0900 D/PKGMGR  (18576): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(18576), pkg_typ(tpk), pkg_id(org.example.recipes), key(end), val(ok)
02-25 22:56:10.751+0900 D/PKGMGR  (18576): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr_status), signal_name(status)
02-25 22:56:10.751+0900 D/PKGMGR_INSTALLER(18576): pkgmgr_installer.c: __send_event(112) > option is pkgid[org.example.recipes] key[end] value[ok]
02-25 22:56:10.751+0900 D/PKGMGR  (18576): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(18576), zone(host), pkg_typ(tpk), pkg_id(org.example.recipes), key(end), val(ok)
02-25 22:56:10.751+0900 D/PKGMGR  (18576): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(18576), pkg_typ(tpk), pkg_id(org.example.recipes), key(end), val(ok)
02-25 22:56:10.751+0900 D/PKGMGR  (18576): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr.upgrade), signal_name(upgrade)
02-25 22:56:10.761+0900 D/PKGMGR  ( 3082): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_896165965], pkg_type=[tpk], pkgid=[org.example.recipes], key=[install_percent], value=[100]
02-25 22:56:10.761+0900 D/PKGMGR  ( 2964): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_896165965], pkg_type=[tpk], pkgid=[org.example.recipes], key=[install_percent], value=[100]
02-25 22:56:10.761+0900 D/QUICKPANEL( 2964): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.recipes key:install_percent val:100
02-25 22:56:10.761+0900 D/PKGMGR  ( 3129): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_896165965], pkg_type=[tpk], pkgid=[org.example.recipes], key=[install_percent], value=[100]
02-25 22:56:10.761+0900 D/PKGMGR  ( 2963): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_896165965], pkg_type=[tpk], pkgid=[org.example.recipes], key=[install_percent], value=[100]
02-25 22:56:10.761+0900 D/DATA_PROVIDER_MASTER( 2963): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.recipes] 100
02-25 22:56:10.761+0900 D/PKGMGR  (18571): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_896165965], pkg_type=[tpk], pkgid=[org.example.recipes], key=[install_percent], value=[100]
02-25 22:56:10.761+0900 D/PKGMGR  ( 2960): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_896165965], pkg_type=[tpk], pkgid=[org.example.recipes], key=[install_percent], value=[100]
02-25 22:56:10.761+0900 D/ESD     ( 2960): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29600002), pkg_type(tpk), pkgid(org.example.recipes), key(install_percent), val(100)
02-25 22:56:10.761+0900 D/PKGMGR  ( 2990): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_896165965], pkg_type=[tpk], pkgid=[org.example.recipes], key=[install_percent], value=[100]
02-25 22:56:10.761+0900 D/PKGMGR  ( 2984): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_896165965], pkg_type=[tpk], pkgid=[org.example.recipes], key=[install_percent], value=[100]
02-25 22:56:10.761+0900 D/PKGMGR  ( 2984): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
02-25 22:56:10.761+0900 D/PKGMGR  ( 2915): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_896165965], pkg_type=[tpk], pkgid=[org.example.recipes], key=[install_percent], value=[100]
02-25 22:56:10.761+0900 W/cluster-home( 2915): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[1], package[org.example.recipes]
02-25 22:56:10.761+0900 D/PKGMGR  ( 2915): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_896165965], pkg_type=[tpk], pkgid=[org.example.recipes], key=[install_percent], value=[100]
02-25 22:56:10.761+0900 D/cluster-home( 2915): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29150003] pkg_type[tpk] package[org.example.recipes] key[install_percent] val[100] pmsg[(null)]
02-25 22:56:10.761+0900 D/PKGMGR  ( 3082): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_896165965], pkg_type=[tpk], pkgid=[org.example.recipes], key=[end], value=[ok]
02-25 22:56:10.761+0900 D/PKGMGR  ( 2964): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_896165965], pkg_type=[tpk], pkgid=[org.example.recipes], key=[end], value=[ok]
02-25 22:56:10.761+0900 D/QUICKPANEL( 2964): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.recipes key:end val:ok
02-25 22:56:10.761+0900 D/ISF_PANEL_EFL( 3082): isf_panel_efl.cpp: _package_manager_event_cb(1288) > type=tpk package=org.example.recipes event_type=UPDATE event_state=COMPLETED progress=100 error=0
02-25 22:56:10.761+0900 D/PKGMGR  ( 3129): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_896165965], pkg_type=[tpk], pkgid=[org.example.recipes], key=[end], value=[ok]
02-25 22:56:10.761+0900 W/ISF_PANEL_EFL( 3082): isf_panel_efl.cpp: _package_manager_event_cb(1380) > isf_db_select_appids_by_pkgid returned 0.
02-25 22:56:10.761+0900 D/PKGMGR  (18571): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_896165965], pkg_type=[tpk], pkgid=[org.example.recipes], key=[end], value=[ok]
02-25 22:56:10.861+0900 D/PKGMGR  ( 2990): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_896165965], pkg_type=[tpk], pkgid=[org.example.recipes], key=[end], value=[ok]
02-25 22:56:10.861+0900 D/PKGMGR  ( 2746): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[upgrade], req_id=[org.example.recipes_896165965], pkg_type=[tpk], pkgid=[org.example.recipes], key=[end], value=[ok]
02-25 22:56:10.861+0900 D/AUL_AMD ( 2746): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(638) > [SECURE_LOG] pkgid(org.example.recipes), key(end), value(ok)
02-25 22:56:10.861+0900 W/AUL_AMD ( 2746): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(664) > [SECURE_LOG] op(update), value(ok)
02-25 22:56:10.761+0900 D/PKGMGR  ( 2960): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_896165965], pkg_type=[tpk], pkgid=[org.example.recipes], key=[end], value=[ok]
02-25 22:56:10.861+0900 D/AUL_AMD ( 2746): amd_appinfo.c: __app_info_insert_handler(488) > [SECURE_LOG] appinfo file:org.example.recipes, type:rpm
02-25 22:56:10.861+0900 D/PKGMGR  ( 2915): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_896165965], pkg_type=[tpk], pkgid=[org.example.recipes], key=[end], value=[ok]
02-25 22:56:10.871+0900 W/cluster-home( 2915): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[2], package[org.example.recipes]
02-25 22:56:10.871+0900 D/cluster-home( 2915): widget-data-provider.cpp: PackageUpdated(2160) >  No boxes that pkgname is[org.example.recipes]
02-25 22:56:10.871+0900 D/PKGMGR  ( 2915): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_896165965], pkg_type=[tpk], pkgid=[org.example.recipes], key=[end], value=[ok]
02-25 22:56:10.871+0900 D/cluster-home( 2915): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29150003] pkg_type[tpk] package[org.example.recipes] key[end] val[ok] pmsg[(null)]
02-25 22:56:10.871+0900 E/cluster-home( 2915): mainmenu-package-manager.cpp: OnClientListenCb(463) >  #Step 1
02-25 22:56:10.871+0900 E/cluster-home( 2915): mainmenu-package-manager.cpp: OnClientListenCb(467) >  #Step 2
02-25 22:56:10.861+0900 D/PKGMGR  ( 2984): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_896165965], pkg_type=[tpk], pkgid=[org.example.recipes], key=[end], value=[ok]
02-25 22:56:10.871+0900 E/cluster-home( 2915): mainmenu-package-manager.cpp: _GetAppIds(334) >  BEGIN
02-25 22:56:10.861+0900 D/PKGMGR  ( 2963): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_896165965], pkg_type=[tpk], pkgid=[org.example.recipes], key=[end], value=[ok]
02-25 22:56:10.871+0900 D/PKGMGR  ( 2984): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
02-25 22:56:10.871+0900 D/DATA_PROVIDER_MASTER( 2963): pkgmgr.c: end_cb(409) > [SECURE_LOG] [org.example.recipes] ok
02-25 22:56:10.871+0900 D/DATA_PROVIDER_MASTER( 2963): notification_service.c: _invoke_package_change_event(916) > [SECURE_LOG] pkgname[org.example.recipes], event_type[1]
02-25 22:56:10.871+0900 D/DATA_PROVIDER_MASTER( 2963): notification_service.c: service_thread_main(883) > [SECURE_LOG] (nil) PACKET_REQ_NOACK: Command: [package_install]
02-25 22:56:10.871+0900 D/DATA_PROVIDER_MASTER( 2963): notification_service.c: _handler_package_install(579) > [SECURE_LOG] _handler_package_install
02-25 22:56:10.871+0900 D/DATA_PROVIDER_MASTER( 2963): notification_service.c: _handler_package_install(581) > [SECURE_LOG] package_name [org.example.recipes]
02-25 22:56:10.871+0900 D/ESD     ( 2960): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29600002), pkg_type(tpk), pkgid(org.example.recipes), key(end), val(ok)
02-25 22:56:10.871+0900 D/ESD     ( 2960): esd_main.c: __esd_pkgmgr_event_callback(1728) > install end (ok)
02-25 22:56:10.871+0900 D/cluster-home( 2915): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(220) >  NoDisplay [0]
02-25 22:56:10.871+0900 D/cluster-home( 2915): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(225) >  app Id [org.example.recipes]
02-25 22:56:10.871+0900 E/cluster-home( 2915): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(236) >  ##### [org.example.recipes]
02-25 22:56:10.871+0900 E/cluster-home( 2915): mainmenu-package-manager.cpp: _GetAppIds(355) >  ##### [org.example.recipes]
02-25 22:56:10.871+0900 E/cluster-home( 2915): mainmenu-package-manager.cpp: _GetAppIds(359) >  END
02-25 22:56:10.871+0900 E/cluster-home( 2915): mainmenu-package-manager.cpp: _DoPkgJob(387) >  #Step 3 size[1]
02-25 22:56:10.871+0900 E/cluster-home( 2915): mainmenu-package-manager.cpp: _DoPkgJob(391) >  appId[org.example.recipes]
02-25 22:56:10.871+0900 D/DATA_PROVIDER_MASTER( 2963): notification_service.c: _invoke_package_change_event(945) > [SECURE_LOG] _invoke_package_change_event returns [0]
02-25 22:56:10.871+0900 E/cluster-home( 2915): mainmenu-package-manager.cpp: _GetAppInfo(848) >  AppId[org.example.recipes] Name[recipes] Icon[/opt/usr/apps/org.example.recipes/shared/res/recipes.png] enable[1] system[0]
02-25 22:56:10.871+0900 D/cluster-home( 2915): mainmenu-presenter.cpp: OnAppUpdated(337) >  pAppId [org.example.recipes]
02-25 22:56:10.871+0900 D/cluster-home( 2915): mainmenu-data-manager.cpp: GetBoxDataByAppId(1832) >  BEGIN, strAppId: org.example.recipes
02-25 22:56:10.891+0900 D/cluster-home( 2915): mainmenu-data-manager.cpp: GetBoxDataByAppId(1874) >  nId[581], isFolder[0], pageId[4], col[4], row[1], appId[org.example.recipes], name[recipes], menuId[1], isPreload[0] isPreload[0]
02-25 22:56:10.891+0900 D/cluster-home( 2915): mainmenu-data-manager.cpp: GetBoxDataByAppId(1881) >  DONE
02-25 22:56:10.891+0900 E/cluster-home( 2915): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.recipes] Name[recipes] Icon[/opt/usr/apps/org.example.recipes/shared/res/recipes.png] enable[1] system[0]
02-25 22:56:10.891+0900 D/cluster-home( 2915): mainmenu-presenter.cpp: OnAppUpdated(364) >  name [recipes]
02-25 22:56:10.891+0900 D/cluster-home( 2915): mainmenu-data-manager.cpp: GetMenuBoxData(1241) >  BEGIN
02-25 22:56:10.891+0900 D/cluster-home( 2915): mainmenu-data-manager.cpp: GetMenuBoxData(1291) >  DONE
02-25 22:56:10.891+0900 D/test-log( 2915): mainmenu-box-impl.cpp: UpdateBoxData(812) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.recipes/shared/res/recipes.png], New icon path[/opt/usr/apps/org.example.recipes/shared/res/recipes.png]!!!!!
02-25 22:56:10.891+0900 D/cluster-home( 2915): mainmenu-data-manager.cpp: UpdateBoxData(853) >  Query [UPDATE boxes set isFolder = 0, pageId = 4, appId = $appId, name = $name, col = 4, row = 1, isPreload = 0, isSystem = 0 WHERE boxId = 581]
02-25 22:56:11.121+0900 D/rpm-installer(18576): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
02-25 22:56:11.121+0900 D/rpm-installer(18576): rpm-appcore-intf.c: main(259) > ------------------------------------------------
02-25 22:56:11.121+0900 D/rpm-installer(18576): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
02-25 22:56:11.121+0900 D/rpm-installer(18576): rpm-appcore-intf.c: main(261) > ------------------------------------------------
02-25 22:56:11.131+0900 D/PKGMGR_SERVER(18573): pkgmgr-server.c: sighandler(387) > child exit [18576]
02-25 22:56:11.131+0900 E/PKGMGR_SERVER(18573): pkgmgr-server.c: sighandler(402) > child NORMAL exit [18576]
02-25 22:56:12.711+0900 D/AUL_AMD ( 2746): amd_request.c: __request_handler(838) > __request_handler: 0
02-25 22:56:12.711+0900 D/AUL_AMD ( 2746): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.recipes
02-25 22:56:12.711+0900 D/PKGMGR_INFO( 2746): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
02-25 22:56:12.711+0900 D/PKGMGR_INFO( 2746): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
02-25 22:56:12.711+0900 I/AUL     ( 2746): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
02-25 22:56:12.711+0900 D/AUL     ( 2746): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 18627, pid = 18629
02-25 22:56:12.711+0900 D/PKGMGR_INFO( 2746): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
02-25 22:56:12.711+0900 D/PKGMGR_INFO( 2746): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
02-25 22:56:12.711+0900 I/AUL     ( 2746): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
02-25 22:56:12.711+0900 E/AUL_AMD ( 2746): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
02-25 22:56:12.711+0900 W/AUL_AMD ( 2746): amd_launch.c: _start_app(2233) > caller pid : 18629
02-25 22:56:12.711+0900 E/AUL_AMD ( 2746): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
02-25 22:56:12.711+0900 W/AUL_AMD ( 2746): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.recipes) pkgid(org.example.recipes) attribute(200)
02-25 22:56:12.711+0900 D/AUL_AMD ( 2746): amd_launch.c: _start_app(2648) > process_pool: false
02-25 22:56:12.711+0900 D/AUL_AMD ( 2746): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
02-25 22:56:12.711+0900 D/AUL_AMD ( 2746): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.recipes
02-25 22:56:12.711+0900 W/AUL_AMD ( 2746): amd_launch.c: _start_app(2665) > pad pid(-5)
02-25 22:56:12.711+0900 D/AUL_AMD ( 2746): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
02-25 22:56:12.711+0900 D/AUL_AMD ( 2746): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
02-25 22:56:12.711+0900 D/AUL     ( 2746): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
02-25 22:56:12.711+0900 D/AUL_PAD ( 2961): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
02-25 22:56:12.711+0900 D/AUL_PAD ( 2961): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
02-25 22:56:12.711+0900 D/AUL_PAD ( 2961): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
02-25 22:56:12.711+0900 D/AUL_PAD ( 2961): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
02-25 22:56:12.711+0900 D/AUL_PAD ( 2961): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
02-25 22:56:12.711+0900 D/AUL_PAD ( 2961): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
02-25 22:56:12.711+0900 D/AUL_PAD ( 2961): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
02-25 22:56:12.711+0900 D/AUL_PAD ( 2961): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
02-25 22:56:12.711+0900 D/RESOURCED( 2892): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.recipes, pkgid = org.example.recipes, flags = 512
02-25 22:56:12.711+0900 D/AUL_PAD ( 2961): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.recipes
02-25 22:56:12.711+0900 D/AUL_PAD ( 2961): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.recipes/bin/recipes
02-25 22:56:12.711+0900 D/AUL_PAD ( 2961): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
02-25 22:56:12.711+0900 D/AUL_PAD ( 2961): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
02-25 22:56:12.711+0900 D/RESOURCED( 2892): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.recipes, pkgname = org.example.recipes, ref = 1
02-25 22:56:12.711+0900 D/AUL_PAD ( 2961): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
02-25 22:56:12.711+0900 D/AUL_PAD ( 2961): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
02-25 22:56:12.711+0900 W/AUL_PAD ( 2961): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
02-25 22:56:12.711+0900 D/AUL     ( 2961): process_pool.c: __send_pkt_raw_data(219) > send(12) : 624 / 624
02-25 22:56:12.711+0900 D/AUL_PAD ( 2961): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 18408, bin path: /opt/usr/apps/org.example.recipes/bin/recipes
02-25 22:56:12.711+0900 W/AUL_PAD ( 2961): launchpad.c: __send_result_to_caller(265) > Check app launching
02-25 22:56:12.711+0900 D/AUL_PAD ( 2961): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
02-25 22:56:12.711+0900 E/RESOURCED( 2892): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
02-25 22:56:12.711+0900 D/AUL_PAD (18408): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
02-25 22:56:12.711+0900 D/AUL_PAD (18408): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 624, pkt->len: 616
02-25 22:56:12.711+0900 D/AUL_PAD (18408): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.recipes, launchpad type: 0
02-25 22:56:12.711+0900 D/AUL_PAD (18408): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
02-25 22:56:12.711+0900 D/AUL_PAD (18408): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.recipes
02-25 22:56:12.711+0900 D/AUL_PAD (18408): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.recipes
02-25 22:56:12.711+0900 D/AUL     (18408): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (18409) is sent.
02-25 22:56:12.711+0900 D/AUL     (18408): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 18409, signo: 10
02-25 22:56:12.711+0900 D/AUL     (18408): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
02-25 22:56:12.711+0900 D/AUL_PAD (18408): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.recipes / pkg_type : rpm / app_path : /opt/usr/apps/org.example.recipes/bin/recipes
02-25 22:56:12.711+0900 D/AUL_PAD (18408): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.recipes/bin/recipes##
02-25 22:56:12.711+0900 D/AUL_PAD (18408): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
02-25 22:56:12.711+0900 D/AUL_PAD (18408): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
02-25 22:56:12.711+0900 D/AUL_PAD (18408): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0ODgwMzA5NzIvNzEyOTA5AA==##
02-25 22:56:12.711+0900 D/AUL_PAD (18408): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
02-25 22:56:12.711+0900 D/AUL_PAD (18408): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KQAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAYAAAAxODYyOQA=##
02-25 22:56:12.711+0900 D/AUL_PAD (18408): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
02-25 22:56:12.711+0900 D/AUL_PAD (18408): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
02-25 22:56:12.711+0900 D/AUL_PAD (18408): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.recipes/bin/recipes, real app argc: 8
02-25 22:56:12.711+0900 D/AUL_PAD (18408): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
02-25 22:56:12.711+0900 D/AUL_PAD (18408): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.recipes/bin/recipes)
02-25 22:56:12.711+0900 I/CAPI_APPFW_APPLICATION(18408): app_main.c: ui_app_main(788) > app_efl_main
02-25 22:56:12.711+0900 D/LAUNCH  (18408): appcore-efl.c: appcore_efl_main(1692) > [recipes:Application:main:done]
02-25 22:56:12.711+0900 D/APP_CORE(18408): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
02-25 22:56:12.711+0900 D/APP_CORE(18408): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.recipes/res/locale
02-25 22:56:12.711+0900 D/APP_CORE(18408): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
02-25 22:56:12.721+0900 D/APP_CORE(18408): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
02-25 22:56:12.721+0900 D/AUL     (18408): app_sock.c: __create_server_sock(156) > pg path - already exists
02-25 22:56:12.721+0900 D/APP_CORE(18408): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb4248520
02-25 22:56:12.721+0900 D/LAUNCH  (18408): appcore-efl.c: __before_loop(1136) > [recipes:Platform:appcore_init:done]
02-25 22:56:12.721+0900 I/CAPI_APPFW_APPLICATION(18408): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
02-25 22:56:12.781+0900 I/TAG11_db_read(18408): 1
02-25 22:56:12.781+0900 I/TAG11_db_read(18408): 1
02-25 22:56:12.781+0900 I/TAG11_db_read(18408): 2
02-25 22:56:12.781+0900 I/TAG11_db_read(18408): 2
02-25 22:56:12.781+0900 I/TAG11_db_read(18408): 3
02-25 22:56:12.781+0900 I/TAG11_db_read(18408): 3
02-25 22:56:12.781+0900 D/LAUNCH  (18408): appcore-efl.c: __before_loop(1154) > [recipes:Application:create:done]
02-25 22:56:12.781+0900 E/E17     ( 2865): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x01e00002)
02-25 22:56:12.781+0900 E/E17     ( 2865): e_border.c: e_border_show(2088) > BD_SHOW(0x01e00002)
02-25 22:56:12.801+0900 D/APP_CORE(18408): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
02-25 22:56:12.801+0900 W/PROCESSMGR( 2865): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=18408
02-25 22:56:12.801+0900 D/AUL_PAD ( 2961): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
02-25 22:56:12.801+0900 W/AUL     ( 2746): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 18408, appid: org.example.recipes
02-25 22:56:12.811+0900 D/AUL     ( 2746): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
02-25 22:56:12.811+0900 E/AUL     ( 2746): simple_util.c: __trm_app_info_send_socket(330) > access
02-25 22:56:12.811+0900 D/AUL_AMD ( 2746): amd_launch.c: _start_app(2700) > add app group info
02-25 22:56:12.811+0900 E/AUL     ( 2746): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
02-25 22:56:12.811+0900 D/AUL_AMD ( 2746): amd_status.c: _status_add_app_info_list(427) > pid(18408) appid(org.example.recipes) pkgid(org.example.recipes) comp(uiapp)
02-25 22:56:12.811+0900 D/RESOURCED( 2892): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.recipes, 18408
02-25 22:56:12.811+0900 D/RESOURCED( 2892): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.recipes with pkgname
02-25 22:56:12.811+0900 E/RESOURCED( 2892): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.recipes
02-25 22:56:12.811+0900 D/RESOURCED( 2892): proc-main.c: resourced_proc_status_change(888) > available memory = 294
02-25 22:56:12.811+0900 E/EFL     ( 2865): eo<2865> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
02-25 22:56:12.811+0900 E/EFL     ( 2865): eo<2865> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
02-25 22:56:12.821+0900 D/AUL_AMD ( 2746): amd_request.c: __request_handler(838) > __request_handler: 15
02-25 22:56:12.831+0900 D/PKGMGR_INFO( 2746): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.recipes/bin/recipes' and package_app_info.app_disable IN ('false','False')
02-25 22:56:12.831+0900 D/PKGMGR_INFO( 2746): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.recipes/bin/recipes' and package_app_info.app_disable IN ('false','False')
02-25 22:56:12.831+0900 D/INDICATOR( 2896): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
02-25 22:56:12.831+0900 D/INDICATOR( 2896): util.c: util_signal_emit_by_win(116) > emission bg.opaque
02-25 22:56:12.831+0900 D/INDICATOR( 2896): main.c: _rotate_window(229) > Indicator angle is 0 degree
02-25 22:56:12.831+0900 D/INDICATOR( 2896): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
02-25 22:56:12.831+0900 D/INDICATOR( 2896): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
02-25 22:56:12.831+0900 D/INDICATOR( 2896): main.c: _rotate_window(252) > port :: hide more icon
02-25 22:56:12.831+0900 D/AUL_AMD ( 2746): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 18408 is org.example.recipes
02-25 22:56:12.831+0900 D/AUL_AMD ( 2746): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 18408 : 0
02-25 22:56:12.831+0900 D/AUL     ( 2990): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
02-25 22:56:12.831+0900 D/APP_CORE(18408): appcore.c: __aul_handler(587) > [APP 18408]     AUL event: AUL_START
02-25 22:56:12.831+0900 I/APP_CORE(18408): appcore-efl.c: __do_app(496) > [APP 18408] Event: RESET State: CREATED
02-25 22:56:12.831+0900 D/APP_CORE(18408): appcore-efl.c: __do_app(527) > [APP 18408] RESET
02-25 22:56:12.831+0900 D/LAUNCH  (18408): appcore-efl.c: __do_app(529) > [recipes:Application:reset:start]
02-25 22:56:12.831+0900 D/APP_CORE(18408): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
02-25 22:56:12.831+0900 D/APP_CORE(18408): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
02-25 22:56:12.831+0900 I/CAPI_APPFW_APPLICATION(18408): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
02-25 22:56:12.831+0900 D/AUL     (18408): service.c: __set_bundle(186) > __set_bundle
02-25 22:56:12.831+0900 D/LAUNCH  (18408): appcore-efl.c: __do_app(544) > [recipes:Application:reset:done]
02-25 22:56:12.831+0900 D/APP_CORE(18408): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
02-25 22:56:12.831+0900 E/EFL     (18408): edje<18408> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
02-25 22:56:12.831+0900 E/EFL     (18408): By the power of Grayskull, your previous Embryo stack is now broken!
02-25 22:56:12.841+0900 E/EFL     (18408): edje<18408> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
02-25 22:56:12.841+0900 E/EFL     (18408): By the power of Grayskull, your previous Embryo stack is now broken!
02-25 22:56:12.841+0900 E/EFL     (18408): edje<18408> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
02-25 22:56:12.841+0900 E/EFL     (18408): By the power of Grayskull, your previous Embryo stack is now broken!
02-25 22:56:12.841+0900 E/EFL     (18408): edje<18408> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
02-25 22:56:12.841+0900 E/EFL     (18408): By the power of Grayskull, your previous Embryo stack is now broken!
02-25 22:56:12.841+0900 E/EFL     (18408): edje<18408> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
02-25 22:56:12.841+0900 E/EFL     (18408): By the power of Grayskull, your previous Embryo stack is now broken!
02-25 22:56:12.841+0900 W/APP_CORE(18408): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1e00002
02-25 22:56:12.841+0900 D/APP_CORE(18408): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:1e00002
02-25 22:56:12.841+0900 D/APP_CORE(18408): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
02-25 22:56:12.841+0900 D/AUL     (18408): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
02-25 22:56:12.841+0900 D/AUL_AMD ( 2746): amd_request.c: __request_handler(838) > __request_handler: 34
02-25 22:56:12.991+0900 E/PKGMGR_SERVER(18573): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
02-25 22:56:12.991+0900 E/PKGMGR_SERVER(18573): pkgmgr-server.c: main(2265) > package manager server terminated.
02-25 22:56:13.711+0900 D/APP_CORE(18408): appcore.c: __prt_ltime(236) > [APP 18408] first idle after reset: 1010 msec
02-25 22:56:13.811+0900 D/AUL_AMD ( 2746): amd_launch.c: __grab_timeout_handler(1445) > pid(18408) ecore_x_pointer_ungrab
02-25 22:56:13.811+0900 D/AUL_AMD ( 2746): amd_key.c: _key_ungrab(265) > _key_ungrab, win : 600002
02-25 22:56:13.811+0900 D/AUL_PAD ( 2961): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
02-25 22:56:13.831+0900 D/AUL_PAD (18637): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
02-25 22:56:13.841+0900 D/AUL_PAD ( 2961): sigchild.h: __send_app_launch_signal(131) > send launch signal done
02-25 22:56:13.971+0900 W/AUL_AMD ( 2746): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
02-25 22:56:13.971+0900 W/AUL_AMD ( 2746): amd_launch.c: __grab_timeout_handler(1447) > back key ungrab error
02-25 22:56:14.311+0900 D/AUL_AMD ( 2746): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.recipes /opt/usr/apps/org.example.recipes/bin/recipes
02-25 22:56:14.311+0900 D/RUA     ( 2746): rua.c: rua_add_history(179) > rua_add_history start
02-25 22:56:14.321+0900 D/RUA     ( 2746): rua.c: rua_add_history(247) > rua_add_history ok
02-25 22:56:14.511+0900 E/E17     ( 2865): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
02-25 22:56:14.531+0900 D/APP_CORE(18408): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1e00002 fully_obscured 0
02-25 22:56:14.531+0900 D/APP_CORE(18408): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
02-25 22:56:14.531+0900 D/APP_CORE(18408): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
02-25 22:56:14.531+0900 I/APP_CORE(18408): appcore-efl.c: __do_app(496) > [APP 18408] Event: RESUME State: CREATED
02-25 22:56:14.531+0900 D/LAUNCH  (18408): appcore-efl.c: __do_app(597) > [recipes:Application:resume:start]
02-25 22:56:14.531+0900 D/APP_CORE(18408): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
02-25 22:56:14.531+0900 D/APP_CORE(18408): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
02-25 22:56:14.531+0900 D/APP_CORE(18408): appcore-efl.c: __do_app(607) > [APP 18408] RESUME
02-25 22:56:14.531+0900 I/APP_CORE(18408): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
02-25 22:56:14.531+0900 I/APP_CORE(18408): appcore-efl.c: __do_app(614) > [APP 18408] Initial Launching, call the resume_cb
02-25 22:56:14.531+0900 I/CAPI_APPFW_APPLICATION(18408): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
02-25 22:56:14.531+0900 D/LAUNCH  (18408): appcore-efl.c: __do_app(636) > [recipes:Application:resume:done]
02-25 22:56:14.531+0900 D/LAUNCH  (18408): appcore-efl.c: __do_app(638) > [recipes:Application:Launching:done]
02-25 22:56:14.531+0900 D/APP_CORE(18408): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
02-25 22:56:14.531+0900 E/APP_CORE(18408): appcore-efl.c: __trm_app_info_send_socket(242) > access
02-25 22:56:14.531+0900 D/APP_CORE( 2915): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
02-25 22:56:14.531+0900 D/APP_CORE( 2915): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
02-25 22:56:14.531+0900 D/APP_CORE( 2915): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
02-25 22:56:14.531+0900 I/APP_CORE( 2915): appcore-efl.c: __do_app(496) > [APP 2915] Event: PAUSE State: RUNNING
02-25 22:56:14.531+0900 D/APP_CORE( 2915): appcore-efl.c: __do_app(565) > [APP 2915] PAUSE
02-25 22:56:14.531+0900 I/CAPI_APPFW_APPLICATION( 2915): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
02-25 22:56:14.531+0900 E/cluster-home( 2915): homescreen.cpp: OnPause(84) >  app pause
02-25 22:56:14.531+0900 D/cluster-view( 2915): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
02-25 22:56:14.531+0900 D/cluster-view( 2915): homescreen-view-manager.cpp: AppPause(923) >  END
02-25 22:56:14.531+0900 D/APP_CORE( 2915): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
02-25 22:56:14.531+0900 E/APP_CORE( 2915): appcore-efl.c: __trm_app_info_send_socket(242) > access
02-25 22:56:14.531+0900 D/AUL_AMD ( 2746): amd_status.c: _status_update_app_info_list(456) > pid(2915) status(4)
02-25 22:56:14.531+0900 D/AUL_AMD ( 2746): amd_status.c: _status_update_app_info_list(468) > pid(2915) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
02-25 22:56:14.531+0900 D/AUL     ( 2746): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
02-25 22:56:14.531+0900 W/AUL     ( 2746): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2915, appid: org.tizen.homescreen, status: bg
02-25 22:56:14.531+0900 D/AUL_AMD ( 2746): amd_launch.c: __e17_status_handler(2891) > pid(18408) status(3)
02-25 22:56:14.531+0900 D/AUL_AMD ( 2746): amd_key.c: _key_ungrab(265) > _key_ungrab, win : 600002
02-25 22:56:14.771+0900 W/AUL_AMD ( 2746): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
02-25 22:56:14.771+0900 W/AUL_AMD ( 2746): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
02-25 22:56:14.771+0900 D/AUL_AMD ( 2746): amd_status.c: _status_update_app_info_list(456) > pid(18408) status(3)
02-25 22:56:14.771+0900 D/AUL_AMD ( 2746): amd_status.c: _status_update_app_info_list(468) > pid(18408) appid(org.example.recipes) pkgid(org.example.recipes) status(3)
02-25 22:56:14.771+0900 D/AUL     ( 2746): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.recipes
02-25 22:56:14.771+0900 W/AUL     ( 2746): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 18408, appid: org.example.recipes, status: fg
02-25 22:56:14.771+0900 D/RESOURCED( 2892): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 18408
02-25 22:56:14.771+0900 D/RESOURCED( 2892): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 18408, proc_name: org.example.recipes, cg_name: foreground, oom_score_adj: 200
02-25 22:56:14.771+0900 D/RESOURCED( 2892): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 18408
02-25 22:56:14.801+0900 D/RESOURCED( 2892): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 18408, appname = org.example.recipes, pkgname = org.example.recipes
02-25 22:56:14.801+0900 D/RESOURCED( 2892): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 18408, appname = org.example.recipes
02-25 22:56:14.801+0900 D/RESOURCED( 2892): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 18408
02-25 22:56:14.801+0900 I/RESOURCED( 2892): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
02-25 22:56:14.801+0900 I/RESOURCED( 2892): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
02-25 22:56:14.851+0900 D/AUL_PAD (18637): launchpad_loader.c: main(588) > sleeping 1 sec...
02-25 22:56:14.851+0900 D/AUL_PAD (18637): preload.h: __preload_init(52) > max_cmdline_size = 1053
02-25 22:56:14.851+0900 D/AUL_PAD (18637): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b94f1760
02-25 22:56:14.861+0900 D/AUL_PAD (18637): preload.h: __preload_init(69) > get pre-initialization function
02-25 22:56:14.861+0900 D/AUL_PAD (18637): preload.h: __preload_init(73) > get shutdown function
02-25 22:56:14.861+0900 D/AUL_PAD (18637): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b94f1a40
02-25 22:56:14.861+0900 D/AUL_PAD (18637): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b94f3640
02-25 22:56:14.861+0900 D/AUL_PAD (18637): preload.h: __preload_init(69) > get pre-initialization function
02-25 22:56:14.861+0900 D/AUL_PAD (18637): preload.h: __preload_init(73) > get shutdown function
02-25 22:56:14.871+0900 D/AUL_PAD (18637): preexec.h: __preexec_init(76) > preexec start
02-25 22:56:14.881+0900 D/AUL_PAD (18637): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
02-25 22:56:14.881+0900 D/AUL     (18637): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
02-25 22:56:14.881+0900 D/AUL     (18637): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
02-25 22:56:14.881+0900 D/AUL     (18637): process_pool.c: __connect_to_launchpad(132) > send(18637) : 4
02-25 22:56:14.881+0900 D/AUL     (18637): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
02-25 22:56:14.881+0900 D/AUL_PAD ( 2961): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
02-25 22:56:14.881+0900 D/AUL_PAD ( 2961): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
02-25 22:56:14.881+0900 D/AUL_PAD ( 2961): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
02-25 22:56:14.881+0900 D/AUL_PAD ( 2961): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
02-25 22:56:14.881+0900 D/AUL_PAD ( 2961): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
02-25 22:56:14.881+0900 D/AUL_PAD ( 2961): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
02-25 22:56:14.881+0900 D/AUL_PAD ( 2961): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
02-25 22:56:14.881+0900 D/AUL_PAD ( 2961): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
02-25 22:56:14.881+0900 D/AUL_PAD ( 2961): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 18637
02-25 22:56:15.051+0900 D/AUL_AMD ( 2746): amd_launch.c: __e17_status_handler(2910) > pid(18408) status(0)
02-25 22:56:15.051+0900 D/DATA_PROVIDER_MASTER( 2963): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2915 is paused
02-25 22:56:15.051+0900 D/DATA_PROVIDER_MASTER( 2963): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
02-25 22:56:15.051+0900 I/CAPI_WIDGET_APPLICATION( 3064): widget_app.c: __provider_pause_cb(294) > widget obj was paused
02-25 22:56:15.051+0900 I/CAPI_WIDGET_APPLICATION( 3064): widget_app.c: __check_status_for_cgroup(142) > enter background group
02-25 22:56:15.051+0900 W/AUL     ( 3064): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3064, appid: org.tizen.calendar.widget, status: bg
02-25 22:56:15.051+0900 D/RESOURCED( 2892): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3064, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
02-25 22:56:15.051+0900 D/RESOURCED( 2892): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3064
02-25 22:56:15.051+0900 D/RESOURCED( 2892): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3064, appname = org.tizen.calendar.widget
02-25 22:56:15.051+0900 D/RESOURCED( 2892): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3064
02-25 22:56:15.081+0900 D/AUL_PAD (18637): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
02-25 22:56:15.081+0900 D/AUL_PAD (18637): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
02-25 22:56:15.081+0900 D/AUL_PAD (18637): launchpad_loader.c: main(693) > [candidate] ecore handler add
02-25 22:56:15.081+0900 D/AUL_PAD (18637): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
02-25 22:56:19.401+0900 E/CAPI_NETWORK_WIFI( 2896): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
02-25 22:56:19.401+0900 E/INDICATOR( 2896): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
02-25 22:56:19.401+0900 E/INDICATOR( 2896): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
02-25 22:56:19.401+0900 E/INDICATOR( 2896): 
02-25 22:56:19.541+0900 D/APP_CORE( 2915): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
02-25 22:56:19.541+0900 I/APP_CORE( 2915): appcore-efl.c: __do_app(496) > [APP 2915] Event: MEM_FLUSH State: PAUSED
02-25 22:56:19.541+0900 D/APP_CORE( 2915): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
02-25 22:56:19.541+0900 D/APP_CORE( 2915): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2915
02-25 22:56:19.541+0900 D/APP_CORE( 2915): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
02-25 22:56:19.541+0900 D/RESOURCED( 2892): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2915
02-25 22:56:27.731+0900 I/TAG11   (18408): 
02-25 22:56:27.741+0900 D/PROCESSMGR( 2865): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x203041 
02-25 22:56:27.801+0900 E/EFL     ( 2865): eo<2865> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
02-25 22:56:27.801+0900 D/AUL_PAD ( 2961): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
02-25 22:56:27.801+0900 D/AUL_PAD ( 2961): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
02-25 22:56:27.801+0900 D/AUL_PAD ( 2961): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
02-25 22:56:27.801+0900 D/AUL_PAD ( 2961): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
02-25 22:56:27.801+0900 D/AUL_PAD ( 2961): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
02-25 22:56:27.801+0900 D/AUL_PAD ( 2961): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
02-25 22:56:27.801+0900 D/AUL_PAD ( 2961): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
02-25 22:56:27.801+0900 I/AUL_PAD ( 2961): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 18408 pgid = 18408
02-25 22:56:27.801+0900 I/AUL_PAD ( 2961): sigchild.h: __sigchild_action(142) > dead_pid(18408)
02-25 22:56:27.801+0900 W/CRASH_MANAGER(18639): worker.c: worker_job(1204) > 1118408726563148803098
