list="$(find /home/database/ -name "*.sql" | sort --version-sort;)";

for i in $list; do mysql -uroot -p("docker")  ("rest_with_asp_net") < $i; done;