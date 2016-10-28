#!/bin/sh

git filter-branch --force --env-filter '

an="$GIT_AUTHOR_NAME" # автор коммита
am="$GIT_AUTHOR_EMAIL" # e-mail автора коммита
cn="$GIT_COMMITTER_NAME" # коммитер
cm="$GIT_COMMITTER_EMAIL" # e-mail коммитера

if [ "$GIT_AUTHOR_NAME" = "Alex Malozemov" ]
then
    cn="Alex Malozemov"
    cm="ya-mzalex@yandex.ru"
    an="Alex Malozemov"
    am="ya-mzalex@yandex.ru"
fi

export GIT_AUTHOR_NAME="$an"
export GIT_AUTHOR_EMAIL="$am"
export GIT_COMMITTER_NAME="$cn"
export GIT_COMMITTER_EMAIL="$cm"
'
