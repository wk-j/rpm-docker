## RPM

```bash
docker-compose down
docker-compose build
docker-compose up


docker run  \
    -it     \
    -v ('pwd')/working:/working     \
    dotnetrpm_centos sh
```

## Hello World

```bash
cd /working
rpmbuild --target noarch -bb HelloWorld.spec --define "_rpmdir $(pwd)"
rpm -i noarch/hello-world-1-1.noarch.rpm
hello-world.sh
rpm -e hello-world
```