---
# Feel free to add content and custom Front Matter to this file.
# To modify the layout, see https://jekyllrb.com/docs/themes/#overriding-theme-defaults

layout: home
permalink: /
---

# Welcome

---

This is a place where the snippets are stored for my blogs.

## Languages

Here all the languages in the repo.

---

{% for item in site.data.language %}

### [{{ item.name }}]({{ item.link | relative_url }})

{% endfor %}

## License

---

See the [about page]({{ "/about.html" | relative_url }}) for more info.
