# About 'Converter' branch
This branch is used to develop new app which helps translating minecraft BE RP lang file.

# How it works
Original lang file (ex. en)
```
item_id=an example item
```
Once translated lang file (ex.ja)
```
item_id=例のアイテム
```
This app will do below steps.
1. Compare above two files' difference
2. Collect data: "'an example item' in the original lang is equals to '例のアイテム' in a translated lang"
3. Export the data as json such as below
```json
[{"orig":"an example item","equals":"例のアイテム"}]
```
4. Translation related to updating become more easy by using above translation datasets, 
   because you can translate from the current version's lang file directly and quickly by using collected reusable datasets.

Since this branch was created as orphan branch this branch cannot be merged to any original one.