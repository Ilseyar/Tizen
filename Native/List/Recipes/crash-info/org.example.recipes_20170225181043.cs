S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160504.2021
Build-Date: 2016.05.04 20:21:45

Crash Information
Process Name: recipes
PID: 9725
Date: 2017-02-25 18:10:43+0900
Executable File Path: /opt/usr/apps/org.example.recipes/bin/recipes
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x69706531

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb6cb63b0, esi = 0x69706531
ebp = 0xb901d758, esp = 0xbf91760c
eax = 0xbf9178a8, ebx = 0xb6e4a000
ecx = 0x00000000, edx = 0x69706531
eip = 0xb6d3a104

Memory Information
MemTotal:      123 KB
MemFree:        23 KB
Buffers:         8 KB
Cached:     184744 KB
VmPeak:      90632 KB
VmSize:      90632 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       17384 KB
VmRSS:       17384 KB
VmData:      28892 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33428 KB
VmPTE:          72 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 9725 TID = 9725
9725 9747 9937 9938 

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

Callstack Information (PID:9725)
Call Stack Count: 2
 0: (0xb6d3a104) [/lib/libc.so.6] + 0xa1104
 1: ((nil)) (null)
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
d=[org.example.recipes], key=[install_percent], value=[30]
02-25 18:10:41.616+0900 D/DATA_PROVIDER_MASTER( 2963): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.recipes] 30
02-25 18:10:41.616+0900 D/PKGMGR  ( 2960): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_946970514], pkg_type=[tpk], pkgid=[org.example.recipes], key=[install_percent], value=[30]
02-25 18:10:41.616+0900 D/ESD     ( 2960): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29600002), pkg_type(tpk), pkgid(org.example.recipes), key(install_percent), val(30)
02-25 18:10:41.626+0900 D/CERT_SVC( 9881): cert-service.c: _cert_svc_verify_certificate_with_caflag(188) > [SECURE_LOG] root cert path : /usr/share/cert-svc/certs/code-signing/tizen/Tizen_Developers_Root_Class.pem
02-25 18:10:41.626+0900 D/rpm-installer( 9881): rpm-installer.c: _ri_verify_sig_and_cert(1744) > cert_svc_verify() is done successfully. validity=[1]
02-25 18:10:41.626+0900 D/rpm-installer( 9881): rpm-installer.c: _ri_verify_sig_and_cert(1758) > cert_svc_get_visibility() returns visibility=[1]
02-25 18:10:41.626+0900 D/rpm-installer( 9881): rpm-installer.c: _ri_verify_sig_and_cert(1771) > Root CA cert path=[/usr/share/cert-svc/certs/code-signing/tizen/Tizen_Developers_Root_Class.pem]
02-25 18:10:41.636+0900 D/rpm-installer( 9881): rpm-installer.c: __ri_verify_file(336) > valid signature
02-25 18:10:41.636+0900 D/rpm-installer( 9881): rpm-installer.c: __ri_get_cert_from_file(1029) > Root CA, len=[1136]
02-25 18:10:41.636+0900 D/rpm-installer( 9881): MIIDTzCCAjegAwIBAgIJALddlYde0wE9MA0GCSqGSIb3DQEBCwUAMF4xGjAYBgNVBAoMEVRpemVuIEFzc29jaWF0aW9uMRowGAYDVQQLDBFUaXplbiBBc3NvY2lhdGlvbjEkMCIGA1UEAwwbVGl6ZW4gRGV2ZWxvcGVycyBSb290IENsYXNzMB4XDTEzMTIzMDE1MDQxMFoXDTMzMTIyNTE1MDQxMFowXjEaMBgGA1UECgwRVGl6ZW4gQXNzb2NpYXRpb24xGjAYBgNVBAsMEVRpemVuIEFzc29jaWF0aW9uMSQwIgYDVQQDDBtUaXplbiBEZXZlbG9wZXJzIFJvb3QgQ2xhc3MwggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEKAoIBAQDRUet02YnWItxNZzZc+o2WqH3LrJh70mCY/B9jlw9ckKKABD39glT17KaW+ZKFyN9M3h/wd2SU5g3CkwMMNOIrFLTB3YryR/aH+3ps6c8RqSUJG+6klFOaXuiG0kCzxvwVA+T+8z7zZKeBj6D6AooA6BpKgflu9J94KQqT3/y5IABQLm3SrB4iclabdT3Y+ZEBz63yNcHqJTpjqQw/wB3LV5a0i/Y/MjPn8Oogkgh/edJvIklUXcZC5Ac1tYB+ZZLKvROqUrPyzFOyPMU/EnoXRYX+PBiLtG+34o0Orw31Ifjs/r0AFs5qsLjR37YB9x5IWSwfTJuZcSPtyO1nDeNDAgMBAAGjEDAOMAwGA1UdEwQFMAMBAf8wDQYJKoZIhvcNAQELBQADggEBAJ60YDkQ8IPBZoamDMoxkNlKFxv5azN7eeD5nO1h9ASzz3HI5wa9Iry67l0MBjio3caLHjCnV9KzllXMBNCL6Dv0fBpFUadU57lfX5raH7ELGlpplyj1aVQlHm3zvF8eXGu6zmdS0Vdw/NOGaNuIwm/xUUCkeJyPWM
02-25 18:10:41.636+0900 D/rpm-installer( 9881): coretpk-installer.c: _coretpk_installer_verify_signatures(1274) > _ri_verify_sig_and_cert(/opt/usr/apps/org.example.recipes/author-signature.xml) succeed.
02-25 18:10:41.636+0900 D/rpm-installer( 9881): rpm-installer-signature.c: _ri_process_signaturevalue(533) > SignatureValue, len=[350]
02-25 18:10:41.636+0900 D/rpm-installer( 9881): 
02-25 18:10:41.636+0900 D/rpm-installer( 9881): ao1HDujzos1ofuA2PwIP2KxG/aWa05T4b9z7InC4GDnyoyb+nxPcJhzYFPjt/VK8rRALF0C0qP78
02-25 18:10:41.636+0900 D/rpm-installer( 9881): txuOjeBpzO8Xf8s7edJ7AUfUbq32Sixx1KP0Srcbz6aniqHC/D51xa6JR5oBkqB4ONJ2chw2H74n
02-25 18:10:41.636+0900 D/rpm-installer( 9881): n7H6JTKJszEgqwLWWiSEJQPyArKXMxxzMQqjctJ0VxMpVH5/rnS6W/PluNhXIm6R3es2fFLQXsKX
02-25 18:10:41.636+0900 D/rpm-installer( 9881): 4xCLO9xlM6PjUMSJYxcjqgdpO/2xj1UagMFH6kWd/uwN3k/343WkPWF+odBXwTMUeRhpUTLKuAqi
02-25 18:10:41.636+0900 D/rpm-installer( 9881): u9NceVpH5e3mXomnONhDN+NFwdsBiS0cHduHzw==
02-25 18:10:41.636+0900 D/rpm-installer( 9881): rpm-installer-signature.c: _ri_process_x509certificate(441) > x509certificate, len=[1270]
02-25 18:10:41.636+0900 D/rpm-installer( 9881): 
02-25 18:10:41.636+0900 D/rpm-installer( 9881): MIIDpzCCAo+gAwIBAgIBZTANBgkqhkiG9w0BAQsFADCBnjELMAkGA1UEBhMCS1IxFDASBgNVBAgM
02-25 18:10:41.636+0900 D/rpm-installer( 9881): C1NvdXRoIEtvcmVhMQ4wDAYDVQQHDAVTdXdvbjEmMCQGA1UECgwdU2Ftc3VuZyBFbGVjdHJvbmlj
02-25 18:10:41.636+0900 D/rpm-installer( 9881): cyBDby4sIEx0ZC4xDzANBgNVBAsMBk1vYmlsZTEwMC4GA1UEAwwnU2Ftc3VuZyBUaXplbiBERVZF
02-25 18:10:41.636+0900 D/rpm-installer( 9881): TE9QRVIgUHVibGljIENBIENsYXNzMB4XDTE3MDIxODA5NTIyOFoXDTE4MDIxODA5NTIyOFowczER
02-25 18:10:41.636+0900 D/rpm-installer( 9881): MA8GA1UEAwwIVGl6ZW5TREsxCTAHBgNVBAsMADEJMAcGA1UECgwAMQkwBwYDVQQHDAAxCTAHBgNV
02-25 18:10:41.636+0900 D/rpm-installer( 9881): BAgMADEJMAcGA1UEBhMAMScwJQYJKoZIhvcNAQkBFhhhbGltb3ZhaWxzZXlhckBnbWFpbC5jb20w
02-25 18:10:41.636+0900 D/rpm-installer( 9881): ggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEKAoIBAQCkGgqRTO5j7J20BgwotN1u/wWW+Qnuvpw6
02-25 18:10:41.636+0900 D/rpm-installer( 9881): 3Nr66RjPSw4oyYGbEiwAYE3YeIJG2UAmWB7EUloiUwtyOCkboiMowNIQpjtjO7ly8vmr9df36yh9
02-25 18:10:41.636+0900 D/rpm-installer( 9881): ijyWY9wyckOMb7XOT6TErgPrv4m6B7UYBbmtFbOqJzIVOk24Q39wW620uLV9z/wyulUO0tOG82Vh
02-25 18:10:41.636+0900 D/rpm-installer( 9881): eRvdLH1H3k8a4ursmXgv+yewnr9yPsCOVmvOdMk7CG+SvK8itE2vPniHZ7uuP8zyXajNSznKzAgd
02-25 18:10:41.636+0900 D/rpm-installer( 9881): Ep0BNb9ce1uTSNbHoeiAWga/B7NaKSwZsldfHe/we95sULuej1Dkh5W4hAtH+7l53eajhbvgkxKS
02-25 18:10:41.636+0900 D/rpm-installer( 9881): BzdnAgMBAAGjGjAYMAkGA1UdEwQCMAAwCwYDVR0PBAQDAgeAMA0GCSqGSIb3DQEBCwUAA4IBAQA4
02-25 18:10:41.636+0900 D/rpm-installer( 9881): 42U7oPzJ
02-25 18:10:41.636+0900 D/rpm-installer( 9881): rpm-installer-signature.c: _ri_process_x509certificate(441) > x509certificate, len=[1298]
02-25 18:10:41.636+0900 D/rpm-installer( 9881): 
02-25 18:10:41.636+0900 D/rpm-installer( 9881): MIIDuzCCAqOgAwIBAgICL+cwDQYJKoZIhvcNAQELBQAwgY8xCzAJBgNVBAYTAktSMRQwEgYDVQQI
02-25 18:10:41.636+0900 D/rpm-installer( 9881): DAtTb3V0aCBLb3JlYTEOMAwGA1UEBwwFU3V3b24xJjAkBgNVBAoMHVNhbXN1bmcgRWxlY3Ryb25p
02-25 18:10:41.636+0900 D/rpm-installer( 9881): Y3MgQ28uLCBMdGQuMTIwMAYDVQQDDClTYW1zdW5nIFRpemVuIERFVkVMT1BFUiBQdWJsaWMgUm9v
02-25 18:10:41.636+0900 D/rpm-installer( 9881): dCBDbGFzczAeFw0xMzEyMzAxNTAxNDdaFw0yODEyMjYxNTAxNDdaMIGeMQswCQYDVQQGEwJLUjEU
02-25 18:10:41.636+0900 D/rpm-installer( 9881): MBIGA1UECAwLU291dGggS29yZWExDjAMBgNVBAcMBVN1d29uMSYwJAYDVQQKDB1TYW1zdW5nIEVs
02-25 18:10:41.636+0900 D/rpm-installer( 9881): ZWN0cm9uaWNzIENvLiwgTHRkLjEPMA0GA1UECwwGTW9iaWxlMTAwLgYDVQQDDCdTYW1zdW5nIFRp
02-25 18:10:41.636+0900 D/rpm-installer( 9881): emVuIERFVkVMT1BFUiBQdWJsaWMgQ0EgQ2xhc3MwggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEK
02-25 18:10:41.636+0900 D/rpm-installer( 9881): AoIBAQCkqW9d0zO5NFOc7u164DKe9Yx+yEgUnsbhnJasqHaqT71qaMxyCOjyysZi7gGycDcgmLcU
02-25 18:10:41.636+0900 D/rpm-installer( 9881): tr2wSMTGWPibK8SrJ8bV/J1cy9nTpljM3s+lbPIVVxZeufhJkU79tXImHLolERd0vui+rj0Xpd9O
02-25 18:10:41.636+0900 D/rpm-installer( 9881): zlyNTRt0+PWVT1taWcbfHL7pUD25hMkTc8C3bC+dUoT1/RhCkXgmUvIor3EnnU0rBtAl4qNtg5y1
02-25 18:10:41.636+0900 D/rpm-installer( 9881): 7RLT8dyicieAHCcW923YC/ngMZxnBjbL2Ht1RBUvrL6K3X5+l0VeF4qC3g7TKm/a/SGjq12ZD4sc
02-25 18:10:41.636+0900 D/rpm-installer( 9881): 7rglzjSNlTVSGag6/2WkqxE6HheEBWaloYOdauzwydFNAgMBAAGjEDAOMAwGA1UdEwQFMAMBAf8w
02-25 18:10:41.636+0900 D/rpm-installer( 9881): DQYJKoZI
02-25 18:10:41.646+0900 D/CERT_SVC( 9881): cert-service.c: _cert_svc_verify_certificate_with_caflag(188) > [SECURE_LOG] root cert path : /usr/share/cert-svc/certs/code-signing/tizen/samsung_tizen_dev_public.pem
02-25 18:10:41.646+0900 D/rpm-installer( 9881): rpm-installer.c: _ri_verify_sig_and_cert(1744) > cert_svc_verify() is done successfully. validity=[1]
02-25 18:10:41.646+0900 D/rpm-installer( 9881): rpm-installer.c: _ri_verify_sig_and_cert(1758) > cert_svc_get_visibility() returns visibility=[64]
02-25 18:10:41.646+0900 D/rpm-installer( 9881): rpm-installer.c: _ri_verify_sig_and_cert(1771) > Root CA cert path=[/usr/share/cert-svc/certs/code-signing/tizen/samsung_tizen_dev_public.pem]
02-25 18:10:41.656+0900 D/rpm-installer( 9881): rpm-installer.c: __ri_verify_file(336) > valid signature
02-25 18:10:41.656+0900 D/rpm-installer( 9881): rpm-installer.c: __ri_get_cert_from_file(1029) > Root CA, len=[1268]
02-25 18:10:41.656+0900 D/rpm-installer( 9881): MIIDszCCApugAwIBAgIJALxYLI/Z7cqZMA0GCSqGSIb3DQEBCwUAMIGPMQswCQYDVQQGEwJLUjEUMBIGA1UECAwLU291dGggS29yZWExDjAMBgNVBAcMBVN1d29uMSYwJAYDVQQKDB1TYW1zdW5nIEVsZWN0cm9uaWNzIENvLiwgTHRkLjEyMDAGA1UEAwwpU2Ftc3VuZyBUaXplbiBERVZFTE9QRVIgUHVibGljIFJvb3QgQ2xhc3MwHhcNMTMxMjMwMTUwMTQyWhcNMzMxMjI1MTUwMTQyWjCBjzELMAkGA1UEBhMCS1IxFDASBgNVBAgMC1NvdXRoIEtvcmVhMQ4wDAYDVQQHDAVTdXdvbjEmMCQGA1UECgwdU2Ftc3VuZyBFbGVjdHJvbmljcyBDby4sIEx0ZC4xMjAwBgNVBAMMKVNhbXN1bmcgVGl6ZW4gREVWRUxPUEVSIFB1YmxpYyBSb290IENsYXNzMIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAsBOg6dthhkQ5vY5QW2KXyMb2bwKqHLUqRj1GkdcOVWJA+rxBnRlfYVVBJv9MCecrLkieriWfHB3Tcn9fIUnGtSzj2X7An5Qg05toNkjuS7B73Pb+eHZ2vEFNmFf+FQBc6KzCg+fSBa63BZg/lQg+l97gSKE1KFzU8D8INWJd/Yn6Uespvmcbyp3nlKakfleVdEsYOQ3HTevPfnoClRYsCI4R5/rFM4h6GzO2X8IEDhLgMc/Q8VWH/CoRkGwww7C//ofutdNs2WCF8FISyiSJq+sDXHlyGXKtZ+7ArKdLpe3xOZGGY2NJOV7H1v0vtJZeJSFPcoVd5csKgURu9v/7twIDAQABoxAwDjAMBgNVHRMEBTADAQH/MA0GCSqGSIb3DQEBCwUAA4IBAQBY+gZZPQ6MYkIrYB6JmaorVncOwy
02-25 18:10:41.656+0900 D/rpm-installer( 9881): coretpk-installer.c: _coretpk_installer_verify_signatures(1284) > _ri_verify_sig_and_cert(/opt/usr/apps/org.example.recipes/signature1.xml) succeed.
02-25 18:10:41.656+0900 D/rpm-installer( 9881): coretpk-installer.c: _coretpk_installer_package_reinstall(4980) > signature and certificate verifying success
02-25 18:10:41.656+0900 D/PKGMGR  ( 9881): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(9881), zone(host), pkg_typ(tpk), pkg_id(org.example.recipes), key(install_percent), val(60)
02-25 18:10:41.656+0900 D/PKGMGR  ( 9881): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(9881), pkg_typ(tpk), pkg_id(org.example.recipes), key(install_percent), val(60)
02-25 18:10:41.656+0900 D/PKGMGR  ( 9881): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr_status), signal_name(status)
02-25 18:10:41.656+0900 D/PKGMGR_INSTALLER( 9881): pkgmgr_installer.c: __send_event(112) > option is pkgid[org.example.recipes] key[install_percent] value[60]
02-25 18:10:41.656+0900 D/PKGMGR  ( 9881): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(9881), zone(host), pkg_typ(tpk), pkg_id(org.example.recipes), key(install_percent), val(60)
02-25 18:10:41.656+0900 D/PKGMGR  ( 9881): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(9881), pkg_typ(tpk), pkg_id(org.example.recipes), key(install_percent), val(60)
02-25 18:10:41.656+0900 D/PKGMGR  ( 9881): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr.install.progress), signal_name(install_progress)
02-25 18:10:41.656+0900 E/PKGMGR_CERT( 9881): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
02-25 18:10:41.656+0900 D/PKGMGR  ( 9876): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_946970514], pkg_type=[tpk], pkgid=[org.example.recipes], key=[install_percent], value=[60]
02-25 18:10:41.656+0900 D/PKGMGR  ( 2964): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_946970514], pkg_type=[tpk], pkgid=[org.example.recipes], key=[install_percent], value=[60]
02-25 18:10:41.656+0900 D/QUICKPANEL( 2964): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.recipes key:install_percent val:60
02-25 18:10:41.656+0900 D/PKGMGR  ( 2990): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_946970514], pkg_type=[tpk], pkgid=[org.example.recipes], key=[install_percent], value=[60]
02-25 18:10:41.656+0900 D/PKGMGR  ( 3082): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_946970514], pkg_type=[tpk], pkgid=[org.example.recipes], key=[install_percent], value=[60]
02-25 18:10:41.656+0900 D/PKGMGR  ( 2984): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_946970514], pkg_type=[tpk], pkgid=[org.example.recipes], key=[install_percent], value=[60]
02-25 18:10:41.656+0900 D/PKGMGR  ( 2984): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
02-25 18:10:41.656+0900 D/PKGMGR  ( 3129): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_946970514], pkg_type=[tpk], pkgid=[org.example.recipes], key=[install_percent], value=[60]
02-25 18:10:41.656+0900 D/PKGMGR  ( 2963): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_946970514], pkg_type=[tpk], pkgid=[org.example.recipes], key=[install_percent], value=[60]
02-25 18:10:41.656+0900 D/DATA_PROVIDER_MASTER( 2963): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.recipes] 60
02-25 18:10:41.656+0900 D/PKGMGR  ( 2915): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_946970514], pkg_type=[tpk], pkgid=[org.example.recipes], key=[install_percent], value=[60]
02-25 18:10:41.656+0900 W/cluster-home( 2915): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[1], package[org.example.recipes]
02-25 18:10:41.656+0900 D/PKGMGR  ( 2915): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_946970514], pkg_type=[tpk], pkgid=[org.example.recipes], key=[install_percent], value=[60]
02-25 18:10:41.656+0900 D/cluster-home( 2915): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29150003] pkg_type[tpk] package[org.example.recipes] key[install_percent] val[60] pmsg[(null)]
02-25 18:10:41.656+0900 D/PKGMGR  ( 2960): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_946970514], pkg_type=[tpk], pkgid=[org.example.recipes], key=[install_percent], value=[60]
02-25 18:10:41.656+0900 D/ESD     ( 2960): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29600002), pkg_type(tpk), pkgid(org.example.recipes), key(install_percent), val(60)
02-25 18:10:41.656+0900 E/PKGMGR_CERT( 9881): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 11 39
02-25 18:10:41.656+0900 E/PKGMGR_CERT( 9881): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 12 39
02-25 18:10:41.656+0900 E/PKGMGR_CERT( 9881): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 13 39
02-25 18:10:41.656+0900 E/PKGMGR_CERT( 9881): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 14 39
02-25 18:10:41.656+0900 E/PKGMGR_CERT( 9881): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 15 39
02-25 18:10:41.656+0900 E/PKGMGR_CERT( 9881): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 21 7
02-25 18:10:41.666+0900 E/PKGMGR_CERT( 9881): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
02-25 18:10:41.666+0900 D/rpm-installer( 9881): rpm-installer-privilege.c: _ri_privilege_unregister_package(85) > [smack] app_uninstall(org.example.recipes), result=[0]
02-25 18:10:41.676+0900 D/rpm-installer( 9881): rpm-installer-privilege.c: _ri_privilege_register_package(65) > [smack] app_install(org.example.recipes), result=[0]
02-25 18:10:41.676+0900 D/rpm-installer( 9881): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.recipes, /opt/usr/apps/org.example.recipes, 5, _), result=[0]
02-25 18:10:41.676+0900 D/rpm-installer( 9881): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.recipes, /opt/usr/apps/org.example.recipes/shared, 5, _), result=[0]
02-25 18:10:41.676+0900 D/rpm-installer( 9881): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.recipes, /opt/usr/apps/org.example.recipes/shared/res, 5, _), result=[0]
02-25 18:10:41.676+0900 D/rpm-installer( 9881): rpm-installer-privilege.c: _ri_privilege_setup_path(117) > [smack] app_setup_path(org.example.recipes, /opt/usr/apps/org.example.recipes/shared/data, 2), result=[0]
02-25 18:10:41.676+0900 D/rpm-installer( 9881): coretpk-installer.c: _coretpk_installer_get_smack_label_access(1101) > [smack] get_smack_label, path=[/opt/usr/apps/org.example.recipes/shared/data], label=[$1$org.exam$ZLEuicYOQpm3dB7I13Il7%]
02-25 18:10:41.676+0900 D/rpm-installer( 9881): coretpk-installer.c: _coretpk_installer_set_smack_label_access(1088) > [smack] set_smack_label, path=[/opt/usr/apps/org.example.recipes/shared/cache], label=[$1$org.exam$ZLEuicYOQpm3dB7I13Il7%]
02-25 18:10:41.676+0900 E/rpm-installer( 9881): installer-util.c: _installer_util_get_configuration_value(418) > [signature]=[on]
02-25 18:10:41.676+0900 D/rpm-installer( 9881): coretpk-installer.c: _coretpk_installer_get_group_id(2472) > encoding done, len=[28]
02-25 18:10:41.676+0900 D/rpm-installer( 9881): coretpk-installer.c: _coretpk_installer_apply_smack(2575) > groupid = [7fdx#xYCmY4C52shosJOkPoCnAg=] for shared/trusted.
02-25 18:10:41.676+0900 D/rpm-installer( 9881): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.recipes, /opt/usr/apps/org.example.recipes/shared/trusted, 1, 7fdx#xYCmY4C52shosJOkPoCnAg=), result=[0]
02-25 18:10:41.676+0900 D/rpm-installer( 9881): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.recipes, /opt/usr/apps/org.example.recipes/bin, 0, org.example.recipes), result=[0]
02-25 18:10:41.676+0900 D/rpm-installer( 9881): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.recipes, /opt/usr/apps/org.example.recipes/data, 0, org.example.recipes), result=[0]
02-25 18:10:41.676+0900 D/rpm-installer( 9881): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.recipes, /opt/usr/apps/org.example.recipes/lib, 0, org.example.recipes), result=[0]
02-25 18:10:41.686+0900 D/rpm-installer( 9881): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.recipes, /opt/usr/apps/org.example.recipes/res, 0, org.example.recipes), result=[0]
02-25 18:10:41.686+0900 D/rpm-installer( 9881): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.recipes, /opt/usr/apps/org.example.recipes/cache, 0, org.example.recipes), result=[0]
02-25 18:10:41.686+0900 D/rpm-installer( 9881): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.recipes, /opt/usr/apps/org.example.recipes/tizen-manifest.xml, 0, org.example.recipes), result=[0]
02-25 18:10:41.686+0900 D/rpm-installer( 9881): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.recipes, /opt/usr/apps/org.example.recipes/author-signature.xml, 0, org.example.recipes), result=[0]
02-25 18:10:41.686+0900 D/rpm-installer( 9881): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.recipes, /opt/usr/apps/org.example.recipes/signature1.xml, 0, org.example.recipes), result=[0]
02-25 18:10:41.686+0900 D/rpm-installer( 9881): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.recipes, /opt/share/packages/org.example.recipes.xml, 0, org.example.recipes), result=[0]
02-25 18:10:41.686+0900 D/rpm-installer( 9881): rpm-installer-privilege.c: _ri_privilege_set_package_version(75) > [smack] app[org.example.recipes] version set to [2.3] result=[0]
02-25 18:10:41.686+0900 D/rpm-installer( 9881): rpm-installer.c: _ri_apply_privilege(1924) > api-version[2.3] fot privilege has done successfully.
02-25 18:10:41.686+0900 D/rpm-installer( 9881): rpm-installer.c: __privilege_func(1046) > package_id=[org.example.recipes], privilege=[http://tizen.org/privilege/systemsettings]
02-25 18:10:41.686+0900 D/rpm-installer( 9881): rpm-installer-privilege.c: _ri_privilege_enable_permissions(106) > [smack] app_enable_permissions(org.example.recipes, 7), result=[0]
02-25 18:10:41.686+0900 D/rpm-installer( 9881): coretpk-installer.c: _coretpk_installer_package_reinstall(5083) > #permission applying success.
02-25 18:10:41.686+0900 D/PKGMGR  ( 9881): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(9881), zone(host), pkg_typ(tpk), pkg_id(org.example.recipes), key(install_percent), val(100)
02-25 18:10:41.686+0900 D/PKGMGR  ( 9881): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(9881), pkg_typ(tpk), pkg_id(org.example.recipes), key(install_percent), val(100)
02-25 18:10:41.686+0900 D/PKGMGR  ( 9881): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr_status), signal_name(status)
02-25 18:10:41.686+0900 D/PKGMGR_INSTALLER( 9881): pkgmgr_installer.c: __send_event(112) > option is pkgid[org.example.recipes] key[install_percent] value[100]
02-25 18:10:41.686+0900 D/PKGMGR  ( 9881): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(9881), zone(host), pkg_typ(tpk), pkg_id(org.example.recipes), key(install_percent), val(100)
02-25 18:10:41.686+0900 D/PKGMGR  ( 9881): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(9881), pkg_typ(tpk), pkg_id(org.example.recipes), key(install_percent), val(100)
02-25 18:10:41.686+0900 D/PKGMGR  ( 9881): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr.install.progress), signal_name(install_progress)
02-25 18:10:41.686+0900 D/rpm-installer( 9881): coretpk-installer.c: _coretpk_installer_package_reinstall(5096) > _coretpk_installer_package_reinstall(org.example.recipes) is done.
02-25 18:10:41.686+0900 D/PKGMGR  ( 9881): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(9881), zone(host), pkg_typ(tpk), pkg_id(org.example.recipes), key(end), val(ok)
02-25 18:10:41.686+0900 D/PKGMGR  ( 9881): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(9881), pkg_typ(tpk), pkg_id(org.example.recipes), key(end), val(ok)
02-25 18:10:41.686+0900 D/PKGMGR  ( 9881): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr_status), signal_name(status)
02-25 18:10:41.686+0900 D/PKGMGR_INSTALLER( 9881): pkgmgr_installer.c: __send_event(112) > option is pkgid[org.example.recipes] key[end] value[ok]
02-25 18:10:41.686+0900 D/PKGMGR  ( 9881): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(9881), zone(host), pkg_typ(tpk), pkg_id(org.example.recipes), key(end), val(ok)
02-25 18:10:41.686+0900 D/PKGMGR  ( 9881): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(9881), pkg_typ(tpk), pkg_id(org.example.recipes), key(end), val(ok)
02-25 18:10:41.686+0900 D/PKGMGR  ( 9881): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr.upgrade), signal_name(upgrade)
02-25 18:10:41.686+0900 D/PKGMGR  ( 9876): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_946970514], pkg_type=[tpk], pkgid=[org.example.recipes], key=[install_percent], value=[100]
02-25 18:10:41.686+0900 D/PKGMGR  ( 3129): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_946970514], pkg_type=[tpk], pkgid=[org.example.recipes], key=[install_percent], value=[100]
02-25 18:10:41.686+0900 D/PKGMGR  ( 3082): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_946970514], pkg_type=[tpk], pkgid=[org.example.recipes], key=[install_percent], value=[100]
02-25 18:10:41.686+0900 D/PKGMGR  ( 2964): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_946970514], pkg_type=[tpk], pkgid=[org.example.recipes], key=[install_percent], value=[100]
02-25 18:10:41.686+0900 D/QUICKPANEL( 2964): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.recipes key:install_percent val:100
02-25 18:10:41.696+0900 D/PKGMGR  ( 2915): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_946970514], pkg_type=[tpk], pkgid=[org.example.recipes], key=[install_percent], value=[100]
02-25 18:10:41.696+0900 W/cluster-home( 2915): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[1], package[org.example.recipes]
02-25 18:10:41.696+0900 D/PKGMGR  ( 2915): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_946970514], pkg_type=[tpk], pkgid=[org.example.recipes], key=[install_percent], value=[100]
02-25 18:10:41.696+0900 D/cluster-home( 2915): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29150003] pkg_type[tpk] package[org.example.recipes] key[install_percent] val[100] pmsg[(null)]
02-25 18:10:41.696+0900 D/PKGMGR  ( 2963): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_946970514], pkg_type=[tpk], pkgid=[org.example.recipes], key=[install_percent], value=[100]
02-25 18:10:41.696+0900 D/DATA_PROVIDER_MASTER( 2963): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.recipes] 100
02-25 18:10:41.696+0900 D/PKGMGR  ( 2984): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_946970514], pkg_type=[tpk], pkgid=[org.example.recipes], key=[install_percent], value=[100]
02-25 18:10:41.696+0900 D/PKGMGR  ( 2984): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
02-25 18:10:41.696+0900 D/PKGMGR  ( 2990): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_946970514], pkg_type=[tpk], pkgid=[org.example.recipes], key=[install_percent], value=[100]
02-25 18:10:41.696+0900 D/PKGMGR  ( 2960): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_946970514], pkg_type=[tpk], pkgid=[org.example.recipes], key=[install_percent], value=[100]
02-25 18:10:41.696+0900 D/ESD     ( 2960): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29600002), pkg_type(tpk), pkgid(org.example.recipes), key(install_percent), val(100)
02-25 18:10:41.696+0900 D/PKGMGR  ( 2990): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_946970514], pkg_type=[tpk], pkgid=[org.example.recipes], key=[end], value=[ok]
02-25 18:10:41.696+0900 D/PKGMGR  ( 2984): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_946970514], pkg_type=[tpk], pkgid=[org.example.recipes], key=[end], value=[ok]
02-25 18:10:41.696+0900 D/PKGMGR  ( 2984): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
02-25 18:10:41.696+0900 D/PKGMGR  ( 2963): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_946970514], pkg_type=[tpk], pkgid=[org.example.recipes], key=[end], value=[ok]
02-25 18:10:41.696+0900 D/DATA_PROVIDER_MASTER( 2963): pkgmgr.c: end_cb(409) > [SECURE_LOG] [org.example.recipes] ok
02-25 18:10:41.696+0900 D/DATA_PROVIDER_MASTER( 2963): notification_service.c: _invoke_package_change_event(916) > [SECURE_LOG] pkgname[org.example.recipes], event_type[1]
02-25 18:10:41.696+0900 D/DATA_PROVIDER_MASTER( 2963): notification_service.c: _invoke_package_change_event(945) > [SECURE_LOG] _invoke_package_change_event returns [0]
02-25 18:10:41.696+0900 D/PKGMGR  ( 2915): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_946970514], pkg_type=[tpk], pkgid=[org.example.recipes], key=[end], value=[ok]
02-25 18:10:41.696+0900 W/cluster-home( 2915): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[2], package[org.example.recipes]
02-25 18:10:41.696+0900 D/cluster-home( 2915): widget-data-provider.cpp: PackageUpdated(2160) >  No boxes that pkgname is[org.example.recipes]
02-25 18:10:41.696+0900 D/PKGMGR  ( 2915): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_946970514], pkg_type=[tpk], pkgid=[org.example.recipes], key=[end], value=[ok]
02-25 18:10:41.696+0900 D/cluster-home( 2915): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29150003] pkg_type[tpk] package[org.example.recipes] key[end] val[ok] pmsg[(null)]
02-25 18:10:41.696+0900 E/cluster-home( 2915): mainmenu-package-manager.cpp: OnClientListenCb(463) >  #Step 1
02-25 18:10:41.696+0900 E/cluster-home( 2915): mainmenu-package-manager.cpp: OnClientListenCb(467) >  #Step 2
02-25 18:10:41.696+0900 E/cluster-home( 2915): mainmenu-package-manager.cpp: _GetAppIds(334) >  BEGIN
02-25 18:10:41.696+0900 D/DATA_PROVIDER_MASTER( 2963): notification_service.c: service_thread_main(883) > [SECURE_LOG] (nil) PACKET_REQ_NOACK: Command: [package_install]
02-25 18:10:41.696+0900 D/DATA_PROVIDER_MASTER( 2963): notification_service.c: _handler_package_install(579) > [SECURE_LOG] _handler_package_install
02-25 18:10:41.696+0900 D/DATA_PROVIDER_MASTER( 2963): notification_service.c: _handler_package_install(581) > [SECURE_LOG] package_name [org.example.recipes]
02-25 18:10:41.696+0900 D/PKGMGR  ( 3082): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_946970514], pkg_type=[tpk], pkgid=[org.example.recipes], key=[end], value=[ok]
02-25 18:10:41.696+0900 D/PKGMGR  ( 2960): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_946970514], pkg_type=[tpk], pkgid=[org.example.recipes], key=[end], value=[ok]
02-25 18:10:41.696+0900 D/ESD     ( 2960): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29600002), pkg_type(tpk), pkgid(org.example.recipes), key(end), val(ok)
02-25 18:10:41.696+0900 D/ISF_PANEL_EFL( 3082): isf_panel_efl.cpp: _package_manager_event_cb(1288) > type=tpk package=org.example.recipes event_type=UPDATE event_state=COMPLETED progress=100 error=0
02-25 18:10:41.696+0900 D/ESD     ( 2960): esd_main.c: __esd_pkgmgr_event_callback(1728) > install end (ok)
02-25 18:10:41.696+0900 D/cluster-home( 2915): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(220) >  NoDisplay [0]
02-25 18:10:41.696+0900 D/cluster-home( 2915): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(225) >  app Id [org.example.recipes]
02-25 18:10:41.696+0900 E/cluster-home( 2915): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(236) >  ##### [org.example.recipes]
02-25 18:10:41.696+0900 E/cluster-home( 2915): mainmenu-package-manager.cpp: _GetAppIds(355) >  ##### [org.example.recipes]
02-25 18:10:41.696+0900 E/cluster-home( 2915): mainmenu-package-manager.cpp: _GetAppIds(359) >  END
02-25 18:10:41.696+0900 E/cluster-home( 2915): mainmenu-package-manager.cpp: _DoPkgJob(387) >  #Step 3 size[1]
02-25 18:10:41.696+0900 E/cluster-home( 2915): mainmenu-package-manager.cpp: _DoPkgJob(391) >  appId[org.example.recipes]
02-25 18:10:41.696+0900 D/PKGMGR  ( 3129): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_946970514], pkg_type=[tpk], pkgid=[org.example.recipes], key=[end], value=[ok]
02-25 18:10:41.696+0900 W/ISF_PANEL_EFL( 3082): isf_panel_efl.cpp: _package_manager_event_cb(1380) > isf_db_select_appids_by_pkgid returned 0.
02-25 18:10:41.696+0900 D/PKGMGR  ( 2964): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_946970514], pkg_type=[tpk], pkgid=[org.example.recipes], key=[end], value=[ok]
02-25 18:10:41.696+0900 D/QUICKPANEL( 2964): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.recipes key:end val:ok
02-25 18:10:41.696+0900 D/PKGMGR  ( 9876): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.recipes_946970514], pkg_type=[tpk], pkgid=[org.example.recipes], key=[end], value=[ok]
02-25 18:10:41.696+0900 E/cluster-home( 2915): mainmenu-package-manager.cpp: _GetAppInfo(848) >  AppId[org.example.recipes] Name[recipes] Icon[/opt/usr/apps/org.example.recipes/shared/res/recipes.png] enable[1] system[0]
02-25 18:10:41.696+0900 D/cluster-home( 2915): mainmenu-presenter.cpp: OnAppUpdated(337) >  pAppId [org.example.recipes]
02-25 18:10:41.696+0900 D/cluster-home( 2915): mainmenu-data-manager.cpp: GetBoxDataByAppId(1832) >  BEGIN, strAppId: org.example.recipes
02-25 18:10:41.696+0900 D/cluster-home( 2915): mainmenu-data-manager.cpp: GetBoxDataByAppId(1874) >  nId[580], isFolder[0], pageId[4], col[4], row[1], appId[org.example.recipes], name[recipes], menuId[1], isPreload[0] isPreload[0]
02-25 18:10:41.696+0900 D/cluster-home( 2915): mainmenu-data-manager.cpp: GetBoxDataByAppId(1881) >  DONE
02-25 18:10:41.696+0900 E/cluster-home( 2915): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.recipes] Name[recipes] Icon[/opt/usr/apps/org.example.recipes/shared/res/recipes.png] enable[1] system[0]
02-25 18:10:41.696+0900 D/cluster-home( 2915): mainmenu-presenter.cpp: OnAppUpdated(364) >  name [recipes]
02-25 18:10:41.696+0900 D/cluster-home( 2915): mainmenu-data-manager.cpp: GetMenuBoxData(1241) >  BEGIN
02-25 18:10:41.696+0900 D/cluster-home( 2915): mainmenu-data-manager.cpp: GetMenuBoxData(1291) >  DONE
02-25 18:10:41.696+0900 D/test-log( 2915): mainmenu-box-impl.cpp: UpdateBoxData(812) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.recipes/shared/res/recipes.png], New icon path[/opt/usr/apps/org.example.recipes/shared/res/recipes.png]!!!!!
02-25 18:10:41.696+0900 D/cluster-home( 2915): mainmenu-data-manager.cpp: UpdateBoxData(853) >  Query [UPDATE boxes set isFolder = 0, pageId = 4, appId = $appId, name = $name, col = 4, row = 1, isPreload = 0, isSystem = 0 WHERE boxId = 580]
02-25 18:10:41.706+0900 D/PKGMGR  ( 2746): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[upgrade], req_id=[org.example.recipes_946970514], pkg_type=[tpk], pkgid=[org.example.recipes], key=[end], value=[ok]
02-25 18:10:41.706+0900 D/AUL_AMD ( 2746): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(638) > [SECURE_LOG] pkgid(org.example.recipes), key(end), value(ok)
02-25 18:10:41.706+0900 W/AUL_AMD ( 2746): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(664) > [SECURE_LOG] op(update), value(ok)
02-25 18:10:41.706+0900 D/AUL_AMD ( 2746): amd_appinfo.c: __app_info_insert_handler(488) > [SECURE_LOG] appinfo file:org.example.recipes, type:rpm
02-25 18:10:42.106+0900 D/rpm-installer( 9881): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
02-25 18:10:42.106+0900 D/rpm-installer( 9881): rpm-appcore-intf.c: main(259) > ------------------------------------------------
02-25 18:10:42.106+0900 D/rpm-installer( 9881): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
02-25 18:10:42.106+0900 D/rpm-installer( 9881): rpm-appcore-intf.c: main(261) > ------------------------------------------------
02-25 18:10:42.106+0900 D/PKGMGR_SERVER( 9878): pkgmgr-server.c: sighandler(387) > child exit [9881]
02-25 18:10:42.106+0900 E/PKGMGR_SERVER( 9878): pkgmgr-server.c: sighandler(402) > child NORMAL exit [9881]
02-25 18:10:43.316+0900 D/AUL_AMD ( 2746): amd_request.c: __request_handler(838) > __request_handler: 0
02-25 18:10:43.316+0900 D/AUL_AMD ( 2746): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.recipes
02-25 18:10:43.316+0900 D/PKGMGR_INFO( 2746): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
02-25 18:10:43.316+0900 D/PKGMGR_INFO( 2746): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
02-25 18:10:43.316+0900 I/AUL     ( 2746): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
02-25 18:10:43.316+0900 D/AUL     ( 2746): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 9931, pid = 9933
02-25 18:10:43.316+0900 D/PKGMGR_INFO( 2746): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
02-25 18:10:43.316+0900 D/PKGMGR_INFO( 2746): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
02-25 18:10:43.326+0900 I/AUL     ( 2746): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
02-25 18:10:43.326+0900 E/AUL_AMD ( 2746): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
02-25 18:10:43.326+0900 W/AUL_AMD ( 2746): amd_launch.c: _start_app(2233) > caller pid : 9933
02-25 18:10:43.326+0900 E/AUL_AMD ( 2746): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
02-25 18:10:43.326+0900 W/AUL_AMD ( 2746): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.recipes) pkgid(org.example.recipes) attribute(200)
02-25 18:10:43.326+0900 D/AUL_AMD ( 2746): amd_launch.c: _start_app(2648) > process_pool: false
02-25 18:10:43.326+0900 D/AUL_AMD ( 2746): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
02-25 18:10:43.326+0900 D/AUL_AMD ( 2746): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.recipes
02-25 18:10:43.326+0900 W/AUL_AMD ( 2746): amd_launch.c: _start_app(2665) > pad pid(-5)
02-25 18:10:43.326+0900 D/AUL_AMD ( 2746): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
02-25 18:10:43.326+0900 D/AUL_AMD ( 2746): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
02-25 18:10:43.326+0900 D/AUL     ( 2746): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
02-25 18:10:43.326+0900 D/AUL_PAD ( 2961): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
02-25 18:10:43.326+0900 D/AUL_PAD ( 2961): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
02-25 18:10:43.326+0900 D/AUL_PAD ( 2961): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
02-25 18:10:43.326+0900 D/AUL_PAD ( 2961): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
02-25 18:10:43.326+0900 D/AUL_PAD ( 2961): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
02-25 18:10:43.326+0900 D/AUL_PAD ( 2961): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
02-25 18:10:43.326+0900 D/AUL_PAD ( 2961): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
02-25 18:10:43.326+0900 D/AUL_PAD ( 2961): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
02-25 18:10:43.326+0900 D/AUL_PAD ( 2961): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.recipes
02-25 18:10:43.326+0900 D/AUL_PAD ( 2961): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.recipes/bin/recipes
02-25 18:10:43.326+0900 D/AUL_PAD ( 2961): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
02-25 18:10:43.326+0900 D/AUL_PAD ( 2961): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
02-25 18:10:43.326+0900 D/AUL_PAD ( 2961): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
02-25 18:10:43.326+0900 D/AUL_PAD ( 2961): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
02-25 18:10:43.326+0900 W/AUL_PAD ( 2961): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
02-25 18:10:43.326+0900 D/AUL     ( 2961): process_pool.c: __send_pkt_raw_data(219) > send(12) : 620 / 620
02-25 18:10:43.326+0900 D/AUL_PAD ( 2961): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 9725, bin path: /opt/usr/apps/org.example.recipes/bin/recipes
02-25 18:10:43.326+0900 W/AUL_PAD ( 2961): launchpad.c: __send_result_to_caller(265) > Check app launching
02-25 18:10:43.326+0900 D/AUL_PAD ( 2961): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
02-25 18:10:43.326+0900 D/RESOURCED( 2892): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.recipes, pkgid = org.example.recipes, flags = 512
02-25 18:10:43.326+0900 D/RESOURCED( 2892): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.recipes, pkgname = org.example.recipes, ref = 1
02-25 18:10:43.326+0900 E/RESOURCED( 2892): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
02-25 18:10:43.326+0900 D/AUL_PAD ( 9725): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
02-25 18:10:43.326+0900 D/AUL_PAD ( 9725): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 620, pkt->len: 612
02-25 18:10:43.326+0900 D/AUL_PAD ( 9725): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.recipes, launchpad type: 0
02-25 18:10:43.326+0900 D/AUL_PAD ( 9725): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
02-25 18:10:43.326+0900 D/AUL_PAD ( 9725): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.recipes
02-25 18:10:43.326+0900 D/AUL_PAD ( 9725): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.recipes
02-25 18:10:43.326+0900 D/AUL     ( 9725): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (9747) is sent.
02-25 18:10:43.326+0900 D/AUL     ( 9725): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 9747, signo: 10
02-25 18:10:43.326+0900 D/AUL     ( 9725): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
02-25 18:10:43.326+0900 D/AUL_PAD ( 9725): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.recipes / pkg_type : rpm / app_path : /opt/usr/apps/org.example.recipes/bin/recipes
02-25 18:10:43.326+0900 D/AUL_PAD ( 9725): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.recipes/bin/recipes##
02-25 18:10:43.326+0900 D/AUL_PAD ( 9725): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
02-25 18:10:43.326+0900 D/AUL_PAD ( 9725): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
02-25 18:10:43.326+0900 D/AUL_PAD ( 9725): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0ODgwMTM4NDMvMzI2ODY5AA==##
02-25 18:10:43.326+0900 D/AUL_PAD ( 9725): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
02-25 18:10:43.326+0900 D/AUL_PAD ( 9725): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAA5OTMzAA==##
02-25 18:10:43.326+0900 D/AUL_PAD ( 9725): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
02-25 18:10:43.326+0900 D/AUL_PAD ( 9725): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
02-25 18:10:43.326+0900 D/AUL_PAD ( 9725): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.recipes/bin/recipes, real app argc: 8
02-25 18:10:43.326+0900 D/AUL_PAD ( 9725): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
02-25 18:10:43.326+0900 D/AUL_PAD ( 9725): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.recipes/bin/recipes)
02-25 18:10:43.336+0900 I/CAPI_APPFW_APPLICATION( 9725): app_main.c: ui_app_main(788) > app_efl_main
02-25 18:10:43.336+0900 D/LAUNCH  ( 9725): appcore-efl.c: appcore_efl_main(1692) > [recipes:Application:main:done]
02-25 18:10:43.336+0900 D/APP_CORE( 9725): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
02-25 18:10:43.336+0900 D/APP_CORE( 9725): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.recipes/res/locale
02-25 18:10:43.336+0900 D/APP_CORE( 9725): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
02-25 18:10:43.336+0900 D/APP_CORE( 9725): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
02-25 18:10:43.336+0900 D/AUL     ( 9725): app_sock.c: __create_server_sock(156) > pg path - already exists
02-25 18:10:43.336+0900 D/APP_CORE( 9725): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb42e7520
02-25 18:10:43.336+0900 D/LAUNCH  ( 9725): appcore-efl.c: __before_loop(1136) > [recipes:Platform:appcore_init:done]
02-25 18:10:43.346+0900 I/CAPI_APPFW_APPLICATION( 9725): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
02-25 18:10:43.426+0900 D/AUL_PAD ( 2961): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
02-25 18:10:43.426+0900 W/AUL     ( 2746): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 9725, appid: org.example.recipes
02-25 18:10:43.426+0900 D/AUL     ( 2746): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
02-25 18:10:43.426+0900 E/AUL     ( 2746): simple_util.c: __trm_app_info_send_socket(330) > access
02-25 18:10:43.426+0900 D/AUL_AMD ( 2746): amd_launch.c: _start_app(2700) > add app group info
02-25 18:10:43.426+0900 E/AUL     ( 2746): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
02-25 18:10:43.426+0900 D/AUL_AMD ( 2746): amd_status.c: _status_add_app_info_list(427) > pid(9725) appid(org.example.recipes) pkgid(org.example.recipes) comp(uiapp)
02-25 18:10:43.426+0900 D/RESOURCED( 2892): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.recipes, 9725
02-25 18:10:43.426+0900 D/RESOURCED( 2892): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.recipes with pkgname
02-25 18:10:43.426+0900 E/RESOURCED( 2892): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.recipes
02-25 18:10:43.426+0900 D/RESOURCED( 2892): proc-main.c: resourced_proc_status_change(888) > available memory = 305
02-25 18:10:43.466+0900 W/CRASH_MANAGER( 9939): worker.c: worker_job(1204) > 1109725726563148801384
