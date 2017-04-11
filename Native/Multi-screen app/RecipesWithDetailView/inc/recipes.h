#ifndef __recipes_H__
#define __recipes_H__

#include <app.h>
#include <Elementary.h>
#include <system_settings.h>
#include <efl_extension.h>
#include <dlog.h>

#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "recipes"

#if !defined(PACKAGE)
#define PACKAGE "org.example.recipes"
#endif

void recipes_detail_cb(void *data, Evas_Object *obj, void *event_info);
void my_box_pack(Evas_Object *box, Evas_Object *child, double h_weight,
		double v_weight, double h_align, double v_align);
void add_recipe_cb(void *data, Evas_Object *obj, void *event_info);
Evas_Object *nf;

#endif /* __recipes_H__ */
