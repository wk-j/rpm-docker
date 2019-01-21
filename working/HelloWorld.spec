Name:   hello-world
Version: 1
Release: 1
Summary: My Web
License: FIXME

%description
This is my first RPM package

%prep
# We have no source

%build
cat > hello-world.sh <<EOF
#!/usr/bin/bash
echo Hello world
EOF

%install
mkdir -p %{buildroot}/usr/bin/
install -m 755 hello-world.sh %{buildroot}/usr/bin/hello-world.sh

%files
/usr/bin/hello-world.sh
