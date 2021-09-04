---
layout: home
permalink: /
---

## Welcome

---

This is a place where the snippets are stored for my blogs.

### Search

---

If you have a snippet name and language you can search it
[here]({{ '/search.html' | relative_url}}).

### Languages

Here all the languages in the repo.

---

{% for item in site.data.language %}

#### [{{ item.name }}]({{ item.link | relative_url }})

{% endfor %}

### License

---

See the [about page]({{ "/about.html" | relative_url }}) for more info.
